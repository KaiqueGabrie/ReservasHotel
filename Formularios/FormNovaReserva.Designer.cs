namespace ReservasHotel.Formularios
{
    partial class FormNovaReserva
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbTitulo = new Label();
            txtNome = new TextBox();
            lbNome = new Label();
            lbCPF = new Label();
            txtCPF = new TextBox();
            lbTelefone = new Label();
            txtTelefone = new TextBox();
            lbEmail = new Label();
            txtEmail = new TextBox();
            dtCheckin = new Label();
            txtDtChekin = new TextBox();
            lbCheckout = new Label();
            txtDtCheckout = new TextBox();
            lbHospedes = new Label();
            txtHospedes = new TextBox();
            label1 = new Label();
            cbTipoQuarto = new ComboBox();
            cbFormaPagamento = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            txtPrefQuarto = new TextBox();
            btSalvar = new Button();
            btCancelar = new Button();
            SuspendLayout();
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.BackColor = Color.Transparent;
            lbTitulo.Font = new Font("Century", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitulo.ForeColor = Color.Black;
            lbTitulo.Location = new Point(506, 20);
            lbTitulo.Margin = new Padding(4, 0, 4, 0);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(268, 34);
            lbTitulo.TabIndex = 1;
            lbTitulo.Text = "NOVA RESERVA";
            // 
            // txtNome
            // 
            txtNome.BackColor = SystemColors.ActiveCaption;
            txtNome.Location = new Point(211, 160);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(404, 29);
            txtNome.TabIndex = 2;
            // 
            // lbNome
            // 
            lbNome.AutoSize = true;
            lbNome.BackColor = Color.Transparent;
            lbNome.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNome.ForeColor = Color.Black;
            lbNome.Location = new Point(211, 139);
            lbNome.Margin = new Padding(4, 0, 4, 0);
            lbNome.Name = "lbNome";
            lbNome.Size = new Size(64, 22);
            lbNome.TabIndex = 3;
            lbNome.Text = "Nome:";
            // 
            // lbCPF
            // 
            lbCPF.AutoSize = true;
            lbCPF.BackColor = Color.Transparent;
            lbCPF.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCPF.ForeColor = Color.Black;
            lbCPF.Location = new Point(676, 139);
            lbCPF.Margin = new Padding(4, 0, 4, 0);
            lbCPF.Name = "lbCPF";
            lbCPF.Size = new Size(52, 22);
            lbCPF.TabIndex = 5;
            lbCPF.Text = "CPF:";
            // 
            // txtCPF
            // 
            txtCPF.BackColor = SystemColors.ActiveCaption;
            txtCPF.Location = new Point(676, 160);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(324, 29);
            txtCPF.TabIndex = 4;
            // 
            // lbTelefone
            // 
            lbTelefone.AutoSize = true;
            lbTelefone.BackColor = Color.Transparent;
            lbTelefone.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbTelefone.ForeColor = Color.Black;
            lbTelefone.Location = new Point(676, 197);
            lbTelefone.Margin = new Padding(4, 0, 4, 0);
            lbTelefone.Name = "lbTelefone";
            lbTelefone.Size = new Size(86, 22);
            lbTelefone.TabIndex = 7;
            lbTelefone.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            txtTelefone.BackColor = SystemColors.ActiveCaption;
            txtTelefone.Location = new Point(676, 219);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(324, 29);
            txtTelefone.TabIndex = 6;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.BackColor = Color.Transparent;
            lbEmail.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEmail.ForeColor = Color.Black;
            lbEmail.Location = new Point(211, 197);
            lbEmail.Margin = new Padding(4, 0, 4, 0);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(72, 22);
            lbEmail.TabIndex = 9;
            lbEmail.Text = "E-mail:";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.ActiveCaption;
            txtEmail.Location = new Point(211, 219);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(404, 29);
            txtEmail.TabIndex = 8;
            // 
            // dtCheckin
            // 
            dtCheckin.AutoSize = true;
            dtCheckin.BackColor = Color.Transparent;
            dtCheckin.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtCheckin.ForeColor = Color.Black;
            dtCheckin.Location = new Point(211, 311);
            dtCheckin.Margin = new Padding(4, 0, 4, 0);
            dtCheckin.Name = "dtCheckin";
            dtCheckin.Size = new Size(136, 22);
            dtCheckin.TabIndex = 11;
            dtCheckin.Text = "Data Check-in:";
            // 
            // txtDtChekin
            // 
            txtDtChekin.BackColor = SystemColors.HotTrack;
            txtDtChekin.Location = new Point(211, 333);
            txtDtChekin.Name = "txtDtChekin";
            txtDtChekin.Size = new Size(134, 29);
            txtDtChekin.TabIndex = 10;
            // 
            // lbCheckout
            // 
            lbCheckout.AutoSize = true;
            lbCheckout.BackColor = Color.Transparent;
            lbCheckout.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCheckout.ForeColor = Color.Black;
            lbCheckout.Location = new Point(362, 311);
            lbCheckout.Margin = new Padding(4, 0, 4, 0);
            lbCheckout.Name = "lbCheckout";
            lbCheckout.Size = new Size(146, 22);
            lbCheckout.TabIndex = 13;
            lbCheckout.Text = "Data Check-out:";
            // 
            // txtDtCheckout
            // 
            txtDtCheckout.BackColor = SystemColors.HotTrack;
            txtDtCheckout.Location = new Point(362, 333);
            txtDtCheckout.Name = "txtDtCheckout";
            txtDtCheckout.Size = new Size(134, 29);
            txtDtCheckout.TabIndex = 12;
            // 
            // lbHospedes
            // 
            lbHospedes.AutoSize = true;
            lbHospedes.BackColor = Color.Transparent;
            lbHospedes.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbHospedes.ForeColor = Color.Black;
            lbHospedes.Location = new Point(521, 311);
            lbHospedes.Margin = new Padding(4, 0, 4, 0);
            lbHospedes.Name = "lbHospedes";
            lbHospedes.Size = new Size(93, 22);
            lbHospedes.TabIndex = 15;
            lbHospedes.Text = "Hospedes:";
            // 
            // txtHospedes
            // 
            txtHospedes.BackColor = SystemColors.HotTrack;
            txtHospedes.Location = new Point(521, 333);
            txtHospedes.Name = "txtHospedes";
            txtHospedes.Size = new Size(93, 29);
            txtHospedes.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(211, 406);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(136, 22);
            label1.TabIndex = 16;
            label1.Text = "Tipo de quarto:";
            // 
            // cbTipoQuarto
            // 
            cbTipoQuarto.BackColor = SystemColors.HotTrack;
            cbTipoQuarto.FormattingEnabled = true;
            cbTipoQuarto.Items.AddRange(new object[] { "Standard", "Luxo", "Suíte" });
            cbTipoQuarto.Location = new Point(211, 426);
            cbTipoQuarto.Name = "cbTipoQuarto";
            cbTipoQuarto.Size = new Size(404, 29);
            cbTipoQuarto.TabIndex = 17;
            cbTipoQuarto.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cbFormaPagamento
            // 
            cbFormaPagamento.BackColor = SystemColors.HotTrack;
            cbFormaPagamento.FormattingEnabled = true;
            cbFormaPagamento.Items.AddRange(new object[] { "Dinheiro", "Cartão", "Pix" });
            cbFormaPagamento.Location = new Point(676, 426);
            cbFormaPagamento.Name = "cbFormaPagamento";
            cbFormaPagamento.Size = new Size(324, 29);
            cbFormaPagamento.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(676, 406);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(188, 22);
            label2.TabIndex = 18;
            label2.Text = "Forma de Pagamento";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(676, 311);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(199, 22);
            label3.TabIndex = 21;
            label3.Text = "Preferência de Quarto:";
            // 
            // txtPrefQuarto
            // 
            txtPrefQuarto.BackColor = SystemColors.HotTrack;
            txtPrefQuarto.Location = new Point(676, 333);
            txtPrefQuarto.Name = "txtPrefQuarto";
            txtPrefQuarto.Size = new Size(324, 29);
            txtPrefQuarto.TabIndex = 20;
            // 
            // btSalvar
            // 
            btSalvar.BackColor = Color.MediumSeaGreen;
            btSalvar.Font = new Font("Century", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSalvar.Location = new Point(211, 541);
            btSalvar.Name = "btSalvar";
            btSalvar.Size = new Size(236, 34);
            btSalvar.TabIndex = 22;
            btSalvar.Text = "Salvar";
            btSalvar.UseVisualStyleBackColor = false;
            btSalvar.Click += btSalvar_Click;
            // 
            // btCancelar
            // 
            btCancelar.BackColor = Color.Crimson;
            btCancelar.Font = new Font("Century", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCancelar.Location = new Point(764, 541);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(236, 34);
            btCancelar.TabIndex = 23;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = false;
            btCancelar.Click += btCancelar_Click;
            // 
            // FormNovaReserva
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1260, 585);
            Controls.Add(btCancelar);
            Controls.Add(btSalvar);
            Controls.Add(label3);
            Controls.Add(txtPrefQuarto);
            Controls.Add(cbFormaPagamento);
            Controls.Add(label2);
            Controls.Add(cbTipoQuarto);
            Controls.Add(label1);
            Controls.Add(lbHospedes);
            Controls.Add(txtHospedes);
            Controls.Add(lbCheckout);
            Controls.Add(txtDtCheckout);
            Controls.Add(dtCheckin);
            Controls.Add(txtDtChekin);
            Controls.Add(lbEmail);
            Controls.Add(txtEmail);
            Controls.Add(lbTelefone);
            Controls.Add(txtTelefone);
            Controls.Add(lbCPF);
            Controls.Add(txtCPF);
            Controls.Add(lbNome);
            Controls.Add(txtNome);
            Controls.Add(lbTitulo);
            Name = "FormNovaReserva";
            Text = "FormNovaReserva";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitulo;
        private TextBox txtNome;
        private Label lbNome;
        private Label lbCPF;
        private TextBox txtCPF;
        private Label lbTelefone;
        private TextBox txtTelefone;
        private Label lbEmail;
        private TextBox txtEmail;
        private Label dtCheckin;
        private TextBox txtDtChekin;
        private Label lbCheckout;
        private TextBox txtDtCheckout;
        private Label lbHospedes;
        private TextBox txtHospedes;
        private Label label1;
        private ComboBox cbTipoQuarto;
        private ComboBox cbFormaPagamento;
        private Label label2;
        private Label label3;
        private TextBox txtPrefQuarto;
        private Button btSalvar;
        private Button btCancelar;
    }
}