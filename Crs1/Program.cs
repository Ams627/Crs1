using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Crs1
{
    internal class Program
    {
        static int GetCRSAsInt(string crs)
        {
            int result = -1;
            return result;
        }
        private static void Main(string[] args)
        {
            try
            {
                var crs = new CRS2("CON");
                var abc = crs.GetCRS();
                Console.WriteLine();
            }
            catch (Exception ex)
            {
                var codeBase = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
                var progname = Path.GetFileNameWithoutExtension(codeBase);
                Console.Error.WriteLine(progname + ": Error: " + ex.Message);
            }

        }
    }
}
