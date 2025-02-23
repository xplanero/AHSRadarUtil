namespace AHSRadarUtil
{
    partial class Encontrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Encontrar));
            lblTexto1 = new Label();
            tBoxArchivoPoligono = new TextBox();
            btnRutaArchPol = new Button();
            lblTexto2 = new Label();
            btnRutaArchRadar = new Button();
            tBoxArchivoRadar = new TextBox();
            btnRutaSalida = new Button();
            tBoxArchivoSalida = new TextBox();
            lblTexto3 = new Label();
            btnMenu = new Button();
            btnGenerar = new Button();
            SuspendLayout();
            // 
            // lblTexto1
            // 
            lblTexto1.AutoSize = true;
            lblTexto1.Location = new Point(49, 50);
            lblTexto1.Margin = new Padding(4, 0, 4, 0);
            lblTexto1.Name = "lblTexto1";
            lblTexto1.Size = new Size(173, 25);
            lblTexto1.TabIndex = 0;
            lblTexto1.Text = "Archivo de Polígono";
            // 
            // tBoxArchivoPoligono
            // 
            tBoxArchivoPoligono.Location = new Point(49, 80);
            tBoxArchivoPoligono.Margin = new Padding(4, 5, 4, 5);
            tBoxArchivoPoligono.Name = "tBoxArchivoPoligono";
            tBoxArchivoPoligono.Size = new Size(960, 31);
            tBoxArchivoPoligono.TabIndex = 1;
            // 
            // btnRutaArchPol
            // 
            btnRutaArchPol.Location = new Point(1019, 80);
            btnRutaArchPol.Margin = new Padding(4, 5, 4, 5);
            btnRutaArchPol.Name = "btnRutaArchPol";
            btnRutaArchPol.Size = new Size(107, 38);
            btnRutaArchPol.TabIndex = 2;
            btnRutaArchPol.Text = "Buscar";
            btnRutaArchPol.UseVisualStyleBackColor = true;
            btnRutaArchPol.Click += btnRutaArchPol_Click;
            // 
            // lblTexto2
            // 
            lblTexto2.AutoSize = true;
            lblTexto2.Location = new Point(49, 140);
            lblTexto2.Margin = new Padding(4, 0, 4, 0);
            lblTexto2.Name = "lblTexto2";
            lblTexto2.Size = new Size(152, 25);
            lblTexto2.TabIndex = 3;
            lblTexto2.Text = "Archivo de Rádar.";
            // 
            // btnRutaArchRadar
            // 
            btnRutaArchRadar.Location = new Point(1019, 170);
            btnRutaArchRadar.Margin = new Padding(4, 5, 4, 5);
            btnRutaArchRadar.Name = "btnRutaArchRadar";
            btnRutaArchRadar.Size = new Size(107, 38);
            btnRutaArchRadar.TabIndex = 5;
            btnRutaArchRadar.Text = "Buscar";
            btnRutaArchRadar.UseVisualStyleBackColor = true;
            btnRutaArchRadar.Click += btnRutaArchRadar_Click;
            // 
            // tBoxArchivoRadar
            // 
            tBoxArchivoRadar.Location = new Point(49, 170);
            tBoxArchivoRadar.Margin = new Padding(4, 5, 4, 5);
            tBoxArchivoRadar.Name = "tBoxArchivoRadar";
            tBoxArchivoRadar.Size = new Size(960, 31);
            tBoxArchivoRadar.TabIndex = 4;
            // 
            // btnRutaSalida
            // 
            btnRutaSalida.Location = new Point(1019, 265);
            btnRutaSalida.Margin = new Padding(4, 5, 4, 5);
            btnRutaSalida.Name = "btnRutaSalida";
            btnRutaSalida.Size = new Size(107, 38);
            btnRutaSalida.TabIndex = 8;
            btnRutaSalida.Text = "Buscar";
            btnRutaSalida.UseVisualStyleBackColor = true;
            btnRutaSalida.Click += btnRutaSalida_Click;
            // 
            // tBoxArchivoSalida
            // 
            tBoxArchivoSalida.Location = new Point(49, 265);
            tBoxArchivoSalida.Margin = new Padding(4, 5, 4, 5);
            tBoxArchivoSalida.Name = "tBoxArchivoSalida";
            tBoxArchivoSalida.Size = new Size(960, 31);
            tBoxArchivoSalida.TabIndex = 7;
            // 
            // lblTexto3
            // 
            lblTexto3.AutoSize = true;
            lblTexto3.Location = new Point(49, 235);
            lblTexto3.Margin = new Padding(4, 0, 4, 0);
            lblTexto3.Name = "lblTexto3";
            lblTexto3.Size = new Size(171, 25);
            lblTexto3.TabIndex = 6;
            lblTexto3.Text = "Directorio de Salida.";
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(954, 670);
            btnMenu.Margin = new Padding(4, 5, 4, 5);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(107, 38);
            btnMenu.TabIndex = 9;
            btnMenu.Text = "Menú";
            btnMenu.UseMnemonic = false;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(54, 363);
            btnGenerar.Margin = new Padding(4, 5, 4, 5);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(107, 38);
            btnGenerar.TabIndex = 10;
            btnGenerar.Text = "Generar.";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // Encontrar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(btnGenerar);
            Controls.Add(btnMenu);
            Controls.Add(btnRutaSalida);
            Controls.Add(tBoxArchivoSalida);
            Controls.Add(lblTexto3);
            Controls.Add(btnRutaArchRadar);
            Controls.Add(tBoxArchivoRadar);
            Controls.Add(lblTexto2);
            Controls.Add(btnRutaArchPol);
            Controls.Add(tBoxArchivoPoligono);
            Controls.Add(lblTexto1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "Encontrar";
            Text = "Encontrar líneas.";
            HelpButtonClicked += Encontrar_HelpButtonClicked;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTexto1;
        private TextBox tBoxArchivoPoligono;
        private Button btnRutaArchPol;
        private Label lblTexto2;
        private Button btnRutaArchRadar;
        private TextBox tBoxArchivoRadar;
        private Button btnRutaSalida;
        private TextBox tBoxArchivoSalida;
        private Label lblTexto3;
        private Button btnMenu;
        private Button btnGenerar;
    }
}