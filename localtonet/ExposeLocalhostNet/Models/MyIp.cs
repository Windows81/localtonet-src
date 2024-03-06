using System;
using Newtonsoft.Json;

namespace ExposeLocalhostNet.Models
{
	// Token: 0x02000020 RID: 32
	internal class MyIp
	{
		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600011B RID: 283 RVA: 0x0000D998 File Offset: 0x0000BB98
		// (set) Token: 0x0600011C RID: 284 RVA: 0x0000D9A0 File Offset: 0x0000BBA0
		[JsonProperty("status")]
		public string Status { get; set; }

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600011D RID: 285 RVA: 0x0000D9A9 File Offset: 0x0000BBA9
		// (set) Token: 0x0600011E RID: 286 RVA: 0x0000D9B1 File Offset: 0x0000BBB1
		[JsonProperty("country")]
		public string Country { get; set; }

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600011F RID: 287 RVA: 0x0000D9BA File Offset: 0x0000BBBA
		// (set) Token: 0x06000120 RID: 288 RVA: 0x0000D9C2 File Offset: 0x0000BBC2
		[JsonProperty("countryCode")]
		public string CountryCode { get; set; }

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000121 RID: 289 RVA: 0x0000D9CB File Offset: 0x0000BBCB
		// (set) Token: 0x06000122 RID: 290 RVA: 0x0000D9D3 File Offset: 0x0000BBD3
		[JsonProperty("region")]
		public string Region { get; set; }

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000123 RID: 291 RVA: 0x0000D9DC File Offset: 0x0000BBDC
		// (set) Token: 0x06000124 RID: 292 RVA: 0x0000D9E4 File Offset: 0x0000BBE4
		[JsonProperty("regionName")]
		public string RegionName { get; set; }

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000125 RID: 293 RVA: 0x0000D9ED File Offset: 0x0000BBED
		// (set) Token: 0x06000126 RID: 294 RVA: 0x0000D9F5 File Offset: 0x0000BBF5
		[JsonProperty("city")]
		public string City { get; set; }

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000127 RID: 295 RVA: 0x0000D9FE File Offset: 0x0000BBFE
		// (set) Token: 0x06000128 RID: 296 RVA: 0x0000DA06 File Offset: 0x0000BC06
		[JsonProperty("zip")]
		public string Zip { get; set; }

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000129 RID: 297 RVA: 0x0000DA0F File Offset: 0x0000BC0F
		// (set) Token: 0x0600012A RID: 298 RVA: 0x0000DA17 File Offset: 0x0000BC17
		[JsonProperty("lat")]
		public double Lat { get; set; }

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600012B RID: 299 RVA: 0x0000DA20 File Offset: 0x0000BC20
		// (set) Token: 0x0600012C RID: 300 RVA: 0x0000DA28 File Offset: 0x0000BC28
		[JsonProperty("lon")]
		public double Lon { get; set; }

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x0600012D RID: 301 RVA: 0x0000DA31 File Offset: 0x0000BC31
		// (set) Token: 0x0600012E RID: 302 RVA: 0x0000DA39 File Offset: 0x0000BC39
		[JsonProperty("timezone")]
		public string Timezone { get; set; }

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x0600012F RID: 303 RVA: 0x0000DA42 File Offset: 0x0000BC42
		// (set) Token: 0x06000130 RID: 304 RVA: 0x0000DA4A File Offset: 0x0000BC4A
		[JsonProperty("isp")]
		public string Isp { get; set; }

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000131 RID: 305 RVA: 0x0000DA53 File Offset: 0x0000BC53
		// (set) Token: 0x06000132 RID: 306 RVA: 0x0000DA5B File Offset: 0x0000BC5B
		[JsonProperty("org")]
		public string Org { get; set; }

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000133 RID: 307 RVA: 0x0000DA64 File Offset: 0x0000BC64
		// (set) Token: 0x06000134 RID: 308 RVA: 0x0000DA6C File Offset: 0x0000BC6C
		[JsonProperty("as")]
		public string As { get; set; }

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000135 RID: 309 RVA: 0x0000DA75 File Offset: 0x0000BC75
		// (set) Token: 0x06000136 RID: 310 RVA: 0x0000DA7D File Offset: 0x0000BC7D
		[JsonProperty("query")]
		public string Query { get; set; }
	}
}
