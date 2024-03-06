using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ExposeLocalhostNet.Models;

namespace ExposeLocalhostNet
{
	// Token: 0x02000015 RID: 21
	public class UdpLocalClient
	{
		// Token: 0x0600007F RID: 127 RVA: 0x0000916F File Offset: 0x0000736F
		public void StartUDPClient(ClientRelayPort clientRelayPort, CancellationTokenSource cancellationToken)
		{
			UdpLocalClient.<>c__DisplayClass10_0 CS$<>8__locals1 = new UdpLocalClient.<>c__DisplayClass10_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.clientRelayPort = clientRelayPort;
			CS$<>8__locals1.cancellationToken = cancellationToken;
			Task.Run(delegate()
			{
				UdpLocalClient.<>c__DisplayClass10_1 CS$<>8__locals2 = new UdpLocalClient.<>c__DisplayClass10_1();
				CS$<>8__locals2.CS$<>8__locals1 = CS$<>8__locals1;
				CS$<>8__locals1.<>4__this._clientRelayPort = CS$<>8__locals1.clientRelayPort;
				CS$<>8__locals1.<>4__this._cancellationToken = CS$<>8__locals1.cancellationToken.Token;
				CancellationTokenSource receiveToken = new CancellationTokenSource();
				CS$<>8__locals1.<>4__this._receiveToken = receiveToken;
				if (!string.IsNullOrEmpty(CS$<>8__locals1.clientRelayPort.ServerIPv6))
				{
					CS$<>8__locals1.<>4__this.supportIpv6 = CommonService.SendPingForV6().Result;
				}
				if (CS$<>8__locals1.<>4__this.supportIpv6)
				{
					CS$<>8__locals1.<>4__this.endPoint = new IPEndPoint(IPAddress.Parse(CS$<>8__locals1.clientRelayPort.ServerIPv6), CS$<>8__locals1.clientRelayPort.ServerPort);
				}
				else
				{
					CS$<>8__locals1.<>4__this.endPoint = new IPEndPoint(IPAddress.Parse(CS$<>8__locals1.clientRelayPort.ServerIp), CS$<>8__locals1.clientRelayPort.ServerPort);
				}
				if (CS$<>8__locals1.clientRelayPort.LocalIp != "localhost")
				{
					CS$<>8__locals1.<>4__this.endPoint2 = new IPEndPoint(IPAddress.Parse(CS$<>8__locals1.clientRelayPort.LocalIp), CS$<>8__locals1.clientRelayPort.Port);
				}
				else
				{
					try
					{
						CS$<>8__locals1.<>4__this.endPoint2 = new IPEndPoint(Dns.GetHostAddresses("localhost")[0], CS$<>8__locals1.clientRelayPort.Port);
					}
					catch
					{
						CS$<>8__locals1.<>4__this.endPoint2 = new IPEndPoint(IPAddress.Loopback, CS$<>8__locals1.clientRelayPort.Port);
					}
				}
				if (CS$<>8__locals1.<>4__this.supportIpv6)
				{
					CS$<>8__locals1.<>4__this.udpServer = new UdpClient(AddressFamily.InterNetworkV6);
				}
				else
				{
					CS$<>8__locals1.<>4__this.udpServer = new UdpClient();
				}
				CS$<>8__locals2.heartBeat = Encoding.ASCII.GetBytes("..12LijxZ");
				while (!CS$<>8__locals1.cancellationToken.IsCancellationRequested)
				{
					try
					{
						CS$<>8__locals1.<>4__this.udpServer.Connect(CS$<>8__locals1.<>4__this.endPoint);
						break;
					}
					catch
					{
						Task.Delay(2000).Wait();
					}
				}
				Task.Run(delegate()
				{
					UdpLocalClient.<>c__DisplayClass10_1.<<StartUDPClient>b__1>d <<StartUDPClient>b__1>d;
					<<StartUDPClient>b__1>d.<>t__builder = AsyncTaskMethodBuilder.Create();
					<<StartUDPClient>b__1>d.<>4__this = CS$<>8__locals2;
					<<StartUDPClient>b__1>d.<>1__state = -1;
					<<StartUDPClient>b__1>d.<>t__builder.Start<UdpLocalClient.<>c__DisplayClass10_1.<<StartUDPClient>b__1>d>(ref <<StartUDPClient>b__1>d);
					return <<StartUDPClient>b__1>d.<>t__builder.Task;
				}).ConfigureAwait(false);
				Func<Task> function;
				if ((function = CS$<>8__locals1.<>9__2) == null)
				{
					function = (CS$<>8__locals1.<>9__2 = delegate()
					{
						UdpLocalClient.<>c__DisplayClass10_0.<<StartUDPClient>b__2>d <<StartUDPClient>b__2>d;
						<<StartUDPClient>b__2>d.<>t__builder = AsyncTaskMethodBuilder.Create();
						<<StartUDPClient>b__2>d.<>4__this = CS$<>8__locals1;
						<<StartUDPClient>b__2>d.<>1__state = -1;
						<<StartUDPClient>b__2>d.<>t__builder.Start<UdpLocalClient.<>c__DisplayClass10_0.<<StartUDPClient>b__2>d>(ref <<StartUDPClient>b__2>d);
						return <<StartUDPClient>b__2>d.<>t__builder.Task;
					});
				}
				Task.Run(function).ConfigureAwait(false);
				Func<Task> function2;
				if ((function2 = CS$<>8__locals1.<>9__3) == null)
				{
					function2 = (CS$<>8__locals1.<>9__3 = delegate()
					{
						UdpLocalClient.<>c__DisplayClass10_0.<<StartUDPClient>b__3>d <<StartUDPClient>b__3>d;
						<<StartUDPClient>b__3>d.<>t__builder = AsyncTaskMethodBuilder.Create();
						<<StartUDPClient>b__3>d.<>4__this = CS$<>8__locals1;
						<<StartUDPClient>b__3>d.<>1__state = -1;
						<<StartUDPClient>b__3>d.<>t__builder.Start<UdpLocalClient.<>c__DisplayClass10_0.<<StartUDPClient>b__3>d>(ref <<StartUDPClient>b__3>d);
						return <<StartUDPClient>b__3>d.<>t__builder.Task;
					});
				}
				Task.Run(function2).ConfigureAwait(false);
				Func<Task> function3;
				if ((function3 = CS$<>8__locals1.<>9__4) == null)
				{
					function3 = (CS$<>8__locals1.<>9__4 = delegate()
					{
						UdpLocalClient.<>c__DisplayClass10_0.<<StartUDPClient>b__4>d <<StartUDPClient>b__4>d;
						<<StartUDPClient>b__4>d.<>t__builder = AsyncTaskMethodBuilder.Create();
						<<StartUDPClient>b__4>d.<>4__this = CS$<>8__locals1;
						<<StartUDPClient>b__4>d.<>1__state = -1;
						<<StartUDPClient>b__4>d.<>t__builder.Start<UdpLocalClient.<>c__DisplayClass10_0.<<StartUDPClient>b__4>d>(ref <<StartUDPClient>b__4>d);
						return <<StartUDPClient>b__4>d.<>t__builder.Task;
					});
				}
				Task.Run(function3).ConfigureAwait(false);
			}).ConfigureAwait(false);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000091A4 File Offset: 0x000073A4
		private void ConnectServerUdp(CancellationTokenSource receiveToken)
		{
			try
			{
				UdpClient udpClient = this.udpServer;
				if (udpClient != null)
				{
					udpClient.Dispose();
				}
				if (this.supportIpv6)
				{
					this.udpServer = new UdpClient(AddressFamily.InterNetworkV6);
				}
				else
				{
					this.udpServer = new UdpClient();
				}
				this.udpServer.Connect(this.endPoint);
				receiveToken.Cancel();
				if (receiveToken != null)
				{
					receiveToken.Dispose();
				}
				foreach (KeyValuePair<string, UdpClient> item in this.userList)
				{
					UdpClient value = item.Value;
					if (value != null)
					{
						value.Dispose();
					}
				}
				this.userList.Clear();
				receiveToken = new CancellationTokenSource();
				this._receiveToken = receiveToken;
			}
			catch
			{
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000927C File Offset: 0x0000747C
		private Task StartClientUdp(string id, byte[] received)
		{
			UdpLocalClient.<StartClientUdp>d__12 <StartClientUdp>d__;
			<StartClientUdp>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<StartClientUdp>d__.<>4__this = this;
			<StartClientUdp>d__.id = id;
			<StartClientUdp>d__.received = received;
			<StartClientUdp>d__.<>1__state = -1;
			<StartClientUdp>d__.<>t__builder.Start<UdpLocalClient.<StartClientUdp>d__12>(ref <StartClientUdp>d__);
			return <StartClientUdp>d__.<>t__builder.Task;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000092D0 File Offset: 0x000074D0
		private static byte[] Slice(byte[] source, int length)
		{
			byte[] destfoo = new byte[length];
			Array.Copy(source, 0, destfoo, 0, length);
			return destfoo;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000092F0 File Offset: 0x000074F0
		public static byte[] Combine(byte[] first, byte[] second)
		{
			byte[] ret = new byte[first.Length + second.Length];
			Buffer.BlockCopy(first, 0, ret, 0, first.Length);
			Buffer.BlockCopy(second, 0, ret, first.Length, second.Length);
			return ret;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00009328 File Offset: 0x00007528
		private IPEndPoint GetEndpointPort(List<LoadBalance> loadBalances)
		{
			double random = new Random().NextDouble();
			double cumulativePercent = 0.0;
			foreach (LoadBalance endpoint in loadBalances.Where(delegate(LoadBalance x)
			{
				bool? isHealthy = x.IsHealthy;
				bool flag = false;
				return !(isHealthy.GetValueOrDefault() == flag & isHealthy != null);
			}))
			{
				cumulativePercent += endpoint.Percent;
				if (random <= cumulativePercent)
				{
					return new IPEndPoint(IPAddress.Parse(endpoint.Ip), endpoint.Port);
				}
			}
			return new IPEndPoint(IPAddress.Parse(this._clientRelayPort.LocalIp), this._clientRelayPort.Port);
		}

		// Token: 0x04000064 RID: 100
		private IPEndPoint endPoint;

		// Token: 0x04000065 RID: 101
		private IPEndPoint endPoint2;

		// Token: 0x04000066 RID: 102
		private ConcurrentDictionary<string, UdpClient> userList = new ConcurrentDictionary<string, UdpClient>();

		// Token: 0x04000067 RID: 103
		private ConcurrentDictionary<string, DateTime> userLastConnectionTime = new ConcurrentDictionary<string, DateTime>();

		// Token: 0x04000068 RID: 104
		private UdpClient udpServer;

		// Token: 0x04000069 RID: 105
		private CancellationToken _cancellationToken;

		// Token: 0x0400006A RID: 106
		private CancellationTokenSource _receiveToken;

		// Token: 0x0400006B RID: 107
		private ClientRelayPort _clientRelayPort;

		// Token: 0x0400006C RID: 108
		private bool supportIpv6;

		// Token: 0x0400006D RID: 109
		private DateTime lastHeartBeat = DateTime.Now;
	}
}
