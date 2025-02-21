namespace AHSRadarUtil
{
    partial class CopiarArchivo
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
            btnMwnu = new Button();
            lstCarpetas = new ListBox();
            lblCarpetaDestino = new Label();
            btnSeleccionarCarpeta = new Button();
            btnSeleccionarDestino = new Button();
            btnCopiarArchivos = new Button();
            btnEliminarSeleccion = new Button();
            SuspendLayout();
            // 
            // btnMwnu
            // 
            btnMwnu.Location = new Point(655, 267);
            btnMwnu.Name = "btnMwnu";
            btnMwnu.Size = new Size(112, 34);
            btnMwnu.TabIndex = 5;
            btnMwnu.Text = "MENÚ";
            btnMwnu.UseVisualStyleBackColor = true;
            btnMwnu.Click += btnMwnu_Click;
            // 
            // lstCarpetas
            // 
            lstCarpetas.FormattingEnabled = true;
            lstCarpetas.ItemHeight = 25;
            lstCarpetas.Location = new Point(170, 12);
            lstCarpetas.Name = "lstCarpetas";
            lstCarpetas.Size = new Size(597, 229);
            lstCarpetas.TabIndex = 6;
            // 
            // lblCarpetaDestino
            // 
            lblCarpetaDestino.AutoSize = true;
            lblCarpetaDestino.Location = new Point(170, 251);
            lblCarpetaDestino.Name = "lblCarpetaDestino";
            lblCarpetaDestino.Size = new Size(59, 25);
            lblCarpetaDestino.TabIndex = 7;
            lblCarpetaDestino.Text = "label1";
            // 
            // btnSeleccionarCarpeta
            // 
            btnSeleccionarCarpeta.Location = new Point(12, 12);
            btnSeleccionarCarpeta.Name = "btnSeleccionarCarpeta";
            btnSeleccionarCarpeta.Size = new Size(112, 34);
            btnSeleccionarCarpeta.TabIndex = 8;
            btnSeleccionarCarpeta.Text = "Seleccionar";
            btnSeleccionarCarpeta.UseVisualStyleBackColor = true;
            btnSeleccionarCarpeta.Click += btnSeleccionarCarpetas_Click;
            // 
            // btnSeleccionarDestino
            // 
            btnSeleccionarDestino.Location = new Point(12, 52);
            btnSeleccionarDestino.Name = "btnSeleccionarDestino";
            btnSeleccionarDestino.Size = new Size(112, 34);
            btnSeleccionarDestino.TabIndex = 9;
            btnSeleccionarDestino.Text = "Destino";
            btnSeleccionarDestino.UseVisualStyleBackColor = true;
            btnSeleccionarDestino.Click += btnSeleccionarDestino_Click;
            // 
            // btnCopiarArchivos
            // 
            btnCopiarArchivos.Location = new Point(12, 92);
            btnCopiarArchivos.Name = "btnCopiarArchivos";
            btnCopiarArchivos.Size = new Size(112, 34);
            btnCopiarArchivos.TabIndex = 10;
            btnCopiarArchivos.Text = "Copiar";
            btnCopiarArchivos.UseVisualStyleBackColor = true;
            btnCopiarArchivos.Click += btnCopiarArchivos_Click;
            // 
            // btnEliminarSeleccion
            // 
            btnEliminarSeleccion.Location = new Point(12, 132);
            btnEliminarSeleccion.Name = "btnEliminarSeleccion";
            btnEliminarSeleccion.Size = new Size(112, 34);
            btnEliminarSeleccion.TabIndex = 11;
            btnEliminarSeleccion.Text = "Eliminar";
            btnEliminarSeleccion.UseVisualStyleBackColor = true;
            btnEliminarSeleccion.Click += btnEliminarSeleccion_Click;
            // 
            // CopiarArchivo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(811, 325);
            Controls.Add(btnEliminarSeleccion);
            Controls.Add(btnCopiarArchivos);
            Controls.Add(btnSeleccionarDestino);
            Controls.Add(btnSeleccionarCarpeta);
            Controls.Add(lblCarpetaDestino);
            Controls.Add(lstCarpetas);
            Controls.Add(btnMwnu);
            Name = "CopiarArchivo";
            Text = "CopiarArchivo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnMwnu;
        private ListBox lstCarpetas;
        private Label lblCarpetaDestino;
        private Button btnSeleccionarCarpeta;
        private Button btnSeleccionarDestino;
        private Button btnCopiarArchivos;
        private Button btnEliminarSeleccion;
    }
}