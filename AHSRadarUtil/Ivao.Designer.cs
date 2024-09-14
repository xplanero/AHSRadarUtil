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
            SuspendLayout();
            // 
            // btnAreasHigh
            // 
            btnAreasHigh.Location = new Point(33, 28);
            btnAreasHigh.Name = "btnAreasHigh";
            btnAreasHigh.Size = new Size(112, 34);
            btnAreasHigh.TabIndex = 0;
            btnAreasHigh.Text = "Areas H";
            btnAreasHigh.UseVisualStyleBackColor = true;
            btnAreasHigh.Click += btnAreasHigh_Click;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(347, 206);
            btnMenu.Margin = new Padding(4, 5, 4, 5);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(107, 38);
            btnMenu.TabIndex = 11;
            btnMenu.Text = "Menú";
            btnMenu.UseMnemonic = false;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // Ivao
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 272);
            Controls.Add(btnMenu);
            Controls.Add(btnAreasHigh);
            Name = "Ivao";
            Text = "Ivao";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAreasHigh;
        private Button btnMenu;
    }
}