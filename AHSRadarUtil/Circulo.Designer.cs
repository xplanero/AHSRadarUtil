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
            // lblCentro
            // 
            lblCentro.AutoSize = true;
            lblCentro.Location = new Point(13, 17);
            lblCentro.Margin = new Padding(1, 0, 1, 0);
            lblCentro.Name = "lblCentro";
            lblCentro.Size = new Size(206, 25);
            lblCentro.TabIndex = 1;
            lblCentro.Text = "Coordenadas del centro:";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(159, 52);
            lblColor.Margin = new Padding(1, 0, 1, 0);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(59, 25);
            lblColor.TabIndex = 2;
            lblColor.Text = "Color:";
            // 
            // tBoxColor
            // 
            tBoxColor.Location = new Point(221, 50);
            tBoxColor.Margin = new Padding(1, 2, 1, 2);
            tBoxColor.Name = "tBoxColor";
            tBoxColor.Size = new Size(151, 31);
            tBoxColor.TabIndex = 3;
            tBoxColor.Text = "parking";
            // 
            // lblcantidad
            // 
            lblcantidad.AutoSize = true;
            lblcantidad.Location = new Point(50, 88);
            lblcantidad.Margin = new Padding(1, 0, 1, 0);
            lblcantidad.Name = "lblcantidad";
            lblcantidad.Size = new Size(171, 25);
            lblcantidad.TabIndex = 4;
            lblcantidad.Text = "1 o 2 para HELIPAD:";
            // 
            // tBoxNumero
            // 
            tBoxNumero.Location = new Point(221, 88);
            tBoxNumero.Margin = new Padding(1, 2, 1, 2);
            tBoxNumero.Name = "tBoxNumero";
            tBoxNumero.Size = new Size(28, 31);
            tBoxNumero.TabIndex = 5;
            tBoxNumero.Text = "1";
            // 
            // lblRadio1
            // 
            lblRadio1.AutoSize = true;
            lblRadio1.Location = new Point(84, 128);
            lblRadio1.Margin = new Padding(1, 0, 1, 0);
            lblRadio1.Name = "lblRadio1";
            lblRadio1.Size = new Size(133, 25);
            lblRadio1.TabIndex = 6;
            lblRadio1.Text = "Radio círculo 1:";
            // 
            // lblCirculo2
            // 
            lblCirculo2.AutoSize = true;
            lblCirculo2.Location = new Point(84, 165);
            lblCirculo2.Margin = new Padding(1, 0, 1, 0);
            lblCirculo2.Name = "lblCirculo2";
            lblCirculo2.Size = new Size(133, 25);
            lblCirculo2.TabIndex = 7;
            lblCirculo2.Text = "Radio círculo 2:";
            // 
            // tBoxRadio1
            // 
            tBoxRadio1.Location = new Point(221, 128);
            tBoxRadio1.Margin = new Padding(1, 2, 1, 2);
            tBoxRadio1.Name = "tBoxRadio1";
            tBoxRadio1.Size = new Size(41, 31);
            tBoxRadio1.TabIndex = 8;
            tBoxRadio1.Text = "5";
            // 
            // tBoxRadio2
            // 
            tBoxRadio2.Location = new Point(221, 165);
            tBoxRadio2.Margin = new Padding(1, 2, 1, 2);
            tBoxRadio2.Name = "tBoxRadio2";
            tBoxRadio2.Size = new Size(41, 31);
            tBoxRadio2.TabIndex = 9;
            tBoxRadio2.Text = "12";
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(149, 252);
            btnGenerar.Margin = new Padding(1, 2, 1, 2);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(113, 35);
            btnGenerar.TabIndex = 10;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(439, 252);
            btnMenu.Margin = new Padding(4, 5, 4, 5);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(107, 38);
            btnMenu.TabIndex = 11;
            btnMenu.Text = "MENÚ";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // tBoxCentro
            // 
            tBoxCentro.Location = new Point(221, 5);
            tBoxCentro.Margin = new Padding(4, 5, 4, 5);
            tBoxCentro.Name = "tBoxCentro";
            tBoxCentro.Size = new Size(323, 31);
            tBoxCentro.TabIndex = 12;
            tBoxCentro.Text = "N037.06.00.000 W004.33.43.000";
            // 
            // Circulo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 303);
            Controls.Add(tBoxCentro);
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
            Margin = new Padding(1, 2, 1, 2);
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
        private TextBox tBoxCentro;
    }
}