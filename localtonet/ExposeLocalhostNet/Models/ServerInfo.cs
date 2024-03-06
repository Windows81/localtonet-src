using System;

namespace ExposeLocalhostNet.Models
{
	// Token: 0x02000023 RID: 35
	public class ServerInfo
	{
		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000150 RID: 336 RVA: 0x0000DB59 File Offset: 0x0000BD59
		// (set) Token: 0x06000151 RID: 337 RVA: 0x0000DB61 File Offset: 0x0000BD61
		public string ServerId { get; set; }

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000152 RID: 338 RVA: 0x0000DB6A File Offset: 0x0000BD6A
		// (set) Token: 0x06000153 RID: 339 RVA: 0x0000DB72 File Offset: 0x0000BD72
		public int Mtu { get; set; }

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000154 RID: 340 RVA: 0x0000DB7B File Offset: 0x0000BD7B
		// (set) Token: 0x06000155 RID: 341 RVA: 0x0000DB83 File Offset: 0x0000BD83
		public string Credential { get; set; }

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000156 RID: 342 RVA: 0x0000DB8C File Offset: 0x0000BD8C
		// (set) Token: 0x06000157 RID: 343 RVA: 0x0000DB94 File Offset: 0x0000BD94
		public string EndPoint { get; set; }
	}
}
