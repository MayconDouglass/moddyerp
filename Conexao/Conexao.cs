using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Conexao
{
    class Conexao
    {
        //Configuração Base de Desenvolvimento Mysql
        static string server = "erpmoddy.mysql.uhserver.com";
        static string port = "3306";
        static string userName = "moddy";
        static string password = "159753m@";
        static string database = "erpmoddy";  // Banco de dados

        public static String ConBD
        {
            get
            {
                return String.Format("Server={0};Port={1};User={2};Password={3};Database={4};", server, port, userName, password, database);
            }
        }
    }
}
