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
            lblText1.Location = new Point(21, 13);
            lblText1.Margin = new Padding(2, 0, 2, 0);
            lblText1.Name = "lblText1";
            lblText1.Size = new Size(169, 15);
            lblText1.TabIndex = 0;
            lblText1.Text = "Archivo de sectores rádar AHS.";
            // 
            // tBoxArchivoRadar
            // 
            tBoxArchivoRadar.Location = new Point(21, 29);
            tBoxArchivoRadar.Margin = new Padding(2);
            tBoxArchivoRadar.Name = "tBoxArchivoRadar";
            tBoxArchivoRadar.Size = new Size(626, 23);
            tBoxArchivoRadar.TabIndex = 1;
            // 
            // btnSelecFichRadar
            // 
            btnSelecFichRadar.Location = new Point(659, 29);
            btnSelecFichRadar.Margin = new Padding(2);
            btnSelecFichRadar.Name = "btnSelecFichRadar";
            btnSelecFichRadar.Size = new Size(78, 20);
            btnSelecFichRadar.TabIndex = 2;
            btnSelecFichRadar.Text = "Seleccionar";
            btnSelecFichRadar.UseVisualStyleBackColor = true;
            btnSelecFichRadar.Click += btnSelecFichRadar_Click;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(570, 77);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(75, 23);
            btnMenu.TabIndex = 10;
            btnMenu.Text = "Menú";
            btnMenu.UseMnemonic = false;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnAnalizar
            // 
            btnAnalizar.Location = new Point(28, 74);
            btnAnalizar.Margin = new Padding(2);
            btnAnalizar.Name = "btnAnalizar";
            btnAnalizar.Size = new Size(78, 23);
            btnAnalizar.TabIndex = 11;
            btnAnalizar.Text = "Analizar";
            btnAnalizar.UseVisualStyleBackColor = true;
            btnAnalizar.Click += btnAnalizar_Click;
            // 
            // IntFile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 125);
            Controls.Add(btnAnalizar);
            Controls.Add(btnMenu);
            Controls.Add(btnSelecFichRadar);
            Controls.Add(tBoxArchivoRadar);
            Controls.Add(lblText1);
            Margin = new Padding(2);
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