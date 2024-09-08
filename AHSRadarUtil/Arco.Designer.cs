namespace AHSRadarUtil
{
    partial class Arco
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
            btnMenu = new Button();
            btnGenerar = new Button();
            lblCentro = new Label();
            lblRadio = new Label();
            lblInicio = new Label();
            lblFin = new Label();
            tBoxCentro = new TextBox();
            tBoxRadio = new TextBox();
            tBoxPuntoInicio = new TextBox();
            tBoxPuntoFin = new TextBox();
            comboBoxSentido = new ComboBox();
            lblSentido = new Label();
            lblNSegmentos = new Label();
            tBoxNumeroSegmentos = new TextBox();
            SuspendLayout();
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(437, 387);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(112, 34);
            btnMenu.TabIndex = 1;
            btnMenu.Text = "MENÚ";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(66, 387);
            btnGenerar.Margin = new Padding(1, 2, 1, 2);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(113, 35);
            btnGenerar.TabIndex = 11;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // lblCentro
            // 
            lblCentro.AutoSize = true;
            lblCentro.Location = new Point(45, 43);
            lblCentro.Name = "lblCentro";
            lblCentro.Size = new Size(206, 25);
            lblCentro.TabIndex = 12;
            lblCentro.Text = "Coordenadas del centro:";
            // 
            // lblRadio
            // 
            lblRadio.AutoSize = true;
            lblRadio.Location = new Point(131, 89);
            lblRadio.Name = "lblRadio";
            lblRadio.Size = new Size(120, 25);
            lblRadio.TabIndex = 13;
            lblRadio.Text = "Radio en NM:";
            // 
            // lblInicio
            // 
            lblInicio.AutoSize = true;
            lblInicio.Location = new Point(66, 135);
            lblInicio.Name = "lblInicio";
            lblInicio.Size = new Size(193, 25);
            lblInicio.TabIndex = 14;
            lblInicio.Text = "Coordenadas de inicio:";
            // 
            // lblFin
            // 
            lblFin.AutoSize = true;
            lblFin.Location = new Point(66, 184);
            lblFin.Name = "lblFin";
            lblFin.Size = new Size(185, 25);
            lblFin.TabIndex = 15;
            lblFin.Text = "Coordenadas de final:";
            // 
            // tBoxCentro
            // 
            tBoxCentro.Location = new Point(262, 37);
            tBoxCentro.Name = "tBoxCentro";
            tBoxCentro.Size = new Size(287, 31);
            tBoxCentro.TabIndex = 16;
            tBoxCentro.Text = "N027.46.47.000 W015.30.24.000";
            // 
            // tBoxRadio
            // 
            tBoxRadio.Location = new Point(262, 83);
            tBoxRadio.Name = "tBoxRadio";
            tBoxRadio.Size = new Size(94, 31);
            tBoxRadio.TabIndex = 17;
            tBoxRadio.Text = "2,00";
            tBoxRadio.TextAlign = HorizontalAlignment.Right;
            // 
            // tBoxPuntoInicio
            // 
            tBoxPuntoInicio.Location = new Point(262, 129);
            tBoxPuntoInicio.Name = "tBoxPuntoInicio";
            tBoxPuntoInicio.Size = new Size(287, 31);
            tBoxPuntoInicio.TabIndex = 18;
            tBoxPuntoInicio.Text = "N027.44.49.000 W015.30.52.000";
            // 
            // tBoxPuntoFin
            // 
            tBoxPuntoFin.Location = new Point(262, 178);
            tBoxPuntoFin.Name = "tBoxPuntoFin";
            tBoxPuntoFin.Size = new Size(287, 31);
            tBoxPuntoFin.TabIndex = 19;
            tBoxPuntoFin.Text = "N027.48.33.000 W015.29.20.000";
            // 
            // comboBoxSentido
            // 
            comboBoxSentido.FormattingEnabled = true;
            comboBoxSentido.Location = new Point(264, 231);
            comboBoxSentido.Name = "comboBoxSentido";
            comboBoxSentido.Size = new Size(182, 33);
            comboBoxSentido.TabIndex = 20;
            comboBoxSentido.Text = "Horario";
            // 
            // lblSentido
            // 
            lblSentido.AutoSize = true;
            lblSentido.Location = new Point(112, 239);
            lblSentido.Name = "lblSentido";
            lblSentido.Size = new Size(139, 25);
            lblSentido.TabIndex = 21;
            lblSentido.Text = "Sentido de giro:";
            // 
            // lblNSegmentos
            // 
            lblNSegmentos.AutoSize = true;
            lblNSegmentos.Location = new Point(52, 288);
            lblNSegmentos.Name = "lblNSegmentos";
            lblNSegmentos.Size = new Size(199, 25);
            lblNSegmentos.TabIndex = 22;
            lblNSegmentos.Text = "Número de segmentos:";
            // 
            // tBoxNumeroSegmentos
            // 
            tBoxNumeroSegmentos.Location = new Point(264, 282);
            tBoxNumeroSegmentos.Name = "tBoxNumeroSegmentos";
            tBoxNumeroSegmentos.Size = new Size(79, 31);
            tBoxNumeroSegmentos.TabIndex = 23;
            tBoxNumeroSegmentos.Text = "18";
            tBoxNumeroSegmentos.TextAlign = HorizontalAlignment.Right;
            // 
            // Arco
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 455);
            Controls.Add(tBoxNumeroSegmentos);
            Controls.Add(lblNSegmentos);
            Controls.Add(lblSentido);
            Controls.Add(comboBoxSentido);
            Controls.Add(tBoxPuntoFin);
            Controls.Add(tBoxPuntoInicio);
            Controls.Add(tBoxRadio);
            Controls.Add(tBoxCentro);
            Controls.Add(lblFin);
            Controls.Add(lblInicio);
            Controls.Add(lblRadio);
            Controls.Add(lblCentro);
            Controls.Add(btnGenerar);
            Controls.Add(btnMenu);
            Name = "Arco";
            Text = "Construccion de arcos.";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMenu;
        private Button btnGenerar;
        private Label lblCentro;
        private Label lblRadio;
        private Label lblInicio;
        private Label lblFin;
        private TextBox tBoxCentro;
        private TextBox tBoxRadio;
        private TextBox tBoxPuntoInicio;
        private TextBox tBoxPuntoFin;
        private ComboBox comboBoxSentido;
        private Label lblSentido;
        private Label lblNSegmentos;
        private TextBox tBoxNumeroSegmentos;
    }
}