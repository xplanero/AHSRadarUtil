namespace AHSRadarUtil
{
    partial class Espera
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
            tBoxFijo = new TextBox();
            tBoxAncho = new TextBox();
            tBoxLargo = new TextBox();
            tBoxRumboInbound = new TextBox();
            comboBoxSentido = new ComboBox();
            btnMenu = new Button();
            lblFijo = new Label();
            lblRumbo = new Label();
            lblAncho = new Label();
            lblLargo = new Label();
            lblSentido = new Label();
            btnGenerar = new Button();
            btnBusqueda = new Button();
            SuspendLayout();
            // 
            // tBoxFijo
            // 
            tBoxFijo.Location = new Point(152, 27);
            tBoxFijo.Name = "tBoxFijo";
            tBoxFijo.Size = new Size(287, 31);
            tBoxFijo.TabIndex = 26;
            tBoxFijo.Text = "N028.32.12.600 W016.16.07.600";
            // 
            // tBoxAncho
            // 
            tBoxAncho.Location = new Point(152, 96);
            tBoxAncho.Margin = new Padding(2, 2, 2, 2);
            tBoxAncho.Name = "tBoxAncho";
            tBoxAncho.Size = new Size(54, 31);
            tBoxAncho.TabIndex = 27;
            tBoxAncho.Text = "2";
            tBoxAncho.TextAlign = HorizontalAlignment.Right;
            // 
            // tBoxLargo
            // 
            tBoxLargo.Location = new Point(152, 130);
            tBoxLargo.Margin = new Padding(2, 2, 2, 2);
            tBoxLargo.Name = "tBoxLargo";
            tBoxLargo.Size = new Size(54, 31);
            tBoxLargo.TabIndex = 28;
            tBoxLargo.Text = "3";
            tBoxLargo.TextAlign = HorizontalAlignment.Right;
            // 
            // tBoxRumboInbound
            // 
            tBoxRumboInbound.Location = new Point(152, 62);
            tBoxRumboInbound.Margin = new Padding(2, 2, 2, 2);
            tBoxRumboInbound.Name = "tBoxRumboInbound";
            tBoxRumboInbound.Size = new Size(54, 31);
            tBoxRumboInbound.TabIndex = 29;
            tBoxRumboInbound.Text = "0";
            tBoxRumboInbound.TextAlign = HorizontalAlignment.Right;
            // 
            // comboBoxSentido
            // 
            comboBoxSentido.FormattingEnabled = true;
            comboBoxSentido.Location = new Point(152, 165);
            comboBoxSentido.Name = "comboBoxSentido";
            comboBoxSentido.Size = new Size(72, 33);
            comboBoxSentido.TabIndex = 30;
            comboBoxSentido.Text = "Right";
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(413, 238);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(111, 33);
            btnMenu.TabIndex = 31;
            btnMenu.Text = "MENÚ";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // lblFijo
            // 
            lblFijo.AutoSize = true;
            lblFijo.Location = new Point(107, 27);
            lblFijo.Margin = new Padding(2, 0, 2, 0);
            lblFijo.Name = "lblFijo";
            lblFijo.Size = new Size(44, 25);
            lblFijo.TabIndex = 32;
            lblFijo.Text = "Fijo:";
            // 
            // lblRumbo
            // 
            lblRumbo.AutoSize = true;
            lblRumbo.Location = new Point(7, 62);
            lblRumbo.Margin = new Padding(2, 0, 2, 0);
            lblRumbo.Name = "lblRumbo";
            lblRumbo.Size = new Size(147, 25);
            lblRumbo.TabIndex = 33;
            lblRumbo.Text = "Rumbo inbound:";
            // 
            // lblAncho
            // 
            lblAncho.AutoSize = true;
            lblAncho.Location = new Point(81, 96);
            lblAncho.Margin = new Padding(2, 0, 2, 0);
            lblAncho.Name = "lblAncho";
            lblAncho.Size = new Size(67, 25);
            lblAncho.TabIndex = 34;
            lblAncho.Text = "Ancho:";
            // 
            // lblLargo
            // 
            lblLargo.AutoSize = true;
            lblLargo.Location = new Point(89, 130);
            lblLargo.Margin = new Padding(2, 0, 2, 0);
            lblLargo.Name = "lblLargo";
            lblLargo.Size = new Size(61, 25);
            lblLargo.TabIndex = 35;
            lblLargo.Text = "Largo:";
            // 
            // lblSentido
            // 
            lblSentido.AutoSize = true;
            lblSentido.Location = new Point(73, 165);
            lblSentido.Margin = new Padding(2, 0, 2, 0);
            lblSentido.Name = "lblSentido";
            lblSentido.Size = new Size(77, 25);
            lblSentido.TabIndex = 36;
            lblSentido.Text = "Sentido:";
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(279, 107);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(111, 33);
            btnGenerar.TabIndex = 37;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnBusqueda
            // 
            btnBusqueda.Location = new Point(449, 27);
            btnBusqueda.Name = "btnBusqueda";
            btnBusqueda.Size = new Size(79, 34);
            btnBusqueda.TabIndex = 38;
            btnBusqueda.Text = "Buscar";
            btnBusqueda.UseVisualStyleBackColor = true;
            btnBusqueda.Click += btnBusqueda_Click;
            // 
            // Espera
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 289);
            Controls.Add(btnBusqueda);
            Controls.Add(btnGenerar);
            Controls.Add(lblSentido);
            Controls.Add(lblLargo);
            Controls.Add(lblAncho);
            Controls.Add(lblRumbo);
            Controls.Add(lblFijo);
            Controls.Add(btnMenu);
            Controls.Add(comboBoxSentido);
            Controls.Add(tBoxRumboInbound);
            Controls.Add(tBoxLargo);
            Controls.Add(tBoxAncho);
            Controls.Add(tBoxFijo);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Espera";
            Text = "Espera";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tBoxFijo;
        private TextBox tBoxAncho;
        private TextBox tBoxLargo;
        private TextBox tBoxRumboInbound;
        private ComboBox comboBoxSentido;
        private Button btnMenu;
        private Label lblFijo;
        private Label lblRumbo;
        private Label lblAncho;
        private Label lblLargo;
        private Label lblSentido;
        private Button btnGenerar;
        private Button btnBusqueda;
    }
}