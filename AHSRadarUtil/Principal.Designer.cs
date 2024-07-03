namespace AHSRadarUtil
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCirculo = new Button();
            SuspendLayout();
            // 
            // btnCirculo
            // 
            btnCirculo.Location = new Point(24, 30);
            btnCirculo.Name = "btnCirculo";
            btnCirculo.Size = new Size(112, 34);
            btnCirculo.TabIndex = 0;
            btnCirculo.Text = "Circulo";
            btnCirculo.UseVisualStyleBackColor = true;
            btnCirculo.Click += btnCirculo_Click;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCirculo);
            Name = "Principal";
            Text = "UTILIDADES RADAR AIRHISPANIA";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCirculo;
    }
}
