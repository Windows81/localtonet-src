using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using ExposeLocalhostNet.Models;
using ExposeLocalhostNet.Models.HttpInceptor;

namespace ExposeLocalhostNet
{
	// Token: 0x02000013 RID: 19
	public class TcpLocalClientNew
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000068 RID: 104 RVA: 0x0000874A File Offset: 0x0000694A
		// (set) Token: 0x06000069 RID: 105 RVA: 0x00008752 File Offset: 0x00006952
		private bool IsInceptorStarted { get; set; }

		// Token: 0x0600006A RID: 106 RVA: 0x0000875C File Offset: 0x0000695C
		public void StartTcpClient(ClientRelayPort clientRelayPort, CancellationToken cancellationToken)
		{
			TcpLocalClientNew.<>c__DisplayClass16_0 CS$<>8__locals1 = new TcpLocalClientNew.<>c__DisplayClass16_0();
			CS$<>8__locals1.clientRelayPort = clientRelayPort;
			CS$<>8__locals1.cancellationToken = cancellationToken;
			CS$<>8__locals1.<>4__this = this;
			this._clientRelayPort = CS$<>8__locals1.clientRelayPort;
			this.token = CS$<>8__locals1.cancellationToken;
			if (!string.IsNullOrEmpty(CS$<>8__locals1.clientRelayPort.ServerIPv6))
			{
				this.supportIpv6 = CommonService.SendPingForV6().Result;
			}
			if (this.supportIpv6)
			{
				CS$<>8__locals1.serverEndPoint = new IPEndPoint(IPAddress.Parse(CS$<>8__locals1.clientRelayPort.ServerIPv6), CS$<>8__locals1.clientRelayPort.ServerPort);
			}
			else
			{
				CS$<>8__locals1.serverEndPoint = new IPEndPoint(IPAddress.Parse(CS$<>8__locals1.clientRelayPort.ServerIp), CS$<>8__locals1.clientRelayPort.ServerPort);
			}
			if (CS$<>8__locals1.clientRelayPort.LocalIp != "localhost")
			{
				CS$<>8__locals1.localEndPoint = new IPEndPoint(IPAddress.Parse(CS$<>8__locals1.clientRelayPort.LocalIp), CS$<>8__locals1.clientRelayPort.Port);
			}
			else
			{
				try
				{
					CS$<>8__locals1.localEndPoint = new IPEndPoint(Dns.GetHostAddresses("localhost")[0], CS$<>8__locals1.clientRelayPort.Port);
				}
				catch
				{
					CS$<>8__locals1.localEndPoint = new IPEndPoint(IPAddress.Loopback, CS$<>8__locals1.clientRelayPort.Port);
				}
			}
			new byte[8196];
			Task.Run(delegate()
			{
				TcpLocalClientNew.<>c__DisplayClass16_0.<<StartTcpClient>b__0>d <<StartTcpClient>b__0>d;
				<<StartTcpClient>b__0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<StartTcpClient>b__0>d.<>4__this = CS$<>8__locals1;
				<<StartTcpClient>b__0>d.<>1__state = -1;
				<<StartTcpClient>b__0>d.<>t__builder.Start<TcpLocalClientNew.<>c__DisplayClass16_0.<<StartTcpClient>b__0>d>(ref <<StartTcpClient>b__0>d);
				return <<StartTcpClient>b__0>d.<>t__builder.Task;
			}).ConfigureAwait(false);
			Task.Run(delegate()
			{
				TcpLocalClientNew.<>c__DisplayClass16_0.<<StartTcpClient>b__1>d <<StartTcpClient>b__1>d;
				<<StartTcpClient>b__1>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<StartTcpClient>b__1>d.<>4__this = CS$<>8__locals1;
				<<StartTcpClient>b__1>d.<>1__state = -1;
				<<StartTcpClient>b__1>d.<>t__builder.Start<TcpLocalClientNew.<>c__DisplayClass16_0.<<StartTcpClient>b__1>d>(ref <<StartTcpClient>b__1>d);
				return <<StartTcpClient>b__1>d.<>t__builder.Task;
			}, CS$<>8__locals1.cancellationToken).ConfigureAwait(false);
			Task.Run(delegate()
			{
				TcpLocalClientNew.<>c__DisplayClass16_0.<<StartTcpClient>b__2>d <<StartTcpClient>b__2>d;
				<<StartTcpClient>b__2>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<StartTcpClient>b__2>d.<>4__this = CS$<>8__locals1;
				<<StartTcpClient>b__2>d.<>1__state = -1;
				<<StartTcpClient>b__2>d.<>t__builder.Start<TcpLocalClientNew.<>c__DisplayClass16_0.<<StartTcpClient>b__2>d>(ref <<StartTcpClient>b__2>d);
				return <<StartTcpClient>b__2>d.<>t__builder.Task;
			}, CS$<>8__locals1.cancellationToken).ConfigureAwait(false);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00008908 File Offset: 0x00006B08
		private Task ConnectServerAndClientAsync(IPEndPoint localEndPoint, IPEndPoint localEndPoint2, bool? isSslStream = null)
		{
			TcpLocalClientNew.<ConnectServerAndClientAsync>d__17 <ConnectServerAndClientAsync>d__;
			<ConnectServerAndClientAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ConnectServerAndClientAsync>d__.<>4__this = this;
			<ConnectServerAndClientAsync>d__.localEndPoint = localEndPoint;
			<ConnectServerAndClientAsync>d__.localEndPoint2 = localEndPoint2;
			<ConnectServerAndClientAsync>d__.isSslStream = isSslStream;
			<ConnectServerAndClientAsync>d__.<>1__state = -1;
			<ConnectServerAndClientAsync>d__.<>t__builder.Start<TcpLocalClientNew.<ConnectServerAndClientAsync>d__17>(ref <ConnectServerAndClientAsync>d__);
			return <ConnectServerAndClientAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00008964 File Offset: 0x00006B64
		private bool SocketConnected(Socket s)
		{
			bool flag = s.Poll(1000, SelectMode.SelectRead);
			bool part2 = s.Available == 0;
			return !flag || !part2;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00008990 File Offset: 0x00006B90
		private Task CopyToAsyncWithFlushAsync(Socket socket1, Socket socket2, IPEndPoint localEndPoint2, string ipString, bool? isSslStream = null)
		{
			TcpLocalClientNew.<CopyToAsyncWithFlushAsync>d__19 <CopyToAsyncWithFlushAsync>d__;
			<CopyToAsyncWithFlushAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<CopyToAsyncWithFlushAsync>d__.<>4__this = this;
			<CopyToAsyncWithFlushAsync>d__.socket1 = socket1;
			<CopyToAsyncWithFlushAsync>d__.socket2 = socket2;
			<CopyToAsyncWithFlushAsync>d__.localEndPoint2 = localEndPoint2;
			<CopyToAsyncWithFlushAsync>d__.ipString = ipString;
			<CopyToAsyncWithFlushAsync>d__.isSslStream = isSslStream;
			<CopyToAsyncWithFlushAsync>d__.<>1__state = -1;
			<CopyToAsyncWithFlushAsync>d__.<>t__builder.Start<TcpLocalClientNew.<CopyToAsyncWithFlushAsync>d__19>(ref <CopyToAsyncWithFlushAsync>d__);
			return <CopyToAsyncWithFlushAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00008A00 File Offset: 0x00006C00
		private Task CopyToAsyncRequest(Stream source, Stream destination, long requestSize, CancellationToken token)
		{
			TcpLocalClientNew.<CopyToAsyncRequest>d__21 <CopyToAsyncRequest>d__;
			<CopyToAsyncRequest>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<CopyToAsyncRequest>d__.<>4__this = this;
			<CopyToAsyncRequest>d__.source = source;
			<CopyToAsyncRequest>d__.destination = destination;
			<CopyToAsyncRequest>d__.requestSize = requestSize;
			<CopyToAsyncRequest>d__.token = token;
			<CopyToAsyncRequest>d__.<>1__state = -1;
			<CopyToAsyncRequest>d__.<>t__builder.Start<TcpLocalClientNew.<CopyToAsyncRequest>d__21>(ref <CopyToAsyncRequest>d__);
			return <CopyToAsyncRequest>d__.<>t__builder.Task;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00008A64 File Offset: 0x00006C64
		private Task CopyToAsyncResponse(Stream source, Stream destination, long requestSize, CancellationToken token)
		{
			TcpLocalClientNew.<CopyToAsyncResponse>d__22 <CopyToAsyncResponse>d__;
			<CopyToAsyncResponse>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<CopyToAsyncResponse>d__.<>4__this = this;
			<CopyToAsyncResponse>d__.source = source;
			<CopyToAsyncResponse>d__.destination = destination;
			<CopyToAsyncResponse>d__.requestSize = requestSize;
			<CopyToAsyncResponse>d__.token = token;
			<CopyToAsyncResponse>d__.<>1__state = -1;
			<CopyToAsyncResponse>d__.<>t__builder.Start<TcpLocalClientNew.<CopyToAsyncResponse>d__22>(ref <CopyToAsyncResponse>d__);
			return <CopyToAsyncResponse>d__.<>t__builder.Task;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00008AC8 File Offset: 0x00006CC8
		public Task ResponseParseMetaDataAsync(string data, Guid id)
		{
			TcpLocalClientNew.<ResponseParseMetaDataAsync>d__23 <ResponseParseMetaDataAsync>d__;
			<ResponseParseMetaDataAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ResponseParseMetaDataAsync>d__.<>4__this = this;
			<ResponseParseMetaDataAsync>d__.data = data;
			<ResponseParseMetaDataAsync>d__.id = id;
			<ResponseParseMetaDataAsync>d__.<>1__state = -1;
			<ResponseParseMetaDataAsync>d__.<>t__builder.Start<TcpLocalClientNew.<ResponseParseMetaDataAsync>d__23>(ref <ResponseParseMetaDataAsync>d__);
			return <ResponseParseMetaDataAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00008B1C File Offset: 0x00006D1C
		public Task RequestParseMetadataAsync(string data, Guid id)
		{
			TcpLocalClientNew.<RequestParseMetadataAsync>d__24 <RequestParseMetadataAsync>d__;
			<RequestParseMetadataAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<RequestParseMetadataAsync>d__.<>4__this = this;
			<RequestParseMetadataAsync>d__.data = data;
			<RequestParseMetadataAsync>d__.id = id;
			<RequestParseMetadataAsync>d__.<>1__state = -1;
			<RequestParseMetadataAsync>d__.<>t__builder.Start<TcpLocalClientNew.<RequestParseMetadataAsync>d__24>(ref <RequestParseMetadataAsync>d__);
			return <RequestParseMetadataAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00008B70 File Offset: 0x00006D70
		public void StartInceptor()
		{
			this.IsInceptorStarted = true;
			ConcurrentDictionary<Guid, RequestModel> requestDictionary = new ConcurrentDictionary<Guid, RequestModel>();
			SignalRClient.requestDic.AddOrUpdate(this._clientRelayPort.UserDomainGuidId, requestDictionary, (Guid key, ConcurrentDictionary<Guid, RequestModel> existingVal) => requestDictionary);
			this.IncertorStarted();
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00008BC3 File Offset: 0x00006DC3
		public void StopInceptor()
		{
			this.IsInceptorStarted = false;
			this.resquest.Clear();
			this.response.Clear();
			this.requestCountSize = 0L;
			this.requestCount.Clear();
			SignalRClient.requestDic.Clear();
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00008BFF File Offset: 0x00006DFF
		private void IncertorStarted()
		{
			Task.Run(delegate()
			{
				TcpLocalClientNew.<<IncertorStarted>b__27_0>d <<IncertorStarted>b__27_0>d;
				<<IncertorStarted>b__27_0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<IncertorStarted>b__27_0>d.<>4__this = this;
				<<IncertorStarted>b__27_0>d.<>1__state = -1;
				<<IncertorStarted>b__27_0>d.<>t__builder.Start<TcpLocalClientNew.<<IncertorStarted>b__27_0>d>(ref <<IncertorStarted>b__27_0>d);
				return <<IncertorStarted>b__27_0>d.<>t__builder.Task;
			}).ConfigureAwait(false);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00008C1C File Offset: 0x00006E1C
		private Tuple<bool?, IPEndPoint> GetEndpointPort(List<LoadBalance> loadBalances)
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
					return Tuple.Create<bool?, IPEndPoint>(endpoint.IsSslStream, new IPEndPoint(IPAddress.Parse(endpoint.Ip), endpoint.Port));
				}
			}
			return Tuple.Create<bool?, IPEndPoint>(this._clientRelayPort.IsSslStream, new IPEndPoint(IPAddress.Parse(this._clientRelayPort.LocalIp), this._clientRelayPort.Port));
		}

		// Token: 0x04000056 RID: 86
		private ConcurrentDictionary<Guid, string> resquest = new ConcurrentDictionary<Guid, string>();

		// Token: 0x04000057 RID: 87
		private ConcurrentDictionary<Guid, string> response = new ConcurrentDictionary<Guid, string>();

		// Token: 0x04000058 RID: 88
		private ConcurrentDictionary<Guid, Stopwatch> responseTime = new ConcurrentDictionary<Guid, Stopwatch>();

		// Token: 0x04000059 RID: 89
		private ConcurrentDictionary<long, Guid> requestCount = new ConcurrentDictionary<long, Guid>();

		// Token: 0x0400005A RID: 90
		private TimeSpan timeout = TimeSpan.FromSeconds(15.0);

		// Token: 0x0400005B RID: 91
		private CancellationToken token;

		// Token: 0x0400005C RID: 92
		private long requestCountSize;

		// Token: 0x0400005D RID: 93
		private bool supportIpv6;

		// Token: 0x0400005E RID: 94
		private ClientRelayPort _clientRelayPort;

		// Token: 0x0400005F RID: 95
		private DateTime _lastHeartBeatReceived = DateTime.Now;

		// Token: 0x04000060 RID: 96
		private DateTime _lastReceivedDate = DateTime.Now;

		// Token: 0x04000061 RID: 97
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

		// Token: 0x04000062 RID: 98
		private static int timeoutDuration = 30000;
	}
}
