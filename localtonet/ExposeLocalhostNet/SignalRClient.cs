using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using ExposeLocalhostNet.Models;
using ExposeLocalhostNet.Models.FileServer;
using ExposeLocalhostNet.Models.HttpInceptor;
using Microsoft.AspNetCore.SignalR.Client;
using Newtonsoft.Json;
using Serilog;
using Spectre.Console;

namespace ExposeLocalhostNet
{
	// Token: 0x0200000E RID: 14
	public class SignalRClient
	{
		// Token: 0x0600003B RID: 59 RVA: 0x00006BCC File Offset: 0x00004DCC
		public Task StartSignalRClientAsync(string authToken, string protocol, int port, string ver)
		{
			SignalRClient.<StartSignalRClientAsync>d__18 <StartSignalRClientAsync>d__;
			<StartSignalRClientAsync>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<StartSignalRClientAsync>d__.<>4__this = this;
			<StartSignalRClientAsync>d__.authToken = authToken;
			<StartSignalRClientAsync>d__.protocol = protocol;
			<StartSignalRClientAsync>d__.port = port;
			<StartSignalRClientAsync>d__.ver = ver;
			<StartSignalRClientAsync>d__.<>1__state = -1;
			<StartSignalRClientAsync>d__.<>t__builder.Start<SignalRClient.<StartSignalRClientAsync>d__18>(ref <StartSignalRClientAsync>d__);
			return <StartSignalRClientAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00006C30 File Offset: 0x00004E30
		public Task ConnectSignalR(string osNameAndVersion)
		{
			SignalRClient.<ConnectSignalR>d__19 <ConnectSignalR>d__;
			<ConnectSignalR>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<ConnectSignalR>d__.<>4__this = this;
			<ConnectSignalR>d__.osNameAndVersion = osNameAndVersion;
			<ConnectSignalR>d__.<>1__state = -1;
			<ConnectSignalR>d__.<>t__builder.Start<SignalRClient.<ConnectSignalR>d__19>(ref <ConnectSignalR>d__);
			return <ConnectSignalR>d__.<>t__builder.Task;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00006C7C File Offset: 0x00004E7C
		private static Task DisposeHubConnection()
		{
			SignalRClient.<DisposeHubConnection>d__20 <DisposeHubConnection>d__;
			<DisposeHubConnection>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<DisposeHubConnection>d__.<>1__state = -1;
			<DisposeHubConnection>d__.<>t__builder.Start<SignalRClient.<DisposeHubConnection>d__20>(ref <DisposeHubConnection>d__);
			return <DisposeHubConnection>d__.<>t__builder.Task;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00006CB7 File Offset: 0x00004EB7
		public void TunnelCount(List<Guid> guids)
		{
			SignalRClient.tunnelCount = guids;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00006CC0 File Offset: 0x00004EC0
		public void StartRelay(ClientRelayPort clientRelayPort)
		{
			try
			{
				SignalRClient.count++;
				ClientRelayPort clientRelayPort2;
				SignalRClient.sessionStatus.UserTunnel.TryRemove(clientRelayPort.UserDomainGuidId, out clientRelayPort2);
				SignalRClient.sessionStatus.UserTunnel.AddOrUpdate(clientRelayPort.UserDomainGuidId, clientRelayPort, (Guid key, ClientRelayPort existingVal) => clientRelayPort);
				Action <>9__2;
				Task.Run(delegate()
				{
					RelayClientServer.StartServerAsync(clientRelayPort);
					if (SignalRClient.isNotRunningNewVersion)
					{
						Action action;
						if ((action = <>9__2) == null)
						{
							action = (<>9__2 = delegate()
							{
								DefaultInterpolatedStringHandler defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(84, 1);
								defaultInterpolatedStringHandler2.AppendLiteral("[white]--------------------------------------------------------------------------");
								defaultInterpolatedStringHandler2.AppendFormatted<int>(SignalRClient.count);
								defaultInterpolatedStringHandler2.AppendLiteral("[/]");
								AnsiConsole.MarkupLine(defaultInterpolatedStringHandler2.ToStringAndClear());
								if (clientRelayPort.ProtocolType.ToLower().Equals("http"))
								{
									defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(56, 3);
									defaultInterpolatedStringHandler2.AppendLiteral("[underline white]Http:[/] [yellow]");
									defaultInterpolatedStringHandler2.AppendFormatted(clientRelayPort.Http);
									defaultInterpolatedStringHandler2.AppendLiteral("[/]   --->[green] ");
									defaultInterpolatedStringHandler2.AppendFormatted(clientRelayPort.LocalIp);
									defaultInterpolatedStringHandler2.AppendLiteral(":");
									defaultInterpolatedStringHandler2.AppendFormatted<int>(clientRelayPort.Port);
									defaultInterpolatedStringHandler2.AppendLiteral("[/]");
									AnsiConsole.MarkupLine(defaultInterpolatedStringHandler2.ToStringAndClear());
									defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(55, 3);
									defaultInterpolatedStringHandler2.AppendLiteral("[underline white]Https:[/] [yellow]");
									defaultInterpolatedStringHandler2.AppendFormatted(clientRelayPort.Https);
									defaultInterpolatedStringHandler2.AppendLiteral("[/] --->[green] ");
									defaultInterpolatedStringHandler2.AppendFormatted(clientRelayPort.LocalIp);
									defaultInterpolatedStringHandler2.AppendLiteral(":");
									defaultInterpolatedStringHandler2.AppendFormatted<int>(clientRelayPort.Port);
									defaultInterpolatedStringHandler2.AppendLiteral("[/]");
									AnsiConsole.MarkupLine(defaultInterpolatedStringHandler2.ToStringAndClear());
								}
								if (clientRelayPort.ProtocolType.ToLower().Contains("udp") && !clientRelayPort.ProtocolType.ToLower().Contains("clientrelay"))
								{
									defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(54, 4);
									defaultInterpolatedStringHandler2.AppendLiteral("[underline white]UDP:[/] [yellow]");
									defaultInterpolatedStringHandler2.AppendFormatted(clientRelayPort.ServerDomain);
									defaultInterpolatedStringHandler2.AppendLiteral(":");
									defaultInterpolatedStringHandler2.AppendFormatted<int>(clientRelayPort.ServerListenerPort);
									defaultInterpolatedStringHandler2.AppendLiteral("[/] --->[green] ");
									defaultInterpolatedStringHandler2.AppendFormatted(clientRelayPort.LocalIp);
									defaultInterpolatedStringHandler2.AppendLiteral(":");
									defaultInterpolatedStringHandler2.AppendFormatted<int>(clientRelayPort.Port);
									defaultInterpolatedStringHandler2.AppendLiteral("[/]");
									AnsiConsole.MarkupLine(defaultInterpolatedStringHandler2.ToStringAndClear());
								}
								if (clientRelayPort.ProtocolType.ToLower().Contains("tcp") && !clientRelayPort.ProtocolType.ToLower().Contains("clientrelay"))
								{
									defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(54, 4);
									defaultInterpolatedStringHandler2.AppendLiteral("[underline white]TCP:[/] [yellow]");
									defaultInterpolatedStringHandler2.AppendFormatted(clientRelayPort.ServerDomain);
									defaultInterpolatedStringHandler2.AppendLiteral(":");
									defaultInterpolatedStringHandler2.AppendFormatted<int>(clientRelayPort.ServerListenerPort);
									defaultInterpolatedStringHandler2.AppendLiteral("[/] --->[green] ");
									defaultInterpolatedStringHandler2.AppendFormatted(clientRelayPort.LocalIp);
									defaultInterpolatedStringHandler2.AppendLiteral(":");
									defaultInterpolatedStringHandler2.AppendFormatted<int>(clientRelayPort.Port);
									defaultInterpolatedStringHandler2.AppendLiteral("[/]");
									AnsiConsole.MarkupLine(defaultInterpolatedStringHandler2.ToStringAndClear());
								}
								if (clientRelayPort.ProtocolType.ToLower().Equals("fileserver"))
								{
									AnsiConsole.MarkupLine("[underline white]FileServer - Http:[/] [yellow]" + clientRelayPort.Http + "[/]");
									AnsiConsole.MarkupLine("[underline white]FileServer - Https:[/] [yellow]" + clientRelayPort.Https + "[/]");
								}
								if (clientRelayPort.ProtocolType.ToLower().Equals("proxyhttp"))
								{
									defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(44, 2);
									defaultInterpolatedStringHandler2.AppendLiteral("[underline white]HTTP Proxy:[/] [yellow]");
									defaultInterpolatedStringHandler2.AppendFormatted(clientRelayPort.ServerDomain);
									defaultInterpolatedStringHandler2.AppendLiteral(":");
									defaultInterpolatedStringHandler2.AppendFormatted<int>(clientRelayPort.ServerListenerPort);
									defaultInterpolatedStringHandler2.AppendLiteral("[/]");
									AnsiConsole.MarkupLine(defaultInterpolatedStringHandler2.ToStringAndClear());
								}
								if (clientRelayPort.ProtocolType.ToLower().Equals("proxysocks"))
								{
									defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(45, 2);
									defaultInterpolatedStringHandler2.AppendLiteral("[underline white]Socks Proxy:[/] [yellow]");
									defaultInterpolatedStringHandler2.AppendFormatted(clientRelayPort.ServerDomain);
									defaultInterpolatedStringHandler2.AppendLiteral(":");
									defaultInterpolatedStringHandler2.AppendFormatted<int>(clientRelayPort.ServerListenerPort);
									defaultInterpolatedStringHandler2.AppendLiteral("[/]");
									AnsiConsole.MarkupLine(defaultInterpolatedStringHandler2.ToStringAndClear());
								}
								if (clientRelayPort.ProtocolType.ToLower().Contains("clientrelay"))
								{
									if (clientRelayPort.ProtocolType.ToLower().Contains("udp"))
									{
										defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(54, 4);
										defaultInterpolatedStringHandler2.AppendLiteral("[underline white]UDP:[/] [yellow]");
										defaultInterpolatedStringHandler2.AppendFormatted(clientRelayPort.ServerDomain);
										defaultInterpolatedStringHandler2.AppendLiteral(":");
										defaultInterpolatedStringHandler2.AppendFormatted<int>(clientRelayPort.ServerListenerPort);
										defaultInterpolatedStringHandler2.AppendLiteral("[/] --->[green] ");
										defaultInterpolatedStringHandler2.AppendFormatted(clientRelayPort.LocalIp);
										defaultInterpolatedStringHandler2.AppendLiteral(":");
										defaultInterpolatedStringHandler2.AppendFormatted<int>(clientRelayPort.Port);
										defaultInterpolatedStringHandler2.AppendLiteral("[/]");
										AnsiConsole.MarkupLine(defaultInterpolatedStringHandler2.ToStringAndClear());
									}
									if (clientRelayPort.ProtocolType.ToLower().Contains("tcp"))
									{
										defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(54, 4);
										defaultInterpolatedStringHandler2.AppendLiteral("[underline white]TCP:[/] [yellow]");
										defaultInterpolatedStringHandler2.AppendFormatted(clientRelayPort.ServerDomain);
										defaultInterpolatedStringHandler2.AppendLiteral(":");
										defaultInterpolatedStringHandler2.AppendFormatted<int>(clientRelayPort.ServerListenerPort);
										defaultInterpolatedStringHandler2.AppendLiteral("[/] --->[green] ");
										defaultInterpolatedStringHandler2.AppendFormatted(clientRelayPort.LocalIp);
										defaultInterpolatedStringHandler2.AppendLiteral(":");
										defaultInterpolatedStringHandler2.AppendFormatted<int>(clientRelayPort.Port);
										defaultInterpolatedStringHandler2.AppendLiteral("[/]");
										AnsiConsole.MarkupLine(defaultInterpolatedStringHandler2.ToStringAndClear());
									}
									if (clientRelayPort.ProtocolType.ToLower().Contains("proxyhttp"))
									{
										defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(44, 2);
										defaultInterpolatedStringHandler2.AppendLiteral("[underline white]HTTP Proxy:[/] [yellow]");
										defaultInterpolatedStringHandler2.AppendFormatted(clientRelayPort.ServerDomain);
										defaultInterpolatedStringHandler2.AppendLiteral(":");
										defaultInterpolatedStringHandler2.AppendFormatted<int>(clientRelayPort.ServerListenerPort);
										defaultInterpolatedStringHandler2.AppendLiteral("[/]");
										AnsiConsole.MarkupLine(defaultInterpolatedStringHandler2.ToStringAndClear());
									}
									if (clientRelayPort.ProtocolType.ToLower().Contains("proxysocks"))
									{
										defaultInterpolatedStringHandler2 = new DefaultInterpolatedStringHandler(45, 2);
										defaultInterpolatedStringHandler2.AppendLiteral("[underline white]Socks Proxy:[/] [yellow]");
										defaultInterpolatedStringHandler2.AppendFormatted(clientRelayPort.ServerDomain);
										defaultInterpolatedStringHandler2.AppendLiteral(":");
										defaultInterpolatedStringHandler2.AppendFormatted<int>(clientRelayPort.ServerListenerPort);
										defaultInterpolatedStringHandler2.AppendLiteral("[/]");
										AnsiConsole.MarkupLine(defaultInterpolatedStringHandler2.ToStringAndClear());
									}
								}
							});
						}
						Task.Run(action);
					}
				}).ConfigureAwait(false);
			}
			catch (Exception ex)
			{
				ILogger logger = ApplicationLogging.Logger;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(109, 2);
				defaultInterpolatedStringHandler.AppendLiteral("CLIENT ERROR => AuthToken : ");
				defaultInterpolatedStringHandler.AppendFormatted(ApplicationSettings.Default.AuthToken);
				defaultInterpolatedStringHandler.AppendLiteral(" | Exception : ");
				defaultInterpolatedStringHandler.AppendFormatted<Exception>(ex);
				defaultInterpolatedStringHandler.AppendLiteral(" | Destination : ExposeLocalhostNet -> SignalRClient -> StartRelay");
				logger.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00006DB8 File Offset: 0x00004FB8
		public Task AddAccessControlList(Guid userRelayGuidId, bool isAllowed, List<string> accessControlList)
		{
			SignalRClient.<AddAccessControlList>d__23 <AddAccessControlList>d__;
			<AddAccessControlList>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<AddAccessControlList>d__.userRelayGuidId = userRelayGuidId;
			<AddAccessControlList>d__.isAllowed = isAllowed;
			<AddAccessControlList>d__.accessControlList = accessControlList;
			<AddAccessControlList>d__.<>1__state = -1;
			<AddAccessControlList>d__.<>t__builder.Start<SignalRClient.<AddAccessControlList>d__23>(ref <AddAccessControlList>d__);
			return <AddAccessControlList>d__.<>t__builder.Task;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00006E0C File Offset: 0x0000500C
		public void DeleteAccessControlList(Guid userRelayGuidId)
		{
			List<IPNetwork2> list;
			SignalRClient.accessControlListDic.Remove(userRelayGuidId.ToString() + "-true", out list);
			SignalRClient.accessControlListDic.Remove(userRelayGuidId.ToString() + "-false", out list);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00006E61 File Offset: 0x00005061
		public void GetMyIp()
		{
			Task.Run(delegate()
			{
				SignalRClient.<>c.<<GetMyIp>b__25_0>d <<GetMyIp>b__25_0>d;
				<<GetMyIp>b__25_0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<GetMyIp>b__25_0>d.<>1__state = -1;
				<<GetMyIp>b__25_0>d.<>t__builder.Start<SignalRClient.<>c.<<GetMyIp>b__25_0>d>(ref <<GetMyIp>b__25_0>d);
				return <<GetMyIp>b__25_0>d.<>t__builder.Task;
			}).ConfigureAwait(false);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00006E8E File Offset: 0x0000508E
		public void StopRelay(string userRelayId, bool isProgramClosed = false)
		{
			Task.Run(delegate()
			{
				try
				{
					RelayClientServer.StopRelay(userRelayId, isProgramClosed);
					SignalRClient.status = false;
				}
				catch (Exception ex)
				{
					ILogger logger = ApplicationLogging.Logger;
					DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(108, 2);
					defaultInterpolatedStringHandler.AppendLiteral("CLIENT ERROR => AuthToken : ");
					defaultInterpolatedStringHandler.AppendFormatted(ApplicationSettings.Default.AuthToken);
					defaultInterpolatedStringHandler.AppendLiteral(" | Exception : ");
					defaultInterpolatedStringHandler.AppendFormatted<Exception>(ex);
					defaultInterpolatedStringHandler.AppendLiteral(" | Destination : ExposeLocalhostNet -> SignalRClient -> StopRelay");
					logger.Error(defaultInterpolatedStringHandler.ToStringAndClear());
				}
			});
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00006EB4 File Offset: 0x000050B4
		public Task UserInfo(UserInfo userInfo)
		{
			SignalRClient.<UserInfo>d__27 <UserInfo>d__;
			<UserInfo>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<UserInfo>d__.userInfo = userInfo;
			<UserInfo>d__.<>1__state = -1;
			<UserInfo>d__.<>t__builder.Start<SignalRClient.<UserInfo>d__27>(ref <UserInfo>d__);
			return <UserInfo>d__.<>t__builder.Task;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00006EF8 File Offset: 0x000050F8
		public Task UpdateProgram()
		{
			SignalRClient.<UpdateProgram>d__28 <UpdateProgram>d__;
			<UpdateProgram>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
			<UpdateProgram>d__.<>1__state = -1;
			<UpdateProgram>d__.<>t__builder.Start<SignalRClient.<UpdateProgram>d__28>(ref <UpdateProgram>d__);
			return <UpdateProgram>d__.<>t__builder.Task;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00006F34 File Offset: 0x00005134
		private string GetTempFileName()
		{
			return Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00006F5E File Offset: 0x0000515E
		public void HeartBeat()
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00006F60 File Offset: 0x00005160
		public void StartInceptorService(Guid userRelayId)
		{
			try
			{
				TcpLocalClientNew service;
				if (RelayClientServer.httpInceptorServices.TryGetValue(userRelayId, out service))
				{
					service.StartInceptor();
				}
			}
			catch (Exception ex)
			{
				ILogger logger = ApplicationLogging.Logger;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(119, 2);
				defaultInterpolatedStringHandler.AppendLiteral("CLIENT ERROR => AuthToken : ");
				defaultInterpolatedStringHandler.AppendFormatted(ApplicationSettings.Default.AuthToken);
				defaultInterpolatedStringHandler.AppendLiteral(" | Exception : ");
				defaultInterpolatedStringHandler.AppendFormatted<Exception>(ex);
				defaultInterpolatedStringHandler.AppendLiteral(" | Destination : ExposeLocalhostNet -> SignalRClient -> StartInceptorService");
				logger.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			}
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00006FF0 File Offset: 0x000051F0
		public void StopInceptorService(Guid userRelayId)
		{
			try
			{
				TcpLocalClientNew service;
				if (RelayClientServer.httpInceptorServices.TryGetValue(userRelayId, out service))
				{
					service.StopInceptor();
				}
			}
			catch (Exception ex)
			{
				ILogger logger = ApplicationLogging.Logger;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(118, 2);
				defaultInterpolatedStringHandler.AppendLiteral("CLIENT ERROR => AuthToken : ");
				defaultInterpolatedStringHandler.AppendFormatted(ApplicationSettings.Default.AuthToken);
				defaultInterpolatedStringHandler.AppendLiteral(" | Exception : ");
				defaultInterpolatedStringHandler.AppendFormatted<Exception>(ex);
				defaultInterpolatedStringHandler.AppendLiteral(" | Destination : ExposeLocalhostNet -> SignalRClient -> StopInceptorService");
				logger.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00007080 File Offset: 0x00005280
		public void ReplayRequest(ReplayRequestModel replayRequestModel)
		{
			SignalRClient.<ReplayRequest>d__33 <ReplayRequest>d__;
			<ReplayRequest>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			<ReplayRequest>d__.replayRequestModel = replayRequestModel;
			<ReplayRequest>d__.<>1__state = -1;
			<ReplayRequest>d__.<>t__builder.Start<SignalRClient.<ReplayRequest>d__33>(ref <ReplayRequest>d__);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000070B8 File Offset: 0x000052B8
		public void UpdateSettingFileServer(string settingFileServerJson, Guid userRelayGuidId)
		{
			try
			{
				SettingFileServer settingFileServer = JsonConvert.DeserializeObject<SettingFileServer>(settingFileServerJson);
				SimpleHttpServer fileServer;
				if (RelayClientServer.simpleHttpServers.TryGetValue(userRelayGuidId, out fileServer))
				{
					fileServer.UpdateSettingFileServer(settingFileServer);
				}
			}
			catch (Exception ex)
			{
				ILogger logger = ApplicationLogging.Logger;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(122, 2);
				defaultInterpolatedStringHandler.AppendLiteral("CLIENT ERROR => AuthToken : ");
				defaultInterpolatedStringHandler.AppendFormatted(ApplicationSettings.Default.AuthToken);
				defaultInterpolatedStringHandler.AppendLiteral(" | Exception : ");
				defaultInterpolatedStringHandler.AppendFormatted<Exception>(ex);
				defaultInterpolatedStringHandler.AppendLiteral(" | Destination : ExposeLocalhostNet -> SignalRClient -> UpdateSettingFileServer");
				logger.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00007150 File Offset: 0x00005350
		public void LoadBalance(string id, List<LoadBalance> loadBalances)
		{
			try
			{
				RelayClientServer.loadBalances.AddOrUpdate(id, loadBalances, (string key, List<LoadBalance> existingVal) => loadBalances);
			}
			catch (Exception ex)
			{
				ILogger logger = ApplicationLogging.Logger;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(110, 2);
				defaultInterpolatedStringHandler.AppendLiteral("CLIENT ERROR => AuthToken : ");
				defaultInterpolatedStringHandler.AppendFormatted(ApplicationSettings.Default.AuthToken);
				defaultInterpolatedStringHandler.AppendLiteral(" | Exception : ");
				defaultInterpolatedStringHandler.AppendFormatted<Exception>(ex);
				defaultInterpolatedStringHandler.AppendLiteral(" | Destination : ExposeLocalhostNet -> SignalRClient -> LoadBalance");
				logger.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000071F8 File Offset: 0x000053F8
		public void RemoveLoadBalance(string id)
		{
			try
			{
				List<LoadBalance> list;
				RelayClientServer.loadBalances.Remove(id, out list);
			}
			catch (Exception ex)
			{
				ILogger logger = ApplicationLogging.Logger;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(110, 2);
				defaultInterpolatedStringHandler.AppendLiteral("CLIENT ERROR => AuthToken : ");
				defaultInterpolatedStringHandler.AppendFormatted(ApplicationSettings.Default.AuthToken);
				defaultInterpolatedStringHandler.AppendLiteral(" | Exception : ");
				defaultInterpolatedStringHandler.AppendFormatted<Exception>(ex);
				defaultInterpolatedStringHandler.AppendLiteral(" | Destination : ExposeLocalhostNet -> SignalRClient -> LoadBalance");
				logger.Error(defaultInterpolatedStringHandler.ToStringAndClear());
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00007280 File Offset: 0x00005480
		private void CheckTunnelCount()
		{
			Task.Run(delegate()
			{
				SignalRClient.<>c.<<CheckTunnelCount>b__37_0>d <<CheckTunnelCount>b__37_0>d;
				<<CheckTunnelCount>b__37_0>d.<>t__builder = AsyncTaskMethodBuilder.Create();
				<<CheckTunnelCount>b__37_0>d.<>1__state = -1;
				<<CheckTunnelCount>b__37_0>d.<>t__builder.Start<SignalRClient.<>c.<<CheckTunnelCount>b__37_0>d>(ref <<CheckTunnelCount>b__37_0>d);
				return <<CheckTunnelCount>b__37_0>d.<>t__builder.Task;
			});
		}

		// Token: 0x0400001E RID: 30
		public static HubConnection connection;

		// Token: 0x0400001F RID: 31
		public static bool status = true;

		// Token: 0x04000020 RID: 32
		public static string authTokenStatic;

		// Token: 0x04000021 RID: 33
		public static string version;

		// Token: 0x04000022 RID: 34
		public static int count = 0;

		// Token: 0x04000023 RID: 35
		public static SessionStatus sessionStatus = new SessionStatus();

		// Token: 0x04000024 RID: 36
		public int width;

		// Token: 0x04000025 RID: 37
		public int height;

		// Token: 0x04000026 RID: 38
		public static bool needUpdate = false;

		// Token: 0x04000027 RID: 39
		private Table table;

		// Token: 0x04000028 RID: 40
		public static bool isCanAirplaneMode = false;

		// Token: 0x04000029 RID: 41
		public static bool isNotRunningNewVersion = true;

		// Token: 0x0400002A RID: 42
		public static List<Guid> tunnelCount = new List<Guid>();

		// Token: 0x0400002B RID: 43
		public static string ipAddress = string.Empty;

		// Token: 0x0400002C RID: 44
		public static UserInfo userInfoStatic;

		// Token: 0x0400002D RID: 45
		public static ConcurrentQueue<RequestLog> requestLogs = new ConcurrentQueue<RequestLog>();

		// Token: 0x0400002E RID: 46
		public static ConcurrentDictionary<Guid, ConcurrentDictionary<Guid, RequestModel>> requestDic = new ConcurrentDictionary<Guid, ConcurrentDictionary<Guid, RequestModel>>();

		// Token: 0x0400002F RID: 47
		public static ConcurrentDictionary<string, List<IPNetwork2>> accessControlListDic = new ConcurrentDictionary<string, List<IPNetwork2>>();
	}
}
