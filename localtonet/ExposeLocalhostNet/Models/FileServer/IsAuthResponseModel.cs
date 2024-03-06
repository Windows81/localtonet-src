using System;

namespace ExposeLocalhostNet.Models.FileServer
{
	// Token: 0x02000029 RID: 41
	public class IsAuthResponseModel
	{
		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x0000E04A File Offset: 0x0000C24A
		// (set) Token: 0x060001E1 RID: 481 RVA: 0x0000E052 File Offset: 0x0000C252
		public string Title { get; set; }

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x0000E05B File Offset: 0x0000C25B
		// (set) Token: 0x060001E3 RID: 483 RVA: 0x0000E063 File Offset: 0x0000C263
		public bool IsAuth { get; set; }

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060001E4 RID: 484 RVA: 0x0000E06C File Offset: 0x0000C26C
		// (set) Token: 0x060001E5 RID: 485 RVA: 0x0000E074 File Offset: 0x0000C274
		public string UserName { get; set; }

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060001E6 RID: 486 RVA: 0x0000E07D File Offset: 0x0000C27D
		// (set) Token: 0x060001E7 RID: 487 RVA: 0x0000E085 File Offset: 0x0000C285
		public bool CanCreateNewFolder { get; set; }

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060001E8 RID: 488 RVA: 0x0000E08E File Offset: 0x0000C28E
		// (set) Token: 0x060001E9 RID: 489 RVA: 0x0000E096 File Offset: 0x0000C296
		public bool CanUploadFile { get; set; }

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060001EA RID: 490 RVA: 0x0000E09F File Offset: 0x0000C29F
		// (set) Token: 0x060001EB RID: 491 RVA: 0x0000E0A7 File Offset: 0x0000C2A7
		public bool CanMoveToFolder { get; set; }

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060001EC RID: 492 RVA: 0x0000E0B0 File Offset: 0x0000C2B0
		// (set) Token: 0x060001ED RID: 493 RVA: 0x0000E0B8 File Offset: 0x0000C2B8
		public bool CanRename { get; set; }

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060001EE RID: 494 RVA: 0x0000E0C1 File Offset: 0x0000C2C1
		// (set) Token: 0x060001EF RID: 495 RVA: 0x0000E0C9 File Offset: 0x0000C2C9
		public bool CanDelete { get; set; }
	}
}
