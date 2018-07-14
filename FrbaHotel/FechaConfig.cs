using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Globalization;

namespace FrbaHotel
{
    class FechaConfig
    {

        internal static DateTime getDate()
        {
            try
            {
                CultureInfo ci = new CultureInfo("en-US");
                var formatosAdmitidos = new[] { "M-d-yyyy", "dd-MM-yyyy", "MM-dd-yyyy", "M.d.yyyy", "dd.MM.yyyy", "MM.dd.yyyy", "yyyy/MM/dd", "dd/MM/yyyy", "yyyy-MM-dd" }.Union(ci.DateTimeFormat.GetAllDateTimePatterns()).ToArray();
                DateTime fechaConfig = DateTime.ParseExact(ConfigurationManager.AppSettings["current_date"].ToString(), formatosAdmitidos, ci, DateTimeStyles.AssumeLocal);
                return fechaConfig;
            }
            catch 
            {
                return DateTime.Now;          
            }
            
        }

        internal static bool validarEmail(string email)
        {
            try
            {
                new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }
    }
}
