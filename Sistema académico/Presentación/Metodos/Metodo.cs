using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_académico.Presentación.Metodos
{
    class Metodo
    {

        public static String convertirMayuscula(String texto)
        {
            String nuevo_texto = "";
            nuevo_texto = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(texto);
            return nuevo_texto;
        }
    }
}
