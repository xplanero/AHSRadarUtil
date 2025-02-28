namespace AHSRadarUtil
{
    partial class SQlite
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
            dataGridView1 = new DataGridView();
            treeView1 = new TreeView();
            tBoxAeropuerto = new TextBox();
            btnBuscarTaxi = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 96);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1654, 731);
            dataGridView1.TabIndex = 0;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(1713, 12);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(642, 815);
            treeView1.TabIndex = 1;
            // 
            // tBoxAeropuerto
            // 
            tBoxAeropuerto.Location = new Point(29, 32);
            tBoxAeropuerto.Name = "tBoxAeropuerto";
            tBoxAeropuerto.Size = new Size(150, 31);
            tBoxAeropuerto.TabIndex = 2;
            // 
            // btnBuscarTaxi
            // 
            btnBuscarTaxi.Location = new Point(199, 32);
            btnBuscarTaxi.Name = "btnBuscarTaxi";
            btnBuscarTaxi.Size = new Size(112, 34);
            btnBuscarTaxi.TabIndex = 3;
            btnBuscarTaxi.Text = "Taxi";
            btnBuscarTaxi.UseVisualStyleBackColor = true;
            btnBuscarTaxi.Click += btnBuscarTaxi_Click;
            // 
            // SQlite
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2386, 839);
            Controls.Add(btnBuscarTaxi);
            Controls.Add(tBoxAeropuerto);
            Controls.Add(treeView1);
            Controls.Add(dataGridView1);
            Name = "SQlite";
            Text = "SQlite";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TreeView treeView1;
        private TextBox tBoxAeropuerto;
        private Button btnBuscarTaxi;
    }
}