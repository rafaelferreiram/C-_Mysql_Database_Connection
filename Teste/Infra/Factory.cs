using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste.Infra
{
    public static class Factory
    {
        public static MySqlConnection getConnection()
        {
            string strConexao = ConfigurationManager.ConnectionStrings["projetoBanco"].ConnectionString;
            MySqlConnection cnn = new MySqlConnection(strConexao);
            cnn.Open();

            return cnn;

        }
    }
}
