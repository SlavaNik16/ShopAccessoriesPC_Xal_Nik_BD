using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAccessoriesPC
{
    public class NugetsPerevod<T> where T : class
    {  
        public string Perevod(object val, Enum en, params string[] rus)
        {
            Type type = en.GetType();

            var i = 0;
            foreach (var c in Enum.GetValues(type))
            {
                if (val.Equals(c))
                {
                    try
                    {
                        return rus[i];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        return "Неизвестно";
                    }
                }
                i++;
            }
            return "Неизвестно";
        }

    }
}
