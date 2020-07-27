using System;
using System.Collections.Generic;
using System.Text;

namespace Helpers
{
    public class StringHelper
    {
        //gereksinimler
        //1.Girilen ifadenin başındaki ve sonundaki fazla boşluklar silinmedlir.
        //2.Girilen ifadenin içindeki fazla boşluklar silinmelidir.
        public static string FazlaBoslukSil(string ifade)
        {
            ifade = ifade.Trim();
            string yeniIfade = string.Empty;
            for (int i = 0; i < ifade.Length; i++)
            {
                if (ifade[i] == ' ' && ifade[i + 1] == ' ')
                {
                    continue;
                }
                yeniIfade += ifade[i];
            }
            return yeniIfade;
        }
    }
}
