namespace TCC
{
	internal class Componente
	{
		public string Name { get; set; } = string.Empty;
		public string Tipo { get; set; } = string.Empty;
		public Point Location { get; set; } = new Point();
		public Size Size { get; set; } = new Size();
		public int TabIndex { get; set; } = 0;
		public string Text { get; set; } = string.Empty;
		public bool Checked { get; set; } = false;
		public string[] Items { get; set; } = Array.Empty<string>();
		public Dictionary<string, string> Eventos { get; set; } = new Dictionary<string, string>();
		public List<Componente> Controls { get; set; } = new List<Componente>();
		public string Parent { get; set; } = string.Empty;
		public string TipoMigracao
		{
			get
			{
				return Tipo switch
				{
					"ComboBox" => "DropDownList",
					"Panel" => "div",
					"DataGridView" => "GridView",
					_ => Tipo
				};
			}
		}
	}
}
