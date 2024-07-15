namespace AHSRadarUtil
{
    partial class IntFile
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
            lblText1 = new Label();
            tBoxArchivoRadar = new TextBox();
            btnSelecFichRadar = new Button();
            btnMenu = new Button();
            btnAnalizar = new Button();
            SuspendLayout();
            // 
            // lblText1
            // 
            lblText1.AutoSize = true;
            lblText1.Location = new Point(30, 21);
            lblText1.Name = "lblText1";
            lblText1.Size = new Size(257, 25);
            lblText1.TabIndex = 0;
            lblText1.Text = "Archivo de sectores rádar AHS.";
            // 
            // tBoxArchivoRadar
            // 
            tBoxArchivoRadar.Location = new Point(30, 49);
            tBoxArchivoRadar.Name = "tBoxArchivoRadar";
            tBoxArchivoRadar.Size = new Size(892, 31);
            tBoxArchivoRadar.TabIndex = 1;
            // 
            // btnSelecFichRadar
            // 
            btnSelecFichRadar.Location = new Point(942, 49);
            btnSelecFichRadar.Name = "btnSelecFichRadar";
            btnSelecFichRadar.Size = new Size(112, 34);
            btnSelecFichRadar.TabIndex = 2;
            btnSelecFichRadar.Text = "Seleccionar";
            btnSelecFichRadar.UseVisualStyleBackColor = true;
            btnSelecFichRadar.Click += btnSelecFichRadar_Click;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(815, 128);
            btnMenu.Margin = new Padding(4, 5, 4, 5);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(107, 38);
            btnMenu.TabIndex = 10;
            btnMenu.Text = "Menú";
            btnMenu.UseMnemonic = false;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnAnalizar
            // 
            btnAnalizar.Location = new Point(40, 128);
            btnAnalizar.Name = "btnAnalizar";
            btnAnalizar.Size = new Size(112, 34);
            btnAnalizar.TabIndex = 11;
            btnAnalizar.Text = "Analizar";
            btnAnalizar.UseVisualStyleBackColor = true;
            btnAnalizar.Click += btnAnalizar_Click;
            // 
            // IntFile
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1088, 209);
            Controls.Add(btnAnalizar);
            Controls.Add(btnMenu);
            Controls.Add(btnSelecFichRadar);
            Controls.Add(tBoxArchivoRadar);
            Controls.Add(lblText1);
            Name = "IntFile";
            Text = "Integridad fichero de radar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblText1;
        private TextBox tBoxArchivoRadar;
        private Button btnSelecFichRadar;
        private Button btnMenu;
        private Button btnAnalizar;
    }
}