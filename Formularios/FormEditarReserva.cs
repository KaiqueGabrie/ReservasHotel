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
using System.Windows.Forms.Design;
using MySql.Data.MySqlClient;
using System.Globalization;

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
            try
            {
                Reserva reserva = new Reserva();
                reserva._id = int.Parse(txtID.Text);
                ReservasDAO reservasDAO = new ReservasDAO();
                
                //// VERFIFICANDO SE OS CAMPOS ESTÃO VAZIOS  ******
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
                ////// FIM VERIFICAÇÃO CAMPOS VAZIOS ********************

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
            catch (FormatException)
            {
                MessageBox.Show("Formato de data inválido!", "Erro");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao editar reserva! {ex.Message}");
            }

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {

                    ReservasDAO reservasDAO = new ReservasDAO();
                    Reserva reserva = new Reserva();
                    List<Reserva> reservaList = reservasDAO.List();
                    foreach (Reserva x in reservaList)
                    {
                        if (x._id == int.Parse(txtID.Text))
                        {
                            txtNome.Text = x._nome;
                            txtCPF.Text = x._cpf;
                            txtEmail.Text = x._email;
                            txtTelefone.Text = x._telefone;
                            txtDtChekin.Text = Convert.ToString(x._dtCheckin);
                            txtDtCheckout.Text = Convert.ToString(x._dtCheckout);
                            txtHospedes.Text = Convert.ToString(x._hospedes);
                            txtPrefQuarto.Text = x._prefQuarto;
                            cbTipoQuarto.SelectedIndex = int.Parse(x._tpQuarto);
                            cbFormaPagamento.SelectedIndex = int.Parse(x._FormaPag);
                        }
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Erro id não encontrado! " + ex.Message);
            }
            
            
        }
    }
}
