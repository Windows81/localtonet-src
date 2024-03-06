using System;

namespace ExposeLocalhostNet.Models
{
	// Token: 0x0200001E RID: 30
	public class FileInfoDetail
	{
		// Token: 0x060000FB RID: 251 RVA: 0x0000D77F File Offset: 0x0000B97F
		public FileInfoDetail(string name, string path, long length, DateTime lastWriteTime, bool isFolder = false)
		{
			this.Name = name;
			this.Path = this.SetPath(isFolder, path, name);
			this.Length = this.DataLengthCalc(length);
			this.LastWriteTime = lastWriteTime;
			this.IsFolder = isFolder;
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000FC RID: 252 RVA: 0x0000D7BB File Offset: 0x0000B9BB
		// (set) Token: 0x060000FD RID: 253 RVA: 0x0000D7C3 File Offset: 0x0000B9C3
		public string Name { get; set; }

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000FE RID: 254 RVA: 0x0000D7CC File Offset: 0x0000B9CC
		// (set) Token: 0x060000FF RID: 255 RVA: 0x0000D7D4 File Offset: 0x0000B9D4
		public string Path { get; set; }

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000100 RID: 256 RVA: 0x0000D7DD File Offset: 0x0000B9DD
		// (set) Token: 0x06000101 RID: 257 RVA: 0x0000D7E5 File Offset: 0x0000B9E5
		public string Length { get; set; }

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000102 RID: 258 RVA: 0x0000D7EE File Offset: 0x0000B9EE
		// (set) Token: 0x06000103 RID: 259 RVA: 0x0000D7F6 File Offset: 0x0000B9F6
		public bool IsFolder { get; set; }

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000104 RID: 260 RVA: 0x0000D7FF File Offset: 0x0000B9FF
		// (set) Token: 0x06000105 RID: 261 RVA: 0x0000D807 File Offset: 0x0000BA07
		public DateTime LastWriteTime { get; set; }

		// Token: 0x06000106 RID: 262 RVA: 0x0000D810 File Offset: 0x0000BA10
		private string SetPath(bool isFolder, string lastPath, string name)
		{
			string path = ("/" + lastPath + "/" + name).Replace("//", "/");
			if (string.IsNullOrEmpty(lastPath))
			{
				if (isFolder)
				{
					path = name + "/";
				}
				else
				{
					path = (name ?? "");
				}
			}
			return path;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000D864 File Offset: 0x0000BA64
		private string DataLengthCalc(long length)
		{
			if (length <= 0L)
			{
				return string.Empty;
			}
			string[] names = new string[]
			{
				"Byte",
				"Kb",
				"Mb",
				"Gb",
				"Tb"
			};
			double sizeResult = (double)length * 1.0;
			int nameIndex = 0;
			while (sizeResult > 1024.0 && nameIndex < names.Length)
			{
				sizeResult /= 1024.0;
				nameIndex++;
			}
			return sizeResult.ToString("F2") + " " + names[nameIndex];
		}
	}
}
