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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fixes));
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
            btnMwnu.Location = new Point(611, 154);
            btnMwnu.Name = "btnMwnu";
            btnMwnu.Size = new Size(112, 34);
            btnMwnu.TabIndex = 11;
            btnMwnu.Text = "MENÚ";
            btnMwnu.UseVisualStyleBackColor = true;
            btnMwnu.Click += btnMwnu_Click;
            // 
            // lblCoordAIP
            // 
            lblCoordAIP.AutoSize = true;
            lblCoordAIP.Location = new Point(173, 57);
            lblCoordAIP.Name = "lblCoordAIP";
            lblCoordAIP.Size = new Size(241, 25);
            lblCoordAIP.TabIndex = 10;
            lblCoordAIP.Text = "Archivo de coordenadas AIP.";
            // 
            // btnCoordAIP
            // 
            btnCoordAIP.Location = new Point(12, 52);
            btnCoordAIP.Name = "btnCoordAIP";
            btnCoordAIP.Size = new Size(138, 34);
            btnCoordAIP.TabIndex = 8;
            btnCoordAIP.Text = "Coord. AIP";
            btnCoordAIP.UseVisualStyleBackColor = true;
            btnCoordAIP.Click += btnCoordAIP_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(12, 91);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(138, 34);
            btnActualizar.TabIndex = 7;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnCoordAHS
            // 
            btnCoordAHS.Location = new Point(12, 12);
            btnCoordAHS.Name = "btnCoordAHS";
            btnCoordAHS.Size = new Size(138, 34);
            btnCoordAHS.TabIndex = 6;
            btnCoordAHS.Text = "Coord. AHS";
            btnCoordAHS.UseVisualStyleBackColor = true;
            btnCoordAHS.Click += btnCoordAHS_Click;
            // 
            // lblCoordAHS
            // 
            lblCoordAHS.AutoSize = true;
            lblCoordAHS.Location = new Point(173, 17);
            lblCoordAHS.Name = "lblCoordAHS";
            lblCoordAHS.Size = new Size(249, 25);
            lblCoordAHS.TabIndex = 12;
            lblCoordAHS.Text = "Archivo de coordenadas AHS.";
            // 
            // Fixes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 200);
            Controls.Add(lblCoordAHS);
            Controls.Add(btnMwnu);
            Controls.Add(lblCoordAIP);
            Controls.Add(btnCoordAIP);
            Controls.Add(btnActualizar);
            Controls.Add(btnCoordAHS);
            Icon = (Icon)resources.GetObject("$this.Icon");
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