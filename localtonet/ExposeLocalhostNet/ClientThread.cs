using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace ExposeLocalhostNet
{
	// Token: 0x02000011 RID: 17
	internal class ClientThread
	{
		// Token: 0x0600005C RID: 92 RVA: 0x000082FC File Offset: 0x000064FC
		public ClientThread(Socket clientTcp, IPEndPoint mainEndPont, CancellationToken cancellationToken, bool auth, Guid userReayGuidId, string user = null, string pass = null, string clientIp = null)
		{
			this.isNeedUserPass = auth;
			ClientThread.usernameMain = user;
			ClientThread.passwordMain = pass;
			this._mainEndPont = mainEndPont;
			this._clientStream = new NetworkStream(clientTcp, true);
			this._cancellationToken = cancellationToken;
			this._clientIp = clientIp;
			this._userRelayGuidId = userReayGuidId;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00008364 File Offset: 0x00006564
		public Task StartAsync()
		{
			ClientThread.<StartAsync>d__10 <StartAsync>d__;
			<StartAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<StartAsync>d__.<>4__this = this;
			<StartAsync>d__.<>1__state = -1;
			<StartAsync>d__.<>t__builder.Start<ClientThread.<StartAsync>d__10>(ref <StartAsync>d__);
			return <StartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000083A8 File Offset: 0x000065A8
		private Task<byte> ReadByteAsync(NetworkStream stream)
		{
			ClientThread.<ReadByteAsync>d__11 <ReadByteAsync>d__;
			<ReadByteAsync>d__.<>t__builder = AsyncTaskMethodBuilder<byte>.Create();
			<ReadByteAsync>d__.<>4__this = this;
			<ReadByteAsync>d__.stream = stream;
			<ReadByteAsync>d__.<>1__state = -1;
			<ReadByteAsync>d__.<>t__builder.Start<ClientThread.<ReadByteAsync>d__11>(ref <ReadByteAsync>d__);
			return <ReadByteAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000083F4 File Offset: 0x000065F4
		private Task StartRelayUdpAsync()
		{
			ClientThread.<StartRelayUdpAsync>d__12 <StartRelayUdpAsync>d__;
			<StartRelayUdpAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<StartRelayUdpAsync>d__.<>4__this = this;
			<StartRelayUdpAsync>d__.<>1__state = -1;
			<StartRelayUdpAsync>d__.<>t__builder.Start<ClientThread.<StartRelayUdpAsync>d__12>(ref <StartRelayUdpAsync>d__);
			return <StartRelayUdpAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00008438 File Offset: 0x00006638
		private Task<bool> AuthenticateWithUsernamePasswordAsync(NetworkStream stream)
		{
			ClientThread.<AuthenticateWithUsernamePasswordAsync>d__13 <AuthenticateWithUsernamePasswordAsync>d__;
			<AuthenticateWithUsernamePasswordAsync>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<AuthenticateWithUsernamePasswordAsync>d__.<>4__this = this;
			<AuthenticateWithUsernamePasswordAsync>d__.stream = stream;
			<AuthenticateWithUsernamePasswordAsync>d__.<>1__state = -1;
			<AuthenticateWithUsernamePasswordAsync>d__.<>t__builder.Start<ClientThread.<AuthenticateWithUsernamePasswordAsync>d__13>(ref <AuthenticateWithUsernamePasswordAsync>d__);
			return <AuthenticateWithUsernamePasswordAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00008484 File Offset: 0x00006684
		private Task SendAuthMethodNotAcceptableAsync(NetworkStream stream)
		{
			ClientThread.<SendAuthMethodNotAcceptableAsync>d__14 <SendAuthMethodNotAcceptableAsync>d__;
			<SendAuthMethodNotAcceptableAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<SendAuthMethodNotAcceptableAsync>d__.<>4__this = this;
			<SendAuthMethodNotAcceptableAsync>d__.stream = stream;
			<SendAuthMethodNotAcceptableAsync>d__.<>1__state = -1;
			<SendAuthMethodNotAcceptableAsync>d__.<>t__builder.Start<ClientThread.<SendAuthMethodNotAcceptableAsync>d__14>(ref <SendAuthMethodNotAcceptableAsync>d__);
			return <SendAuthMethodNotAcceptableAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000084D0 File Offset: 0x000066D0
		private Task SendConnectionRefusedAsync(NetworkStream stream)
		{
			ClientThread.<SendConnectionRefusedAsync>d__15 <SendConnectionRefusedAsync>d__;
			<SendConnectionRefusedAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<SendConnectionRefusedAsync>d__.<>4__this = this;
			<SendConnectionRefusedAsync>d__.stream = stream;
			<SendConnectionRefusedAsync>d__.<>1__state = -1;
			<SendConnectionRefusedAsync>d__.<>t__builder.Start<ClientThread.<SendConnectionRefusedAsync>d__15>(ref <SendConnectionRefusedAsync>d__);
			return <SendConnectionRefusedAsync>d__.<>t__builder.Task;
		}

		// Token: 0x04000044 RID: 68
		private IPEndPoint _mainEndPont;

		// Token: 0x04000045 RID: 69
		private bool isNeedUserPass;

		// Token: 0x04000046 RID: 70
		private static string usernameMain = string.Empty;

		// Token: 0x04000047 RID: 71
		private static string passwordMain = string.Empty;

		// Token: 0x04000048 RID: 72
		private NetworkStream _clientStream;

		// Token: 0x04000049 RID: 73
		private CancellationToken _cancellationToken;

		// Token: 0x0400004A RID: 74
		private string _clientIp;

		// Token: 0x0400004B RID: 75
		private Guid _userRelayGuidId;

		// Token: 0x0400004C RID: 76
		private TimeSpan timeout = TimeSpan.FromSeconds(15.0);
	}
}
