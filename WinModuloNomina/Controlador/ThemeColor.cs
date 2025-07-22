using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinNominaPisip
{

    public static class ThemeColor
    {
        public static Color PrimaryColor { get; set; }
        public static Color SecondaryColor { get; set; }
        public static List<string> ColorList = new List<string>
        {
            // 🔵 Azules tecnológicos
             "#607D8B", // Gris azulado intermedio
             "#37474F", // Gris carbón
             "#455A64", // Azul gris oscuro
             "#2E3A59", // Gris azulado para texto principal
             "#1565C0", // Azul oscuro profesional
             "#3949AB", // Indigo moderno
             ///
             "#2ECC71", // Verde esmeralda elegante
             "#00B894", // Verde menta moderno
             "#00897B", // Teal profundo
             "#16A085", // Verde marino tranquilo
             "#FF6F61", // Coral suave
             "#EF5350"  // Rojo intenso suave
        };

        public static Color ChangeColorBrightness(Color color2, double correctionFactor)
        {
            double red = color2.R;
            double green = color2.G;
            double blue = color2.B;
            //If correction factor is less than 0, darken color.
            if (correctionFactor < 0)
            {
                correctionFactor = 1 + correctionFactor;
                red *= correctionFactor;
                green *= correctionFactor;
                blue *= correctionFactor;
            }
            //If correction factor is greater than zero, lighten color.
            else
            {
                red = (255 - red) * correctionFactor + red;
                green = (255 - green) * correctionFactor + green;
                blue = (255 - blue) * correctionFactor + blue;
            }
            return Color.FromArgb(color2.A, (byte)red, (byte)green, (byte)blue);
        }

    }
}     
