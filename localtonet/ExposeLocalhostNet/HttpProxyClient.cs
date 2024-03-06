using System;
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
	// Token: 0x0200000A RID: 10
	public class HttpProxyClient
	{
		// Token: 0x06000020 RID: 32 RVA: 0x00005C78 File Offset: 0x00003E78
		public void StartTcpHttpProxyClient(ClientRelayPort clientRelayPortMain, CancellationToken cancellationToken)
		{
			HttpProxyClient.<>c__DisplayClass13_0 CS$<>8__locals1 = new HttpProxyClient.<>c__DisplayClass13_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.cancellationToken = cancellationToken;
			CS$<>8__locals1.clientRelayPortMain = clientRelayPortMain;
			this._clientRelayPortMain = CS$<>8__locals1.clientRelayPortMain;
			if (!string.IsNullOrEmpty(CS$<>8__locals1.clientRelayPortMain.ServerIPv6))
			{
				this.supportIpv6 = CommonService.SendPingForV6().Result;
			}
			if (this.supportIpv6)
			{
				this.serverEndPoint = new IPEndPoint(IPAddress.Parse(CS$<>8__locals1.clientRelayPortMain.ServerIPv6), CS$<>8__locals1.clientRelayPortMain.ServerPort);
			}
			else
			{
				this.serverEndPoint = new IPEndPoint(IPAddress.Parse(CS$<>8__locals1.clientRelayPortMain.ServerIp), CS$<>8__locals1.clientRelayPortMain.ServerPort);
			}
			this.token = CS$<>8__locals1.cancellationToken;
			this.userRelayGuidId = CS$<>8__locals1.clientRelayPortMain.UserDomainGuidId;
			this.username = CS$<>8__locals1.clientRelayPortMain.BasicAuthenticationUsername;
			this.password = CS$<>8__locals1.clientRelayPortMain.BasicAuthenticationPassword;
			this.isAuth = CS$<>8__locals1.clientRelayPortMain.BasicAuthentication;
			Task.Run(delegate()
			{
				HttpProxyClient.<>c__DisplayClass13_0.<<StartTcpHttpProxyClient>b__0>d <<StartTcpHttpProxyClient>b__0>d;
				<<StartTcpHttpProxyClient>b__0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<StartTcpHttpProxyClient>b__0>d.<>4__this = CS$<>8__locals1;
				<<StartTcpHttpProxyClient>b__0>d.<>1__state = -1;
				<<StartTcpHttpProxyClient>b__0>d.<>t__builder.Start<HttpProxyClient.<>c__DisplayClass13_0.<<StartTcpHttpProxyClient>b__0>d>(ref <<StartTcpHttpProxyClient>b__0>d);
				return <<StartTcpHttpProxyClient>b__0>d.<>t__builder.Task;
			}, CS$<>8__locals1.cancellationToken).ConfigureAwait(false);
			Task.Run(delegate()
			{
				HttpProxyClient.<>c__DisplayClass13_0.<<StartTcpHttpProxyClient>b__1>d <<StartTcpHttpProxyClient>b__1>d;
				<<StartTcpHttpProxyClient>b__1>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<StartTcpHttpProxyClient>b__1>d.<>4__this = CS$<>8__locals1;
				<<StartTcpHttpProxyClient>b__1>d.<>1__state = -1;
				<<StartTcpHttpProxyClient>b__1>d.<>t__builder.Start<HttpProxyClient.<>c__DisplayClass13_0.<<StartTcpHttpProxyClient>b__1>d>(ref <<StartTcpHttpProxyClient>b__1>d);
				return <<StartTcpHttpProxyClient>b__1>d.<>t__builder.Task;
			}, CS$<>8__locals1.cancellationToken).ConfigureAwait(false);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00005DB0 File Offset: 0x00003FB0
		private Task ConnectServerAndClientAsync(IPEndPoint serverEndPoint)
		{
			HttpProxyClient.<ConnectServerAndClientAsync>d__14 <ConnectServerAndClientAsync>d__;
			<ConnectServerAndClientAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ConnectServerAndClientAsync>d__.<>4__this = this;
			<ConnectServerAndClientAsync>d__.serverEndPoint = serverEndPoint;
			<ConnectServerAndClientAsync>d__.<>1__state = -1;
			<ConnectServerAndClientAsync>d__.<>t__builder.Start<HttpProxyClient.<ConnectServerAndClientAsync>d__14>(ref <ConnectServerAndClientAsync>d__);
			return <ConnectServerAndClientAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00005DFC File Offset: 0x00003FFC
		private bool SocketConnected(Socket s)
		{
			bool flag = s.Poll(1000, SelectMode.SelectRead);
			bool part2 = s.Available == 0;
			return !flag || !part2;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00005E28 File Offset: 0x00004028
		private Task HandleTCPRequestAsync(Socket socket, string ipString)
		{
			HttpProxyClient.<HandleTCPRequestAsync>d__16 <HandleTCPRequestAsync>d__;
			<HandleTCPRequestAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<HandleTCPRequestAsync>d__.<>4__this = this;
			<HandleTCPRequestAsync>d__.socket = socket;
			<HandleTCPRequestAsync>d__.ipString = ipString;
			<HandleTCPRequestAsync>d__.<>1__state = -1;
			<HandleTCPRequestAsync>d__.<>t__builder.Start<HttpProxyClient.<HandleTCPRequestAsync>d__16>(ref <HandleTCPRequestAsync>d__);
			return <HandleTCPRequestAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00005E7C File Offset: 0x0000407C
		private bool IsAuthorized(string request)
		{
			bool result;
			try
			{
				string authHeaderValue = HttpProxyClient.ExtractAuthHeader(request);
				if (string.IsNullOrEmpty(authHeaderValue))
				{
					result = false;
				}
				else
				{
					string[] credentials = Encoding.UTF8.GetString(Convert.FromBase64String(authHeaderValue)).Split(":", StringSplitOptions.None);
					if (credentials.Length != 2)
					{
						result = false;
					}
					else
					{
						string user = credentials[0];
						string pass = credentials[1];
						result = (user == this.username && pass == this.password);
					}
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("An error occurred: " + ex.Message);
				result = false;
			}
			return result;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00005F1C File Offset: 0x0000411C
		private static string ExtractAuthHeader(string request)
		{
			Match match = Regex.Match(request, "proxy-authorization:\\s*Basic\\s*(\\S+)", RegexOptions.IgnoreCase);
			if (match.Success)
			{
				return match.Groups[1].Value.Trim();
			}
			return string.Empty;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00005F5C File Offset: 0x0000415C
		[return: TupleElementNames(new string[]
		{
			"Host",
			"Port"
		})]
		private ValueTuple<string, int?> ExtractTargetHostAndPort(string request)
		{
			int hostStart = request.IndexOf("Host: ") + "Host: ".Length;
			int hostEnd = request.IndexOf("\r\n", hostStart);
			string host = request.Substring(hostStart, hostEnd - hostStart).Trim();
			int? port = null;
			int portStart = host.IndexOf(':');
			if (portStart != -1)
			{
				int parsedPort;
				if (int.TryParse(host.Substring(portStart + 1), out parsedPort))
				{
					port = new int?(parsedPort);
				}
				host = host.Substring(0, portStart);
			}
			if (port == null)
			{
				int connectStart = request.IndexOf("CONNECT ");
				if (connectStart != -1)
				{
					connectStart += "CONNECT ".Length;
					int connectEnd = request.IndexOf(" ", connectStart);
					string connectHostAndPort = request.Substring(connectStart, connectEnd - connectStart).Trim();
					if (host.Contains(" "))
					{
						host = connectHostAndPort.Split(":", StringSplitOptions.None)[0];
					}
					int connectPortStart = connectHostAndPort.IndexOf(':');
					int parsedPort2;
					if (connectPortStart != -1 && int.TryParse(connectHostAndPort.Substring(connectPortStart + 1), out parsedPort2))
					{
						port = new int?(parsedPort2);
					}
				}
			}
			return new ValueTuple<string, int?>(host, port);
		}

		// Token: 0x04000008 RID: 8
		private string username;

		// Token: 0x04000009 RID: 9
		private string password;

		// Token: 0x0400000A RID: 10
		private bool isAuth;

		// Token: 0x0400000B RID: 11
		private CancellationToken token;

		// Token: 0x0400000C RID: 12
		private TimeSpan timeout = TimeSpan.FromSeconds(15.0);

		// Token: 0x0400000D RID: 13
		private Guid userRelayGuidId;

		// Token: 0x0400000E RID: 14
		private bool supportIpv6;

		// Token: 0x0400000F RID: 15
		private DateTime _lastHeartBeatReceived = DateTime.Now;

		// Token: 0x04000010 RID: 16
		private DateTime _lastReceivedDate = DateTime.Now;

		// Token: 0x04000011 RID: 17
		private ClientRelayPort _clientRelayPortMain;

		// Token: 0x04000012 RID: 18
		private IPEndPoint serverEndPoint;

		// Token: 0x04000013 RID: 19
		private byte[] key = new byte[]
		{
			0,
			8,
			0,
			0,
			0,
			34,
			77,
			0,
			0,
			0
		};

		// Token: 0x04000014 RID: 20
		private byte[] connectionEstablished = Encoding.ASCII.GetBytes("HTTP/1.1 200 Connection established\r\n\r\n");
	}
}
