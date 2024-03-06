using System;

namespace ExposeLocalhostNet.Models
{
	// Token: 0x02000022 RID: 34
	public class RequestLog
	{
		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000141 RID: 321 RVA: 0x0000DADA File Offset: 0x0000BCDA
		// (set) Token: 0x06000142 RID: 322 RVA: 0x0000DAE2 File Offset: 0x0000BCE2
		public Guid UserRelayGuidId { get; set; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000143 RID: 323 RVA: 0x0000DAEB File Offset: 0x0000BCEB
		// (set) Token: 0x06000144 RID: 324 RVA: 0x0000DAF3 File Offset: 0x0000BCF3
		public DateTime DateTime { get; set; }

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000145 RID: 325 RVA: 0x0000DAFC File Offset: 0x0000BCFC
		// (set) Token: 0x06000146 RID: 326 RVA: 0x0000DB04 File Offset: 0x0000BD04
		public string RequestIp { get; set; }

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000147 RID: 327 RVA: 0x0000DB0D File Offset: 0x0000BD0D
		// (set) Token: 0x06000148 RID: 328 RVA: 0x0000DB15 File Offset: 0x0000BD15
		public string ClientIp { get; set; }

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000149 RID: 329 RVA: 0x0000DB1E File Offset: 0x0000BD1E
		// (set) Token: 0x0600014A RID: 330 RVA: 0x0000DB26 File Offset: 0x0000BD26
		public string Destination { get; set; }

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600014B RID: 331 RVA: 0x0000DB2F File Offset: 0x0000BD2F
		// (set) Token: 0x0600014C RID: 332 RVA: 0x0000DB37 File Offset: 0x0000BD37
		public string TokenName { get; set; }

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600014D RID: 333 RVA: 0x0000DB40 File Offset: 0x0000BD40
		// (set) Token: 0x0600014E RID: 334 RVA: 0x0000DB48 File Offset: 0x0000BD48
		public string ProtocolType { get; set; }
	}
}
