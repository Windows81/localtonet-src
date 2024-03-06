using System;

namespace ExposeLocalhostNet.Models
{
	// Token: 0x0200001C RID: 28
	public class ClientRelayPort
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x0000D3CC File Offset: 0x0000B5CC
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x0000D3D4 File Offset: 0x0000B5D4
		public Guid UserDomainGuidId { get; set; }

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x0000D3DD File Offset: 0x0000B5DD
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x0000D3E5 File Offset: 0x0000B5E5
		public string UserRelayId { get; set; }

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x0000D3EE File Offset: 0x0000B5EE
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x0000D3F6 File Offset: 0x0000B5F6
		public string ServerIp { get; set; }

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x0000D3FF File Offset: 0x0000B5FF
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x0000D407 File Offset: 0x0000B607
		public string ServerIPv6 { get; set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x060000AA RID: 170 RVA: 0x0000D410 File Offset: 0x0000B610
		// (set) Token: 0x060000AB RID: 171 RVA: 0x0000D418 File Offset: 0x0000B618
		public int ServerPort { get; set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060000AC RID: 172 RVA: 0x0000D421 File Offset: 0x0000B621
		// (set) Token: 0x060000AD RID: 173 RVA: 0x0000D429 File Offset: 0x0000B629
		public int LocaltonetAppPort { get; set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060000AE RID: 174 RVA: 0x0000D432 File Offset: 0x0000B632
		// (set) Token: 0x060000AF RID: 175 RVA: 0x0000D43A File Offset: 0x0000B63A
		public int ServerListenerPort { get; set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x0000D443 File Offset: 0x0000B643
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x0000D44B File Offset: 0x0000B64B
		public int ServerClientListenerPort { get; set; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x0000D454 File Offset: 0x0000B654
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x0000D45C File Offset: 0x0000B65C
		public string ServerId { get; set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x0000D465 File Offset: 0x0000B665
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x0000D46D File Offset: 0x0000B66D
		public int Mtu { get; set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x0000D476 File Offset: 0x0000B676
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x0000D47E File Offset: 0x0000B67E
		public byte[] ServerPassword { get; set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x0000D487 File Offset: 0x0000B687
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x0000D48F File Offset: 0x0000B68F
		public string LocalIp { get; set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000BA RID: 186 RVA: 0x0000D498 File Offset: 0x0000B698
		// (set) Token: 0x060000BB RID: 187 RVA: 0x0000D4A0 File Offset: 0x0000B6A0
		public int Port { get; set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000BC RID: 188 RVA: 0x0000D4A9 File Offset: 0x0000B6A9
		// (set) Token: 0x060000BD RID: 189 RVA: 0x0000D4B1 File Offset: 0x0000B6B1
		public string Http { get; set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000BE RID: 190 RVA: 0x0000D4BA File Offset: 0x0000B6BA
		// (set) Token: 0x060000BF RID: 191 RVA: 0x0000D4C2 File Offset: 0x0000B6C2
		public string Https { get; set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x0000D4CB File Offset: 0x0000B6CB
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x0000D4D3 File Offset: 0x0000B6D3
		public string ProtocolType { get; set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x0000D4DC File Offset: 0x0000B6DC
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x0000D4E4 File Offset: 0x0000B6E4
		public DateTime StartedTime { get; set; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x0000D4ED File Offset: 0x0000B6ED
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x0000D4F5 File Offset: 0x0000B6F5
		public int? TotalMinutes { get; set; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x0000D4FE File Offset: 0x0000B6FE
		// (set) Token: 0x060000C7 RID: 199 RVA: 0x0000D506 File Offset: 0x0000B706
		public string ServerDomain { get; set; }

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x0000D50F File Offset: 0x0000B70F
		// (set) Token: 0x060000C9 RID: 201 RVA: 0x0000D517 File Offset: 0x0000B717
		public string Path { get; set; }

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000CA RID: 202 RVA: 0x0000D520 File Offset: 0x0000B720
		// (set) Token: 0x060000CB RID: 203 RVA: 0x0000D528 File Offset: 0x0000B728
		public bool BasicAuthentication { get; set; }

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000CC RID: 204 RVA: 0x0000D531 File Offset: 0x0000B731
		// (set) Token: 0x060000CD RID: 205 RVA: 0x0000D539 File Offset: 0x0000B739
		public string BasicAuthenticationUsername { get; set; }

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000CE RID: 206 RVA: 0x0000D542 File Offset: 0x0000B742
		// (set) Token: 0x060000CF RID: 207 RVA: 0x0000D54A File Offset: 0x0000B74A
		public string BasicAuthenticationPassword { get; set; }

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x0000D553 File Offset: 0x0000B753
		// (set) Token: 0x060000D1 RID: 209 RVA: 0x0000D55B File Offset: 0x0000B75B
		public long Ping { get; set; }

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x0000D564 File Offset: 0x0000B764
		// (set) Token: 0x060000D3 RID: 211 RVA: 0x0000D56C File Offset: 0x0000B76C
		public string TunnelStatus { get; set; }

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x0000D575 File Offset: 0x0000B775
		// (set) Token: 0x060000D5 RID: 213 RVA: 0x0000D57D File Offset: 0x0000B77D
		public bool? IsSslStream { get; set; }

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x0000D586 File Offset: 0x0000B786
		// (set) Token: 0x060000D7 RID: 215 RVA: 0x0000D58E File Offset: 0x0000B78E
		public bool IsLogOn { get; set; }
	}
}
