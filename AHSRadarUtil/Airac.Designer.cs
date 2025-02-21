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
            tBoxFijos = new TextBox();
            tBoxRadioAyudas = new TextBox();
            btnBuscarFix = new Button();
            btnVorNdb = new Button();
            dataGridView1 = new DataGridView();
            btnGenerar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tBoxFijos
            // 
            tBoxFijos.Location = new Point(15, 19);
            tBoxFijos.Margin = new Padding(2);
            tBoxFijos.Name = "tBoxFijos";
            tBoxFijos.Size = new Size(348, 23);
            tBoxFijos.TabIndex = 0;
            // 
            // tBoxRadioAyudas
            // 
            tBoxRadioAyudas.Location = new Point(15, 41);
            tBoxRadioAyudas.Margin = new Padding(2);
            tBoxRadioAyudas.Name = "tBoxRadioAyudas";
            tBoxRadioAyudas.Size = new Size(348, 23);
            tBoxRadioAyudas.TabIndex = 1;
            // 
            // btnBuscarFix
            // 
            btnBuscarFix.Location = new Point(367, 19);
            btnBuscarFix.Margin = new Padding(2);
            btnBuscarFix.Name = "btnBuscarFix";
            btnBuscarFix.Size = new Size(78, 20);
            btnBuscarFix.TabIndex = 2;
            btnBuscarFix.Text = "Buscar";
            btnBuscarFix.UseVisualStyleBackColor = true;
            btnBuscarFix.Click += btnBuscarFix_Click;
            // 
            // btnVorNdb
            // 
            btnVorNdb.Location = new Point(367, 44);
            btnVorNdb.Margin = new Padding(2);
            btnVorNdb.Name = "btnVorNdb";
            btnVorNdb.Size = new Size(78, 20);
            btnVorNdb.TabIndex = 3;
            btnVorNdb.Text = "Buscar";
            btnVorNdb.UseVisualStyleBackColor = true;
            btnVorNdb.Click += btnVorNdb_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 67);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(543, 190);
            dataGridView1.TabIndex = 4;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(459, 28);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(75, 23);
            btnGenerar.TabIndex = 5;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // Airac
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 270);
            Controls.Add(btnGenerar);
            Controls.Add(dataGridView1);
            Controls.Add(btnVorNdb);
            Controls.Add(btnBuscarFix);
            Controls.Add(tBoxRadioAyudas);
            Controls.Add(tBoxFijos);
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
    }
}