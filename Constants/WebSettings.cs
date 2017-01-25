using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Constants
{
    public class WebSettings
    {
        public static string FILE_REPO()
        {
            return "";
            //return ConfigurationManager.AppSettings["FILE_REPO"];
        }
    }
}
