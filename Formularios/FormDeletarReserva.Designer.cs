namespace ReservasHotel.Formularios
{
    partial class FormDeletarReserva
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
            lbID = new Label();
            txtID = new TextBox();
            lbTitulo = new Label();
            btCancelar = new Button();
            btDeletar = new Button();
            SuspendLayout();
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.BackColor = Color.Transparent;
            lbID.Font = new Font("Century", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbID.ForeColor = Color.Black;
            lbID.Location = new Point(175, 96);
            lbID.Margin = new Padding(4, 0, 4, 0);
            lbID.Name = "lbID";
            lbID.Size = new Size(479, 22);
            lbID.TabIndex = 7;
            lbID.Text = "DIGITE O ID DA RESERVA QUE DESEJA DELETAR: ";
            // 
            // txtID
            // 
            txtID.BackColor = Color.Moccasin;
            txtID.Location = new Point(175, 121);
            txtID.Name = "txtID";
            txtID.Size = new Size(461, 29);
            txtID.TabIndex = 6;
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.BackColor = Color.Transparent;
            lbTitulo.Font = new Font("Century", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitulo.ForeColor = Color.Black;
            lbTitulo.Location = new Point(245, 9);
            lbTitulo.Margin = new Padding(4, 0, 4, 0);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(327, 34);
            lbTitulo.TabIndex = 8;
            lbTitulo.Text = "DELETAR RESERVA";
            // 
            // btCancelar
            // 
            btCancelar.BackColor = Color.Crimson;
            btCancelar.Font = new Font("Century", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btCancelar.Location = new Point(438, 239);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(236, 34);
            btCancelar.TabIndex = 67;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = false;
            btCancelar.Click += btCancelar_Click;
            // 
            // btDeletar
            // 
            btDeletar.BackColor = Color.White;
            btDeletar.Font = new Font("Century", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDeletar.Location = new Point(159, 239);
            btDeletar.Name = "btDeletar";
            btDeletar.Size = new Size(236, 34);
            btDeletar.TabIndex = 66;
            btDeletar.Text = "Deletar";
            btDeletar.UseVisualStyleBackColor = false;
            btDeletar.Click += btDeletar_Click;
            // 
            // FormDeletarReserva
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 363);
            Controls.Add(btCancelar);
            Controls.Add(btDeletar);
            Controls.Add(lbTitulo);
            Controls.Add(lbID);
            Controls.Add(txtID);
            Name = "FormDeletarReserva";
            Text = "FormDeletarReserva";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbID;
        private TextBox txtID;
        private Label lbTitulo;
        private Button btCancelar;
        private Button btDeletar;
    }
}