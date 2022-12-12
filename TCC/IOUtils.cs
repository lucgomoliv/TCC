using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCC
{
	internal static class IOUtils
	{
		public static string LerArquivo(string path)
		{
			if(File.Exists(path))
				return File.ReadAllText(path);
			
			return string.Empty;
		}

		public static void SalvarArquivo(string path, string conteudo)
		{
			File.WriteAllText(path, conteudo, Encoding.Latin1);
		}
	}
}
