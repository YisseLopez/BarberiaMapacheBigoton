namespace MapacheBigoton
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            btnNuevaCita = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnCitasRegistradas = new Button();
            btnSalir = new Button();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnNuevaCita
            // 
            btnNuevaCita.BackColor = SystemColors.ActiveCaption;
            btnNuevaCita.Font = new Font("Lucida Handwriting", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevaCita.Location = new Point(458, 102);
            btnNuevaCita.Name = "btnNuevaCita";
            btnNuevaCita.Size = new Size(157, 48);
            btnNuevaCita.TabIndex = 0;
            btnNuevaCita.Text = "Nueva Cita";
            btnNuevaCita.UseVisualStyleBackColor = false;
            btnNuevaCita.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(120, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(133, 119);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Handwriting", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(67, 168);
            label2.Name = "label2";
            label2.Size = new Size(259, 48);
            label2.TabIndex = 5;
            label2.Text = "Barber \r\n\"El Mapache Bigotón\"";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(130, 306);
            label4.Name = "label4";
            label4.Size = new Size(123, 20);
            label4.TabIndex = 10;
            label4.Text = "Tel. 231 222 3568";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(79, 278);
            label3.Name = "label3";
            label3.Size = new Size(227, 20);
            label3.TabIndex = 9;
            label3.Text = "\"El refugio del caballero moderno\"";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft PhagsPa", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 240);
            label1.Name = "label1";
            label1.Size = new Size(357, 20);
            label1.TabIndex = 8;
            label1.Text = "Calle Emiliano Zapata, No. 1175, Barrio de Francia";
            // 
            // btnCitasRegistradas
            // 
            btnCitasRegistradas.BackColor = SystemColors.GradientInactiveCaption;
            btnCitasRegistradas.Font = new Font("Lucida Handwriting", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCitasRegistradas.Location = new Point(458, 180);
            btnCitasRegistradas.Name = "btnCitasRegistradas";
            btnCitasRegistradas.Size = new Size(157, 64);
            btnCitasRegistradas.TabIndex = 11;
            btnCitasRegistradas.Text = "Citas Registradas";
            btnCitasRegistradas.UseVisualStyleBackColor = false;
            btnCitasRegistradas.Click += btnCitasRegistradas_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Red;
            btnSalir.Font = new Font("Lucida Handwriting", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(458, 278);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(157, 48);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(346, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(344, 433);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 14;
            pictureBox3.TabStop = false;
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 433);
            Controls.Add(btnSalir);
            Controls.Add(btnCitasRegistradas);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(btnNuevaCita);
            Controls.Add(pictureBox3);
            Name = "FrmInicio";
            Text = "FrmInicio";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNuevaCita;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label1;
        private Button btnCitasRegistradas;
        private Button btnSalir;
        private PictureBox pictureBox3;
    }
}