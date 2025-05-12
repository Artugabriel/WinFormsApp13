namespace WinFormsApp13.Usercontrol
{
    partial class UserControl2
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            mskTemperatura = new MaskedTextBox();
            label18 = new Label();
            mskFrequenciaCardiaca = new MaskedTextBox();
            label17 = new Label();
            label16 = new Label();
            cmbPressaoArterial = new ComboBox();
            textBox2 = new TextBox();
            label15 = new Label();
            txtAlergias = new TextBox();
            label14 = new Label();
            label13 = new Label();
            cmbTipoSanguinio = new ComboBox();
            txtDeficiencias = new TextBox();
            label6 = new Label();
            txtDoencas = new TextBox();
            label5 = new Label();
            mskPeso = new MaskedTextBox();
            label4 = new Label();
            mskAltura = new MaskedTextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // mskTemperatura
            // 
            mskTemperatura.Location = new Point(610, 255);
            mskTemperatura.Mask = "00,00";
            mskTemperatura.Name = "mskTemperatura";
            mskTemperatura.Size = new Size(100, 23);
            mskTemperatura.TabIndex = 39;
            mskTemperatura.TextAlign = HorizontalAlignment.Center;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(493, 258);
            label18.Name = "label18";
            label18.Size = new Size(111, 15);
            label18.TabIndex = 38;
            label18.Text = "TEMPERATURA (*) : ";
            // 
            // mskFrequenciaCardiaca
            // 
            mskFrequenciaCardiaca.Location = new Point(610, 223);
            mskFrequenciaCardiaca.Mask = "000";
            mskFrequenciaCardiaca.Name = "mskFrequenciaCardiaca";
            mskFrequenciaCardiaca.Size = new Size(100, 23);
            mskFrequenciaCardiaca.TabIndex = 37;
            mskFrequenciaCardiaca.TextAlign = HorizontalAlignment.Center;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(444, 226);
            label17.Name = "label17";
            label17.Size = new Size(160, 15);
            label17.TabIndex = 36;
            label17.Text = "FREQUENCIA CARDIACA(*) : ";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(467, 194);
            label16.Name = "label16";
            label16.Size = new Size(137, 15);
            label16.TabIndex = 35;
            label16.Text = "PRESSÃO ARTERIAL  (*) : ";
            // 
            // cmbPressaoArterial
            // 
            cmbPressaoArterial.FormattingEnabled = true;
            cmbPressaoArterial.Location = new Point(610, 194);
            cmbPressaoArterial.Name = "cmbPressaoArterial";
            cmbPressaoArterial.Size = new Size(114, 23);
            cmbPressaoArterial.TabIndex = 34;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(214, 189);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 23);
            textBox2.TabIndex = 33;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(53, 195);
            label15.Name = "label15";
            label15.Size = new Size(155, 15);
            label15.TabIndex = 32;
            label15.Text = "REMEDIOS CONTINUOS(*) : ";
            // 
            // txtAlergias
            // 
            txtAlergias.Location = new Point(214, 160);
            txtAlergias.Name = "txtAlergias";
            txtAlergias.Size = new Size(114, 23);
            txtAlergias.TabIndex = 31;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(121, 168);
            label14.Name = "label14";
            label14.Size = new Size(87, 15);
            label14.TabIndex = 30;
            label14.Text = "ALERGIAS  (*) : ";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(88, 253);
            label13.Name = "label13";
            label13.Size = new Size(120, 15);
            label13.TabIndex = 29;
            label13.Text = "TIPO SANGUINIO(*) : ";
            // 
            // cmbTipoSanguinio
            // 
            cmbTipoSanguinio.FormattingEnabled = true;
            cmbTipoSanguinio.Location = new Point(214, 250);
            cmbTipoSanguinio.Name = "cmbTipoSanguinio";
            cmbTipoSanguinio.Size = new Size(121, 23);
            cmbTipoSanguinio.TabIndex = 28;
            // 
            // txtDeficiencias
            // 
            txtDeficiencias.Location = new Point(214, 218);
            txtDeficiencias.Name = "txtDeficiencias";
            txtDeficiencias.Size = new Size(114, 23);
            txtDeficiencias.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(105, 221);
            label6.Name = "label6";
            label6.Size = new Size(103, 15);
            label6.TabIndex = 26;
            label6.Text = "DEFICIENCIAS(*) : ";
            // 
            // txtDoencas
            // 
            txtDoencas.Location = new Point(214, 131);
            txtDoencas.Name = "txtDoencas";
            txtDoencas.Size = new Size(243, 23);
            txtDoencas.TabIndex = 25;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(125, 134);
            label5.Name = "label5";
            label5.Size = new Size(83, 15);
            label5.TabIndex = 24;
            label5.Text = "DOENÇAS(*) : ";
            // 
            // mskPeso
            // 
            mskPeso.Location = new Point(610, 160);
            mskPeso.Mask = "00,00";
            mskPeso.Name = "mskPeso";
            mskPeso.Size = new Size(100, 23);
            mskPeso.TabIndex = 23;
            mskPeso.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(547, 165);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 22;
            label4.Text = "PESO(*) : ";
            // 
            // mskAltura
            // 
            mskAltura.Location = new Point(610, 131);
            mskAltura.Mask = "00,00";
            mskAltura.Name = "mskAltura";
            mskAltura.Size = new Size(100, 23);
            mskAltura.TabIndex = 21;
            mskAltura.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(533, 139);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 20;
            label3.Text = "ALTURA(*) : ";
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            Controls.Add(mskTemperatura);
            Controls.Add(label18);
            Controls.Add(mskFrequenciaCardiaca);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(cmbPressaoArterial);
            Controls.Add(textBox2);
            Controls.Add(label15);
            Controls.Add(txtAlergias);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(cmbTipoSanguinio);
            Controls.Add(txtDeficiencias);
            Controls.Add(label6);
            Controls.Add(txtDoencas);
            Controls.Add(label5);
            Controls.Add(mskPeso);
            Controls.Add(label4);
            Controls.Add(mskAltura);
            Controls.Add(label3);
            Name = "UserControl2";
            Size = new Size(816, 489);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mskTemperatura;
        private Label label18;
        private MaskedTextBox mskFrequenciaCardiaca;
        private Label label17;
        private Label label16;
        private ComboBox cmbPressaoArterial;
        private TextBox textBox2;
        private Label label15;
        private TextBox txtAlergias;
        private Label label14;
        private Label label13;
        private ComboBox cmbTipoSanguinio;
        private TextBox txtDeficiencias;
        private Label label6;
        private TextBox txtDoencas;
        private Label label5;
        private MaskedTextBox mskPeso;
        private Label label4;
        private MaskedTextBox mskAltura;
        private Label label3;
    }
}
