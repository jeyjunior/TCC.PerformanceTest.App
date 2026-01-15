using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Extension
{
    public static class ExtensionString
    {
        public static bool ToBoolean(this string valor)
        {
            valor = valor.ToLower();

            if (valor == "true" || valor == "1") 
                return true;

            return false;
        }
    }
}
