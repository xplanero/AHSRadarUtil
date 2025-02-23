namespace AHSRadarUtil
{
    partial class GoAround
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoAround));
            tBoxDestino = new TextBox();
            tBoxOrigen = new TextBox();
            btnMenu = new Button();
            btnProcesar = new Button();
            btnDestino = new Button();
            btnOrigen = new Button();
            SuspendLayout();
            // 
            // tBoxDestino
            // 
            tBoxDestino.Location = new Point(127, 72);
            tBoxDestino.Name = "tBoxDestino";
            tBoxDestino.Size = new Size(983, 31);
            tBoxDestino.TabIndex = 17;
            // 
            // tBoxOrigen
            // 
            tBoxOrigen.Location = new Point(127, 33);
            tBoxOrigen.Name = "tBoxOrigen";
            tBoxOrigen.Size = new Size(983, 31);
            tBoxOrigen.TabIndex = 16;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(997, 120);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(111, 33);
            btnMenu.TabIndex = 15;
            btnMenu.Text = "Menú";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnProcesar
            // 
            btnProcesar.Location = new Point(9, 120);
            btnProcesar.Name = "btnProcesar";
            btnProcesar.Size = new Size(111, 33);
            btnProcesar.TabIndex = 14;
            btnProcesar.Text = "Procesar";
            btnProcesar.UseVisualStyleBackColor = true;
            btnProcesar.Click += btnProcesar_Click;
            // 
            // btnDestino
            // 
            btnDestino.Location = new Point(9, 70);
            btnDestino.Name = "btnDestino";
            btnDestino.Size = new Size(111, 33);
            btnDestino.TabIndex = 13;
            btnDestino.Text = "Destino";
            btnDestino.UseVisualStyleBackColor = true;
            btnDestino.Click += btnDestino_Click;
            // 
            // btnOrigen
            // 
            btnOrigen.Location = new Point(9, 30);
            btnOrigen.Name = "btnOrigen";
            btnOrigen.Size = new Size(111, 33);
            btnOrigen.TabIndex = 12;
            btnOrigen.Text = "Origen";
            btnOrigen.UseVisualStyleBackColor = true;
            btnOrigen.Click += btnOrigen_Click;
            // 
            // GoAround
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 185);
            Controls.Add(tBoxDestino);
            Controls.Add(tBoxOrigen);
            Controls.Add(btnMenu);
            Controls.Add(btnProcesar);
            Controls.Add(btnDestino);
            Controls.Add(btnOrigen);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "GoAround";
            Text = "GoAround";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tBoxDestino;
        private TextBox tBoxOrigen;
        private Button btnMenu;
        private Button btnProcesar;
        private Button btnDestino;
        private Button btnOrigen;
    }
}