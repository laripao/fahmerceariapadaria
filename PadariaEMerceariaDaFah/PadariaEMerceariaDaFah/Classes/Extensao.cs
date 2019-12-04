using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PadariaEMerceariaDaFah.Classes
{
    public static class Extensao
    {
        public static string FormatToDB(this string data)
        {
            var result = data.Replace($"'", "")
                                .Replace($"\"", "")
                                .Replace($"/", "")
                                .Replace($"\\", "");
            return result;
        }

        public static string Agregacao(this string data)
        {
            string result = "";

            switch (data)
            {
                case "Maior":
                    result = "MAX";
                    break;
                case "Menor":
                    result = "MIN";
                    break;
                case "Média":
                    result = "AVG";
                    break;
                case "Contar":
                    result = "Count";
                    break;
                case "Somar":
                    result = "SUM";
                    break;
            }

            return result;
        }

    }
}
