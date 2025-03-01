using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReservasHotel.DAO;
using ReservasHotel.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                if (string.IsNullOrEmpty(txtNome.Text))
                {
                    MessageBox.Show("Erro: O campo Nome não pode estar vazio.");
                    return;
                }
                else
                {
                    reserva._nome = txtNome.Text;
                }
                if (string.IsNullOrEmpty(txtTelefone.Text))
                {
                    MessageBox.Show("Erro: O campo Telefone não pode estar vazio.");
                    return;
                }
                else
                {
                    reserva._telefone = txtTelefone.Text;
                }
                reserva.SetCPF(txtCPF.Text);
                reserva._email = txtEmail.Text;
                if (string.IsNullOrEmpty(txtDtChekin.Text))
                {
                    MessageBox.Show("Erro: O campo Data Check-in não pode estar vazio.");
                    return;
                }
                else
                {
                    reserva._dtCheckin = DateOnly.Parse(txtDtChekin.Text);
                }
                if (string.IsNullOrEmpty(txtDtCheckout.Text))
                {
                    MessageBox.Show("Erro: O campo Data Check-out não pode estar vazio.");
                    return;
                }
                else
                {
                    reserva._dtCheckout = DateOnly.Parse(txtDtCheckout.Text);
                }
                if (string.IsNullOrEmpty(txtHospedes.Text))
                {
                    MessageBox.Show("Erro: O campo Hospedes não pode estar vazio.");
                    return;
                }
                else
                {
                    reserva._hospedes = Convert.ToInt32(txtHospedes.Text);
                }
                reserva._prefQuarto = txtPrefQuarto.Text; 
                if (cbTipoQuarto.SelectedIndex == -1)
                {
                    MessageBox.Show("Erro: O campo Tipo de Quarto não pode estar vazio.");
                    return;
                }
                else
                {
                    reserva._tpQuarto = Convert.ToString(cbTipoQuarto.SelectedIndex);
                }
                if (cbFormaPagamento.SelectedIndex == -1)
                {
                    MessageBox.Show("Erro: O campo Forma de Pagamento não pode estar vazio.");
                    return;
                }
                else
                {
                    reserva._FormaPag = Convert.ToString(cbFormaPagamento.SelectedIndex);
                }
                DateOnly dataCheckin = DateOnly.ParseExact(txtDtChekin.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                DateOnly dataCheckout = DateOnly.ParseExact(txtDtCheckout.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                if (dataCheckout < dataCheckin)
                {
                    MessageBox.Show("Erro a data de check-out não pode ser anterior à data de check-in.");
                    return;
                }

                listaReservas.Add(reserva);
                ReservasDAO dao = new ReservasDAO();
                dao.Insert(reserva);
                MessageBox.Show("Salvo com sucesso!", "Reserva Salva", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            }
            catch (FormatException)
            {
                MessageBox.Show("Formato de data inválido!", "Erro");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inserir os dados! {ex.Message}");
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
