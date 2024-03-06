using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ExposeLocalhostNet
{
	// Token: 0x02000017 RID: 23
	internal class UdpClientLocalToNet
	{
		// Token: 0x06000088 RID: 136 RVA: 0x0000959C File Offset: 0x0000779C
		public UdpClientLocalToNet(UdpClient server, IPEndPoint clientEndpoint, IPEndPoint remoteServer, UdpLocalClientRelay udpLocalClientRelay)
		{
			this._server = server;
			this._isRunning = true;
			this._remoteServer = remoteServer;
			this._clientEndpoint = clientEndpoint;
			this.Run();
			this.udpLocalClientRelay = udpLocalClientRelay;
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000095FC File Offset: 0x000077FC
		public Task SendToServer(byte[] message)
		{
			UdpClientLocalToNet.<SendToServer>d__9 <SendToServer>d__;
			<SendToServer>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<SendToServer>d__.<>4__this = this;
			<SendToServer>d__.message = message;
			<SendToServer>d__.<>1__state = -1;
			<SendToServer>d__.<>t__builder.Start<UdpClientLocalToNet.<SendToServer>d__9>(ref <SendToServer>d__);
			return <SendToServer>d__.<>t__builder.Task;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00009647 File Offset: 0x00007847
		private void Run()
		{
			Task.Run(delegate()
			{
				UdpClientLocalToNet.<<Run>b__10_0>d <<Run>b__10_0>d;
				<<Run>b__10_0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<Run>b__10_0>d.<>4__this = this;
				<<Run>b__10_0>d.<>1__state = -1;
				<<Run>b__10_0>d.<>t__builder.Start<UdpClientLocalToNet.<<Run>b__10_0>d>(ref <<Run>b__10_0>d);
				return <<Run>b__10_0>d.<>t__builder.Task;
			});
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000965B File Offset: 0x0000785B
		public void Stop()
		{
			this._isRunning = false;
		}

		// Token: 0x0400006F RID: 111
		private readonly UdpClient _server;

		// Token: 0x04000070 RID: 112
		private UdpLocalClientRelay udpLocalClientRelay;

		// Token: 0x04000071 RID: 113
		public readonly UdpClient client = new UdpClient();

		// Token: 0x04000072 RID: 114
		public DateTime lastActivity = DateTime.UtcNow;

		// Token: 0x04000073 RID: 115
		private readonly IPEndPoint _clientEndpoint;

		// Token: 0x04000074 RID: 116
		private readonly IPEndPoint _remoteServer;

		// Token: 0x04000075 RID: 117
		private bool _isRunning;

		// Token: 0x04000076 RID: 118
		private readonly TaskCompletionSource<bool> _tcs = new TaskCompletionSource<bool>();
	}
}
