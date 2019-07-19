using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Unity3dScriptsProgramming.Nullable
{
    class Test
    {
        public static void Main()
        {
            string unitName = GetHeroName() ?? "123";
            Console.WriteLine(unitName);
        }

        public static string GetHeroName()
        {
            return null;
        }
    }
}