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

        public static Boolean esDigito(String e)
        {
 
                String cadena = e;
                if (e == "uno" || e == "UNO" || e == "Uno" || e == "UNo" || e == "uNo"
                    || e == "dos" || e == "DOS" || e == "Dos" || e == "DOs" || e == "dOs"
                    || e == "tres" || e =="treS" || e == "trES" || e== "tRES" || e=="TRES" || e == "tREs" || e=="TreS" || e == "TRes" || e == "Tres"
                    || e == "cuatro" || e == "CUATRO" || e == "Cuatro" || e == "cUATRO" || e == "cuatrO" || e == "CUATRo" || e == "CUatro" || e == "cuatRO" || e == "CUAtro" || e == "cuaTRO" || e == "CUATro" || e == "cuatRO" || e == "cuATro" || e == "CUatRO" || e == "cUATRo" || e == "CuatrO"
                    || e == "cinco" || e == "CINCO" || e == "Cinco" || e == "cINCO" || e == "cincO" || e == "CINCo" || e == "CInco" || e == "cinCO" || e == "CINco" || e == "ciNCO" || e == "CInCO" || e == "ciNco" || e == "CincO" || e == "cINCo"
                    || e == "seis" || e == "seiS" || e == "seIS" || e == "sEIS" || e == "SEIS" || e == "SEIs" || e == "SeiS" || e == "SEis" || e == "Seis"
                    || e == "siete" || e == "SIETE" || e == "Siete" || e == "sIETE" || e == "sietE" || e == "SIETe" || e == "SIete" || e == "sieTE" || e == "SIete" || e == "siETE" || e == "SIeTE" || e == "siEte" || e == "SietE" || e == "sIETe"
                    || e == "ocho" || e == "ochO" || e == "ocHO" || e == "oCHO" || e == "OCHO" || e == "OCHo" || e == "OchO" || e == "OCho" || e == "Ocho"
                    || e == "nueve" || e == "NUEVE" || e == "Nueve" || e == "nUEVE" || e == "nuevE" || e == "NUEVe" || e == "NUeve" || e == "nueVE" || e == "NUEve" || e == "nuEVE" || e == "NUeVE" || e == "nuEve" || e == "NuevE" || e == "nUEVe"
                    || e == "diez" || e == "dieZ" || e == "diEZ" || e == "dIEZ" || e == "DIEZ" || e == "DIEz" || e == "DieZ" || e == "diEZ" || e == "Diez"
                    )
                {
                return true;
            }else
                return false;
           
        }
    }
}
