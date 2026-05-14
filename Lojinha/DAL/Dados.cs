using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lojinha.DAL
{
    public class Dados
    {
        public static string StringConexao
        {
            get
            {
                // return @"Data Source=PCAURORA;Initial Catalog=dblojinha;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";

                return "Server=PCAURORA;Database=dblojinha;Trusted_Connection=True;Encrypt=False;TrustServerCertificate=True";
            }
        }
    }
}




