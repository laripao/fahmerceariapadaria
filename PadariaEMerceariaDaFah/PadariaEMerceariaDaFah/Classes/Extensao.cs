using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    }
}
