using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using ExposeLocalhostNet.Models;
using Microsoft.AspNetCore.SignalR.Client;
using Serilog;
using Spectre.Console;

namespace ExposeLocalhostNet
{
	// Token: 0x0200000D RID: 13
	internal class RelayClientServer
	{
		// Token: 0x06000033 RID: 51 RVA: 0x00006450 File Offset: 0x00004650
		public static void StartServerAsync(ClientRelayPort clientRelayPort)
		{
			CancellationTokenSource source = new CancellationTokenSource();
			CancellationToken previouslyProvidedToken = source.Token;
			try
			{
				if (clientRelayPort.ProtocolType.ToLower().Contains("tcp") && !clientRelayPort.ProtocolType.ToLower().Contains("clientrelay"))
				{
					TcpLocalClientNew tcpLocalClientNew = new TcpLocalClientNew();
					clientRelayPort.IsLogOn = true;
					tcpLocalClientNew.StartTcpClient(clientRelayPort, previouslyProvidedToken);
				}
				if (clientRelayPort.ProtocolType.ToLower().Contains("udp") && !clientRelayPort.ProtocolType.ToLower().Contains("clientrelay"))
				{
					new UdpLocalClient().StartUDPClient(clientRelayPort, source);
				}
				if (clientRelayPort.ProtocolType.ToLower() == "http" && !clientRelayPort.ProtocolType.ToLower().Contains("clientrelay"))
				{
					TcpLocalClientNew tcpLocalClient = new TcpLocalClientNew();
					tcpLocalClient.StartTcpClient(clientRelayPort, previouslyProvidedToken);
					RelayClientServer.httpInceptorServices.AddOrUpdate(clientRelayPort.UserDomainGuidId, tcpLocalClient, (Guid key, TcpLocalClientNew existingVal) => tcpLocalClient);
				}
				if (clientRelayPort.ProtocolType.ToLower() == "fileserver" && !clientRelayPort.ProtocolType.ToLower().Contains("clientrelay"))
				{
					int freePort = RelayClientServer.FindFreeTcpPort();
					TcpLocalClientNew tcpLocalClientNew2 = new TcpLocalClientNew();
					clientRelayPort.Port = freePort;
					clientRelayPort.LocalIp = IPAddress.Loopback.ToString();
					clientRelayPort.IsSslStream = new bool?(false);
					tcpLocalClientNew2.StartTcpClient(clientRelayPort, previouslyProvidedToken);
					SimpleHttpServer simpleHttpServer = new SimpleHttpServer();
					simpleHttpServer.StartHttpServerOnThread(clientRelayPort.Path, freePort, clientRelayPort, previouslyProvidedToken);
					RelayClientServer.simpleHttpServers.AddOrUpdate(clientRelayPort.UserDomainGuidId, simpleHttpServer, (Guid key, SimpleHttpServer existingVal) => simpleHttpServer);
				}
				if (clientRelayPort.ProtocolType.ToLower() == "proxyhttp" && !clientRelayPort.ProtocolType.ToLower().Contains("clientrelay"))
				{
					new HttpProxyClient().StartTcpHttpProxyClient(clientRelayPort, previouslyProvidedToken);
				}
				if (clientRelayPort.ProtocolType.ToLower() == "proxysocks" && !clientRelayPort.ProtocolType.ToLower().Contains("clientrelay"))
				{
					int port = RelayClientServer.FindFreeUdpPort();
					bool supportIpv6 = false;
					if (!string.IsNullOrEmpty(clientRelayPort.ServerIPv6))
					{
						supportIpv6 = CommonService.SendPingForV6().Result;
					}
					IPEndPoint endPoint;
					if (supportIpv6)
					{
						endPoint = new IPEndPoint(IPAddress.Parse(clientRelayPort.ServerIPv6), clientRelayPort.ServerListenerPort);
					}
					else
					{
						endPoint = new IPEndPoint(IPAddress.Parse(clientRelayPort.ServerIp), clientRelayPort.ServerListenerPort);
					}
					new Socks5ProxyClient().StartTcpSocks5ProxyClient(clientRelayPort, supportIpv6, port, endPoint, previouslyProvidedToken);
					UdpLocalClient udpLocalClient = new UdpLocalClient();
					clientRelayPort.LocalIp = IPAddress.Loopback.ToString();
					clientRelayPort.Port = port;
					udpLocalClient.StartUDPClient(clientRelayPort, source);
				}
				if (clientRelayPort.ProtocolType.ToLower().Contains("clientrelay"))
				{
					if (clientRelayPort.ServerListenerPort == 0)
					{
						clientRelayPort.ServerListenerPort = RelayClientServer.FindFreeTcpUdpPort();
						SignalRClient.connection.InvokeAsync("UpdateClientRelayServerPort", clientRelayPort.UserRelayId, clientRelayPort.ServerListenerPort, default(CancellationToken));
					}
					if (clientRelayPort.ProtocolType.ToLower().Contains("udp"))
					{
						new UdpLocalClientRelay().Start(clientRelayPort, source);
					}
					if (clientRelayPort.ProtocolType.ToLower().Contains("tcp"))
					{
						new TcpLocalClientRelay().Start(clientRelayPort, source);
					}
					if (clientRelayPort.ProtocolType.ToLower().Contains("proxyhttp"))
					{
						new HttpProxyClientRelay().StartTcpHttpProxyClient(clientRelayPort.ServerIp, clientRelayPort.ServerListenerPort, previouslyProvidedToken, clientRelayPort.UserDomainGuidId, clientRelayPort.BasicAuthentication, clientRelayPort.BasicAuthenticationUsername, clientRelayPort.BasicAuthenticationPassword);
					}
					if (clientRelayPort.ProtocolType.ToLower().Contains("proxysocks"))
					{
						new Socks5ProxyClientRelay().StartTcpSocks5ProxyClient(clientRelayPort.ServerIp, clientRelayPort.ServerListenerPort, previouslyProvidedToken, clientRelayPort.UserDomainGuidId, clientRelayPort.BasicAuthentication, clientRelayPort.BasicAuthenticationUsername, clientRelayPort.BasicAuthenticationPassword);
					}
				}
				Tuple<ClientRelayPort, CancellationTokenSource> tuple = Tuple.Create<ClientRelayPort, CancellationTokenSource>(clientRelayPort, source);
				RelayClientServer.activeRelayServers.AddOrUpdate(clientRelayPort.UserRelayId, tuple, (string key, Tuple<ClientRelayPort, CancellationTokenSource> existingVal) => tuple);
			}
			catch (Exception ex)
			{
				ILogger logger = ApplicationLogging.Logger;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(119, 2);
				defaultInterpolatedStringHandler.AppendLiteral("CLIENT ERROR => AuthToken : ");
				defaultInterpolatedStringHandler.AppendFormatted(ApplicationSettings.Default.AuthToken);
				defaultInterpolatedStringHandler.AppendLiteral(" | Exception : ");
				defaultInterpolatedStringHandler.AppendFormatted<Exception>(ex);
				defaultInterpolatedStringHandler.AppendLiteral(" | Destination : ExposeLocalhostNet -> RelayClientServer -> StartServerAsync");
				logger.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000068E8 File Offset: 0x00004AE8
		public static void StopRelay(string userRelayId, bool isProgramClosed = false)
		{
			Tuple<ClientRelayPort, CancellationTokenSource> tuple;
			if (RelayClientServer.activeRelayServers.TryRemove(userRelayId, out tuple))
			{
				ClientRelayPort clientRelayPort;
				SignalRClient.sessionStatus.UserTunnel.TryRemove(tuple.Item1.UserDomainGuidId, out clientRelayPort);
				tuple.Item2.Cancel();
				if (SignalRClient.isNotRunningNewVersion)
				{
					AnsiConsole.MarkupLine("[red]----------------------------------------------------------[/]");
					if (tuple.Item1.ProtocolType == "HTTP")
					{
						AnsiConsole.MarkupLine("[underline red]Stopped Relay " + tuple.Item1.Http + "[/]");
						return;
					}
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(40, 2);
					defaultInterpolatedStringHandler.AppendLiteral("[underline red]Stopped Relay ");
					defaultInterpolatedStringHandler.AppendFormatted(tuple.Item1.ProtocolType);
					defaultInterpolatedStringHandler.AppendLiteral(" - ");
					defaultInterpolatedStringHandler.AppendFormatted<int>(tuple.Item1.Port);
					defaultInterpolatedStringHandler.AppendLiteral(" port[/]");
					AnsiConsole.MarkupLine(defaultInterpolatedStringHandler.ToStringAndClear());
				}
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000069D8 File Offset: 0x00004BD8
		public static void StopAll()
		{
			foreach (KeyValuePair<string, Tuple<ClientRelayPort, CancellationTokenSource>> item in RelayClientServer.activeRelayServers)
			{
				item.Value.Item2.Cancel();
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00006A30 File Offset: 0x00004C30
		public static int FindFreeTcpPort()
		{
			int port = 0;
			Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			try
			{
				IPEndPoint localEP = new IPEndPoint(IPAddress.Any, 0);
				socket.Bind(localEP);
				localEP = (IPEndPoint)socket.LocalEndPoint;
				port = localEP.Port;
			}
			catch
			{
			}
			finally
			{
				socket.Close();
			}
			return port;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00006A98 File Offset: 0x00004C98
		public static int FindFreeUdpPort()
		{
			int port = 0;
			UdpClient udpClient = new UdpClient(0);
			try
			{
				port = ((IPEndPoint)udpClient.Client.LocalEndPoint).Port;
			}
			catch
			{
			}
			finally
			{
				udpClient.Close();
			}
			if (port == 0)
			{
				return RelayClientServer.FindFreeUdpPort();
			}
			return port;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00006AF8 File Offset: 0x00004CF8
		public static int FindFreeTcpUdpPort()
		{
			int port = 0;
			Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			UdpClient udpClient = null;
			try
			{
				IPEndPoint localEP = new IPEndPoint(IPAddress.Any, 0);
				socket.Bind(localEP);
				localEP = (IPEndPoint)socket.LocalEndPoint;
				udpClient = new UdpClient(localEP);
				port = localEP.Port;
			}
			catch
			{
				if (socket != null)
				{
					socket.Close();
				}
				if (udpClient != null)
				{
					udpClient.Close();
				}
			}
			finally
			{
				if (socket != null)
				{
					socket.Close();
				}
				if (udpClient != null)
				{
					udpClient.Close();
				}
			}
			if (port == 0)
			{
				return RelayClientServer.FindFreeTcpUdpPort();
			}
			return port;
		}

		// Token: 0x04000019 RID: 25
		public static ConcurrentDictionary<string, Tuple<ClientRelayPort, CancellationTokenSource>> activeRelayServers = new ConcurrentDictionary<string, Tuple<ClientRelayPort, CancellationTokenSource>>();

		// Token: 0x0400001A RID: 26
		public static ConcurrentDictionary<Guid, TcpLocalClientNew> httpInceptorServices = new ConcurrentDictionary<Guid, TcpLocalClientNew>();

		// Token: 0x0400001B RID: 27
		public static ConcurrentDictionary<Guid, SimpleHttpServer> simpleHttpServers = new ConcurrentDictionary<Guid, SimpleHttpServer>();

		// Token: 0x0400001C RID: 28
		public static ConcurrentDictionary<string, List<LoadBalance>> loadBalances = new ConcurrentDictionary<string, List<LoadBalance>>();

		// Token: 0x0400001D RID: 29
		public static ConcurrentDictionary<string, bool> isClientRelayCanCustomerConnected = new ConcurrentDictionary<string, bool>();
	}
}
