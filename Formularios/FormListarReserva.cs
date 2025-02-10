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
            ReservasDAO listReservas = new ReservasDAO();
            
            dgvListaReservas.DataSource = listReservas.List();
        }
    }
}
