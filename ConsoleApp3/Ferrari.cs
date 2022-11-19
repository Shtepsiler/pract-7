using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Ferrari : Brake, Gas
    {
        static string car = "488-Spider";
        public string Name { get; set; }
        public string PrintBrakeMassage()
        {
            return "Brakes!";
        }
        public string PrintGasMassage()
        {
            return "Zadu6avam sA!";
        }

   
        public string Masage()
        {
        StringBuilder Masage = new StringBuilder($"{car}");
            Masage.Append("/");
            Masage.Append($"{PrintBrakeMassage()}");
            Masage.Append("/");
            Masage.Append($"{PrintGasMassage()}");
            Masage.Append("/");
            Masage.Append($"{Name}");


            return Masage.ToString();

    }
        
    }
}
