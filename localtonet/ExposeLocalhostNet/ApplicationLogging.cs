using System;
using Serilog;
using Serilog.Events;

namespace ExposeLocalhostNet
{
	// Token: 0x02000006 RID: 6
	public static class ApplicationLogging
	{
		// Token: 0x06000006 RID: 6 RVA: 0x000020A0 File Offset: 0x000002A0
		public static void ConfigureLogger(LogEventLevel restrictedToMinimumLevel = LogEventLevel.Verbose)
		{
			try
			{
				ApplicationLogging._logger = new LoggerConfiguration().WriteTo.Seq("https://seq.localtonet.com", restrictedToMinimumLevel, 1000, null, "QABLLG3y2xIz59zUBFN0", null, null, new long?(262144L), null, null, null, 100000).CreateLogger();
			}
			catch
			{
			}
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000007 RID: 7 RVA: 0x0000211C File Offset: 0x0000031C
		public static ILogger Logger
		{
			get
			{
				if (ApplicationLogging._logger == null)
				{
					ApplicationLogging.ConfigureLogger(LogEventLevel.Verbose);
				}
				return ApplicationLogging._logger;
			}
		}

		// Token: 0x04000004 RID: 4
		private static ILogger _logger;
	}
}
