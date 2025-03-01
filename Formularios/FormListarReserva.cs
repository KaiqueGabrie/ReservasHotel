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

namespace ReservasHotel.Formularios
{
    public partial class FormListarReserva : Form
    {
        public FormListarReserva()
        {
            InitializeComponent();
            try
            {
                
                ReservasDAO listReservas = new ReservasDAO();
                dgvListaReservas.DataSource = listReservas.List();
                dgvListaReservas.ReadOnly = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao exibir lista de reservas!" + ex.Message);
            }
            
        }
    }
}
