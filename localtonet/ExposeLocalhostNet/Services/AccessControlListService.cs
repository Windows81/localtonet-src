using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace ExposeLocalhostNet.Services
{
	// Token: 0x0200001A RID: 26
	public class AccessControlListService
	{
		// Token: 0x0600009B RID: 155 RVA: 0x0000D204 File Offset: 0x0000B404
		public static Task<bool> CanBeAccessAsync(Guid guid, string destination)
		{
			AccessControlListService.<CanBeAccessAsync>d__0 <CanBeAccessAsync>d__;
			<CanBeAccessAsync>d__.<>t__builder = AsyncTaskMethodBuilder<bool>.Create();
			<CanBeAccessAsync>d__.guid = guid;
			<CanBeAccessAsync>d__.destination = destination;
			<CanBeAccessAsync>d__.<>1__state = -1;
			<CanBeAccessAsync>d__.<>t__builder.Start<AccessControlListService.<CanBeAccessAsync>d__0>(ref <CanBeAccessAsync>d__);
			return <CanBeAccessAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000D250 File Offset: 0x0000B450
		private static bool CheckAccessList(Guid guid, IPAddress destination)
		{
			try
			{
				List<IPNetwork2> ipDic;
				if (SignalRClient.accessControlListDic.TryGetValue(guid.ToString() + "-true", out ipDic))
				{
					return AccessControlListService.IsIPInRestriction(destination, ipDic);
				}
				if (SignalRClient.accessControlListDic.TryGetValue(guid.ToString() + "-false", out ipDic))
				{
					return !AccessControlListService.IsIPInRestriction(destination, ipDic);
				}
			}
			catch
			{
			}
			return true;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000D2D8 File Offset: 0x0000B4D8
		public static bool IsIPInRestriction(IPAddress ip, List<IPNetwork2> networks)
		{
			return networks.Any((IPNetwork2 network) => network.Contains(ip));
		}
	}
}
