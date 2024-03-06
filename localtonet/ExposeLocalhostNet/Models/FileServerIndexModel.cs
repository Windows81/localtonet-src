using System;
using System.Collections.Generic;

namespace ExposeLocalhostNet.Models
{
	// Token: 0x0200001D RID: 29
	public class FileServerIndexModel
	{
		// Token: 0x060000D9 RID: 217 RVA: 0x0000D59F File Offset: 0x0000B79F
		public FileServerIndexModel()
		{
			this.FileInfoDetailList = new List<FileInfoDetail>();
			this.PathDic = new List<Tuple<string, string>>();
			this.FolderPathList = new List<Tuple<string, string>>();
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000DA RID: 218 RVA: 0x0000D5C8 File Offset: 0x0000B7C8
		// (set) Token: 0x060000DB RID: 219 RVA: 0x0000D5D0 File Offset: 0x0000B7D0
		public string Title { get; set; }

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000DC RID: 220 RVA: 0x0000D5D9 File Offset: 0x0000B7D9
		// (set) Token: 0x060000DD RID: 221 RVA: 0x0000D5E1 File Offset: 0x0000B7E1
		public string UserName { get; set; }

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000DE RID: 222 RVA: 0x0000D5EA File Offset: 0x0000B7EA
		// (set) Token: 0x060000DF RID: 223 RVA: 0x0000D5F2 File Offset: 0x0000B7F2
		public string FaviconPath { get; set; }

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x0000D5FB File Offset: 0x0000B7FB
		// (set) Token: 0x060000E1 RID: 225 RVA: 0x0000D603 File Offset: 0x0000B803
		public string LogoFile { get; set; }

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x0000D60C File Offset: 0x0000B80C
		// (set) Token: 0x060000E3 RID: 227 RVA: 0x0000D614 File Offset: 0x0000B814
		public string WrongPasswordMessage { get; set; }

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x0000D61D File Offset: 0x0000B81D
		// (set) Token: 0x060000E5 RID: 229 RVA: 0x0000D625 File Offset: 0x0000B825
		public List<Tuple<string, string>> PathDic { get; set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x0000D62E File Offset: 0x0000B82E
		// (set) Token: 0x060000E7 RID: 231 RVA: 0x0000D636 File Offset: 0x0000B836
		public List<FileInfoDetail> FileInfoDetailList { get; set; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x0000D63F File Offset: 0x0000B83F
		// (set) Token: 0x060000E9 RID: 233 RVA: 0x0000D647 File Offset: 0x0000B847
		public List<Tuple<string, string>> FolderPathList { get; set; }

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000EA RID: 234 RVA: 0x0000D650 File Offset: 0x0000B850
		// (set) Token: 0x060000EB RID: 235 RVA: 0x0000D658 File Offset: 0x0000B858
		public bool IsAuth { get; set; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000EC RID: 236 RVA: 0x0000D661 File Offset: 0x0000B861
		// (set) Token: 0x060000ED RID: 237 RVA: 0x0000D669 File Offset: 0x0000B869
		public bool CanCreateNewFolder { get; set; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000EE RID: 238 RVA: 0x0000D672 File Offset: 0x0000B872
		// (set) Token: 0x060000EF RID: 239 RVA: 0x0000D67A File Offset: 0x0000B87A
		public bool CanUploadFile { get; set; }

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x0000D683 File Offset: 0x0000B883
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x0000D68B File Offset: 0x0000B88B
		public bool CanMoveToFolder { get; set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x0000D694 File Offset: 0x0000B894
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x0000D69C File Offset: 0x0000B89C
		public bool CanRename { get; set; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x0000D6A5 File Offset: 0x0000B8A5
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x0000D6AD File Offset: 0x0000B8AD
		public bool CanDelete { get; set; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x0000D6B6 File Offset: 0x0000B8B6
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x0000D6BE File Offset: 0x0000B8BE
		public bool HaveUserPermissions { get; set; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x0000D6C7 File Offset: 0x0000B8C7
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x0000D6CF File Offset: 0x0000B8CF
		public bool CanEveryoneReadAccess { get; set; }

		// Token: 0x060000FA RID: 250 RVA: 0x0000D6D8 File Offset: 0x0000B8D8
		public void SetPathDic(string lastPath)
		{
			string[] lastPathList = lastPath.Split('/', StringSplitOptions.None);
			List<Tuple<string, string>> pathDic = new List<Tuple<string, string>>();
			pathDic.Add(Tuple.Create<string, string>("", "Home"));
			for (int i = 0; i < lastPathList.Length; i++)
			{
				if (!string.IsNullOrEmpty(lastPathList[i]))
				{
					if (i > 0)
					{
						string totalPath = string.Empty;
						for (int j = 0; j <= i; j++)
						{
							totalPath = totalPath + "/" + lastPathList[j];
						}
						pathDic.Add(Tuple.Create<string, string>(totalPath, lastPathList[i]));
					}
					else
					{
						pathDic.Add(Tuple.Create<string, string>("/" + lastPathList[i], lastPathList[i]));
					}
				}
			}
			this.PathDic = pathDic;
		}
	}
}
