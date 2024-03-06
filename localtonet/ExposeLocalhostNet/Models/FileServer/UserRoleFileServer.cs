using System;

namespace ExposeLocalhostNet.Models.FileServer
{
	// Token: 0x0200002B RID: 43
	public class UserRoleFileServer
	{
		// Token: 0x060001FC RID: 508 RVA: 0x0000E142 File Offset: 0x0000C342
		public UserRoleFileServer(bool canReadAccess, bool canUploadFile, bool canDelete, string password)
		{
			this.CanReadAccess = canReadAccess;
			this.CanWriteAccess = canUploadFile;
			this.CanDeleteAccess = canDelete;
			this.Password = password;
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060001FD RID: 509 RVA: 0x0000E167 File Offset: 0x0000C367
		// (set) Token: 0x060001FE RID: 510 RVA: 0x0000E16F File Offset: 0x0000C36F
		public bool CanReadAccess { get; set; }

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060001FF RID: 511 RVA: 0x0000E178 File Offset: 0x0000C378
		// (set) Token: 0x06000200 RID: 512 RVA: 0x0000E180 File Offset: 0x0000C380
		public bool CanWriteAccess { get; set; }

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000201 RID: 513 RVA: 0x0000E189 File Offset: 0x0000C389
		// (set) Token: 0x06000202 RID: 514 RVA: 0x0000E191 File Offset: 0x0000C391
		public bool CanDeleteAccess { get; set; }

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000203 RID: 515 RVA: 0x0000E19A File Offset: 0x0000C39A
		// (set) Token: 0x06000204 RID: 516 RVA: 0x0000E1A2 File Offset: 0x0000C3A2
		public string Password { get; set; }
	}
}
