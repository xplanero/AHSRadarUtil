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
            btnCirculo = new Button();
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
            SuspendLayout();
            // 
            // btnCirculo
            // 
            btnCirculo.Location = new Point(24, 18);
            btnCirculo.Name = "btnCirculo";
            btnCirculo.Size = new Size(111, 38);
            btnCirculo.TabIndex = 0;
            btnCirculo.Text = "Circulo";
            btnCirculo.UseVisualStyleBackColor = true;
            btnCirculo.Click += btnCirculo_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(650, 382);
            btnSalir.Margin = new Padding(1, 2, 1, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(113, 35);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEncontrar
            // 
            btnEncontrar.Location = new Point(171, 73);
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
            btnFileInt.Location = new Point(171, 18);
            btnFileInt.Name = "btnFileInt";
            btnFileInt.Size = new Size(111, 38);
            btnFileInt.TabIndex = 3;
            btnFileInt.Text = "Integridad";
            btnFileInt.UseVisualStyleBackColor = true;
            btnFileInt.Click += btnFileInt_Click;
            // 
            // btnArco
            // 
            btnArco.Location = new Point(24, 77);
            btnArco.Name = "btnArco";
            btnArco.Size = new Size(111, 35);
            btnArco.TabIndex = 4;
            btnArco.Text = "Arco";
            btnArco.UseVisualStyleBackColor = true;
            btnArco.Click += btnArco_Click;
            // 
            // btnAreas
            // 
            btnAreas.Location = new Point(320, 22);
            btnAreas.Name = "btnAreas";
            btnAreas.Size = new Size(111, 33);
            btnAreas.TabIndex = 5;
            btnAreas.Text = "Areas";
            btnAreas.UseVisualStyleBackColor = true;
            btnAreas.Click += btnAreas_Click;
            // 
            // btnDeIvao
            // 
            btnDeIvao.Location = new Point(320, 77);
            btnDeIvao.Name = "btnDeIvao";
            btnDeIvao.Size = new Size(111, 33);
            btnDeIvao.TabIndex = 6;
            btnDeIvao.Text = "IVAO";
            btnDeIvao.UseVisualStyleBackColor = true;
            btnDeIvao.Click += btnDeIvao_Click;
            // 
            // btnCopiarArchivos
            // 
            btnCopiarArchivos.Location = new Point(650, 22);
            btnCopiarArchivos.Name = "btnCopiarArchivos";
            btnCopiarArchivos.Size = new Size(111, 33);
            btnCopiarArchivos.TabIndex = 9;
            btnCopiarArchivos.Text = "Copiar  AR";
            btnCopiarArchivos.UseVisualStyleBackColor = true;
            btnCopiarArchivos.Click += btnCopiarArchivos_Click;
            // 
            // BtnFixes
            // 
            BtnFixes.Location = new Point(650, 73);
            BtnFixes.Name = "BtnFixes";
            BtnFixes.Size = new Size(111, 33);
            BtnFixes.TabIndex = 10;
            BtnFixes.Text = "Fixes";
            BtnFixes.UseVisualStyleBackColor = true;
            BtnFixes.Click += BtnFixes_Click;
            // 
            // btnEspera
            // 
            btnEspera.Location = new Point(486, 76);
            btnEspera.Margin = new Padding(1, 2, 1, 2);
            btnEspera.Name = "btnEspera";
            btnEspera.Size = new Size(109, 33);
            btnEspera.TabIndex = 12;
            btnEspera.Text = "Esperas";
            btnEspera.UseVisualStyleBackColor = true;
            btnEspera.Click += btnEspera_Click;
            // 
            // btnGoAround
            // 
            btnGoAround.Location = new Point(486, 23);
            btnGoAround.Name = "btnGoAround";
            btnGoAround.Size = new Size(111, 33);
            btnGoAround.TabIndex = 13;
            btnGoAround.Text = "Go Around";
            btnGoAround.UseVisualStyleBackColor = true;
            btnGoAround.Click += btnGoAround_Click;
            // 
            // btnAirac
            // 
            btnAirac.Location = new Point(24, 133);
            btnAirac.Name = "btnAirac";
            btnAirac.Size = new Size(112, 34);
            btnAirac.TabIndex = 14;
            btnAirac.Text = "Airac";
            btnAirac.UseVisualStyleBackColor = true;
            btnAirac.Click += btnAirac_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Controls.Add(btnCirculo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Principal";
            Text = "UTILIDADES RADAR AIRHISPANIA";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCirculo;
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
    }
}
