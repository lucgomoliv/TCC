using System.Reflection;
using System.Text.RegularExpressions;

namespace TCC
{
	internal static class ComponenteUtils
	{
		public static void SetarPropriedade(this Componente componente, string propriedade, object valor)
		{
			PropertyInfo? prop = componente.GetType().GetProperty(propriedade, BindingFlags.Public | BindingFlags.Instance);
			if (null != prop && prop.CanWrite)
			{
				prop.SetValue(componente, valor, null);
			}
		}

		public static object PropriedadeParaValor(this string valor, string propriedade)
		{
			switch (propriedade)
			{
				case "Size":
					var splitSize = valor.TextoEntreParenteses().Split(',');
					return new Size(int.Parse(splitSize[0].Trim()), int.Parse(splitSize[1].Trim()));
				case "Location":
					var splitLoc = valor.TextoEntreParenteses().Split(',');
					return new Point(int.Parse(splitLoc[0].Trim()), int.Parse(splitLoc[1].Trim()));
				case "TabIndex":
					return int.Parse(valor);
				case "Text":
					return valor.Replace("\"", "");
				case "Checked":
					return bool.Parse(valor);
				case "Items":
					valor = valor.TextoEntre("{", "}").Replace("\"", "");
					return Regex.Split(valor.Trim(), "\\s*,\\s*");
				case "Controls":
					return valor.TextoEntreParenteses().Replace("this.", "");
				default:
					return "";
			}
		}

	}
}
