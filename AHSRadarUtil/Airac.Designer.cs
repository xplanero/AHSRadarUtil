namespace AHSRadarUtil
{
    partial class Airac
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Airac));
            tBoxFijos = new TextBox();
            tBoxRadioAyudas = new TextBox();
            btnBuscarFix = new Button();
            btnVorNdb = new Button();
            dataGridView1 = new DataGridView();
            btnGenerar = new Button();
            lblENR41 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tBoxFijos
            // 
            tBoxFijos.Location = new Point(15, 22);
            tBoxFijos.Margin = new Padding(2);
            tBoxFijos.Name = "tBoxFijos";
            tBoxFijos.Size = new Size(348, 23);
            tBoxFijos.TabIndex = 0;
            // 
            // tBoxRadioAyudas
            // 
            tBoxRadioAyudas.Location = new Point(15, 67);
            tBoxRadioAyudas.Margin = new Padding(2);
            tBoxRadioAyudas.Name = "tBoxRadioAyudas";
            tBoxRadioAyudas.Size = new Size(348, 23);
            tBoxRadioAyudas.TabIndex = 1;
            // 
            // btnBuscarFix
            // 
            btnBuscarFix.Location = new Point(374, 22);
            btnBuscarFix.Margin = new Padding(2);
            btnBuscarFix.Name = "btnBuscarFix";
            btnBuscarFix.Size = new Size(78, 23);
            btnBuscarFix.TabIndex = 2;
            btnBuscarFix.Text = "Buscar";
            btnBuscarFix.UseVisualStyleBackColor = true;
            btnBuscarFix.Click += btnBuscarFix_Click;
            // 
            // btnVorNdb
            // 
            btnVorNdb.Location = new Point(374, 67);
            btnVorNdb.Margin = new Padding(2);
            btnVorNdb.Name = "btnVorNdb";
            btnVorNdb.Size = new Size(78, 23);
            btnVorNdb.TabIndex = 3;
            btnVorNdb.Text = "Buscar";
            btnVorNdb.UseVisualStyleBackColor = true;
            btnVorNdb.Click += btnVorNdb_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 98);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(543, 263);
            dataGridView1.TabIndex = 4;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(462, 46);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(75, 29);
            btnGenerar.TabIndex = 5;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // lblENR41
            // 
            lblENR41.AutoSize = true;
            lblENR41.Location = new Point(15, 5);
            lblENR41.Margin = new Padding(2, 0, 2, 0);
            lblENR41.Name = "lblENR41";
            lblENR41.Size = new Size(111, 15);
            lblENR41.TabIndex = 6;
            lblENR41.Text = "Archivo ENR 4.1 csv";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 49);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 7;
            label1.Text = "Archivo ENR 4.4 csv";
            // 
            // Airac
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 368);
            Controls.Add(label1);
            Controls.Add(lblENR41);
            Controls.Add(btnGenerar);
            Controls.Add(dataGridView1);
            Controls.Add(btnVorNdb);
            Controls.Add(btnBuscarFix);
            Controls.Add(tBoxRadioAyudas);
            Controls.Add(tBoxFijos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Airac";
            Text = "Airac";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tBoxFijos;
        private TextBox tBoxRadioAyudas;
        private Button btnBuscarFix;
        private Button btnVorNdb;
        private DataGridView dataGridView1;
        private Button btnGenerar;
        private Label lblENR41;
        private Label label1;
    }
}