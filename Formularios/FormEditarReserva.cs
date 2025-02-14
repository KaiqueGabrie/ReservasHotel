using ReservasHotel.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReservasHotel.Models;
using MySqlX.XDevAPI.Common;

namespace ReservasHotel.Formularios
{
    public partial class FormEditarReserva : Form
    {
        public FormEditarReserva()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Reserva reserva = new Reserva();
            reserva._id = int.Parse(txtID.Text);
            ReservasDAO reservasDAO = new ReservasDAO();
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
            reservasDAO.Update(reserva);
            MessageBox.Show("Atualizado com sucesso!", "Título", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtNome.Clear();
            txtCPF.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtDtChekin.Clear();
            txtDtCheckout.Clear();
            txtHospedes.Clear();
            txtPrefQuarto.Clear();
            cbTipoQuarto.SelectedIndex = -1;
            cbFormaPagamento.SelectedIndex = -1;
            txtID.Clear();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
