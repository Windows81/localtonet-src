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
	// Token: 0x02000016 RID: 22
	public class UdpLocalClientRelay
	{
		// Token: 0x06000086 RID: 134 RVA: 0x00009418 File Offset: 0x00007618
		public void Start(ClientRelayPort clientRelay, CancellationTokenSource cancellationToken)
		{
			UdpLocalClientRelay.<>c__DisplayClass1_0 CS$<>8__locals1 = new UdpLocalClientRelay.<>c__DisplayClass1_0();
			CS$<>8__locals1.<>4__this = this;
			CS$<>8__locals1.clientRelay = clientRelay;
			CS$<>8__locals1.cancellationToken = cancellationToken;
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
			CS$<>8__locals1.clients = new ConcurrentDictionary<IPEndPoint, UdpClientLocalToNet>();
			CS$<>8__locals1.server = new UdpClient(AddressFamily.InterNetworkV6);
			CS$<>8__locals1.server.Client.SetSocketOption(SocketOptionLevel.IPv6, SocketOptionName.IPv6Only, false);
			CS$<>8__locals1.server.Client.Bind(new IPEndPoint(IPAddress.Parse(CS$<>8__locals1.clientRelay.ServerIp), CS$<>8__locals1.clientRelay.ServerListenerPort));
			SignalRClient.sessionStatus.UserTunnel.TryGetValue(CS$<>8__locals1.clientRelay.UserDomainGuidId, out CS$<>8__locals1.clientRelayPort);
			CS$<>8__locals1.clientRelayPort.ServerListenerPort = ((IPEndPoint)CS$<>8__locals1.server.Client.LocalEndPoint).Port;
			SignalRClient.sessionStatus.UserTunnel.AddOrUpdate(CS$<>8__locals1.clientRelay.UserDomainGuidId, CS$<>8__locals1.clientRelayPort, (Guid key, ClientRelayPort existingVal) => CS$<>8__locals1.clientRelayPort);
			Task.Run(delegate()
			{
				UdpLocalClientRelay.<>c__DisplayClass1_0.<<Start>b__1>d <<Start>b__1>d;
				<<Start>b__1>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<Start>b__1>d.<>4__this = CS$<>8__locals1;
				<<Start>b__1>d.<>1__state = -1;
				<<Start>b__1>d.<>t__builder.Start<UdpLocalClientRelay.<>c__DisplayClass1_0.<<Start>b__1>d>(ref <<Start>b__1>d);
				return <<Start>b__1>d.<>t__builder.Task;
			});
			Task.Run(delegate()
			{
				UdpLocalClientRelay.<>c__DisplayClass1_0.<<Start>b__2>d <<Start>b__2>d;
				<<Start>b__2>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<Start>b__2>d.<>4__this = CS$<>8__locals1;
				<<Start>b__2>d.<>1__state = -1;
				<<Start>b__2>d.<>t__builder.Start<UdpLocalClientRelay.<>c__DisplayClass1_0.<<Start>b__2>d>(ref <<Start>b__2>d);
				return <<Start>b__2>d.<>t__builder.Task;
			});
		}

		// Token: 0x0400006E RID: 110
		public int byteCount;
	}
}
