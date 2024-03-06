using System;
using System.Collections.Generic;
using System.Text;

namespace ExposeLocalhostNet.Models.HttpInceptor
{
	// Token: 0x02000027 RID: 39
	public class RequestModel
	{
		// Token: 0x0600017E RID: 382 RVA: 0x0000DCF4 File Offset: 0x0000BEF4
		public RequestModel()
		{
			this.Headers = new Dictionary<string, string>();
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600017F RID: 383 RVA: 0x0000DD07 File Offset: 0x0000BF07
		// (set) Token: 0x06000180 RID: 384 RVA: 0x0000DD0F File Offset: 0x0000BF0F
		public Guid Id { get; set; }

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000181 RID: 385 RVA: 0x0000DD18 File Offset: 0x0000BF18
		// (set) Token: 0x06000182 RID: 386 RVA: 0x0000DD20 File Offset: 0x0000BF20
		public Guid UserRelayGuidId { get; set; }

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000183 RID: 387 RVA: 0x0000DD29 File Offset: 0x0000BF29
		// (set) Token: 0x06000184 RID: 388 RVA: 0x0000DD31 File Offset: 0x0000BF31
		public Dictionary<string, string> Headers { get; set; }

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000185 RID: 389 RVA: 0x0000DD3A File Offset: 0x0000BF3A
		// (set) Token: 0x06000186 RID: 390 RVA: 0x0000DD42 File Offset: 0x0000BF42
		public string HeaderText { get; set; }

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000187 RID: 391 RVA: 0x0000DD4B File Offset: 0x0000BF4B
		// (set) Token: 0x06000188 RID: 392 RVA: 0x0000DD53 File Offset: 0x0000BF53
		public bool HasBody { get; set; }

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000189 RID: 393 RVA: 0x0000DD5C File Offset: 0x0000BF5C
		// (set) Token: 0x0600018A RID: 394 RVA: 0x0000DD64 File Offset: 0x0000BF64
		public string BodyString { get; set; }

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600018B RID: 395 RVA: 0x0000DD6D File Offset: 0x0000BF6D
		// (set) Token: 0x0600018C RID: 396 RVA: 0x0000DD75 File Offset: 0x0000BF75
		public string BodyHex { get; set; }

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600018D RID: 397 RVA: 0x0000DD7E File Offset: 0x0000BF7E
		// (set) Token: 0x0600018E RID: 398 RVA: 0x0000DD86 File Offset: 0x0000BF86
		public byte[] Body { get; set; }

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600018F RID: 399 RVA: 0x0000DD8F File Offset: 0x0000BF8F
		// (set) Token: 0x06000190 RID: 400 RVA: 0x0000DD97 File Offset: 0x0000BF97
		public string Method { get; set; }

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000191 RID: 401 RVA: 0x0000DDA0 File Offset: 0x0000BFA0
		// (set) Token: 0x06000192 RID: 402 RVA: 0x0000DDA8 File Offset: 0x0000BFA8
		public bool IsHttp { get; set; }

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000193 RID: 403 RVA: 0x0000DDB1 File Offset: 0x0000BFB1
		// (set) Token: 0x06000194 RID: 404 RVA: 0x0000DDB9 File Offset: 0x0000BFB9
		public string Url { get; set; }

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000195 RID: 405 RVA: 0x0000DDC2 File Offset: 0x0000BFC2
		// (set) Token: 0x06000196 RID: 406 RVA: 0x0000DDCA File Offset: 0x0000BFCA
		public string Host { get; set; }

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000197 RID: 407 RVA: 0x0000DDD3 File Offset: 0x0000BFD3
		// (set) Token: 0x06000198 RID: 408 RVA: 0x0000DDDB File Offset: 0x0000BFDB
		public Uri RequestUri { get; set; }

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000199 RID: 409 RVA: 0x0000DDE4 File Offset: 0x0000BFE4
		// (set) Token: 0x0600019A RID: 410 RVA: 0x0000DDEC File Offset: 0x0000BFEC
		public string RequestUriString { get; set; }

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600019B RID: 411 RVA: 0x0000DDF5 File Offset: 0x0000BFF5
		// (set) Token: 0x0600019C RID: 412 RVA: 0x0000DDFD File Offset: 0x0000BFFD
		public bool KeepBody { get; set; }

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600019D RID: 413 RVA: 0x0000DE06 File Offset: 0x0000C006
		// (set) Token: 0x0600019E RID: 414 RVA: 0x0000DE0E File Offset: 0x0000C00E
		public bool UpgradeToWebSocket { get; set; }

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600019F RID: 415 RVA: 0x0000DE17 File Offset: 0x0000C017
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x0000DE1F File Offset: 0x0000C01F
		public string ContentEncoding { get; set; }

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x0000DE28 File Offset: 0x0000C028
		// (set) Token: 0x060001A2 RID: 418 RVA: 0x0000DE30 File Offset: 0x0000C030
		public long ContentLength { get; set; }

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x0000DE39 File Offset: 0x0000C039
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x0000DE41 File Offset: 0x0000C041
		public string ContentType { get; set; }

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x0000DE4A File Offset: 0x0000C04A
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x0000DE52 File Offset: 0x0000C052
		public Encoding Encoding { get; set; }

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x0000DE5B File Offset: 0x0000C05B
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x0000DE63 File Offset: 0x0000C063
		public bool ExpectationFailed { get; set; }

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x0000DE6C File Offset: 0x0000C06C
		// (set) Token: 0x060001AA RID: 426 RVA: 0x0000DE74 File Offset: 0x0000C074
		public bool ExpectationSucceeded { get; set; }

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001AB RID: 427 RVA: 0x0000DE7D File Offset: 0x0000C07D
		// (set) Token: 0x060001AC RID: 428 RVA: 0x0000DE85 File Offset: 0x0000C085
		public bool ExpectContinue { get; set; }

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001AD RID: 429 RVA: 0x0000DE8E File Offset: 0x0000C08E
		// (set) Token: 0x060001AE RID: 430 RVA: 0x0000DE96 File Offset: 0x0000C096
		public string HttpVersion { get; set; }

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001AF RID: 431 RVA: 0x0000DE9F File Offset: 0x0000C09F
		// (set) Token: 0x060001B0 RID: 432 RVA: 0x0000DEA7 File Offset: 0x0000C0A7
		public bool IsChunked { get; set; }

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x0000DEB0 File Offset: 0x0000C0B0
		// (set) Token: 0x060001B2 RID: 434 RVA: 0x0000DEB8 File Offset: 0x0000C0B8
		public bool IsMultipartFormData { get; set; }

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x0000DEC1 File Offset: 0x0000C0C1
		// (set) Token: 0x060001B4 RID: 436 RVA: 0x0000DEC9 File Offset: 0x0000C0C9
		public bool IsBodyRead { get; set; }
	}
}
