using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReservasHotel.DAO;
using ReservasHotel.RegrasDeNegocio;

namespace ReservasHotel.Formularios
{
    public partial class FormNovaReserva : Form
    {
        public static List<Reserva> listaReservas = new List<Reserva>();
        static int id = 0;

        public FormNovaReserva()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tpQuarto = 0;
            tpQuarto = Convert.ToInt32(cbTipoQuarto.SelectedIndex);

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Reserva reserva = new Reserva();
                id++;
                reserva._id = id;
                reserva._nome = txtNome.Text;
                reserva._cpf = txtCPF.Text;
                reserva._email = txtEmail.Text;
                reserva._telefone = txtTelefone.Text;
                reserva._dtCheckin = DateOnly.Parse(txtDtChekin.Text);
                reserva._dtCheckout = DateOnly.Parse(txtDtCheckout.Text);
                reserva._hospedes = Convert.ToInt32(txtHospedes.Text);
                reserva._prefQuarto = txtPrefQuarto.Text;
                reserva._tpQuarto = Convert.ToString(cbTipoQuarto.SelectedIndex);
                reserva._FormaPag = Convert.ToString(cbFormaPagamento.SelectedIndex);
                listaReservas.Add(reserva);
                ReservasDAO dao = new ReservasDAO();
                dao.Insert(reserva);
                MessageBox.Show("Salvo com sucesso!", "Título", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro ao inserir os dados! {ex.Message}");
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
