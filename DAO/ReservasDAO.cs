using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using ReservasHotel.RegrasDeNegocio;

namespace ReservasHotel.DAO
{
    internal class ReservasDAO
    {
        public void Insert(Reserva reserva)
        {
            try
            {
                string dtCheckin = reserva._dtCheckin.ToString("yyyy-MM-dd");
                string dtCheckout = reserva._dtCheckout.ToString("yyyy-MM-dd");
                string sql = "INSERT INTO Reserva(nome, cpf, email, telefone, dtCheckin, dtCheckout, hospedes, prefQuarto, tpQuarto, formaPag) " + // Nome da tabela com nome das colunas igual do banco
                    "VALUES(@nome, @cpf, @email, @telefone, @dtcheckin, @dtcheckout, @hospedes, @prefquarto, @tpquarto, @formapag)"; // aqui os nomes iguais os que viram abaixo
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@nome", reserva._nome);    
                comando.Parameters.AddWithValue("@cpf", reserva._cpf);    
                comando.Parameters.AddWithValue("@email", reserva._email);    
                comando.Parameters.AddWithValue("@telefone", reserva._telefone);    
                comando.Parameters.AddWithValue("@dtcheckin", dtCheckin);    
                comando.Parameters.AddWithValue("@dtcheckout", dtCheckout);    
                comando.Parameters.AddWithValue("@hospedes", reserva._hospedes);
                comando.Parameters.AddWithValue("@prefquarto", reserva._prefQuarto);
                comando.Parameters.AddWithValue("@tpquarto", reserva._tpQuarto);
                comando.Parameters.AddWithValue("@formapag", reserva._FormaPag);
                comando.ExecuteNonQuery();
                Console.WriteLine("Reserva feita com sucesso!");
                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao cadastrar a reserva! {ex.Message}");
            }
        }
        public void Delete(Reserva reserva)
        {
            try
            {
                string sql = "DELETE FROM Reservas WHERE id = @id";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@id", reserva._id);
                comando.ExecuteNonQuery();
                Console.WriteLine("Reserva excluída com sucesso!");
                Conexao.FecharConexao();

            }
            catch(Exception ex)
            {
                throw new Exception($"Erro ao excluir a reserva {ex.Message}");
            }
        }
        public void Update(Reserva reserva)
        {
            try
            {
                string sql = "UPDATE Reservas SET nome = @nome, cpf = @cpf, email = @email, telefone = @telefone, dtCheckin = @dtcheckin, dtCheckout = @dtcheckout, hospedes = @hospedes, prefQuarto = @prefquarto, formaPag = @formapag WHERE id = @id";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@nome", reserva._nome);
                comando.Parameters.AddWithValue("@cpf", reserva._cpf);
                comando.Parameters.AddWithValue("@email", reserva._email);
                comando.Parameters.AddWithValue("@telefone", reserva._telefone);
                comando.Parameters.AddWithValue("@dtcheckin", reserva._dtCheckin);
                comando.Parameters.AddWithValue("@dtcheckout", reserva._dtCheckout);
                comando.Parameters.AddWithValue("@hospedes", reserva._hospedes);
                comando.Parameters.AddWithValue("@prefquarto", reserva._prefQuarto);
                comando.Parameters.AddWithValue("@tpquarto", reserva._tpQuarto);
                comando.Parameters.AddWithValue("@formapag", reserva._FormaPag);
                comando.Parameters.AddWithValue("@id", reserva._id);
                comando.ExecuteNonQuery();
                Console.WriteLine("Reserva atualizada com sucesso!");
                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao atualizar a reserva {ex.Message}");
            }
        }
        public List<Reserva> List()
        {
            List<Reserva> reservas = new List<Reserva>();
            try
            {
                var sql = "SELECT * FROM Reserva ORDERBY nome";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                using (MySqlDataReader dr = comando.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Reserva reserva = new Reserva();
                        reserva._id = dr.GetInt32("id");
                        reserva._nome = dr.GetString("nome");
                        reserva._cpf = dr.GetString("cpf");
                        reserva._email = dr.GetString("email");
                        reserva._telefone = dr.GetString("telefone");
                        reserva._dtCheckin = DateOnly.FromDateTime(dr.GetDateTime("dtCheckin"));
                        reserva._dtCheckout = DateOnly.FromDateTime(dr.GetDateTime("dtCheckout"));
                        reserva._hospedes = dr.GetInt32("hospedes");
                        reserva._prefQuarto = dr.GetString("prefQuarto");
                        reserva._tpQuarto = dr.GetString("tpQuarto");
                        reserva._FormaPag = dr.GetString("formaPag");
                        reservas.Add(reserva);
                    }
                }
                Conexao.FecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao listas os alunos! {ex.Message}");
            }
            return reservas;
        }
    }
}
