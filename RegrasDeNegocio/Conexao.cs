using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ReservasHotel.RegrasDeNegocio
{
    public class Conexao
    {
        static MySqlConnection conexao; //Objeto resposável por controlar a conexão com a base
        public static MySqlConnection Conectar()
        {
            try
            {
                /*
                  Configuração da conexão com o banco de dados:
                        - Sserver irá definir o servidor que está o banco de dados
                        - uid irá definir o nome do usuario do banco de dados
                        - pwd irá definir a senha do usuário no SGBD
                        - database irá definir o nome da base de dados
                */
                string strconexao = "server=localhost;uid=root;pwd=root;database=ReservasHotel";
                conexao = new MySqlConnection(strconexao);
                conexao.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao realizar a conexão com o banco de dados!");
            }
            return conexao;
        }
        public static void FecharConexao()
        {
            conexao.Close();
        }

        
    }
}
