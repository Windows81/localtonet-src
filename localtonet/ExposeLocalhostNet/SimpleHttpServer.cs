using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using ExposeLocalhostNet.Models;
using ExposeLocalhostNet.Models.FileServer;
using ExposeLocalhostNet.Views;

namespace ExposeLocalhostNet
{
	// Token: 0x0200000F RID: 15
	public class SimpleHttpServer
	{
		// Token: 0x06000051 RID: 81 RVA: 0x00007318 File Offset: 0x00005518
		public void StartHttpServerOnThread(string path, int port, ClientRelayPort clientRelayPort, CancellationToken cancellationToken)
		{
			if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
			{
				SimpleHttpServer.slash = "\\";
			}
			Task.Run(delegate()
			{
				this.Listen(path, port, clientRelayPort, cancellationToken);
			});
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00007378 File Offset: 0x00005578
		private void Listen(string path, int port, ClientRelayPort clientRelayPort, CancellationToken cancellationToken)
		{
			this._rootDirectory = path;
			clientRelayPort.BasicAuthentication = false;
			this._clientRelayPort = clientRelayPort;
			this.service = new FileServerService();
			HttpListener _listener = new HttpListener();
			try
			{
				_listener.Prefixes.Add("http://+:" + port.ToString() + "/");
				_listener.Start();
				goto IL_148;
			}
			catch (Exception)
			{
				_listener = new HttpListener();
				_listener.Prefixes.Add("http://127.0.0.1:" + port.ToString() + "/");
				_listener.Start();
				goto IL_148;
			}
			IL_85:
			try
			{
				HttpListenerContext context = _listener.GetContext();
				string empty = string.Empty;
				if (clientRelayPort.BasicAuthentication && context.User.Identity.IsAuthenticated)
				{
					HttpListenerBasicIdentity identity = (HttpListenerBasicIdentity)context.User.Identity;
					string name = identity.Name;
					if (identity.Name != clientRelayPort.BasicAuthenticationUsername || identity.Password != clientRelayPort.BasicAuthenticationPassword)
					{
						context.Response.StatusCode = 401;
						context.Response.Close();
						goto IL_148;
					}
				}
				Task.Run(delegate()
				{
					this.Process(context);
				});
			}
			catch (Exception)
			{
			}
			IL_148:
			if (cancellationToken.IsCancellationRequested)
			{
				_listener.Stop();
				return;
			}
			goto IL_85;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000074FC File Offset: 0x000056FC
		public void UpdateSettingFileServer(SettingFileServer settingFileServer)
		{
			this._settingFileServer = settingFileServer;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00007508 File Offset: 0x00005708
		private void Process(HttpListenerContext context)
		{
			if (context.Request.Url.AbsolutePath.Contains("TUrOF07TmAaVP7qPuALbUD1cSybdAUif"))
			{
				this.service.SaveFile(context.Request.ContentEncoding, context.Request.ContentType, context.Request.InputStream, this._rootDirectory, context.Request.QueryString["basePath"], context.Request.QueryString["fileName"]);
			}
			else if (context.Request.Url.AbsolutePath.Contains("KirOF07TmAaVP7qPuALbUD1cSybcAUi3"))
			{
				this.service.CreateNewFolder(this._rootDirectory, context.Request.QueryString["basePath"], context.Request.QueryString["newFolderName"]);
			}
			else if (context.Request.Url.AbsolutePath.Contains("PelOF07TmAaVP7qPuALbUD1cSybcTAe1"))
			{
				this.service.DeleteFile(this._rootDirectory, context.Request.QueryString["basePath"], context.Request.QueryString["name"]);
			}
			else
			{
				if (context.Request.Url.AbsolutePath.Contains("BUrOF07TASaVd7qPuALBXVhnsDdAUiCx"))
				{
					string isFolderText = context.Request.QueryString["isFolder"];
					string directoryName = context.Request.QueryString["fileName"];
					directoryName = directoryName.TrimStart('/').TrimEnd('/');
					string files = Path.Combine(this._rootDirectory, directoryName);
					try
					{
						bool isFolder;
						if (!string.IsNullOrEmpty(isFolderText) && bool.TryParse(isFolderText, out isFolder) && isFolder)
						{
							Guid guid = Guid.NewGuid();
							ZipFile.CreateFromDirectory(files, files + guid.ToString() + ".zip");
							this.service.DownloadFile(files + guid.ToString() + ".zip", context, directoryName + ".zip");
							File.Delete(files + guid.ToString() + ".zip");
						}
						else
						{
							this.service.DownloadFile(files, context, directoryName);
						}
						goto IL_AA9;
					}
					catch
					{
						goto IL_AA9;
					}
				}
				if (context.Request.Url.AbsolutePath.Contains("RenOF07TmAaVP7qPuALbUD1cSybame3"))
				{
					this.service.Rename(this._rootDirectory, context.Request.QueryString["basePath"], context.Request.QueryString["name"], context.Request.QueryString["newValue"]);
				}
				else if (context.Request.Url.AbsolutePath.Contains("MoveOF07TmAaVP7qToALbUD1cFolder7"))
				{
					this.service.MoveToFolder(this._rootDirectory, context.Request.QueryString["basePath"], context.Request.QueryString["name"], context.Request.QueryString["newValue"]);
				}
				else if (context.Request.Url.AbsolutePath.Contains("ShrOF07TmAaVP7qPuALblinkSybame3"))
				{
					string res = this.service.ShareLink(this._rootDirectory, context.Request.QueryString["basePath"], context.Request.QueryString["name"]);
					res = this._clientRelayPort.Https + "/ShDwOF07TmAaVP123jhabinkSybame3?gl=" + res;
					byte[] buf = Encoding.UTF8.GetBytes(res);
					context.Response.ContentLength64 = (long)buf.Length;
					context.Response.OutputStream.Write(buf, 0, buf.Length);
					context.Response.ContentType = "text/plain";
					context.Response.ContentEncoding = Encoding.UTF8;
					context.Response.StatusCode = 200;
				}
				else
				{
					if (context.Request.Url.AbsolutePath.Contains("ShDwOF07TmAaVP123jhabinkSybame3"))
					{
						try
						{
							string[] fullPathArray = this.service.Decrypt(context.Request.QueryString["gl"].Replace(" ", "+"), "LocOT3YUsAlhd7qPuAtoXVhnsDdNet7A0").Split("---", StringSplitOptions.None);
							Guid guid2 = Guid.NewGuid();
							DateTime expireDate;
							if (DateTime.TryParse(fullPathArray[0], out expireDate) && expireDate >= DateTime.UtcNow)
							{
								string fullPath = fullPathArray[1];
								FileAttributes attr = File.GetAttributes(fullPath ?? "");
								bool isFolder2 = attr.HasFlag(FileAttributes.Directory);
								try
								{
									if (isFolder2)
									{
										ZipFile.CreateFromDirectory(fullPath, fullPath + guid2.ToString() + ".zip");
										this.service.DownloadFile(fullPath + guid2.ToString() + ".zip", context, fullPathArray[2] + ".zip");
										File.Delete(fullPath + guid2.ToString() + ".zip");
									}
									else
									{
										this.service.DownloadFile(fullPath, context, fullPathArray[2]);
									}
									goto IL_554;
								}
								catch
								{
									goto IL_554;
								}
							}
							context.Response.StatusCode = 404;
							IL_554:
							goto IL_AA9;
						}
						catch
						{
							goto IL_AA9;
						}
					}
					if (context.Request.Url.AbsolutePath.Contains("LogOT3YUsadhd7qPuALBXVhnsDdAUinA0"))
					{
						try
						{
							string userName = context.Request.QueryString["userName"];
							string password = context.Request.QueryString["password"];
							UserRoleFileServer roleFileServer;
							if (this._settingFileServer.UserRoleFileServer.TryGetValue(userName, out roleFileServer) && roleFileServer != null && roleFileServer.Password.Equals(password))
							{
								DateTime expires = DateTime.UtcNow.AddYears(1);
								string token = this.service.Encrypt(password, "LocOT3YUsAlhd7qPuAtoXVhnsDdNet7A0");
								string u_name = this.service.Encrypt(userName, "LocOT3YUsAlhd7qPuAtoXVhnsDdNet7A0");
								Cookie cookie = new Cookie();
								cookie.Name = "auth";
								cookie.Value = u_name + "&token=" + token;
								cookie.Expires = expires;
								context.Response.AppendCookie(cookie);
							}
							else
							{
								context.Response.SetCookie(new Cookie("wrongPasswordMessage", "Invalid User Name or Password!"));
							}
							context.Response.Redirect("/");
							goto IL_AA9;
						}
						catch
						{
							goto IL_AA9;
						}
					}
					if (context.Request.Url.AbsolutePath.Contains("SignOT3YUsadhd7qPuALBinhnsDdAUint4"))
					{
						try
						{
							context.Response.SetCookie(new Cookie("s_in", "dhd7qPuALBinh"));
							FileServerIndexModel model = new FileServerIndexModel();
							FileServerIndex fileServerIndex = new FileServerIndex();
							model.IsAuth = false;
							model.CanEveryoneReadAccess = this._settingFileServer.CanEveryoneReadAccess;
							model.HaveUserPermissions = this._settingFileServer.UserRoleFileServer.Any<KeyValuePair<string, UserRoleFileServer>>();
							fileServerIndex.Model = model;
							string html = fileServerIndex.GenerateString();
							byte[] buf2 = Encoding.UTF8.GetBytes(html);
							context.Response.ContentLength64 = (long)buf2.Length;
							context.Response.OutputStream.Write(buf2, 0, buf2.Length);
							context.Response.ContentType = "text/html";
							context.Response.ContentEncoding = Encoding.UTF8;
							goto IL_AA9;
						}
						catch
						{
							goto IL_AA9;
						}
					}
					string filename = context.Request.Url.AbsolutePath;
					filename = filename.Substring(1);
					if (string.IsNullOrEmpty(filename))
					{
						foreach (string indexFile in this.DefaultDocuments)
						{
							if (File.Exists(Path.Combine(this._rootDirectory, indexFile)))
							{
								filename = indexFile;
								break;
							}
						}
					}
					filename = HttpUtility.UrlDecode(filename);
					filename = Path.Combine(this._rootDirectory, filename);
					if (File.Exists(filename) && this.service.IsAuth(context, this._settingFileServer).IsAuth)
					{
						this.service.DownloadFile(filename, context, "");
					}
					else
					{
						try
						{
							FileServerIndexModel model2 = new FileServerIndexModel();
							string faviconFile = Path.Combine(this._rootDirectory, "favicon.ico");
							model2.FaviconPath = (File.Exists(faviconFile) ? "/favicon.ico" : "https://cdn.localtonet.com/fileserver/favicon.ico");
							string logoFile = Path.Combine(this._rootDirectory, "logo.png");
							model2.LogoFile = (File.Exists(logoFile) ? "/logo.png" : "https://cdn.localtonet.com/fileserver/favicon.ico");
							model2.CanEveryoneReadAccess = this._settingFileServer.CanEveryoneReadAccess;
							model2.HaveUserPermissions = this._settingFileServer.UserRoleFileServer.Any<KeyValuePair<string, UserRoleFileServer>>();
							FileServerIndex fileServerIndex2 = new FileServerIndex();
							IsAuthResponseModel isAuthRes = this.service.IsAuth(context, this._settingFileServer);
							if (isAuthRes.IsAuth)
							{
								DirectoryInfo d = new DirectoryInfo(Path.Combine(this._rootDirectory, filename));
								string lastPath = filename.Replace(this._rootDirectory, "").Replace(SimpleHttpServer.slash, "");
								model2.SetPathDic(lastPath);
								model2.FolderPathList.AddRange(this.service.GetDirectories(this._rootDirectory, "*", SearchOption.AllDirectories));
								model2.FileInfoDetailList.AddRange((from x in d.GetDirectories()
								select new FileInfoDetail(x.Name, lastPath, 0L, x.LastWriteTime, true)).ToList<FileInfoDetail>());
								model2.FileInfoDetailList.AddRange((from x in d.GetFiles()
								select new FileInfoDetail(x.Name, lastPath, x.Length, x.LastWriteTime, false)).ToList<FileInfoDetail>());
								model2.IsAuth = true;
								model2.Title = isAuthRes.Title;
								model2.UserName = isAuthRes.UserName;
								model2.CanCreateNewFolder = isAuthRes.CanCreateNewFolder;
								model2.CanUploadFile = isAuthRes.CanUploadFile;
								model2.CanRename = isAuthRes.CanRename;
								model2.CanMoveToFolder = isAuthRes.CanMoveToFolder;
								model2.CanDelete = isAuthRes.CanDelete;
							}
							else
							{
								FileServerIndexModel fileServerIndexModel = model2;
								Cookie cookie2 = context.Request.Cookies["wrongPasswordMessage"];
								fileServerIndexModel.WrongPasswordMessage = ((cookie2 != null) ? cookie2.Value : null);
							}
							fileServerIndex2.Model = model2;
							string html2 = fileServerIndex2.GenerateString();
							byte[] buf3 = Encoding.UTF8.GetBytes(html2);
							context.Response.ContentLength64 = (long)buf3.Length;
							context.Response.OutputStream.Write(buf3, 0, buf3.Length);
							context.Response.ContentType = "text/html";
							context.Response.ContentEncoding = Encoding.UTF8;
						}
						catch (Exception)
						{
							context.Response.StatusCode = 404;
						}
					}
				}
			}
			IL_AA9:
			context.Response.OutputStream.Close();
		}

		// Token: 0x04000030 RID: 48
		public static string slash = "/";

		// Token: 0x04000031 RID: 49
		private string[] DefaultDocuments = new string[]
		{
			"index.html",
			"index.htm",
			"default.html",
			"default.htm"
		};

		// Token: 0x04000032 RID: 50
		private SettingFileServer _settingFileServer = new SettingFileServer();

		// Token: 0x04000033 RID: 51
		private FileServerService service;

		// Token: 0x04000034 RID: 52
		private string _rootDirectory;

		// Token: 0x04000035 RID: 53
		private ClientRelayPort _clientRelayPort;
	}
}
