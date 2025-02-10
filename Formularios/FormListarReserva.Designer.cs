namespace ReservasHotel.Formularios
{
    partial class FormListarReserva
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
            dgvListaReservas = new DataGridView();
            lbTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvListaReservas).BeginInit();
            SuspendLayout();
            // 
            // dgvListaReservas
            // 
            dgvListaReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaReservas.Location = new Point(12, 209);
            dgvListaReservas.Name = "dgvListaReservas";
            dgvListaReservas.RowHeadersWidth = 53;
            dgvListaReservas.Size = new Size(1051, 446);
            dgvListaReservas.TabIndex = 0;
            // 
            // lbTitulo
            // 
            lbTitulo.AutoSize = true;
            lbTitulo.BackColor = Color.Transparent;
            lbTitulo.Font = new Font("Century", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTitulo.ForeColor = Color.Black;
            lbTitulo.Location = new Point(398, 31);
            lbTitulo.Margin = new Padding(4, 0, 4, 0);
            lbTitulo.Name = "lbTitulo";
            lbTitulo.Size = new Size(343, 34);
            lbTitulo.TabIndex = 2;
            lbTitulo.Text = "LISTA DE RESERVAS";
            // 
            // FormListarReserva
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 667);
            Controls.Add(lbTitulo);
            Controls.Add(dgvListaReservas);
            Name = "FormListarReserva";
            Text = "FormListarReserva";
            ((System.ComponentModel.ISupportInitialize)dgvListaReservas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvListaReservas;
        private Label lbTitulo;
    }
}