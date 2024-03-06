using System;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using ExposeLocalhostNet.Models;

namespace ExposeLocalhostNet
{
	// Token: 0x02000008 RID: 8
	public class CommonService
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00002178 File Offset: 0x00000378
		public static Task<bool> SendPingForV6()
		{
			CommonService.<SendPingForV6>d__1 <SendPingForV6>d__;
			<SendPingForV6>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<SendPingForV6>d__.<>1__state = -1;
			<SendPingForV6>d__.<>t__builder.Start<CommonService.<SendPingForV6>d__1>(ref <SendPingForV6>d__);
			return <SendPingForV6>d__.<>t__builder.Task;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000021B4 File Offset: 0x000003B4
		public static void CreateRequestLogAndAddQueue(Guid guidId, string clientIp, string destination, string requestIp, DateTime dateTime, string token, string protocolType)
		{
			RequestLog requestLog = new RequestLog();
			requestLog.ClientIp = clientIp;
			requestLog.Destination = destination;
			requestLog.RequestIp = requestIp;
			requestLog.DateTime = dateTime;
			requestLog.UserRelayGuidId = guidId;
			requestLog.TokenName = token;
			requestLog.ProtocolType = protocolType;
			SignalRClient.requestLogs.Enqueue(requestLog);
		}

		// Token: 0x04000006 RID: 6
		public static HttpClient client = new HttpClient();
	}
}
