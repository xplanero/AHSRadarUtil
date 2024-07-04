namespace AHSRadarUtil
{
    partial class Circulo
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
            TextBox tBoxCentro;
            lblCentro = new Label();
            lblColor = new Label();
            tBoxColor = new TextBox();
            lblcantidad = new Label();
            tBoxNumero = new TextBox();
            lblRadio1 = new Label();
            lblCirculo2 = new Label();
            tBoxRadio1 = new TextBox();
            tBoxRadio2 = new TextBox();
            btnGenerar = new Button();
            btnMenu = new Button();
            tBoxCentro = new TextBox();
            SuspendLayout();
            // 
            // tBoxCentro
            // 
            tBoxCentro.Location = new Point(155, 7);
            tBoxCentro.Margin = new Padding(1);
            tBoxCentro.Name = "tBoxCentro";
            tBoxCentro.Size = new Size(210, 23);
            tBoxCentro.TabIndex = 0;
            tBoxCentro.Text = "N037.50.30.300 W002.50.30.300";
            // 
            // lblCentro
            // 
            lblCentro.AutoSize = true;
            lblCentro.Location = new Point(9, 10);
            lblCentro.Margin = new Padding(1, 0, 1, 0);
            lblCentro.Name = "lblCentro";
            lblCentro.Size = new Size(136, 15);
            lblCentro.TabIndex = 1;
            lblCentro.Text = "Coordenadas del centro:";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(111, 31);
            lblColor.Margin = new Padding(1, 0, 1, 0);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(39, 15);
            lblColor.TabIndex = 2;
            lblColor.Text = "Color:";
            // 
            // tBoxColor
            // 
            tBoxColor.Location = new Point(155, 30);
            tBoxColor.Margin = new Padding(1);
            tBoxColor.Name = "tBoxColor";
            tBoxColor.Size = new Size(107, 23);
            tBoxColor.TabIndex = 3;
            tBoxColor.Text = "parking";
            // 
            // lblcantidad
            // 
            lblcantidad.AutoSize = true;
            lblcantidad.Location = new Point(35, 53);
            lblcantidad.Margin = new Padding(1, 0, 1, 0);
            lblcantidad.Name = "lblcantidad";
            lblcantidad.Size = new Size(110, 15);
            lblcantidad.TabIndex = 4;
            lblcantidad.Text = "1 o 2 para HELIPAD:";
            // 
            // tBoxNumero
            // 
            tBoxNumero.Location = new Point(155, 53);
            tBoxNumero.Margin = new Padding(1);
            tBoxNumero.Name = "tBoxNumero";
            tBoxNumero.Size = new Size(21, 23);
            tBoxNumero.TabIndex = 5;
            tBoxNumero.Text = "1";
            // 
            // lblRadio1
            // 
            lblRadio1.AutoSize = true;
            lblRadio1.Location = new Point(59, 77);
            lblRadio1.Margin = new Padding(1, 0, 1, 0);
            lblRadio1.Name = "lblRadio1";
            lblRadio1.Size = new Size(88, 15);
            lblRadio1.TabIndex = 6;
            lblRadio1.Text = "Radio círculo 1:";
            // 
            // lblCirculo2
            // 
            lblCirculo2.AutoSize = true;
            lblCirculo2.Location = new Point(59, 99);
            lblCirculo2.Margin = new Padding(1, 0, 1, 0);
            lblCirculo2.Name = "lblCirculo2";
            lblCirculo2.Size = new Size(88, 15);
            lblCirculo2.TabIndex = 7;
            lblCirculo2.Text = "Radio círculo 2:";
            // 
            // tBoxRadio1
            // 
            tBoxRadio1.Location = new Point(155, 77);
            tBoxRadio1.Margin = new Padding(1);
            tBoxRadio1.Name = "tBoxRadio1";
            tBoxRadio1.Size = new Size(30, 23);
            tBoxRadio1.TabIndex = 8;
            tBoxRadio1.Text = "5";
            // 
            // tBoxRadio2
            // 
            tBoxRadio2.Location = new Point(155, 99);
            tBoxRadio2.Margin = new Padding(1);
            tBoxRadio2.Name = "tBoxRadio2";
            tBoxRadio2.Size = new Size(30, 23);
            tBoxRadio2.TabIndex = 9;
            tBoxRadio2.Text = "12";
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(104, 151);
            btnGenerar.Margin = new Padding(1);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(79, 21);
            btnGenerar.TabIndex = 10;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(307, 151);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(75, 23);
            btnMenu.TabIndex = 11;
            btnMenu.Text = "MENÚ";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // Circulo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 182);
            Controls.Add(btnMenu);
            Controls.Add(btnGenerar);
            Controls.Add(tBoxRadio2);
            Controls.Add(tBoxRadio1);
            Controls.Add(lblCirculo2);
            Controls.Add(lblRadio1);
            Controls.Add(tBoxNumero);
            Controls.Add(lblcantidad);
            Controls.Add(tBoxColor);
            Controls.Add(lblColor);
            Controls.Add(lblCentro);
            Controls.Add(tBoxCentro);
            Margin = new Padding(1);
            Name = "Circulo";
            Text = "Construcción de circulos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCentro;
        private Label lblColor;
        private TextBox tBoxColor;
        private Label lblcantidad;
        private TextBox tBoxNumero;
        private Label lblRadio1;
        private Label lblCirculo2;
        private TextBox tBoxRadio1;
        private TextBox tBoxRadio2;
        private Button btnGenerar;
        private Button btnMenu;
    }
}