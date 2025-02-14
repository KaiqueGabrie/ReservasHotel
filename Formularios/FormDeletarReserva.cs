using ReservasHotel.DAO;
using ReservasHotel.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservasHotel.Formularios
{
    public partial class FormDeletarReserva : Form
    {
        public FormDeletarReserva()
        {
            InitializeComponent();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btDeletar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tem certeza que deseja deletar a reserva?", "DELETAR RESERVA!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                Reserva reserva = new Reserva();
                reserva._id = int.Parse(txtID.Text);
                ReservasDAO reservasDAO = new ReservasDAO();
                reservasDAO.Delete(reserva);
                MessageBox.Show("Deletado com sucesso!", "DELETAR RESERVA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Clear();
            }
            
        }
    }
}
