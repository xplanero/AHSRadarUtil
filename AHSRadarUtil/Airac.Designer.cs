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
            tBoxFijos.Location = new Point(21, 37);
            tBoxFijos.Name = "tBoxFijos";
            tBoxFijos.Size = new Size(495, 31);
            tBoxFijos.TabIndex = 0;
            // 
            // tBoxRadioAyudas
            // 
            tBoxRadioAyudas.Location = new Point(21, 112);
            tBoxRadioAyudas.Name = "tBoxRadioAyudas";
            tBoxRadioAyudas.Size = new Size(495, 31);
            tBoxRadioAyudas.TabIndex = 1;
            // 
            // btnBuscarFix
            // 
            btnBuscarFix.Location = new Point(534, 37);
            btnBuscarFix.Name = "btnBuscarFix";
            btnBuscarFix.Size = new Size(111, 31);
            btnBuscarFix.TabIndex = 2;
            btnBuscarFix.Text = "Buscar";
            btnBuscarFix.UseVisualStyleBackColor = true;
            btnBuscarFix.Click += btnBuscarFix_Click;
            // 
            // btnVorNdb
            // 
            btnVorNdb.Location = new Point(534, 112);
            btnVorNdb.Name = "btnVorNdb";
            btnVorNdb.Size = new Size(111, 31);
            btnVorNdb.TabIndex = 3;
            btnVorNdb.Text = "Buscar";
            btnVorNdb.UseVisualStyleBackColor = true;
            btnVorNdb.Click += btnVorNdb_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 164);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(776, 438);
            dataGridView1.TabIndex = 4;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(660, 76);
            btnGenerar.Margin = new Padding(4, 5, 4, 5);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(107, 31);
            btnGenerar.TabIndex = 5;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // lblENR41
            // 
            lblENR41.AutoSize = true;
            lblENR41.Location = new Point(21, 9);
            lblENR41.Name = "lblENR41";
            lblENR41.Size = new Size(169, 25);
            lblENR41.TabIndex = 6;
            lblENR41.Text = "Archivo ENR 4.1 csv";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 82);
            label1.Name = "label1";
            label1.Size = new Size(169, 25);
            label1.TabIndex = 7;
            label1.Text = "Archivo ENR 4.4 csv";
            // 
            // Airac
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 614);
            Controls.Add(label1);
            Controls.Add(lblENR41);
            Controls.Add(btnGenerar);
            Controls.Add(dataGridView1);
            Controls.Add(btnVorNdb);
            Controls.Add(btnBuscarFix);
            Controls.Add(tBoxRadioAyudas);
            Controls.Add(tBoxFijos);
            Icon = (Icon)resources.GetObject("$this.Icon");
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