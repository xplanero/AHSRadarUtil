namespace AHSRadarUtil
{
    partial class BuscarPunto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarPunto));
            tBoxBusqueda = new TextBox();
            listBoxResultados = new ListBox();
            SuspendLayout();
            // 
            // tBoxBusqueda
            // 
            tBoxBusqueda.Location = new Point(495, 395);
            tBoxBusqueda.Name = "tBoxBusqueda";
            tBoxBusqueda.Size = new Size(150, 31);
            tBoxBusqueda.TabIndex = 0;
            tBoxBusqueda.TextChanged += tBoxBusqueda_TextChanged;
            // 
            // listBoxResultados
            // 
            listBoxResultados.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxResultados.FormattingEnabled = true;
            listBoxResultados.ItemHeight = 22;
            listBoxResultados.Location = new Point(12, 3);
            listBoxResultados.Name = "listBoxResultados";
            listBoxResultados.Size = new Size(776, 378);
            listBoxResultados.TabIndex = 1;
            listBoxResultados.DoubleClick += listBoxResultados_DoubleClick;
            // 
            // BuscarPunto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxResultados);
            Controls.Add(tBoxBusqueda);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BuscarPunto";
            Text = "BuscarPunto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tBoxBusqueda;
        private ListBox listBoxResultados;
    }
}