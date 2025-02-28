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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ivao));
            btnAreasHigh = new Button();
            btnMenu = new Button();
            btnHolding = new Button();
            btnSQlite = new Button();
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
            btnMenu.Location = new Point(290, 176);
            btnMenu.Margin = new Padding(4, 5, 4, 5);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(107, 38);
            btnMenu.TabIndex = 11;
            btnMenu.Text = "Menú";
            btnMenu.UseMnemonic = false;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnHolding
            // 
            btnHolding.Location = new Point(33, 69);
            btnHolding.Name = "btnHolding";
            btnHolding.Size = new Size(112, 34);
            btnHolding.TabIndex = 12;
            btnHolding.Text = "Holding";
            btnHolding.UseVisualStyleBackColor = true;
            btnHolding.Click += btnHolding_Click;
            // 
            // btnSQlite
            // 
            btnSQlite.Location = new Point(274, 59);
            btnSQlite.Name = "btnSQlite";
            btnSQlite.Size = new Size(112, 34);
            btnSQlite.TabIndex = 13;
            btnSQlite.Text = "SQlite";
            btnSQlite.UseVisualStyleBackColor = true;
            btnSQlite.Click += btnSQlite_Click;
            // 
            // Ivao
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 221);
            Controls.Add(btnSQlite);
            Controls.Add(btnHolding);
            Controls.Add(btnMenu);
            Controls.Add(btnAreasHigh);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Ivao";
            Text = "Ivao";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAreasHigh;
        private Button btnMenu;
        private Button btnHolding;
        private Button btnSQlite;
    }
}