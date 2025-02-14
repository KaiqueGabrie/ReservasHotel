using ReservasHotel.Formularios;

namespace ReservasHotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btNovaReserva_Click(object sender, EventArgs e)
        {
            FormNovaReserva form = new FormNovaReserva();
            form.ShowDialog();
        }

        private void btListarReservas_Click(object sender, EventArgs e)
        {
            FormListarReserva form = new FormListarReserva();
            form.ShowDialog();
        }

        private void btEditarReserva_Click(object sender, EventArgs e)
        {
            FormEditarReserva form = new FormEditarReserva();
            form.ShowDialog();
        }

        private void btDeletarReserva_Click(object sender, EventArgs e)
        {
            FormDeletarReserva form = new FormDeletarReserva();
            form.ShowDialog();
        } 
    }
}
