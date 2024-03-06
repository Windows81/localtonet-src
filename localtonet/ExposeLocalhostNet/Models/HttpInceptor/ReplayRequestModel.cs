using System;
using System.Collections.Generic;

namespace ExposeLocalhostNet.Models.HttpInceptor
{
	// Token: 0x02000026 RID: 38
	public class ReplayRequestModel
	{
		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600016D RID: 365 RVA: 0x0000DC59 File Offset: 0x0000BE59
		// (set) Token: 0x0600016E RID: 366 RVA: 0x0000DC61 File Offset: 0x0000BE61
		public Guid Id { get; set; }

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600016F RID: 367 RVA: 0x0000DC6A File Offset: 0x0000BE6A
		// (set) Token: 0x06000170 RID: 368 RVA: 0x0000DC72 File Offset: 0x0000BE72
		public Guid UserRelayGuidId { get; set; }

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000171 RID: 369 RVA: 0x0000DC7B File Offset: 0x0000BE7B
		// (set) Token: 0x06000172 RID: 370 RVA: 0x0000DC83 File Offset: 0x0000BE83
		public Dictionary<string, string> Headers { get; set; } = new Dictionary<string, string>();

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000173 RID: 371 RVA: 0x0000DC8C File Offset: 0x0000BE8C
		// (set) Token: 0x06000174 RID: 372 RVA: 0x0000DC94 File Offset: 0x0000BE94
		public byte[] Body { get; set; }

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000175 RID: 373 RVA: 0x0000DC9D File Offset: 0x0000BE9D
		// (set) Token: 0x06000176 RID: 374 RVA: 0x0000DCA5 File Offset: 0x0000BEA5
		public string BodyString { get; set; }

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000177 RID: 375 RVA: 0x0000DCAE File Offset: 0x0000BEAE
		// (set) Token: 0x06000178 RID: 376 RVA: 0x0000DCB6 File Offset: 0x0000BEB6
		public string Method { get; set; }

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000179 RID: 377 RVA: 0x0000DCBF File Offset: 0x0000BEBF
		// (set) Token: 0x0600017A RID: 378 RVA: 0x0000DCC7 File Offset: 0x0000BEC7
		public string Url { get; set; }

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600017B RID: 379 RVA: 0x0000DCD0 File Offset: 0x0000BED0
		// (set) Token: 0x0600017C RID: 380 RVA: 0x0000DCD8 File Offset: 0x0000BED8
		public bool IsModifiedRequest { get; set; }
	}
}
