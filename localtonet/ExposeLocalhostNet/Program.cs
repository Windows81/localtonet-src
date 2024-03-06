using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ExposeLocalhostNet
{
	// Token: 0x0200000C RID: 12
	public class Program
	{
		// Token: 0x06000030 RID: 48 RVA: 0x000063E4 File Offset: 0x000045E4
		private static Task Main(string[] args)
		{
			Program.<Main>d__0 <Main>d__;
			<Main>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<Main>d__.args = args;
			<Main>d__.<>1__state = -1;
			<Main>d__.<>t__builder.Start<Program.<Main>d__0>(ref <Main>d__);
			return <Main>d__.<>t__builder.Task;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00006430 File Offset: 0x00004630
		private static void <Main>(string[] args)
		{
			Program.Main(args).GetAwaiter().GetResult();
		}
	}
}
