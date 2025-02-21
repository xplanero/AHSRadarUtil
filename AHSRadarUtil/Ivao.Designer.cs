namespace AHSRadarUtil
{
    partial class Ivao
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
            btnAreasHigh = new Button();
            btnMenu = new Button();
            btnHolding = new Button();
            SuspendLayout();
            // 
            // btnAreasHigh
            // 
            btnAreasHigh.Location = new Point(40, 34);
            btnAreasHigh.Margin = new Padding(4, 4, 4, 4);
            btnAreasHigh.Name = "btnAreasHigh";
            btnAreasHigh.Size = new Size(134, 41);
            btnAreasHigh.TabIndex = 0;
            btnAreasHigh.Text = "Areas H";
            btnAreasHigh.UseVisualStyleBackColor = true;
            btnAreasHigh.Click += btnAreasHigh_Click;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(416, 247);
            btnMenu.Margin = new Padding(5, 6, 5, 6);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(128, 46);
            btnMenu.TabIndex = 11;
            btnMenu.Text = "Menú";
            btnMenu.UseMnemonic = false;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnHolding
            // 
            btnHolding.Location = new Point(40, 83);
            btnHolding.Margin = new Padding(4);
            btnHolding.Name = "btnHolding";
            btnHolding.Size = new Size(134, 41);
            btnHolding.TabIndex = 12;
            btnHolding.Text = "Holding";
            btnHolding.UseVisualStyleBackColor = true;
            btnHolding.Click += btnHolding_Click;
            // 
            // Ivao
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(606, 326);
            Controls.Add(btnHolding);
            Controls.Add(btnMenu);
            Controls.Add(btnAreasHigh);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Ivao";
            Text = "Ivao";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAreasHigh;
        private Button btnMenu;
        private Button btnHolding;
    }
}