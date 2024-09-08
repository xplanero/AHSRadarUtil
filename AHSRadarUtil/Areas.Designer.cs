namespace AHSRadarUtil
{
    partial class Areas
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
            label1 = new Label();
            btnR_D_P = new Button();
            btnCargarArchivo = new Button();
            btnMenu = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 19);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(317, 25);
            label1.TabIndex = 5;
            label1.Text = "Extraer datos de archivo XML de areas,";
            // 
            // btnR_D_P
            // 
            btnR_D_P.Location = new Point(168, 74);
            btnR_D_P.Margin = new Padding(4, 5, 4, 5);
            btnR_D_P.Name = "btnR_D_P";
            btnR_D_P.Size = new Size(107, 38);
            btnR_D_P.TabIndex = 4;
            btnR_D_P.Text = "D R P";
            btnR_D_P.UseVisualStyleBackColor = true;
            btnR_D_P.Click += btnR_D_P_Click;
            // 
            // btnCargarArchivo
            // 
            btnCargarArchivo.Location = new Point(28, 75);
            btnCargarArchivo.Name = "btnCargarArchivo";
            btnCargarArchivo.Size = new Size(111, 33);
            btnCargarArchivo.TabIndex = 3;
            btnCargarArchivo.Text = "Todas";
            btnCargarArchivo.UseVisualStyleBackColor = true;
            btnCargarArchivo.Click += btnCargarArchivo_Click;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(323, 182);
            btnMenu.Margin = new Padding(4, 5, 4, 5);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(107, 38);
            btnMenu.TabIndex = 10;
            btnMenu.Text = "Menú";
            btnMenu.UseMnemonic = false;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // Areas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 253);
            Controls.Add(btnMenu);
            Controls.Add(label1);
            Controls.Add(btnR_D_P);
            Controls.Add(btnCargarArchivo);
            Name = "Areas";
            Text = "Areas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnR_D_P;
        private Button btnCargarArchivo;
        private Button btnMenu;
    }
}