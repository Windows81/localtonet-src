using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace ExposeLocalhostNet
{
	// Token: 0x02000007 RID: 7
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.1.0.0")]
	public sealed partial class ApplicationSettings : ApplicationSettingsBase
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00002130 File Offset: 0x00000330
		public static ApplicationSettings Default
		{
			get
			{
				return ApplicationSettings.defaultInstance;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00002137 File Offset: 0x00000337
		// (set) Token: 0x0600000A RID: 10 RVA: 0x00002149 File Offset: 0x00000349
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string AuthToken
		{
			get
			{
				return (string)this["AuthToken"];
			}
			set
			{
				this["AuthToken"] = value;
			}
		}

		// Token: 0x04000005 RID: 5
		private static ApplicationSettings defaultInstance = (ApplicationSettings)SettingsBase.Synchronized(new ApplicationSettings());
	}
}
