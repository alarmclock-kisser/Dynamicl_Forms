using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // Notwendig für Control und Form

namespace MKLAudio
{
	public static class DarkModeToggle
	{
		public static readonly Dictionary<Type, Color> LightPalette = new()
					{
						{ typeof(Form), Color.FromArgb(240, 240, 240) },
						{ typeof(Panel), Color.FromArgb(240, 240, 240) },
						{ typeof(GroupBox), Color.FromArgb(240, 240, 240) },
						{ typeof(Button), Color.FromArgb(225, 225, 225) },
						{ typeof(Label), Color.FromArgb(0, 0, 0) }, // Schwarzer Text  
						{ typeof(TextBox), Color.FromArgb(255, 255, 255) },
						{ typeof(ComboBox), Color.FromArgb(255, 255, 255) },
						{ typeof(ListBox), Color.FromArgb(255, 255, 255) },
						{ typeof(CheckBox), Color.FromArgb(0, 0, 0) }, // Schwarzer Text  
						{ typeof(RadioButton), Color.FromArgb(0, 0, 0) }, // Schwarzer Text  
						{ typeof(NumericUpDown), Color.FromArgb(255, 255, 255) },
						{ typeof(VScrollBar), Color.FromArgb(200, 200, 200) }, // Scrollbar Hintergrund  
						{ typeof(HScrollBar), Color.FromArgb(200, 200, 200) },
						{ typeof(PictureBox), Color.FromArgb(230, 230, 230) },
						{ typeof(ProgressBar), Color.FromArgb(200, 200, 200) },
						{ typeof(string), Color.Black }
					};

		public static readonly Dictionary<Type, Color> DarkPalette = new()
					{
						{ typeof(Form), Color.FromArgb(45, 45, 48) },
						{ typeof(Panel), Color.FromArgb(45, 45, 48) },
						{ typeof(GroupBox), Color.FromArgb(45, 45, 48) },
						{ typeof(Button), Color.FromArgb(70, 70, 70) },
						{ typeof(Label), Color.FromArgb(240, 240, 240) }, // Heller Text  
						{ typeof(TextBox), Color.FromArgb(60, 60, 60) },
						{ typeof(ComboBox), Color.FromArgb(60, 60, 60) },
						{ typeof(ListBox), Color.FromArgb(60, 60, 60) },
						{ typeof(CheckBox), Color.FromArgb(240, 240, 240) }, // Heller Text  
						{ typeof(RadioButton), Color.FromArgb(240, 240, 240) }, // Heller Text  
						{ typeof(NumericUpDown), Color.FromArgb(60, 60, 60) },
						{ typeof(VScrollBar), Color.FromArgb(80, 80, 80) },
						{ typeof(HScrollBar), Color.FromArgb(80, 80, 80) },
						{ typeof(PictureBox), Color.FromArgb(55, 55, 58) },
						{ typeof(ProgressBar), Color.FromArgb(80, 80, 80) },
						{ typeof(string), Color.LightGray }
					};

		public static readonly Dictionary<Type, Color> OledPalette = new()
					{
						{ typeof(Form), Color.Black }, // PURE SCHWARZ  
						{ typeof(Panel), Color.Black },
						{ typeof(GroupBox), Color.Black },
						{ typeof(Button), Color.FromArgb(20, 20, 20) }, // Sehr dunkles Grau für Buttons  
						{ typeof(Label), Color.FromArgb(255, 255, 255) }, // Weißer Text  
						{ typeof(TextBox), Color.FromArgb(10, 10, 10) },
						{ typeof(ComboBox), Color.FromArgb(10, 10, 10) },
						{ typeof(ListBox), Color.FromArgb(10, 10, 10) },
						{ typeof(CheckBox), Color.FromArgb(255, 255, 255) }, // Weißer Text  
						{ typeof(RadioButton), Color.FromArgb(255, 255, 255) }, // Weißer Text  
						{ typeof(NumericUpDown), Color.FromArgb(10, 10, 10) },
						{ typeof(VScrollBar), Color.FromArgb(30, 30, 30) },
						{ typeof(HScrollBar), Color.FromArgb(30, 30, 30) },
						{ typeof(PictureBox), Color.FromArgb(5, 5, 5) },
						{ typeof(ProgressBar), Color.FromArgb(30, 30, 30) },
						{ typeof(string), Color.White }
					};

		public static readonly Dictionary<Type, Color> HighContrastLight = new()
					{
						{ typeof(Form), Color.White },
						{ typeof(Panel), Color.White },
						{ typeof(GroupBox), Color.White },
						{ typeof(Button), Color.FromArgb(240, 240, 240) }, // Fast weiß, klarer Rand  
						{ typeof(Label), Color.Black },
						{ typeof(TextBox), Color.White },
						{ typeof(ComboBox), Color.White },
						{ typeof(ListBox), Color.White },
						{ typeof(CheckBox), Color.Black },
						{ typeof(RadioButton), Color.Black },
						{ typeof(NumericUpDown), Color.White },
						{ typeof(VScrollBar), Color.LightGray },
						{ typeof(HScrollBar), Color.LightGray },
						{ typeof(PictureBox), Color.WhiteSmoke },
						{ typeof(ProgressBar), Color.LightGray },
						{ typeof(string), Color.Black }
					};

		public static readonly Dictionary<Type, Color> HighContrastDark = new()
					{
						{ typeof(Form), Color.Black },
						{ typeof(Panel), Color.Black },
						{ typeof(GroupBox), Color.Black },
						{ typeof(Button), Color.FromArgb(20, 20, 20) }, // Sehr dunkles Grau  
						{ typeof(Label), Color.Yellow }, // Kontrastreich gelber Text  
						{ typeof(TextBox), Color.Black },
						{ typeof(ComboBox), Color.Black },
						{ typeof(ListBox), Color.Black },
						{ typeof(CheckBox), Color.Yellow },
						{ typeof(RadioButton), Color.Yellow },
						{ typeof(NumericUpDown), Color.Black },
						{ typeof(VScrollBar), Color.FromArgb(40, 40, 40) },
						{ typeof(HScrollBar), Color.FromArgb(40, 40, 40) },
						{ typeof(PictureBox), Color.Black },
						{ typeof(ProgressBar), Color.FromArgb(40, 40, 40) },
						{ typeof(string), Color.Yellow }
					};

		public static readonly Dictionary<Type, Color> AquaTheme = new()
					{
						{ typeof(Form), Color.FromArgb(220, 240, 250) }, // Hellblau  
						{ typeof(Panel), Color.FromArgb(220, 240, 250) },
						{ typeof(GroupBox), Color.FromArgb(220, 240, 250) },
						{ typeof(Button), Color.FromArgb(170, 210, 230) }, // Mittleres Blau  
						{ typeof(Label), Color.FromArgb(20, 50, 70) }, // Dunkelblauer Text  
						{ typeof(TextBox), Color.FromArgb(250, 255, 255) },
						{ typeof(ComboBox), Color.FromArgb(250, 255, 255) },
						{ typeof(ListBox), Color.FromArgb(250, 255, 255) },
						{ typeof(CheckBox), Color.FromArgb(20, 50, 70) },
						{ typeof(RadioButton), Color.FromArgb(20, 50, 70) },
						{ typeof(NumericUpDown), Color.FromArgb(250, 255, 255) },
						{ typeof(VScrollBar), Color.FromArgb(180, 220, 240) },
						{ typeof(HScrollBar), Color.FromArgb(180, 220, 240) },
						{ typeof(PictureBox), Color.FromArgb(200, 230, 245) },
						{ typeof(ProgressBar), Color.FromArgb(180, 220, 240) },
						{ typeof(string), Color.Black }
					};

		public static readonly Dictionary<Type, Color> MagmaTheme = new()
					{
						{ typeof(Form), Color.FromArgb(30, 10, 0) }, // Sehr dunkles Braun-Rot  
						{ typeof(Panel), Color.FromArgb(30, 10, 0) },
						{ typeof(GroupBox), Color.FromArgb(30, 10, 0) },
						{ typeof(Button), Color.FromArgb(80, 20, 0) }, // Dunkles Rotbraun  
						{ typeof(Label), Color.FromArgb(255, 200, 150) }, // Helles Orange-Gelb  
						{ typeof(TextBox), Color.FromArgb(40, 15, 5) },
						{ typeof(ComboBox), Color.FromArgb(40, 15, 5) },
						{ typeof(ListBox), Color.FromArgb(40, 15, 5) },
						{ typeof(CheckBox), Color.FromArgb(255, 200, 150) },
						{ typeof(RadioButton), Color.FromArgb(255, 200, 150) },
						{ typeof(NumericUpDown), Color.FromArgb(40, 15, 5) },
						{ typeof(VScrollBar), Color.FromArgb(60, 25, 10) },
						{ typeof(HScrollBar), Color.FromArgb(60, 25, 10) },
						{ typeof(PictureBox), Color.FromArgb(20, 5, 0) },
						{ typeof(ProgressBar), Color.FromArgb(60, 25, 10) },
						{ typeof(string), Color.FromArgb(255, 200, 150) } // Helles Orange-Gelb für Text
					};

		public static readonly Dictionary<Type, Color> FloraTheme = new()
					{
						{ typeof(Form), Color.FromArgb(220, 240, 220) }, // Helles Grün  
						{ typeof(Panel), Color.FromArgb(220, 240, 220) },
						{ typeof(GroupBox), Color.FromArgb(220, 240, 220) },
						{ typeof(Button), Color.FromArgb(180, 220, 180) }, // Mittleres Grün  
						{ typeof(Label), Color.FromArgb(50, 80, 50) }, // Dunkles Grün für Text  
						{ typeof(TextBox), Color.FromArgb(245, 255, 245) },
						{ typeof(ComboBox), Color.FromArgb(245, 255, 245) },
						{ typeof(ListBox), Color.FromArgb(245, 255, 245) },
						{ typeof(CheckBox), Color.FromArgb(50, 80, 50) },
						{ typeof(RadioButton), Color.FromArgb(50, 80, 50) },
						{ typeof(NumericUpDown), Color.FromArgb(245, 255, 245) },
						{ typeof(VScrollBar), Color.FromArgb(190, 230, 190) },
						{ typeof(HScrollBar), Color.FromArgb(190, 230, 190) },
						{ typeof(PictureBox), Color.FromArgb(200, 230, 200) },
						{ typeof(ProgressBar), Color.FromArgb(190, 230, 190) },
						{ typeof(string), Color.FromArgb(50, 80, 50) } // Dunkles Grün für Text
					};

		public static readonly Dictionary<Type, Color> VisualStudioTheme = new()
					{
						{ typeof(Form), Color.FromArgb(30, 30, 30) }, // Dunkles Grau  
						{ typeof(Panel), Color.FromArgb(30, 30, 30) },
						{ typeof(GroupBox), Color.FromArgb(30, 30, 30) },
						{ typeof(Button), Color.FromArgb(50, 50, 50) },
						{ typeof(Label), Color.FromArgb(220, 220, 220) }, // Heller Text  
						{ typeof(TextBox), Color.FromArgb(40, 40, 40) },
						{ typeof(ComboBox), Color.FromArgb(40, 40, 40) },
						{ typeof(ListBox), Color.FromArgb(40, 40, 40) },
						{ typeof(CheckBox), Color.FromArgb(220, 220, 220) },
						{ typeof(RadioButton), Color.FromArgb(220, 220, 220) },
						{ typeof(NumericUpDown), Color.FromArgb(40, 40, 40) },
						{ typeof(VScrollBar), Color.FromArgb(60, 60, 60) },
						{ typeof(HScrollBar), Color.FromArgb(60, 60, 60) },
						{ typeof(PictureBox), Color.FromArgb(35, 35, 35) },
						{ typeof(ProgressBar), Color.FromArgb(60, 60, 60) },
						{ typeof(string), Color.LightGray } // Heller Text
					};


		public static Dictionary<string, Dictionary<Type, Color>> Themes = new()
		{
			{ "light", LightPalette },
			{ "dark", DarkPalette },
			{ "oled", OledPalette },
			{ "highContrastLight", HighContrastLight },
			{ "highContrastDark", HighContrastDark },
			{ "aqua", AquaTheme },
			{ "magma", MagmaTheme },
			{ "flora", FloraTheme },
			{ "visualStudio", VisualStudioTheme }
		};

		public static void ApplyTheme(Form form, string themeName = "light")
		{
			// Find palette dictionary based on theme name (contains string)
			if (!Themes.TryGetValue(themeName, out Dictionary<Type, Color>? paletteToApply))
			{
				Console.WriteLine("Invalid theme selected, defaulting to 'LightTheme'.");
				paletteToApply = LightPalette;
			}

			form.SuspendLayout();

			// Rekursively apply theme to all controls in the form
			ApplyThemeToControl(form, paletteToApply);

			form.ResumeLayout(true);
			form.Refresh();
		}

		// --- Rekursive Hilfsfunktion ---
		private static void ApplyThemeToControl(Control control, Dictionary<Type, Color> palette)
		{
			// Get back color by control type in palette and apply it
			if (palette.TryGetValue(control.GetType(), out Color backColor))
			{
				control.BackColor = backColor;
			}
			// Fallback for controls not explicitly listed, or for containers
			else if (palette.TryGetValue(typeof(Panel), out Color defaultBackColor))
			{
				control.BackColor = defaultBackColor;
			}


			// If control has text, apply color typeof(string) from palette
			if (palette.TryGetValue(typeof(string), out Color textColor))
			{
				control.ForeColor = textColor;
			}

			// Special handling for controls that are not directly 'text' controls but contain text, like buttons
			if (control is Button || control is CheckBox || control is RadioButton || control is GroupBox)
			{
				if (palette.TryGetValue(control.GetType(), out Color foreColorSpecific))
				{
					// If a specific ForeColor is defined for this control type, use it
					control.ForeColor = foreColorSpecific;
				}
				else if (palette.TryGetValue(typeof(string), out Color foreColorGeneric))
				{
					// Otherwise, use the generic text color
					control.ForeColor = foreColorGeneric;
				}
			}


			// Loop recursively through child controls
			foreach (Control childControl in control.Controls)
			{
				ApplyThemeToControl(childControl, palette);
			}
		}
	}
}