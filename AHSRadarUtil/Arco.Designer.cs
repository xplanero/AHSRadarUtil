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
            tBoxEquidistancia1 = new TextBox();
            btn2PuntosCentro = new Button();
            tBoxEquidistancia2 = new TextBox();
            btnCirculoCentroRadio = new Button();
            lblCentro1 = new Label();
            lblCentro2 = new Label();
            btnArcoCentro2 = new Button();
            btnArcoCentro1 = new Button();
            btnBusquedaInicio = new Button();
            btnBusquedaFinal = new Button();
            btnBusquedaCentro = new Button();
            SuspendLayout();
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(800, 490);
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
            lblInicio.Location = new Point(36, 63);
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
            tBoxRadio.Location = new Point(239, 23);
            tBoxRadio.Name = "tBoxRadio";
            tBoxRadio.Size = new Size(94, 31);
            tBoxRadio.TabIndex = 17;
            tBoxRadio.Text = "12";
            tBoxRadio.TextAlign = HorizontalAlignment.Right;
            // 
            // tBoxPuntoInicio
            // 
            tBoxPuntoInicio.Location = new Point(239, 62);
            tBoxPuntoInicio.Name = "tBoxPuntoInicio";
            tBoxPuntoInicio.Size = new Size(287, 31);
            tBoxPuntoInicio.TabIndex = 18;
            tBoxPuntoInicio.Text = "N028.29.29.554 W016.29.23.793";
            // 
            // tBoxPuntoFin
            // 
            tBoxPuntoFin.Location = new Point(239, 98);
            tBoxPuntoFin.Name = "tBoxPuntoFin";
            tBoxPuntoFin.Size = new Size(287, 31);
            tBoxPuntoFin.TabIndex = 19;
            tBoxPuntoFin.Text = "N028.41.54.578 W016.24.11.554";
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
            lblNSegmentos.Location = new Point(26, 213);
            lblNSegmentos.Name = "lblNSegmentos";
            lblNSegmentos.Size = new Size(199, 25);
            lblNSegmentos.TabIndex = 22;
            lblNSegmentos.Text = "Número de segmentos:";
            // 
            // tBoxNumeroSegmentos
            // 
            tBoxNumeroSegmentos.Location = new Point(239, 212);
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
            tBoxCentro.Text = "N028.32.12.600 W016.16.07.600";
            // 
            // lblNumeroEspacios
            // 
            lblNumeroEspacios.AutoSize = true;
            lblNumeroEspacios.Location = new Point(44, 252);
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
            btnCalcularEquidistancia.Location = new Point(34, 322);
            btnCalcularEquidistancia.Margin = new Padding(4, 5, 4, 5);
            btnCalcularEquidistancia.Name = "btnCalcularEquidistancia";
            btnCalcularEquidistancia.Size = new Size(229, 38);
            btnCalcularEquidistancia.TabIndex = 28;
            btnCalcularEquidistancia.Text = "Calcular equidistancia";
            btnCalcularEquidistancia.UseVisualStyleBackColor = true;
            btnCalcularEquidistancia.Click += btnCalcularEquidistancia_Click;
            // 
            // tBoxEquidistancia1
            // 
            tBoxEquidistancia1.Location = new Point(271, 325);
            tBoxEquidistancia1.Margin = new Padding(4, 5, 4, 5);
            tBoxEquidistancia1.Name = "tBoxEquidistancia1";
            tBoxEquidistancia1.Size = new Size(338, 31);
            tBoxEquidistancia1.TabIndex = 33;
            // 
            // btn2PuntosCentro
            // 
            btn2PuntosCentro.Location = new Point(34, 373);
            btn2PuntosCentro.Name = "btn2PuntosCentro";
            btn2PuntosCentro.Size = new Size(229, 38);
            btn2PuntosCentro.TabIndex = 38;
            btn2PuntosCentro.Text = "2 Puntos Centro";
            btn2PuntosCentro.UseVisualStyleBackColor = true;
            btn2PuntosCentro.Click += btn2PuntosCentro_Click;
            // 
            // tBoxEquidistancia2
            // 
            tBoxEquidistancia2.Location = new Point(643, 328);
            tBoxEquidistancia2.Margin = new Padding(4, 5, 4, 5);
            tBoxEquidistancia2.Name = "tBoxEquidistancia2";
            tBoxEquidistancia2.Size = new Size(338, 31);
            tBoxEquidistancia2.TabIndex = 46;
            // 
            // btnCirculoCentroRadio
            // 
            btnCirculoCentroRadio.Location = new Point(34, 428);
            btnCirculoCentroRadio.Margin = new Padding(4, 5, 4, 5);
            btnCirculoCentroRadio.Name = "btnCirculoCentroRadio";
            btnCirculoCentroRadio.Size = new Size(229, 38);
            btnCirculoCentroRadio.TabIndex = 47;
            btnCirculoCentroRadio.Text = "Circulo centro radio";
            btnCirculoCentroRadio.UseVisualStyleBackColor = true;
            btnCirculoCentroRadio.Click += btnCirculoCentroRadio_Click;
            // 
            // lblCentro1
            // 
            lblCentro1.AutoSize = true;
            lblCentro1.Location = new Point(404, 298);
            lblCentro1.Margin = new Padding(4, 0, 4, 0);
            lblCentro1.Name = "lblCentro1";
            lblCentro1.Size = new Size(94, 25);
            lblCentro1.TabIndex = 48;
            lblCentro1.Text = "CENTRO 1";
            // 
            // lblCentro2
            // 
            lblCentro2.AutoSize = true;
            lblCentro2.Location = new Point(753, 298);
            lblCentro2.Margin = new Padding(4, 0, 4, 0);
            lblCentro2.Name = "lblCentro2";
            lblCentro2.Size = new Size(94, 25);
            lblCentro2.TabIndex = 49;
            lblCentro2.Text = "CENTRO 2";
            // 
            // btnArcoCentro2
            // 
            btnArcoCentro2.Location = new Point(699, 370);
            btnArcoCentro2.Margin = new Padding(4, 5, 4, 5);
            btnArcoCentro2.Name = "btnArcoCentro2";
            btnArcoCentro2.Size = new Size(229, 38);
            btnArcoCentro2.TabIndex = 50;
            btnArcoCentro2.Text = "Arco 2 puntos centro 2";
            btnArcoCentro2.UseVisualStyleBackColor = true;
            btnArcoCentro2.Click += btnArcoCentro2_Click;
            // 
            // btnArcoCentro1
            // 
            btnArcoCentro1.Location = new Point(329, 373);
            btnArcoCentro1.Margin = new Padding(4, 5, 4, 5);
            btnArcoCentro1.Name = "btnArcoCentro1";
            btnArcoCentro1.Size = new Size(229, 38);
            btnArcoCentro1.TabIndex = 51;
            btnArcoCentro1.Text = "Arco 2 puntos centro 1";
            btnArcoCentro1.UseVisualStyleBackColor = true;
            btnArcoCentro1.Click += btnArcoCentro1_Click;
            // 
            // btnBusquedaInicio
            // 
            btnBusquedaInicio.Location = new Point(532, 63);
            btnBusquedaInicio.Name = "btnBusquedaInicio";
            btnBusquedaInicio.Size = new Size(79, 34);
            btnBusquedaInicio.TabIndex = 52;
            btnBusquedaInicio.Text = "Buscar";
            btnBusquedaInicio.UseVisualStyleBackColor = true;
            btnBusquedaInicio.Click += btnBusquedaInicio_Click;
            // 
            // btnBusquedaFinal
            // 
            btnBusquedaFinal.Location = new Point(532, 98);
            btnBusquedaFinal.Name = "btnBusquedaFinal";
            btnBusquedaFinal.Size = new Size(79, 34);
            btnBusquedaFinal.TabIndex = 53;
            btnBusquedaFinal.Text = "Buscar";
            btnBusquedaFinal.UseVisualStyleBackColor = true;
            btnBusquedaFinal.Click += btnBusquedaFinal_Click;
            // 
            // btnBusquedaCentro
            // 
            btnBusquedaCentro.Location = new Point(532, 133);
            btnBusquedaCentro.Name = "btnBusquedaCentro";
            btnBusquedaCentro.Size = new Size(79, 34);
            btnBusquedaCentro.TabIndex = 54;
            btnBusquedaCentro.Text = "Buscar";
            btnBusquedaCentro.UseVisualStyleBackColor = true;
            btnBusquedaCentro.Click += btnBusquedaCentro_Click;
            // 
            // Arco
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 548);
            Controls.Add(btnBusquedaCentro);
            Controls.Add(btnBusquedaFinal);
            Controls.Add(btnBusquedaInicio);
            Controls.Add(btnArcoCentro1);
            Controls.Add(btnArcoCentro2);
            Controls.Add(lblCentro2);
            Controls.Add(lblCentro1);
            Controls.Add(btnCirculoCentroRadio);
            Controls.Add(tBoxEquidistancia2);
            Controls.Add(btn2PuntosCentro);
            Controls.Add(tBoxEquidistancia1);
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
        private TextBox tBoxEquidistancia1;
        private Button btn2PuntosCentro;
        private TextBox tBoxEquidistancia2;
        private Button btnCirculoCentroRadio;
        private Label lblCentro1;
        private Label lblCentro2;
        private Button btnArcoCentro2;
        private Button btnArcoCentro1;
        private Button btnBusquedaInicio;
        private Button btnBusquedaFinal;
        private Button btnBusquedaCentro;
    }
}