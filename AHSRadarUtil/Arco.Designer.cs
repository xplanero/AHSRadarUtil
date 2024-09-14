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
            lblRadio = new Label();
            lblInicio = new Label();
            lblFin = new Label();
            tBoxRadio = new TextBox();
            tBoxPuntoInicio = new TextBox();
            tBoxPuntoFin = new TextBox();
            comboBoxSentido = new ComboBox();
            lblSentido = new Label();
            lblNSegmentos = new Label();
            tBoxNumeroSegmentos = new TextBox();
            lblCentroCirculo = new Label();
            tBoxCentro = new TextBox();
            lblNumeroEspacios = new Label();
            tBoxNumeroEspacios = new TextBox();
            btnCalcularEquidistancia = new Button();
            lblPuntoEquidistante1 = new Label();
            lblPuntoEquidistante2 = new Label();
            btnArco180 = new Button();
            btnArcoRadio = new Button();
            tBoxEquidistancia = new TextBox();
            btnLeerArchivoMarcas = new Button();
            lblArchivoMarcas = new Label();
            tBoxArchivoMarcas = new TextBox();
            btnBuscarMarcas = new Button();
            SuspendLayout();
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(529, 916);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(111, 33);
            btnMenu.TabIndex = 1;
            btnMenu.Text = "MENÚ";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // lblRadio
            // 
            lblRadio.AutoSize = true;
            lblRadio.Location = new Point(109, 27);
            lblRadio.Name = "lblRadio";
            lblRadio.Size = new Size(120, 25);
            lblRadio.TabIndex = 13;
            lblRadio.Text = "Radio en NM:";
            // 
            // lblInicio
            // 
            lblInicio.AutoSize = true;
            lblInicio.Location = new Point(36, 64);
            lblInicio.Name = "lblInicio";
            lblInicio.Size = new Size(193, 25);
            lblInicio.TabIndex = 14;
            lblInicio.Text = "Coordenadas de inicio:";
            // 
            // lblFin
            // 
            lblFin.AutoSize = true;
            lblFin.Location = new Point(44, 98);
            lblFin.Name = "lblFin";
            lblFin.Size = new Size(185, 25);
            lblFin.TabIndex = 15;
            lblFin.Text = "Coordenadas de final:";
            // 
            // tBoxRadio
            // 
            tBoxRadio.Location = new Point(239, 24);
            tBoxRadio.Name = "tBoxRadio";
            tBoxRadio.Size = new Size(94, 31);
            tBoxRadio.TabIndex = 17;
            tBoxRadio.Text = "3";
            tBoxRadio.TextAlign = HorizontalAlignment.Right;
            // 
            // tBoxPuntoInicio
            // 
            tBoxPuntoInicio.Location = new Point(239, 61);
            tBoxPuntoInicio.Name = "tBoxPuntoInicio";
            tBoxPuntoInicio.Size = new Size(287, 31);
            tBoxPuntoInicio.TabIndex = 18;
            tBoxPuntoInicio.Text = "N028.33.42.679 W016.16.14.768";
            // 
            // tBoxPuntoFin
            // 
            tBoxPuntoFin.Location = new Point(239, 98);
            tBoxPuntoFin.Name = "tBoxPuntoFin";
            tBoxPuntoFin.Size = new Size(287, 31);
            tBoxPuntoFin.TabIndex = 19;
            tBoxPuntoFin.Text = "N028.32.47.376 W016.18.07.825";
            // 
            // comboBoxSentido
            // 
            comboBoxSentido.FormattingEnabled = true;
            comboBoxSentido.Location = new Point(239, 172);
            comboBoxSentido.Name = "comboBoxSentido";
            comboBoxSentido.Size = new Size(183, 33);
            comboBoxSentido.TabIndex = 20;
            comboBoxSentido.Text = "Horario";
            // 
            // lblSentido
            // 
            lblSentido.AutoSize = true;
            lblSentido.Location = new Point(90, 175);
            lblSentido.Name = "lblSentido";
            lblSentido.Size = new Size(139, 25);
            lblSentido.TabIndex = 21;
            lblSentido.Text = "Sentido de giro:";
            // 
            // lblNSegmentos
            // 
            lblNSegmentos.AutoSize = true;
            lblNSegmentos.Location = new Point(26, 214);
            lblNSegmentos.Name = "lblNSegmentos";
            lblNSegmentos.Size = new Size(199, 25);
            lblNSegmentos.TabIndex = 22;
            lblNSegmentos.Text = "Número de segmentos:";
            // 
            // tBoxNumeroSegmentos
            // 
            tBoxNumeroSegmentos.Location = new Point(239, 211);
            tBoxNumeroSegmentos.Name = "tBoxNumeroSegmentos";
            tBoxNumeroSegmentos.Size = new Size(78, 31);
            tBoxNumeroSegmentos.TabIndex = 23;
            tBoxNumeroSegmentos.Text = "18";
            tBoxNumeroSegmentos.TextAlign = HorizontalAlignment.Right;
            // 
            // lblCentroCirculo
            // 
            lblCentroCirculo.AutoSize = true;
            lblCentroCirculo.Location = new Point(49, 138);
            lblCentroCirculo.Name = "lblCentroCirculo";
            lblCentroCirculo.Size = new Size(180, 25);
            lblCentroCirculo.TabIndex = 24;
            lblCentroCirculo.Text = "Coordenadas Centro:";
            // 
            // tBoxCentro
            // 
            tBoxCentro.Location = new Point(239, 135);
            tBoxCentro.Name = "tBoxCentro";
            tBoxCentro.Size = new Size(287, 31);
            tBoxCentro.TabIndex = 25;
            tBoxCentro.Text = "N028.34.58.773 W016.18.34.315";
            // 
            // lblNumeroEspacios
            // 
            lblNumeroEspacios.AutoSize = true;
            lblNumeroEspacios.Location = new Point(44, 251);
            lblNumeroEspacios.Name = "lblNumeroEspacios";
            lblNumeroEspacios.Size = new Size(179, 25);
            lblNumeroEspacios.TabIndex = 26;
            lblNumeroEspacios.Text = "Número de espacios:";
            // 
            // tBoxNumeroEspacios
            // 
            tBoxNumeroEspacios.Location = new Point(239, 248);
            tBoxNumeroEspacios.Name = "tBoxNumeroEspacios";
            tBoxNumeroEspacios.Size = new Size(78, 31);
            tBoxNumeroEspacios.TabIndex = 27;
            tBoxNumeroEspacios.Text = "26";
            tBoxNumeroEspacios.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCalcularEquidistancia
            // 
            btnCalcularEquidistancia.Location = new Point(62, 714);
            btnCalcularEquidistancia.Margin = new Padding(4, 5, 4, 5);
            btnCalcularEquidistancia.Name = "btnCalcularEquidistancia";
            btnCalcularEquidistancia.Size = new Size(229, 38);
            btnCalcularEquidistancia.TabIndex = 28;
            btnCalcularEquidistancia.Text = "Calcular equidistancia";
            btnCalcularEquidistancia.UseVisualStyleBackColor = true;
            btnCalcularEquidistancia.Click += btnCalcularEquidistancia_Click;
            // 
            // lblPuntoEquidistante1
            // 
            lblPuntoEquidistante1.AutoSize = true;
            lblPuntoEquidistante1.Location = new Point(73, 883);
            lblPuntoEquidistante1.Margin = new Padding(4, 0, 4, 0);
            lblPuntoEquidistante1.Name = "lblPuntoEquidistante1";
            lblPuntoEquidistante1.Size = new Size(59, 25);
            lblPuntoEquidistante1.TabIndex = 29;
            lblPuntoEquidistante1.Text = "label1";
            // 
            // lblPuntoEquidistante2
            // 
            lblPuntoEquidistante2.AutoSize = true;
            lblPuntoEquidistante2.Location = new Point(73, 924);
            lblPuntoEquidistante2.Margin = new Padding(4, 0, 4, 0);
            lblPuntoEquidistante2.Name = "lblPuntoEquidistante2";
            lblPuntoEquidistante2.Size = new Size(59, 25);
            lblPuntoEquidistante2.TabIndex = 30;
            lblPuntoEquidistante2.Text = "label2";
            // 
            // btnArco180
            // 
            btnArco180.Location = new Point(65, 809);
            btnArco180.Margin = new Padding(4, 5, 4, 5);
            btnArco180.Name = "btnArco180";
            btnArco180.Size = new Size(229, 38);
            btnArco180.TabIndex = 31;
            btnArco180.Text = "Arco 2 puntos 180";
            btnArco180.UseVisualStyleBackColor = true;
            btnArco180.Click += btnArco180_Click;
            // 
            // btnArcoRadio
            // 
            btnArcoRadio.Location = new Point(69, 624);
            btnArcoRadio.Margin = new Padding(4, 5, 4, 5);
            btnArcoRadio.Name = "btnArcoRadio";
            btnArcoRadio.Size = new Size(229, 38);
            btnArcoRadio.TabIndex = 32;
            btnArcoRadio.Text = "Arco 2 puntos Radio";
            btnArcoRadio.UseVisualStyleBackColor = true;
            btnArcoRadio.Click += btnArcoRadio_Click;
            // 
            // tBoxEquidistancia
            // 
            tBoxEquidistancia.Location = new Point(299, 716);
            tBoxEquidistancia.Margin = new Padding(4, 5, 4, 5);
            tBoxEquidistancia.Name = "tBoxEquidistancia";
            tBoxEquidistancia.Size = new Size(338, 31);
            tBoxEquidistancia.TabIndex = 33;
            // 
            // btnLeerArchivoMarcas
            // 
            btnLeerArchivoMarcas.Location = new Point(325, 628);
            btnLeerArchivoMarcas.Name = "btnLeerArchivoMarcas";
            btnLeerArchivoMarcas.Size = new Size(248, 34);
            btnLeerArchivoMarcas.TabIndex = 34;
            btnLeerArchivoMarcas.Text = "Leer archivo de marcas.";
            btnLeerArchivoMarcas.UseVisualStyleBackColor = true;
            btnLeerArchivoMarcas.Click += btnLeerArchivoMarcas_Click;
            // 
            // lblArchivoMarcas
            // 
            lblArchivoMarcas.AutoSize = true;
            lblArchivoMarcas.Location = new Point(49, 287);
            lblArchivoMarcas.Name = "lblArchivoMarcas";
            lblArchivoMarcas.Size = new Size(162, 25);
            lblArchivoMarcas.TabIndex = 35;
            lblArchivoMarcas.Text = "Archivo de marcas:";
            // 
            // tBoxArchivoMarcas
            // 
            tBoxArchivoMarcas.Location = new Point(239, 285);
            tBoxArchivoMarcas.Name = "tBoxArchivoMarcas";
            tBoxArchivoMarcas.Size = new Size(595, 31);
            tBoxArchivoMarcas.TabIndex = 36;
            // 
            // btnBuscarMarcas
            // 
            btnBuscarMarcas.Location = new Point(860, 287);
            btnBuscarMarcas.Name = "btnBuscarMarcas";
            btnBuscarMarcas.Size = new Size(112, 34);
            btnBuscarMarcas.TabIndex = 37;
            btnBuscarMarcas.Text = "Buscar";
            btnBuscarMarcas.UseVisualStyleBackColor = true;
            btnBuscarMarcas.Click += btnBuscarMarcas_Click;
            // 
            // Arco
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1521, 1008);
            Controls.Add(btnBuscarMarcas);
            Controls.Add(tBoxArchivoMarcas);
            Controls.Add(lblArchivoMarcas);
            Controls.Add(btnLeerArchivoMarcas);
            Controls.Add(tBoxEquidistancia);
            Controls.Add(btnArcoRadio);
            Controls.Add(btnArco180);
            Controls.Add(lblPuntoEquidistante2);
            Controls.Add(lblPuntoEquidistante1);
            Controls.Add(btnCalcularEquidistancia);
            Controls.Add(tBoxNumeroEspacios);
            Controls.Add(lblNumeroEspacios);
            Controls.Add(tBoxCentro);
            Controls.Add(lblCentroCirculo);
            Controls.Add(tBoxNumeroSegmentos);
            Controls.Add(lblNSegmentos);
            Controls.Add(lblSentido);
            Controls.Add(comboBoxSentido);
            Controls.Add(tBoxPuntoFin);
            Controls.Add(tBoxPuntoInicio);
            Controls.Add(tBoxRadio);
            Controls.Add(lblFin);
            Controls.Add(lblInicio);
            Controls.Add(lblRadio);
            Controls.Add(btnMenu);
            Name = "Arco";
            Text = "Construccion de arcos.";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnMenu;
        private Label lblRadio;
        private Label lblInicio;
        private Label lblFin;
        private TextBox tBoxRadio;
        private TextBox tBoxPuntoInicio;
        private TextBox tBoxPuntoFin;
        private ComboBox comboBoxSentido;
        private Label lblSentido;
        private Label lblNSegmentos;
        private TextBox tBoxNumeroSegmentos;
        private Label lblCentroCirculo;
        private TextBox tBoxCentro;
        private Label lblNumeroEspacios;
        private TextBox tBoxNumeroEspacios;
        private Button btnCalcularEquidistancia;
        private Label lblPuntoEquidistante1;
        private Label lblPuntoEquidistante2;
        private Button btnArco180;
        private Button btnArcoRadio;
        private TextBox tBoxEquidistancia;
        private Button btnLeerArchivoMarcas;
        private Label lblArchivoMarcas;
        private TextBox tBoxArchivoMarcas;
        private Button btnBuscarMarcas;
    }
}