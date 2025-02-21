namespace AHSRadarUtil
{
    partial class Fixes
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
            btnMwnu = new Button();
            lblCoordAIP = new Label();
            btnCoordAIP = new Button();
            btnActualizar = new Button();
            btnCoordAHS = new Button();
            lblCoordAHS = new Label();
            SuspendLayout();
            // 
            // btnMwnu
            // 
            btnMwnu.Location = new Point(916, 228);
            btnMwnu.Margin = new Padding(4, 4, 4, 4);
            btnMwnu.Name = "btnMwnu";
            btnMwnu.Size = new Size(168, 50);
            btnMwnu.TabIndex = 11;
            btnMwnu.Text = "MENÚ";
            btnMwnu.UseVisualStyleBackColor = true;
            btnMwnu.Click += btnMwnu_Click;
            // 
            // lblCoordAIP
            // 
            lblCoordAIP.AutoSize = true;
            lblCoordAIP.Location = new Point(260, 84);
            lblCoordAIP.Margin = new Padding(4, 0, 4, 0);
            lblCoordAIP.Name = "lblCoordAIP";
            lblCoordAIP.Size = new Size(355, 37);
            lblCoordAIP.TabIndex = 10;
            lblCoordAIP.Text = "Archivo de coordenadas AIP.";
            // 
            // btnCoordAIP
            // 
            btnCoordAIP.Location = new Point(18, 77);
            btnCoordAIP.Margin = new Padding(4, 4, 4, 4);
            btnCoordAIP.Name = "btnCoordAIP";
            btnCoordAIP.Size = new Size(207, 50);
            btnCoordAIP.TabIndex = 8;
            btnCoordAIP.Text = "Coord. AIP";
            btnCoordAIP.UseVisualStyleBackColor = true;
            btnCoordAIP.Click += btnCoordAIP_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(18, 135);
            btnActualizar.Margin = new Padding(4, 4, 4, 4);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(207, 50);
            btnActualizar.TabIndex = 7;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnCoordAHS
            // 
            btnCoordAHS.Location = new Point(18, 18);
            btnCoordAHS.Margin = new Padding(4, 4, 4, 4);
            btnCoordAHS.Name = "btnCoordAHS";
            btnCoordAHS.Size = new Size(207, 50);
            btnCoordAHS.TabIndex = 6;
            btnCoordAHS.Text = "Coord. AHS";
            btnCoordAHS.UseVisualStyleBackColor = true;
            btnCoordAHS.Click += btnCoordAHS_Click;
            // 
            // lblCoordAHS
            // 
            lblCoordAHS.AutoSize = true;
            lblCoordAHS.Location = new Point(260, 25);
            lblCoordAHS.Margin = new Padding(4, 0, 4, 0);
            lblCoordAHS.Name = "lblCoordAHS";
            lblCoordAHS.Size = new Size(366, 37);
            lblCoordAHS.TabIndex = 12;
            lblCoordAHS.Text = "Archivo de coordenadas AHS.";
            // 
            // Fixes
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1102, 296);
            Controls.Add(lblCoordAHS);
            Controls.Add(btnMwnu);
            Controls.Add(lblCoordAIP);
            Controls.Add(btnCoordAIP);
            Controls.Add(btnActualizar);
            Controls.Add(btnCoordAHS);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Fixes";
            Text = "Fixes";
            Load += Fixes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMwnu;
        private Label lblCoordAIP;
        private Button btnCoordAIP;
        private Button btnActualizar;
        private Button btnCoordAHS;
        private Label lblCoordAHS;
    }
}