namespace AHSRadarUtil
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            btnSalir = new Button();
            btnEncontrar = new Button();
            btnFileInt = new Button();
            btnArco = new Button();
            btnAreas = new Button();
            btnDeIvao = new Button();
            btnCopiarArchivos = new Button();
            BtnFixes = new Button();
            btnEspera = new Button();
            btnGoAround = new Button();
            btnAirac = new Button();
            pictureBoxLogo = new PictureBox();
            lblAirac = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.GradientActiveCaption;
            btnSalir.Location = new Point(657, 133);
            btnSalir.Margin = new Padding(1, 2, 1, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(111, 38);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEncontrar
            // 
            btnEncontrar.Location = new Point(189, 77);
            btnEncontrar.Margin = new Padding(4, 5, 4, 5);
            btnEncontrar.Name = "btnEncontrar";
            btnEncontrar.Size = new Size(111, 38);
            btnEncontrar.TabIndex = 2;
            btnEncontrar.Text = "Encontrar";
            btnEncontrar.UseVisualStyleBackColor = true;
            btnEncontrar.Click += btnEncontrar_Click;
            // 
            // btnFileInt
            // 
            btnFileInt.Location = new Point(189, 18);
            btnFileInt.Name = "btnFileInt";
            btnFileInt.Size = new Size(111, 38);
            btnFileInt.TabIndex = 3;
            btnFileInt.Text = "Integridad";
            btnFileInt.UseVisualStyleBackColor = true;
            btnFileInt.Click += btnFileInt_Click;
            // 
            // btnArco
            // 
            btnArco.Location = new Point(33, 18);
            btnArco.Name = "btnArco";
            btnArco.Size = new Size(111, 38);
            btnArco.TabIndex = 4;
            btnArco.Text = "CirculoArco";
            btnArco.UseVisualStyleBackColor = true;
            btnArco.Click += btnArco_Click;
            // 
            // btnAreas
            // 
            btnAreas.Location = new Point(346, 18);
            btnAreas.Name = "btnAreas";
            btnAreas.Size = new Size(111, 38);
            btnAreas.TabIndex = 5;
            btnAreas.Text = "Areas";
            btnAreas.UseVisualStyleBackColor = true;
            btnAreas.Click += btnAreas_Click;
            // 
            // btnDeIvao
            // 
            btnDeIvao.Location = new Point(346, 77);
            btnDeIvao.Name = "btnDeIvao";
            btnDeIvao.Size = new Size(111, 38);
            btnDeIvao.TabIndex = 6;
            btnDeIvao.Text = "IVAO";
            btnDeIvao.UseVisualStyleBackColor = true;
            btnDeIvao.Click += btnDeIvao_Click;
            // 
            // btnCopiarArchivos
            // 
            btnCopiarArchivos.Location = new Point(657, 18);
            btnCopiarArchivos.Name = "btnCopiarArchivos";
            btnCopiarArchivos.Size = new Size(111, 38);
            btnCopiarArchivos.TabIndex = 9;
            btnCopiarArchivos.Text = "Copiar  AR";
            btnCopiarArchivos.UseVisualStyleBackColor = true;
            btnCopiarArchivos.Click += btnCopiarArchivos_Click;
            // 
            // BtnFixes
            // 
            BtnFixes.Location = new Point(657, 77);
            BtnFixes.Name = "BtnFixes";
            BtnFixes.Size = new Size(111, 38);
            BtnFixes.TabIndex = 10;
            BtnFixes.Text = "Fixes";
            BtnFixes.UseVisualStyleBackColor = true;
            BtnFixes.Click += BtnFixes_Click;
            // 
            // btnEspera
            // 
            btnEspera.Location = new Point(501, 77);
            btnEspera.Margin = new Padding(1, 2, 1, 2);
            btnEspera.Name = "btnEspera";
            btnEspera.Size = new Size(111, 38);
            btnEspera.TabIndex = 12;
            btnEspera.Text = "Esperas";
            btnEspera.UseVisualStyleBackColor = true;
            btnEspera.Click += btnEspera_Click;
            // 
            // btnGoAround
            // 
            btnGoAround.Location = new Point(501, 18);
            btnGoAround.Name = "btnGoAround";
            btnGoAround.Size = new Size(111, 38);
            btnGoAround.TabIndex = 13;
            btnGoAround.Text = "Go Around";
            btnGoAround.UseVisualStyleBackColor = true;
            btnGoAround.Click += btnGoAround_Click;
            // 
            // btnAirac
            // 
            btnAirac.Location = new Point(33, 77);
            btnAirac.Name = "btnAirac";
            btnAirac.Size = new Size(111, 38);
            btnAirac.TabIndex = 14;
            btnAirac.Text = "Airac";
            btnAirac.UseVisualStyleBackColor = true;
            btnAirac.Click += btnAirac_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(250, 133);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(244, 52);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 15;
            pictureBoxLogo.TabStop = false;
            // 
            // lblAirac
            // 
            lblAirac.AutoSize = true;
            lblAirac.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAirac.Location = new Point(52, 140);
            lblAirac.Name = "lblAirac";
            lblAirac.Size = new Size(56, 25);
            lblAirac.TabIndex = 16;
            lblAirac.Text = "Airac";
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 197);
            Controls.Add(lblAirac);
            Controls.Add(pictureBoxLogo);
            Controls.Add(btnAirac);
            Controls.Add(btnGoAround);
            Controls.Add(btnEspera);
            Controls.Add(BtnFixes);
            Controls.Add(btnCopiarArchivos);
            Controls.Add(btnDeIvao);
            Controls.Add(btnAreas);
            Controls.Add(btnArco);
            Controls.Add(btnFileInt);
            Controls.Add(btnEncontrar);
            Controls.Add(btnSalir);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Principal";
            Text = "UTILIDADES RADAR AIRHISPANIA";
            Load += Principal_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSalir;
        private Button btnEncontrar;
        private Button btnFileInt;
        private Button btnArco;
        private Button btnAreas;
        private Button btnDeIvao;
        private Button btnCopiarArchivos;
        private Button BtnFixes;
        private Button btnEspera;
        private Button btnGoAround;
        private Button btnAirac;
        private PictureBox pictureBoxLogo;
        private Label lblAirac;
    }
}
