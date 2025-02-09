using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReservasHotel.RegrasDeNegocio;

namespace ReservasHotel.Formularios
{
    public partial class FormNovaReserva : Form
    {
        static int numeroPedido = 1;
        static int id = 0;

        public static List<Reserva> listaReservas = new List<Reserva>();
        public FormNovaReserva()
        {
            InitializeComponent();
            txtID.Text = numeroPedido.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tpQuarto = 0;
            tpQuarto = Convert.ToInt32(cbTipoQuarto.SelectedIndex);

        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Reserva reserva = new Reserva();
            id++;
            reserva._id = id;
            reserva._nome = txtNome.Text;
            reserva._cpf = txtCPF.Text;
            reserva._email = txtEmail.Text;
            reserva._telefone = txtTelefone.Text;
            reserva._dtCheckin = txtDtChekin.Text;
            reserva._dtCheckout = txtDtCheckout.Text;
            reserva._hospedes = txtHospedes.Text;
            reserva._prefQuarto = txtPrefQuarto.Text;
            reserva._tpQuarto = Convert.ToString(cbTipoQuarto.SelectedIndex);
            reserva._FormaPag = Convert.ToString(cbFormaPagamento.SelectedIndex);
            listaReservas.Add(reserva);
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
