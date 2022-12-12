using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TCC
{
	internal static class StringUtils
	{
		public static string TextoEntre(this string str, string primeiro, string segundo)
		{
			int pos1 = str.IndexOf(primeiro) + primeiro.Length;
			return str[pos1..str.IndexOf(segundo)];
		}

		public static string TextoEntreParenteses(this string str)
		{
			return TextoEntre(str, "(", ")");
		}
	}
}
