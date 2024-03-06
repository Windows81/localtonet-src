using System;
using System.IO;
using System.Net;

namespace ExposeLocalhostNet.Views
{
	// Token: 0x02000019 RID: 25
	public abstract class FileServerIndexBase
	{
		// Token: 0x06000091 RID: 145 RVA: 0x0000D044 File Offset: 0x0000B244
		public string GenerateString()
		{
			string result;
			using (StringWriter stringWriter = new StringWriter())
			{
				this.Generate(stringWriter);
				result = stringWriter.ToString();
			}
			return result;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000D084 File Offset: 0x0000B284
		public void Generate(TextWriter writer)
		{
			this.__razor_writer = writer;
			this.Execute();
			this.__razor_writer = null;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000D09A File Offset: 0x0000B29A
		protected void WriteLiteral(string value)
		{
			this.__razor_writer.Write(value);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000D0A8 File Offset: 0x0000B2A8
		protected static void WriteLiteralTo(TextWriter writer, string value)
		{
			writer.Write(value);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000D0B1 File Offset: 0x0000B2B1
		protected void Write(object value)
		{
			FileServerIndexBase.WriteTo(this.__razor_writer, value);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000D0C0 File Offset: 0x0000B2C0
		protected static void WriteTo(TextWriter writer, object value)
		{
			if (value == null)
			{
				return;
			}
			Action<TextWriter> action = value as Action<TextWriter>;
			if (action != null)
			{
				action(writer);
				return;
			}
			writer.Write(WebUtility.HtmlEncode(value.ToString()));
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000D0F4 File Offset: 0x0000B2F4
		protected void WriteAttribute(string name, string prefix, string suffix, params Tuple<string, object, bool>[] values)
		{
			FileServerIndexBase.WriteAttributeTo(this.__razor_writer, name, prefix, suffix, values);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000D108 File Offset: 0x0000B308
		protected static void WriteAttributeTo(TextWriter writer, string name, string prefix, string suffix, params Tuple<string, object, bool>[] values)
		{
			if (values.Length == 0)
			{
				writer.Write(prefix);
				writer.Write(suffix);
				return;
			}
			bool flag = true;
			bool flag2 = false;
			foreach (Tuple<string, object, bool> tuple in values)
			{
				string item = tuple.Item1;
				object item2 = tuple.Item2;
				bool item3 = tuple.Item3;
				if (item2 != null)
				{
					bool? flag3 = item2 as bool?;
					bool? flag4 = flag3;
					bool flag5 = true;
					string text;
					if (flag4.GetValueOrDefault() == flag5 & flag4 != null)
					{
						text = name;
					}
					else
					{
						flag4 = flag3;
						flag5 = false;
						if (flag4.GetValueOrDefault() == flag5 & flag4 != null)
						{
							goto IL_CD;
						}
						text = (item2 as string);
					}
					if (flag)
					{
						writer.Write(prefix);
						flag = false;
					}
					else
					{
						writer.Write(item);
					}
					if (item3)
					{
						writer.Write(text ?? item2);
					}
					else
					{
						FileServerIndexBase.WriteTo(writer, text ?? item2);
					}
					flag2 = true;
				}
				IL_CD:;
			}
			if (flag2)
			{
				writer.Write(suffix);
			}
		}

		// Token: 0x06000099 RID: 153
		public abstract void Execute();

		// Token: 0x04000078 RID: 120
		private TextWriter __razor_writer;
	}
}
