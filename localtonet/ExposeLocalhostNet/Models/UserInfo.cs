using System;

namespace ExposeLocalhostNet.Models
{
	// Token: 0x02000025 RID: 37
	public class UserInfo
	{
		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000162 RID: 354 RVA: 0x0000DBFC File Offset: 0x0000BDFC
		// (set) Token: 0x06000163 RID: 355 RVA: 0x0000DC04 File Offset: 0x0000BE04
		public string Email { get; set; }

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000164 RID: 356 RVA: 0x0000DC0D File Offset: 0x0000BE0D
		// (set) Token: 0x06000165 RID: 357 RVA: 0x0000DC15 File Offset: 0x0000BE15
		public string Subscription { get; set; }

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000166 RID: 358 RVA: 0x0000DC1E File Offset: 0x0000BE1E
		// (set) Token: 0x06000167 RID: 359 RVA: 0x0000DC26 File Offset: 0x0000BE26
		public bool IsRegistered { get; set; }

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000168 RID: 360 RVA: 0x0000DC2F File Offset: 0x0000BE2F
		// (set) Token: 0x06000169 RID: 361 RVA: 0x0000DC37 File Offset: 0x0000BE37
		public bool IsWrongAuthToken { get; set; }

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600016A RID: 362 RVA: 0x0000DC40 File Offset: 0x0000BE40
		// (set) Token: 0x0600016B RID: 363 RVA: 0x0000DC48 File Offset: 0x0000BE48
		public string AuthTokenName { get; set; }
	}
}
