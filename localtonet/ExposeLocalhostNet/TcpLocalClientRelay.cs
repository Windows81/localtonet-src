using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using ExposeLocalhostNet.Models;

namespace ExposeLocalhostNet
{
	// Token: 0x02000014 RID: 20
	public class TcpLocalClientRelay
	{
		// Token: 0x06000079 RID: 121 RVA: 0x00008DD0 File Offset: 0x00006FD0
		public void Start(ClientRelayPort clientRelay, CancellationTokenSource cancellationToken)
		{
			TcpLocalClientRelay.<>c__DisplayClass1_0 CS$<>8__locals1 = new TcpLocalClientRelay.<>c__DisplayClass1_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.clientRelay = clientRelay;
			if (CS$<>8__locals1.clientRelay.LocalIp == "localhost")
			{
				try
				{
					CS$<>8__locals1.clientRelay.LocalIp = Dns.GetHostAddresses("localhost")[0].ToString();
				}
				catch
				{
					CS$<>8__locals1.clientRelay.LocalIp = IPAddress.Loopback.ToString();
				}
			}
			if (CS$<>8__locals1.clientRelay.ServerIp == "localhost")
			{
				try
				{
					CS$<>8__locals1.clientRelay.ServerIp = Dns.GetHostAddresses("localhost")[0].ToString();
				}
				catch
				{
					CS$<>8__locals1.clientRelay.ServerIp = IPAddress.Loopback.ToString();
				}
			}
			CS$<>8__locals1.listener = new Socket(SocketType.Stream, ProtocolType.Tcp);
			IPEndPoint listenerEndPoint = new IPEndPoint(IPAddress.Parse(CS$<>8__locals1.clientRelay.ServerIp), CS$<>8__locals1.clientRelay.ServerListenerPort);
			CS$<>8__locals1.listener.Bind(listenerEndPoint);
			CS$<>8__locals1.listener.Listen(2000);
			SignalRClient.sessionStatus.UserTunnel.TryGetValue(CS$<>8__locals1.clientRelay.UserDomainGuidId, out CS$<>8__locals1.clientRelayPort);
			CS$<>8__locals1.clientRelayPort.ServerListenerPort = ((IPEndPoint)CS$<>8__locals1.listener.LocalEndPoint).Port;
			SignalRClient.sessionStatus.UserTunnel.AddOrUpdate(CS$<>8__locals1.clientRelay.UserDomainGuidId, CS$<>8__locals1.clientRelayPort, (Guid key, ClientRelayPort existingVal) => CS$<>8__locals1.clientRelayPort);
			Task.Run(delegate()
			{
				for (;;)
				{
					try
					{
						TcpLocalClientRelay.<>c__DisplayClass1_1 CS$<>8__locals2 = new TcpLocalClientRelay.<>c__DisplayClass1_1();
						CS$<>8__locals2.CS$<>8__locals1 = CS$<>8__locals1;
						CS$<>8__locals2.handler = CS$<>8__locals1.listener.Accept();
						if (CS$<>8__locals1.clientRelayPort.BasicAuthentication)
						{
							TcpLocalClientRelay.<>c__DisplayClass1_2 CS$<>8__locals3 = new TcpLocalClientRelay.<>c__DisplayClass1_2();
							CS$<>8__locals3.CS$<>8__locals2 = CS$<>8__locals2;
							NetworkStream clientStream = new NetworkStream(CS$<>8__locals3.CS$<>8__locals2.handler, true);
							clientStream.ReadByte();
							byte numMethods = (byte)clientStream.ReadByte();
							byte[] authMethods = new byte[(int)numMethods];
							clientStream.Read(authMethods, 0, (int)numMethods);
							byte[] array = new byte[2];
							array[0] = 5;
							byte[] response = array;
							response[0] = 5;
							response[1] = 2;
							clientStream.Write(response, 0, 2);
							CS$<>8__locals3.ip = ((IPEndPoint)CS$<>8__locals3.CS$<>8__locals2.handler.RemoteEndPoint).Address.ToString().Replace("::ffff:", "");
							if (CS$<>8__locals1.<>4__this.AuthenticateWithUsernamePassword(clientStream, CS$<>8__locals1.clientRelayPort.BasicAuthenticationUsername, CS$<>8__locals1.clientRelayPort.BasicAuthenticationPassword))
							{
								Task.Run(delegate()
								{
									TcpLocalClientRelay.<>c__DisplayClass1_2.<<Start>b__4>d <<Start>b__4>d;
									<<Start>b__4>d.<>t__builder = AsyncTaskMethodBuilder.Create();
									<<Start>b__4>d.<>4__this = CS$<>8__locals3;
									<<Start>b__4>d.<>1__state = -1;
									<<Start>b__4>d.<>t__builder.Start<TcpLocalClientRelay.<>c__DisplayClass1_2.<<Start>b__4>d>(ref <<Start>b__4>d);
									return <<Start>b__4>d.<>t__builder.Task;
								});
							}
							else
							{
								RelayClientServer.isClientRelayCanCustomerConnected.AddOrUpdate(CS$<>8__locals1.clientRelay.UserDomainGuidId.ToString() + "-" + CS$<>8__locals3.ip, false, (string key, bool existingVal) => false);
								CS$<>8__locals1.<>4__this.SendAuthMethodNotAcceptable(clientStream);
								CS$<>8__locals3.CS$<>8__locals2.handler.Close();
							}
						}
						else
						{
							Task.Run(delegate()
							{
								TcpLocalClientRelay.<>c__DisplayClass1_1.<<Start>b__3>d <<Start>b__3>d;
								<<Start>b__3>d.<>t__builder = AsyncTaskMethodBuilder.Create();
								<<Start>b__3>d.<>4__this = CS$<>8__locals2;
								<<Start>b__3>d.<>1__state = -1;
								<<Start>b__3>d.<>t__builder.Start<TcpLocalClientRelay.<>c__DisplayClass1_1.<<Start>b__3>d>(ref <<Start>b__3>d);
								return <<Start>b__3>d.<>t__builder.Task;
							});
						}
					}
					catch
					{
					}
				}
			}, cancellationToken.Token);
			Task.Run(delegate()
			{
				TcpLocalClientRelay.<>c__DisplayClass1_0.<<Start>b__2>d <<Start>b__2>d;
				<<Start>b__2>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<Start>b__2>d.<>4__this = CS$<>8__locals1;
				<<Start>b__2>d.<>1__state = -1;
				<<Start>b__2>d.<>t__builder.Start<TcpLocalClientRelay.<>c__DisplayClass1_0.<<Start>b__2>d>(ref <<Start>b__2>d);
				return <<Start>b__2>d.<>t__builder.Task;
			}, cancellationToken.Token);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00008F90 File Offset: 0x00007190
		public Task CopyToAsyncWithFlushAsync(Socket socket1, Socket socket2)
		{
			TcpLocalClientRelay.<CopyToAsyncWithFlushAsync>d__2 <CopyToAsyncWithFlushAsync>d__;
			<CopyToAsyncWithFlushAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<CopyToAsyncWithFlushAsync>d__.<>4__this = this;
			<CopyToAsyncWithFlushAsync>d__.socket1 = socket1;
			<CopyToAsyncWithFlushAsync>d__.socket2 = socket2;
			<CopyToAsyncWithFlushAsync>d__.<>1__state = -1;
			<CopyToAsyncWithFlushAsync>d__.<>t__builder.Start<TcpLocalClientRelay.<CopyToAsyncWithFlushAsync>d__2>(ref <CopyToAsyncWithFlushAsync>d__);
			return <CopyToAsyncWithFlushAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00008FE4 File Offset: 0x000071E4
		private Task CopyToAsync(Stream source, Stream destination, CancellationToken token = default(CancellationToken))
		{
			TcpLocalClientRelay.<CopyToAsync>d__3 <CopyToAsync>d__;
			<CopyToAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<CopyToAsync>d__.<>4__this = this;
			<CopyToAsync>d__.source = source;
			<CopyToAsync>d__.destination = destination;
			<CopyToAsync>d__.token = token;
			<CopyToAsync>d__.<>1__state = -1;
			<CopyToAsync>d__.<>t__builder.Start<TcpLocalClientRelay.<CopyToAsync>d__3>(ref <CopyToAsync>d__);
			return <CopyToAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00009040 File Offset: 0x00007240
		private bool AuthenticateWithUsernamePassword(NetworkStream stream, string usernameMain, string passwordMain)
		{
			bool result;
			try
			{
				byte[] username = new byte[1000];
				stream.Read(username, 0, username.Length);
				string usernameString = Encoding.ASCII.GetString(username).Replace("\0", "");
				usernameString = Regex.Replace(usernameString, "[\\u0001-\\u0008\\u000B-\\u000C\\u000E-\\u001F]", "").Replace("\n", "").Replace("\r", "").Replace("\t", "").Replace("\b", "").Replace("\f", "").Replace("\a", "").Replace("\v", "").Replace("*", "");
				if (usernameMain + passwordMain == usernameString)
				{
					result = true;
				}
				else
				{
					result = false;
				}
			}
			catch (Exception)
			{
				this.SendAuthMethodNotAcceptable(stream);
				result = false;
			}
			return result;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000913C File Offset: 0x0000733C
		private void SendAuthMethodNotAcceptable(NetworkStream stream)
		{
			byte[] buffer = new byte[]
			{
				5,
				byte.MaxValue
			};
			stream.Write(buffer, 0, buffer.Length);
		}

		// Token: 0x04000063 RID: 99
		private int byteCount;
	}
}
