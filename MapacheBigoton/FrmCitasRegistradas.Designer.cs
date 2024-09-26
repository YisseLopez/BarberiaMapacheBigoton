namespace MapacheBigoton
{
    partial class FrmCitasRegistradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCitasRegistradas));
            label2 = new Label();
            pictureBox1 = new PictureBox();
            dgvCitasAgendadas = new DataGridView();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCitasAgendadas).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Ravie", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(205, 61);
            label2.Name = "label2";
            label2.Size = new Size(377, 43);
            label2.TabIndex = 7;
            label2.Text = "Citas Agendadas";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(59, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // dgvCitasAgendadas
            // 
            dgvCitasAgendadas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCitasAgendadas.Location = new Point(103, 158);
            dgvCitasAgendadas.Name = "dgvCitasAgendadas";
            dgvCitasAgendadas.Size = new Size(591, 194);
            dgvCitasAgendadas.TabIndex = 17;
            // 
            // btnSalir
            // 
            btnSalir.Font = new Font("Lucida Handwriting", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(525, 374);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(157, 48);
            btnSalir.TabIndex = 25;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmCitasRegistradas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(dgvCitasAgendadas);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Name = "FrmCitasRegistradas";
            Text = "FrmCitasRegistradas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCitasAgendadas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private PictureBox pictureBox1;
        private DataGridView dgvCitasAgendadas;
        private Button btnSalir;
    }
}