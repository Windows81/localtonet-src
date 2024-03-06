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
	// Token: 0x02000010 RID: 16
	public class Socks5ProxyClient
	{
		// Token: 0x06000057 RID: 87 RVA: 0x000080B0 File Offset: 0x000062B0
		public void StartTcpSocks5ProxyClient(ClientRelayPort clientRelayPort, bool supportIpv6, int udpPort, IPEndPoint mainEndPont, CancellationToken cancellationToken)
		{
			Socks5ProxyClient.<>c__DisplayClass14_0 CS$<>8__locals1 = new Socks5ProxyClient.<>c__DisplayClass14_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.cancellationToken = cancellationToken;
			CS$<>8__locals1.supportIpv6 = supportIpv6;
			this._clientRelayPortMain = clientRelayPort;
			this._mainEndPont = mainEndPont;
			this.token = CS$<>8__locals1.cancellationToken;
			if (CS$<>8__locals1.supportIpv6)
			{
				this.serverEndPoint = new IPEndPoint(IPAddress.Parse(clientRelayPort.ServerIPv6), clientRelayPort.ServerPort);
			}
			else
			{
				this.serverEndPoint = new IPEndPoint(IPAddress.Parse(clientRelayPort.ServerIp), clientRelayPort.ServerPort);
			}
			this.userRelayGuidId = clientRelayPort.UserDomainGuidId;
			this.username = clientRelayPort.BasicAuthenticationUsername;
			this.password = clientRelayPort.BasicAuthenticationPassword;
			this.isAuth = clientRelayPort.BasicAuthentication;
			new byte[8196];
			this._udpClientServer = new UdpClient(udpPort);
			Task.Run(delegate()
			{
				Socks5ProxyClient.<>c__DisplayClass14_0.<<StartTcpSocks5ProxyClient>b__0>d <<StartTcpSocks5ProxyClient>b__0>d;
				<<StartTcpSocks5ProxyClient>b__0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<StartTcpSocks5ProxyClient>b__0>d.<>4__this = CS$<>8__locals1;
				<<StartTcpSocks5ProxyClient>b__0>d.<>1__state = -1;
				<<StartTcpSocks5ProxyClient>b__0>d.<>t__builder.Start<Socks5ProxyClient.<>c__DisplayClass14_0.<<StartTcpSocks5ProxyClient>b__0>d>(ref <<StartTcpSocks5ProxyClient>b__0>d);
				return <<StartTcpSocks5ProxyClient>b__0>d.<>t__builder.Task;
			}, CS$<>8__locals1.cancellationToken).ConfigureAwait(false);
			Task.Run(delegate()
			{
				Socks5ProxyClient.<>c__DisplayClass14_0.<<StartTcpSocks5ProxyClient>b__1>d <<StartTcpSocks5ProxyClient>b__1>d;
				<<StartTcpSocks5ProxyClient>b__1>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<StartTcpSocks5ProxyClient>b__1>d.<>4__this = CS$<>8__locals1;
				<<StartTcpSocks5ProxyClient>b__1>d.<>1__state = -1;
				<<StartTcpSocks5ProxyClient>b__1>d.<>t__builder.Start<Socks5ProxyClient.<>c__DisplayClass14_0.<<StartTcpSocks5ProxyClient>b__1>d>(ref <<StartTcpSocks5ProxyClient>b__1>d);
				return <<StartTcpSocks5ProxyClient>b__1>d.<>t__builder.Task;
			}, CS$<>8__locals1.cancellationToken).ConfigureAwait(false);
			Task.Run(delegate()
			{
				Socks5ProxyClient.<>c__DisplayClass14_0.<<StartTcpSocks5ProxyClient>b__2>d <<StartTcpSocks5ProxyClient>b__2>d;
				<<StartTcpSocks5ProxyClient>b__2>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<StartTcpSocks5ProxyClient>b__2>d.<>4__this = CS$<>8__locals1;
				<<StartTcpSocks5ProxyClient>b__2>d.<>1__state = -1;
				<<StartTcpSocks5ProxyClient>b__2>d.<>t__builder.Start<Socks5ProxyClient.<>c__DisplayClass14_0.<<StartTcpSocks5ProxyClient>b__2>d>(ref <<StartTcpSocks5ProxyClient>b__2>d);
				return <<StartTcpSocks5ProxyClient>b__2>d.<>t__builder.Task;
			}, CS$<>8__locals1.cancellationToken).ConfigureAwait(false);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000081D8 File Offset: 0x000063D8
		private Task ConnectServerAndClientAsync(IPEndPoint serverEndPoint)
		{
			Socks5ProxyClient.<ConnectServerAndClientAsync>d__15 <ConnectServerAndClientAsync>d__;
			<ConnectServerAndClientAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ConnectServerAndClientAsync>d__.<>4__this = this;
			<ConnectServerAndClientAsync>d__.serverEndPoint = serverEndPoint;
			<ConnectServerAndClientAsync>d__.<>1__state = -1;
			<ConnectServerAndClientAsync>d__.<>t__builder.Start<Socks5ProxyClient.<ConnectServerAndClientAsync>d__15>(ref <ConnectServerAndClientAsync>d__);
			return <ConnectServerAndClientAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00008224 File Offset: 0x00006424
		private bool SocketConnected(Socket s)
		{
			bool flag = s.Poll(1000, SelectMode.SelectRead);
			bool part2 = s.Available == 0;
			return !flag || !part2;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00008250 File Offset: 0x00006450
		private Task ForwardUdpTrafficAsync(CancellationToken cancellationToken)
		{
			Socks5ProxyClient.<ForwardUdpTrafficAsync>d__17 <ForwardUdpTrafficAsync>d__;
			<ForwardUdpTrafficAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ForwardUdpTrafficAsync>d__.<>4__this = this;
			<ForwardUdpTrafficAsync>d__.cancellationToken = cancellationToken;
			<ForwardUdpTrafficAsync>d__.<>1__state = -1;
			<ForwardUdpTrafficAsync>d__.<>t__builder.Start<Socks5ProxyClient.<ForwardUdpTrafficAsync>d__17>(ref <ForwardUdpTrafficAsync>d__);
			return <ForwardUdpTrafficAsync>d__.<>t__builder.Task;
		}

		// Token: 0x04000036 RID: 54
		private DateTime _lastHeartBeatReceived = DateTime.Now;

		// Token: 0x04000037 RID: 55
		private DateTime _lastReceivedDate = DateTime.Now;

		// Token: 0x04000038 RID: 56
		private string username;

		// Token: 0x04000039 RID: 57
		private string password;

		// Token: 0x0400003A RID: 58
		private bool isAuth;

		// Token: 0x0400003B RID: 59
		private CancellationToken token;

		// Token: 0x0400003C RID: 60
		private IPEndPoint _mainEndPont;

		// Token: 0x0400003D RID: 61
		private Guid userRelayGuidId;

		// Token: 0x0400003E RID: 62
		private UdpClient _udpClientServer;

		// Token: 0x0400003F RID: 63
		private ConcurrentDictionary<string, UdpClient> userList = new ConcurrentDictionary<string, UdpClient>();

		// Token: 0x04000040 RID: 64
		private ClientRelayPort _clientRelayPortMain;

		// Token: 0x04000041 RID: 65
		private IPEndPoint serverEndPoint;

		// Token: 0x04000042 RID: 66
		private TimeSpan timeout = TimeSpan.FromSeconds(15.0);

		// Token: 0x04000043 RID: 67
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
	}
}
