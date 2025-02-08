namespace ReservasHotel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbTitulo = new Label();
            lbKaique = new Label();
            btNovaReserva = new Button();
            btConsultarReser = new Button();
            btEditarReserva = new Button();
            btDeletarReserva = new Button();
            SuspendLayout();
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.BackColor = Color.Transparent;
            lbTitulo.Font = new Font("Century", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitulo.ForeColor = Color.Black;
            lbTitulo.Location = new Point(389, 41);
            lbTitulo.Margin = new Padding(4, 0, 4, 0);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(409, 39);
            lbTitulo.TabIndex = 0;
            lbTitulo.Text = "RESERVAS DE HOTEL";
            // 
            // lbKaique
            // 
            lbKaique.AutoSize = true;
            lbKaique.Font = new Font("Century", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbKaique.Location = new Point(1034, 670);
            lbKaique.Margin = new Padding(4, 0, 4, 0);
            lbKaique.Name = "lbKaique";
            lbKaique.Size = new Size(152, 22);
            lbKaique.TabIndex = 1;
            lbKaique.Text = "Kaique Gabriel";
            // 
            // btNovaReserva
            // 
            btNovaReserva.BackColor = Color.MediumSeaGreen;
            btNovaReserva.Font = new Font("Century", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btNovaReserva.Location = new Point(138, 162);
            btNovaReserva.Name = "btNovaReserva";
            btNovaReserva.Size = new Size(262, 41);
            btNovaReserva.TabIndex = 2;
            btNovaReserva.Text = "Nova Reserva";
            btNovaReserva.UseVisualStyleBackColor = false;
            btNovaReserva.Click += btNovaReserva_Click;
            // 
            // btConsultarReser
            // 
            btConsultarReser.BackColor = Color.YellowGreen;
            btConsultarReser.Font = new Font("Century", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btConsultarReser.Location = new Point(138, 240);
            btConsultarReser.Name = "btConsultarReser";
            btConsultarReser.Size = new Size(262, 41);
            btConsultarReser.TabIndex = 3;
            btConsultarReser.Text = "Consultar Reservas";
            btConsultarReser.UseVisualStyleBackColor = false;
            // 
            // btEditarReserva
            // 
            btEditarReserva.BackColor = Color.DodgerBlue;
            btEditarReserva.Font = new Font("Century", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btEditarReserva.Location = new Point(138, 316);
            btEditarReserva.Name = "btEditarReserva";
            btEditarReserva.Size = new Size(262, 41);
            btEditarReserva.TabIndex = 4;
            btEditarReserva.Text = "Editar Reservas";
            btEditarReserva.UseVisualStyleBackColor = false;
            // 
            // btDeletarReserva
            // 
            btDeletarReserva.BackColor = Color.Crimson;
            btDeletarReserva.Font = new Font("Century", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btDeletarReserva.Location = new Point(138, 392);
            btDeletarReserva.Name = "btDeletarReserva";
            btDeletarReserva.Size = new Size(262, 41);
            btDeletarReserva.TabIndex = 5;
            btDeletarReserva.Text = "Deletar Reservas";
            btDeletarReserva.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 704);
            Controls.Add(btDeletarReserva);
            Controls.Add(btEditarReserva);
            Controls.Add(btConsultarReser);
            Controls.Add(btNovaReserva);
            Controls.Add(lbKaique);
            Controls.Add(lbTitulo);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitulo;
        private Label lbKaique;
        private Button btNovaReserva;
        private Button btConsultarReser;
        private Button btEditarReserva;
        private Button btDeletarReserva;
    }
}
