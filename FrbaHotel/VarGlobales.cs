using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace FrbaHotel
{
    class VarGlobales
    {

        internal static DateTime getDate()
        {
            try
            {
                return Convert.ToDateTime(ConfigurationManager.AppSettings["current_date"]);
            }
            catch 
            {
                return DateTime.Now;          
            }
            
        }
    }
}
