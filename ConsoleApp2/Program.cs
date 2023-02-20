using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VIN_LIB.Class1 class1 = new VIN_LIB.Class1();
            Console.WriteLine(class1.CheckVIN("FFFFM55557C404453"));
            Console.WriteLine(class1.GetVINCountry("JHMCM56557C404453"));
            Console.ReadKey();
        }
    }
}
