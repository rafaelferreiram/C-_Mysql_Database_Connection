using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teste.Infra;

namespace Teste
{
    class Program
    {
        static void Main(string[] args)
        {

            MySqlConnection cnn = Factory.getConnection();
            try
            {

                MySqlCommand comando = cnn.CreateCommand();
                comando.CommandText = "INSERT INTO databse values(, );";
                comando.ExecuteNonQuery();
                Console.WriteLine("Conexão feita e dado cadastrado com sucesso");
                Console.ReadLine();
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                       Console.WriteLine("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again");
                        break;
                }            
         }
      }
   }
}