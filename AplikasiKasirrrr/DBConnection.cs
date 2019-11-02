using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikasiKasirrrr
{
    class DBConnection
    {
        public string MYConnection()
        {
            string con = @"Data Source=DESKTOP-F99RU1A\DIMASSQL;Initial Catalog=kasirrr;Integrated Security=True";
            return con;
        }
    }
}
