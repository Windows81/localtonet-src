using System;
using System.Collections.Generic;
using System.Text;

namespace ExposeLocalhostNet.Models.HttpInceptor
{
	// Token: 0x02000028 RID: 40
	public class ResponseModel
	{
		// Token: 0x060001B5 RID: 437 RVA: 0x0000DED2 File Offset: 0x0000C0D2
		public ResponseModel()
		{
			this.Headers = new Dictionary<string, string>();
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x0000DEE5 File Offset: 0x0000C0E5
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x0000DEED File Offset: 0x0000C0ED
		public Guid Id { get; set; }

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x0000DEF6 File Offset: 0x0000C0F6
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x0000DEFE File Offset: 0x0000C0FE
		public Guid UserRelayGuidId { get; set; }

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001BA RID: 442 RVA: 0x0000DF07 File Offset: 0x0000C107
		// (set) Token: 0x060001BB RID: 443 RVA: 0x0000DF0F File Offset: 0x0000C10F
		public Dictionary<string, string> Headers { get; set; }

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001BC RID: 444 RVA: 0x0000DF18 File Offset: 0x0000C118
		// (set) Token: 0x060001BD RID: 445 RVA: 0x0000DF20 File Offset: 0x0000C120
		public int StatusCode { get; set; }

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001BE RID: 446 RVA: 0x0000DF29 File Offset: 0x0000C129
		// (set) Token: 0x060001BF RID: 447 RVA: 0x0000DF31 File Offset: 0x0000C131
		public string StatusDescription { get; set; }

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x0000DF3A File Offset: 0x0000C13A
		// (set) Token: 0x060001C1 RID: 449 RVA: 0x0000DF42 File Offset: 0x0000C142
		public string HeaderText { get; set; }

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x0000DF4B File Offset: 0x0000C14B
		// (set) Token: 0x060001C3 RID: 451 RVA: 0x0000DF53 File Offset: 0x0000C153
		public bool HasBody { get; set; }

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x0000DF5C File Offset: 0x0000C15C
		// (set) Token: 0x060001C5 RID: 453 RVA: 0x0000DF64 File Offset: 0x0000C164
		public string BodyString { get; set; }

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x0000DF6D File Offset: 0x0000C16D
		// (set) Token: 0x060001C7 RID: 455 RVA: 0x0000DF75 File Offset: 0x0000C175
		public string BodyHex { get; set; }

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x0000DF7E File Offset: 0x0000C17E
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x0000DF86 File Offset: 0x0000C186
		public string Method { get; set; }

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001CA RID: 458 RVA: 0x0000DF8F File Offset: 0x0000C18F
		// (set) Token: 0x060001CB RID: 459 RVA: 0x0000DF97 File Offset: 0x0000C197
		public bool KeepBody { get; set; }

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001CC RID: 460 RVA: 0x0000DFA0 File Offset: 0x0000C1A0
		// (set) Token: 0x060001CD RID: 461 RVA: 0x0000DFA8 File Offset: 0x0000C1A8
		public bool UpgradeToWebSocket { get; set; }

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001CE RID: 462 RVA: 0x0000DFB1 File Offset: 0x0000C1B1
		// (set) Token: 0x060001CF RID: 463 RVA: 0x0000DFB9 File Offset: 0x0000C1B9
		public string ContentEncoding { get; set; }

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x0000DFC2 File Offset: 0x0000C1C2
		// (set) Token: 0x060001D1 RID: 465 RVA: 0x0000DFCA File Offset: 0x0000C1CA
		public long ContentLength { get; set; }

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x0000DFD3 File Offset: 0x0000C1D3
		// (set) Token: 0x060001D3 RID: 467 RVA: 0x0000DFDB File Offset: 0x0000C1DB
		public string ContentType { get; set; }

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x0000DFE4 File Offset: 0x0000C1E4
		// (set) Token: 0x060001D5 RID: 469 RVA: 0x0000DFEC File Offset: 0x0000C1EC
		public Encoding Encoding { get; set; }

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x0000DFF5 File Offset: 0x0000C1F5
		// (set) Token: 0x060001D7 RID: 471 RVA: 0x0000DFFD File Offset: 0x0000C1FD
		public bool KeepAlive { get; set; }

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x0000E006 File Offset: 0x0000C206
		// (set) Token: 0x060001D9 RID: 473 RVA: 0x0000E00E File Offset: 0x0000C20E
		public string HttpVersion { get; set; }

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001DA RID: 474 RVA: 0x0000E017 File Offset: 0x0000C217
		// (set) Token: 0x060001DB RID: 475 RVA: 0x0000E01F File Offset: 0x0000C21F
		public bool IsChunked { get; set; }

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060001DC RID: 476 RVA: 0x0000E028 File Offset: 0x0000C228
		// (set) Token: 0x060001DD RID: 477 RVA: 0x0000E030 File Offset: 0x0000C230
		public bool IsBodyRead { get; set; }

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060001DE RID: 478 RVA: 0x0000E039 File Offset: 0x0000C239
		// (set) Token: 0x060001DF RID: 479 RVA: 0x0000E041 File Offset: 0x0000C241
		public string ResponseTime { get; set; }
	}
}
