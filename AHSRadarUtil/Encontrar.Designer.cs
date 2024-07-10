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
            lblTexto1.Location = new Point(34, 30);
            lblTexto1.Name = "lblTexto1";
            lblTexto1.Size = new Size(115, 15);
            lblTexto1.TabIndex = 0;
            lblTexto1.Text = "Archivo de Polígono";
            // 
            // tBoxArchivoPoligono
            // 
            tBoxArchivoPoligono.Location = new Point(34, 48);
            tBoxArchivoPoligono.Name = "tBoxArchivoPoligono";
            tBoxArchivoPoligono.Size = new Size(673, 23);
            tBoxArchivoPoligono.TabIndex = 1;
            // 
            // btnRutaArchPol
            // 
            btnRutaArchPol.Location = new Point(713, 48);
            btnRutaArchPol.Name = "btnRutaArchPol";
            btnRutaArchPol.Size = new Size(75, 23);
            btnRutaArchPol.TabIndex = 2;
            btnRutaArchPol.Text = "Buscar";
            btnRutaArchPol.UseVisualStyleBackColor = true;
            btnRutaArchPol.Click += btnRutaArchPol_Click;
            // 
            // lblTexto2
            // 
            lblTexto2.AutoSize = true;
            lblTexto2.Location = new Point(34, 84);
            lblTexto2.Name = "lblTexto2";
            lblTexto2.Size = new Size(100, 15);
            lblTexto2.TabIndex = 3;
            lblTexto2.Text = "Archivo de Rádar.";
            // 
            // btnRutaArchRadar
            // 
            btnRutaArchRadar.Location = new Point(713, 102);
            btnRutaArchRadar.Name = "btnRutaArchRadar";
            btnRutaArchRadar.Size = new Size(75, 23);
            btnRutaArchRadar.TabIndex = 5;
            btnRutaArchRadar.Text = "Buscar";
            btnRutaArchRadar.UseVisualStyleBackColor = true;
            btnRutaArchRadar.Click += btnRutaArchRadar_Click;
            // 
            // tBoxArchivoRadar
            // 
            tBoxArchivoRadar.Location = new Point(34, 102);
            tBoxArchivoRadar.Name = "tBoxArchivoRadar";
            tBoxArchivoRadar.Size = new Size(673, 23);
            tBoxArchivoRadar.TabIndex = 4;
            // 
            // btnRutaSalida
            // 
            btnRutaSalida.Location = new Point(713, 159);
            btnRutaSalida.Name = "btnRutaSalida";
            btnRutaSalida.Size = new Size(75, 23);
            btnRutaSalida.TabIndex = 8;
            btnRutaSalida.Text = "Buscar";
            btnRutaSalida.UseVisualStyleBackColor = true;
            btnRutaSalida.Click += btnRutaSalida_Click;
            // 
            // tBoxArchivoSalida
            // 
            tBoxArchivoSalida.Location = new Point(34, 159);
            tBoxArchivoSalida.Name = "tBoxArchivoSalida";
            tBoxArchivoSalida.Size = new Size(673, 23);
            tBoxArchivoSalida.TabIndex = 7;
            // 
            // lblTexto3
            // 
            lblTexto3.AutoSize = true;
            lblTexto3.Location = new Point(34, 141);
            lblTexto3.Name = "lblTexto3";
            lblTexto3.Size = new Size(112, 15);
            lblTexto3.TabIndex = 6;
            lblTexto3.Text = "Directorio de Salida.";
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(668, 402);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(75, 23);
            btnMenu.TabIndex = 9;
            btnMenu.Text = "Menú";
            btnMenu.UseMnemonic = false;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(38, 218);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(75, 23);
            btnGenerar.TabIndex = 10;
            btnGenerar.Text = "Generar.";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // Encontrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "Encontrar";
            Text = "Encontrar líneas.";
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