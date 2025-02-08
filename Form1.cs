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
    }
}
