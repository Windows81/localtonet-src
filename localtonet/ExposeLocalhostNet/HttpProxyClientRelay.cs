using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ExposeLocalhostNet.Models;

namespace ExposeLocalhostNet
{
	// Token: 0x0200000B RID: 11
	public class HttpProxyClientRelay
	{
		// Token: 0x06000028 RID: 40 RVA: 0x000060E8 File Offset: 0x000042E8
		public void StartTcpHttpProxyClient(string listenerIp, int listenerPort, CancellationToken cancellationToken, Guid userRelayId, bool auth, string user = null, string pass = null)
		{
			HttpProxyClientRelay.<>c__DisplayClass4_0 CS$<>8__locals1 = new HttpProxyClientRelay.<>c__DisplayClass4_0();
			CS$<>8__locals1.<>4__this = this;
			this.token = cancellationToken;
			this.username = user;
			this.password = pass;
			this.isAuth = auth;
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
						HttpProxyClientRelay.<>c__DisplayClass4_1 CS$<>8__locals2 = new HttpProxyClientRelay.<>c__DisplayClass4_1();
						CS$<>8__locals2.CS$<>8__locals1 = CS$<>8__locals1;
						CS$<>8__locals2.handler = CS$<>8__locals1.listener.Accept();
						Task.Run(delegate()
						{
							HttpProxyClientRelay.<>c__DisplayClass4_1.<<StartTcpHttpProxyClient>b__2>d <<StartTcpHttpProxyClient>b__2>d;
							<<StartTcpHttpProxyClient>b__2>d.<>t__builder = AsyncTaskMethodBuilder.Create();
							<<StartTcpHttpProxyClient>b__2>d.<>4__this = CS$<>8__locals2;
							<<StartTcpHttpProxyClient>b__2>d.<>1__state = -1;
							<<StartTcpHttpProxyClient>b__2>d.<>t__builder.Start<HttpProxyClientRelay.<>c__DisplayClass4_1.<<StartTcpHttpProxyClient>b__2>d>(ref <<StartTcpHttpProxyClient>b__2>d);
							return <<StartTcpHttpProxyClient>b__2>d.<>t__builder.Task;
						});
					}
					catch
					{
					}
				}
			}, cancellationToken);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00006208 File Offset: 0x00004408
		private Task CopyToAsyncWithFlushAsync(Socket listener)
		{
			HttpProxyClientRelay.<CopyToAsyncWithFlushAsync>d__5 <CopyToAsyncWithFlushAsync>d__;
			<CopyToAsyncWithFlushAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<CopyToAsyncWithFlushAsync>d__.<>4__this = this;
			<CopyToAsyncWithFlushAsync>d__.listener = listener;
			<CopyToAsyncWithFlushAsync>d__.<>1__state = -1;
			<CopyToAsyncWithFlushAsync>d__.<>t__builder.Start<HttpProxyClientRelay.<CopyToAsyncWithFlushAsync>d__5>(ref <CopyToAsyncWithFlushAsync>d__);
			return <CopyToAsyncWithFlushAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00006254 File Offset: 0x00004454
		private Task HandleTCPRequestAsync(Socket socket)
		{
			HttpProxyClientRelay.<HandleTCPRequestAsync>d__6 <HandleTCPRequestAsync>d__;
			<HandleTCPRequestAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<HandleTCPRequestAsync>d__.<>4__this = this;
			<HandleTCPRequestAsync>d__.socket = socket;
			<HandleTCPRequestAsync>d__.<>1__state = -1;
			<HandleTCPRequestAsync>d__.<>t__builder.Start<HttpProxyClientRelay.<HandleTCPRequestAsync>d__6>(ref <HandleTCPRequestAsync>d__);
			return <HandleTCPRequestAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000062A0 File Offset: 0x000044A0
		private bool IsAuthorized(string request)
		{
			string authHeader = HttpProxyClientRelay.ExtractAuthHeader(request);
			if (string.IsNullOrEmpty(authHeader))
			{
				return false;
			}
			string[] array = Encoding.UTF8.GetString(Convert.FromBase64String(authHeader.Split(" ", StringSplitOptions.None)[2])).Split(":", StringSplitOptions.None);
			string user = array[0];
			string pass = array[1];
			return user == this.username && pass == this.password;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x0000630C File Offset: 0x0000450C
		private static string ExtractAuthHeader(string request)
		{
			int authHeaderStart = request.IndexOf("Authorization: Basic");
			if (authHeaderStart == -1)
			{
				return null;
			}
			int authHeaderEnd = request.IndexOf("\r\n", authHeaderStart);
			return request.Substring(authHeaderStart, authHeaderEnd - authHeaderStart).Trim();
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00006348 File Offset: 0x00004548
		private string ExtractTargetHost(string request)
		{
			int hostStart = request.IndexOf("Host: ") + "Host: ".Length;
			int hostEnd = request.IndexOf("\r\n", hostStart);
			return request.Substring(hostStart, hostEnd - hostStart).Trim();
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00006388 File Offset: 0x00004588
		private Task CopyToAsync(Stream source, Stream destination, CancellationToken token = default(CancellationToken))
		{
			HttpProxyClientRelay.<CopyToAsync>d__10 <CopyToAsync>d__;
			<CopyToAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<CopyToAsync>d__.source = source;
			<CopyToAsync>d__.destination = destination;
			<CopyToAsync>d__.token = token;
			<CopyToAsync>d__.<>1__state = -1;
			<CopyToAsync>d__.<>t__builder.Start<HttpProxyClientRelay.<CopyToAsync>d__10>(ref <CopyToAsync>d__);
			return <CopyToAsync>d__.<>t__builder.Task;
		}

		// Token: 0x04000015 RID: 21
		private string username;

		// Token: 0x04000016 RID: 22
		private string password;

		// Token: 0x04000017 RID: 23
		private bool isAuth;

		// Token: 0x04000018 RID: 24
		private CancellationToken token;
	}
}
