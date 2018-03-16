using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Validar
    {
        public static Boolean esEntero (String e)
        {   
            try
            {
                int entero = Int32.Parse(e);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public static Boolean esDecimal(String e)
        {
            try
            {
                double dec = Double.Parse(e);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public static Boolean esEdad(String e)
        {
            try
            {
                int entero = Int32.Parse(e);
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
