using System;

namespace ExposeLocalhostNet.Models
{
	// Token: 0x0200001F RID: 31
	public class LoadBalance
	{
		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000108 RID: 264 RVA: 0x0000D8F7 File Offset: 0x0000BAF7
		// (set) Token: 0x06000109 RID: 265 RVA: 0x0000D8FF File Offset: 0x0000BAFF
		public int Id { get; set; }

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x0600010A RID: 266 RVA: 0x0000D908 File Offset: 0x0000BB08
		// (set) Token: 0x0600010B RID: 267 RVA: 0x0000D910 File Offset: 0x0000BB10
		public string Ip { get; set; }

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600010C RID: 268 RVA: 0x0000D919 File Offset: 0x0000BB19
		// (set) Token: 0x0600010D RID: 269 RVA: 0x0000D921 File Offset: 0x0000BB21
		public int Port { get; set; }

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600010E RID: 270 RVA: 0x0000D92A File Offset: 0x0000BB2A
		// (set) Token: 0x0600010F RID: 271 RVA: 0x0000D932 File Offset: 0x0000BB32
		public double Percent { get; set; }

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000110 RID: 272 RVA: 0x0000D93B File Offset: 0x0000BB3B
		// (set) Token: 0x06000111 RID: 273 RVA: 0x0000D943 File Offset: 0x0000BB43
		public bool? IsHealthy { get; set; }

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000112 RID: 274 RVA: 0x0000D94C File Offset: 0x0000BB4C
		// (set) Token: 0x06000113 RID: 275 RVA: 0x0000D954 File Offset: 0x0000BB54
		public bool EnableHealthy { get; set; }

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000114 RID: 276 RVA: 0x0000D95D File Offset: 0x0000BB5D
		// (set) Token: 0x06000115 RID: 277 RVA: 0x0000D965 File Offset: 0x0000BB65
		public bool EnableHealthyCheckWithHttp { get; set; }

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000116 RID: 278 RVA: 0x0000D96E File Offset: 0x0000BB6E
		// (set) Token: 0x06000117 RID: 279 RVA: 0x0000D976 File Offset: 0x0000BB76
		public string Url { get; set; }

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000118 RID: 280 RVA: 0x0000D97F File Offset: 0x0000BB7F
		// (set) Token: 0x06000119 RID: 281 RVA: 0x0000D987 File Offset: 0x0000BB87
		public bool? IsSslStream { get; set; }
	}
}
