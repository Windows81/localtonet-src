using System;
using System.Collections.Concurrent;

namespace ExposeLocalhostNet.Models.FileServer
{
	// Token: 0x0200002A RID: 42
	public class SettingFileServer
	{
		// Token: 0x060001F1 RID: 497 RVA: 0x0000E0DA File Offset: 0x0000C2DA
		public SettingFileServer()
		{
			this.UserRoleFileServer = new ConcurrentDictionary<string, UserRoleFileServer>();
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060001F2 RID: 498 RVA: 0x0000E0ED File Offset: 0x0000C2ED
		// (set) Token: 0x060001F3 RID: 499 RVA: 0x0000E0F5 File Offset: 0x0000C2F5
		public string Title { get; set; }

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060001F4 RID: 500 RVA: 0x0000E0FE File Offset: 0x0000C2FE
		// (set) Token: 0x060001F5 RID: 501 RVA: 0x0000E106 File Offset: 0x0000C306
		public bool CanEveryoneReadAccess { get; set; }

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060001F6 RID: 502 RVA: 0x0000E10F File Offset: 0x0000C30F
		// (set) Token: 0x060001F7 RID: 503 RVA: 0x0000E117 File Offset: 0x0000C317
		public bool CanEveryoneWriteAccess { get; set; }

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x0000E120 File Offset: 0x0000C320
		// (set) Token: 0x060001F9 RID: 505 RVA: 0x0000E128 File Offset: 0x0000C328
		public bool CanEveryoneDeleteAccess { get; set; }

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060001FA RID: 506 RVA: 0x0000E131 File Offset: 0x0000C331
		// (set) Token: 0x060001FB RID: 507 RVA: 0x0000E139 File Offset: 0x0000C339
		public ConcurrentDictionary<string, UserRoleFileServer> UserRoleFileServer { get; set; }
	}
}
