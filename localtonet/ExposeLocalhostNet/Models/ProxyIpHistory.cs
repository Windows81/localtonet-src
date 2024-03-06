using System;

namespace ExposeLocalhostNet.Models
{
	// Token: 0x02000021 RID: 33
	public class ProxyIpHistory
	{
		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000138 RID: 312 RVA: 0x0000DA8E File Offset: 0x0000BC8E
		// (set) Token: 0x06000139 RID: 313 RVA: 0x0000DA96 File Offset: 0x0000BC96
		public string UserToken { get; set; }

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600013A RID: 314 RVA: 0x0000DA9F File Offset: 0x0000BC9F
		// (set) Token: 0x0600013B RID: 315 RVA: 0x0000DAA7 File Offset: 0x0000BCA7
		public string IP { get; set; }

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x0600013C RID: 316 RVA: 0x0000DAB0 File Offset: 0x0000BCB0
		// (set) Token: 0x0600013D RID: 317 RVA: 0x0000DAB8 File Offset: 0x0000BCB8
		public DateTime Date { get; set; }

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600013E RID: 318 RVA: 0x0000DAC1 File Offset: 0x0000BCC1
		// (set) Token: 0x0600013F RID: 319 RVA: 0x0000DAC9 File Offset: 0x0000BCC9
		public bool IsHealth { get; set; }
	}
}
