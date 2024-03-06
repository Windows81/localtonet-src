using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using RabbitMQ.Client;

namespace ExposeLocalhostNet.Services
{
	// Token: 0x0200001B RID: 27
	public class RequestLogService
	{
		// Token: 0x0600009F RID: 159 RVA: 0x0000D30C File Offset: 0x0000B50C
		public static void QueueLogAsync()
		{
			Task.Run(delegate()
			{
				RequestLogService.<>c.<<QueueLogAsync>b__3_0>d <<QueueLogAsync>b__3_0>d;
				<<QueueLogAsync>b__3_0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<QueueLogAsync>b__3_0>d.<>1__state = -1;
				<<QueueLogAsync>b__3_0>d.<>t__builder.Start<RequestLogService.<>c.<<QueueLogAsync>b__3_0>d>(ref <<QueueLogAsync>b__3_0>d);
				return <<QueueLogAsync>b__3_0>d.<>t__builder.Task;
			});
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000D334 File Offset: 0x0000B534
		public static void CreateFactory()
		{
			try
			{
				RequestLogService.connection = new ConnectionFactory
				{
					HostName = "localtonet.com",
					AutomaticRecoveryEnabled = true,
					UserName = "guest",
					Password = "System32.34.36",
					NetworkRecoveryInterval = TimeSpan.FromSeconds(2.0)
				}.CreateConnection();
				RequestLogService.channel = RequestLogService.connection.CreateModel();
				RequestLogService.channel.QueueDeclareNoWait("requestLog", false, false, false, null);
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x04000079 RID: 121
		[Nullable(2)]
		public static IModel channel;

		// Token: 0x0400007A RID: 122
		public static IConnection connection;

		// Token: 0x0400007B RID: 123
		public static bool isStarted;
	}
}
