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
            tBoxCentro = new TextBox();
            SuspendLayout();
            // 
            // tBoxCentro
            // 
            tBoxCentro.Location = new Point(332, 18);
            tBoxCentro.Name = "tBoxCentro";
            tBoxCentro.Size = new Size(445, 43);
            tBoxCentro.TabIndex = 0;
            tBoxCentro.Text = "N037.50.30.300 W002.50.30.300";
            // 
            // lblCentro
            // 
            lblCentro.AutoSize = true;
            lblCentro.Location = new Point(19, 24);
            lblCentro.Name = "lblCentro";
            lblCentro.Size = new Size(307, 37);
            lblCentro.TabIndex = 1;
            lblCentro.Text = "Coordenadas del centro:";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(238, 76);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(88, 37);
            lblColor.TabIndex = 2;
            lblColor.Text = "Color:";
            // 
            // tBoxColor
            // 
            tBoxColor.Location = new Point(332, 73);
            tBoxColor.Name = "tBoxColor";
            tBoxColor.Size = new Size(225, 43);
            tBoxColor.TabIndex = 3;
            tBoxColor.Text = "parking";
            // 
            // lblcantidad
            // 
            lblcantidad.AutoSize = true;
            lblcantidad.Location = new Point(74, 130);
            lblcantidad.Name = "lblcantidad";
            lblcantidad.Size = new Size(252, 37);
            lblcantidad.TabIndex = 4;
            lblcantidad.Text = "1 o 2 para HELIPAD:";
            // 
            // tBoxNumero
            // 
            tBoxNumero.Location = new Point(332, 130);
            tBoxNumero.Name = "tBoxNumero";
            tBoxNumero.Size = new Size(40, 43);
            tBoxNumero.TabIndex = 5;
            tBoxNumero.Text = "1";
            // 
            // lblRadio1
            // 
            lblRadio1.AutoSize = true;
            lblRadio1.Location = new Point(127, 190);
            lblRadio1.Name = "lblRadio1";
            lblRadio1.Size = new Size(199, 37);
            lblRadio1.TabIndex = 6;
            lblRadio1.Text = "Radio círculo 1:";
            // 
            // lblCirculo2
            // 
            lblCirculo2.AutoSize = true;
            lblCirculo2.Location = new Point(127, 245);
            lblCirculo2.Name = "lblCirculo2";
            lblCirculo2.Size = new Size(199, 37);
            lblCirculo2.TabIndex = 7;
            lblCirculo2.Text = "Radio círculo 2:";
            // 
            // tBoxRadio1
            // 
            tBoxRadio1.Location = new Point(332, 190);
            tBoxRadio1.Name = "tBoxRadio1";
            tBoxRadio1.Size = new Size(60, 43);
            tBoxRadio1.TabIndex = 8;
            tBoxRadio1.Text = "5";
            // 
            // tBoxRadio2
            // 
            tBoxRadio2.Location = new Point(332, 245);
            tBoxRadio2.Name = "tBoxRadio2";
            tBoxRadio2.Size = new Size(60, 43);
            tBoxRadio2.TabIndex = 9;
            tBoxRadio2.Text = "12";
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(223, 373);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(169, 52);
            btnGenerar.TabIndex = 10;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            // 
            // Circulo
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 450);
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
    }
}