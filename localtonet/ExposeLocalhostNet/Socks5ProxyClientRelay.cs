using System;
using System.Collections.Concurrent;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using ExposeLocalhostNet.Models;

namespace ExposeLocalhostNet
{
	// Token: 0x02000012 RID: 18
	public class Socks5ProxyClientRelay
	{
		// Token: 0x06000064 RID: 100 RVA: 0x00008534 File Offset: 0x00006734
		public void StartTcpSocks5ProxyClient(string listenerIp, int listenerPort, CancellationToken cancellationToken, Guid userRelayId, bool auth, string user = null, string pass = null)
		{
			Socks5ProxyClientRelay.<>c__DisplayClass8_0 CS$<>8__locals1 = new Socks5ProxyClientRelay.<>c__DisplayClass8_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.cancellationToken = cancellationToken;
			this.token = CS$<>8__locals1.cancellationToken;
			this.username = user;
			this.password = pass;
			this.isAuth = auth;
			this.userRelayGuidId = userRelayId;
			IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(listenerIp), listenerPort);
			this._mainEndPont = endPoint;
			this._udpClientServer = new UdpClient(listenerPort);
			Task.Run(delegate()
			{
				Socks5ProxyClientRelay.<>c__DisplayClass8_0.<<StartTcpSocks5ProxyClient>b__0>d <<StartTcpSocks5ProxyClient>b__0>d;
				<<StartTcpSocks5ProxyClient>b__0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<StartTcpSocks5ProxyClient>b__0>d.<>4__this = CS$<>8__locals1;
				<<StartTcpSocks5ProxyClient>b__0>d.<>1__state = -1;
				<<StartTcpSocks5ProxyClient>b__0>d.<>t__builder.Start<Socks5ProxyClientRelay.<>c__DisplayClass8_0.<<StartTcpSocks5ProxyClient>b__0>d>(ref <<StartTcpSocks5ProxyClient>b__0>d);
				return <<StartTcpSocks5ProxyClient>b__0>d.<>t__builder.Task;
			});
			if (listenerIp == "localhost")
			{
				try
				{
					listenerIp = Dns.GetHostAddresses("localhost")[0].ToString();
				}
				catch
				{
					listenerIp = IPAddress.Loopback.ToString();
				}
			}
			CS$<>8__locals1.listener = new Socket(SocketType.Stream, ProtocolType.Tcp);
			IPEndPoint listenerEndPoint = new IPEndPoint(IPAddress.Parse(listenerIp), listenerPort);
			CS$<>8__locals1.listener.Bind(listenerEndPoint);
			CS$<>8__locals1.listener.Listen(2000);
			SignalRClient.sessionStatus.UserTunnel.TryGetValue(userRelayId, out CS$<>8__locals1.clientRelayPort);
			CS$<>8__locals1.clientRelayPort.ServerListenerPort = ((IPEndPoint)CS$<>8__locals1.listener.LocalEndPoint).Port;
			SignalRClient.sessionStatus.UserTunnel.AddOrUpdate(userRelayId, CS$<>8__locals1.clientRelayPort, (Guid key, ClientRelayPort existingVal) => CS$<>8__locals1.clientRelayPort);
			Task.Run(delegate()
			{
				for (;;)
				{
					try
					{
						Socks5ProxyClientRelay.<>c__DisplayClass8_1 CS$<>8__locals2 = new Socks5ProxyClientRelay.<>c__DisplayClass8_1();
						CS$<>8__locals2.CS$<>8__locals1 = CS$<>8__locals1;
						CS$<>8__locals2.handler = CS$<>8__locals1.listener.Accept();
						Task.Run(delegate()
						{
							Socks5ProxyClientRelay.<>c__DisplayClass8_1.<<StartTcpSocks5ProxyClient>b__3>d <<StartTcpSocks5ProxyClient>b__3>d;
							<<StartTcpSocks5ProxyClient>b__3>d.<>t__builder = AsyncTaskMethodBuilder.Create();
							<<StartTcpSocks5ProxyClient>b__3>d.<>4__this = CS$<>8__locals2;
							<<StartTcpSocks5ProxyClient>b__3>d.<>1__state = -1;
							<<StartTcpSocks5ProxyClient>b__3>d.<>t__builder.Start<Socks5ProxyClientRelay.<>c__DisplayClass8_1.<<StartTcpSocks5ProxyClient>b__3>d>(ref <<StartTcpSocks5ProxyClient>b__3>d);
							return <<StartTcpSocks5ProxyClient>b__3>d.<>t__builder.Task;
						});
					}
					catch
					{
					}
				}
			}, CS$<>8__locals1.cancellationToken);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000086A0 File Offset: 0x000068A0
		private Task ForwardUdpTrafficAsync(CancellationToken cancellationToken)
		{
			Socks5ProxyClientRelay.<ForwardUdpTrafficAsync>d__9 <ForwardUdpTrafficAsync>d__;
			<ForwardUdpTrafficAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ForwardUdpTrafficAsync>d__.<>4__this = this;
			<ForwardUdpTrafficAsync>d__.cancellationToken = cancellationToken;
			<ForwardUdpTrafficAsync>d__.<>1__state = -1;
			<ForwardUdpTrafficAsync>d__.<>t__builder.Start<Socks5ProxyClientRelay.<ForwardUdpTrafficAsync>d__9>(ref <ForwardUdpTrafficAsync>d__);
			return <ForwardUdpTrafficAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x000086EC File Offset: 0x000068EC
		private Task ConnectServerAndClientAsync(Socket listener)
		{
			Socks5ProxyClientRelay.<ConnectServerAndClientAsync>d__10 <ConnectServerAndClientAsync>d__;
			<ConnectServerAndClientAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ConnectServerAndClientAsync>d__.<>4__this = this;
			<ConnectServerAndClientAsync>d__.listener = listener;
			<ConnectServerAndClientAsync>d__.<>1__state = -1;
			<ConnectServerAndClientAsync>d__.<>t__builder.Start<Socks5ProxyClientRelay.<ConnectServerAndClientAsync>d__10>(ref <ConnectServerAndClientAsync>d__);
			return <ConnectServerAndClientAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0400004D RID: 77
		private string username;

		// Token: 0x0400004E RID: 78
		private string password;

		// Token: 0x0400004F RID: 79
		private bool isAuth;

		// Token: 0x04000050 RID: 80
		private IPEndPoint _mainEndPont;

		// Token: 0x04000051 RID: 81
		private UdpClient _udpClientServer;

		// Token: 0x04000052 RID: 82
		private CancellationToken token;

		// Token: 0x04000053 RID: 83
		private Guid userRelayGuidId;

		// Token: 0x04000054 RID: 84
		private ConcurrentDictionary<string, UdpClient> userList = new ConcurrentDictionary<string, UdpClient>();
	}
}
