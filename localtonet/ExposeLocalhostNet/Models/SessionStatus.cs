using System;
using System.Collections.Concurrent;

namespace ExposeLocalhostNet.Models
{
	// Token: 0x02000024 RID: 36
	public class SessionStatus
	{
		// Token: 0x06000159 RID: 345 RVA: 0x0000DBA5 File Offset: 0x0000BDA5
		public SessionStatus()
		{
			this.UserTunnel = new ConcurrentDictionary<Guid, ClientRelayPort>();
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600015A RID: 346 RVA: 0x0000DBB8 File Offset: 0x0000BDB8
		// (set) Token: 0x0600015B RID: 347 RVA: 0x0000DBC0 File Offset: 0x0000BDC0
		public bool SignalRIsConnected { get; set; }

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600015C RID: 348 RVA: 0x0000DBC9 File Offset: 0x0000BDC9
		// (set) Token: 0x0600015D RID: 349 RVA: 0x0000DBD1 File Offset: 0x0000BDD1
		public ConcurrentDictionary<Guid, ClientRelayPort> UserTunnel { get; set; }

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600015E RID: 350 RVA: 0x0000DBDA File Offset: 0x0000BDDA
		// (set) Token: 0x0600015F RID: 351 RVA: 0x0000DBE2 File Offset: 0x0000BDE2
		public string UserSubscription { get; set; }

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000160 RID: 352 RVA: 0x0000DBEB File Offset: 0x0000BDEB
		// (set) Token: 0x06000161 RID: 353 RVA: 0x0000DBF3 File Offset: 0x0000BDF3
		public string AuthTokenName { get; set; }
	}
}
