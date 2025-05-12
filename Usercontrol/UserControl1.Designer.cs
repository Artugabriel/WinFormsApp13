namespace WinFormsApp13.Usercontrol
{
    partial class UserControl1
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
            cmbSexo = new ComboBox();
            cmbRaca = new ComboBox();
            txtNomeSocial = new TextBox();
            label19 = new Label();
            txtNomeCompleto = new TextBox();
            label2 = new Label();
            txtEstado = new TextBox();
            lblRaca = new Label();
            label12 = new Label();
            label3 = new Label();
            txtComplemento = new TextBox();
            label10 = new Label();
            txtEmail = new TextBox();
            txtCidade = new TextBox();
            mskNumeroSecundarioCLL = new MaskedTextBox();
            label11 = new Label();
            lblTelefone = new Label();
            txtBairro = new TextBox();
            label9 = new Label();
            lblNumeroSecundarioCLL = new Label();
            txtEndereco = new TextBox();
            mskNumeroPrincipalCLL = new MaskedTextBox();
            label8 = new Label();
            mskNascimento = new MaskedTextBox();
            mskCEP = new MaskedTextBox();
            lblDatadeNasc = new Label();
            label7 = new Label();
            lblSexo = new Label();
            mskCPF = new MaskedTextBox();
            lblCPF = new Label();
            lblCartaoSUS = new Label();
            mskSUS = new MaskedTextBox();
            SuspendLayout();
            // 
            // cmbSexo
            // 
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Location = new Point(632, 62);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(119, 23);
            cmbSexo.TabIndex = 48;
            // 
            // cmbRaca
            // 
            cmbRaca.FormattingEnabled = true;
            cmbRaca.Location = new Point(632, 152);
            cmbRaca.Name = "cmbRaca";
            cmbRaca.Size = new Size(119, 23);
            cmbRaca.TabIndex = 52;
            // 
            // txtNomeSocial
            // 
            txtNomeSocial.Location = new Point(225, 59);
            txtNomeSocial.Name = "txtNomeSocial";
            txtNomeSocial.Size = new Size(220, 23);
            txtNomeSocial.TabIndex = 38;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Location = new Point(64, 62);
            label19.Name = "label19";
            label19.Size = new Size(155, 15);
            label19.TabIndex = 67;
            label19.Text = "NOME SOCIAL(OPCIONAL):";
            // 
            // txtNomeCompleto
            // 
            txtNomeCompleto.Location = new Point(225, 30);
            txtNomeCompleto.Name = "txtNomeCompleto";
            txtNomeCompleto.Size = new Size(220, 23);
            txtNomeCompleto.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(94, 33);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 37;
            label2.Text = "NOME COMPLETO(*) :";
            // 
            // txtEstado
            // 
            txtEstado.Enabled = false;
            txtEstado.Location = new Point(423, 265);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(95, 23);
            txtEstado.TabIndex = 63;
            // 
            // lblRaca
            // 
            lblRaca.AutoSize = true;
            lblRaca.BackColor = Color.Transparent;
            lblRaca.Location = new Point(566, 155);
            lblRaca.Name = "lblRaca";
            lblRaca.Size = new Size(60, 15);
            lblRaca.TabIndex = 66;
            lblRaca.Text = "RAÇA(*) : ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Location = new Point(387, 268);
            label12.Name = "label12";
            label12.Size = new Size(30, 15);
            label12.TabIndex = 62;
            label12.Text = "UF : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(100, 90);
            label3.Name = "label3";
            label3.Size = new Size(119, 15);
            label3.TabIndex = 54;
            label3.Text = "E-MAIL (OPCIONAL):";
            // 
            // txtComplemento
            // 
            txtComplemento.Location = new Point(225, 294);
            txtComplemento.Name = "txtComplemento";
            txtComplemento.Size = new Size(220, 23);
            txtComplemento.TabIndex = 44;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Location = new Point(103, 297);
            label10.Name = "label10";
            label10.Size = new Size(116, 15);
            label10.TabIndex = 61;
            label10.Text = "COMPLEMENTO (*) :";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(225, 87);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(220, 23);
            txtEmail.TabIndex = 39;
            // 
            // txtCidade
            // 
            txtCidade.Enabled = false;
            txtCidade.Location = new Point(225, 265);
            txtCidade.Name = "txtCidade";
            txtCidade.Size = new Size(143, 23);
            txtCidade.TabIndex = 60;
            // 
            // mskNumeroSecundarioCLL
            // 
            mskNumeroSecundarioCLL.Location = new Point(225, 149);
            mskNumeroSecundarioCLL.Mask = "(00) 00000-0000";
            mskNumeroSecundarioCLL.Name = "mskNumeroSecundarioCLL";
            mskNumeroSecundarioCLL.Size = new Size(120, 23);
            mskNumeroSecundarioCLL.TabIndex = 42;
            mskNumeroSecundarioCLL.TextAlign = HorizontalAlignment.Center;
            mskNumeroSecundarioCLL.ValidatingType = typeof(DateTime);
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Location = new Point(162, 268);
            label11.Name = "label11";
            label11.Size = new Size(57, 15);
            label11.TabIndex = 59;
            label11.Text = "CIDADE : ";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.BackColor = Color.Transparent;
            lblTelefone.Location = new Point(135, 123);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(86, 15);
            lblTelefone.TabIndex = 64;
            lblTelefone.Text = "TELEFONE (*) : ";
            // 
            // txtBairro
            // 
            txtBairro.Enabled = false;
            txtBairro.Location = new Point(225, 236);
            txtBairro.Name = "txtBairro";
            txtBairro.Size = new Size(220, 23);
            txtBairro.TabIndex = 58;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Location = new Point(162, 239);
            label9.Name = "label9";
            label9.Size = new Size(57, 15);
            label9.TabIndex = 57;
            label9.Text = "BAIRRO : ";
            // 
            // lblNumeroSecundarioCLL
            // 
            lblNumeroSecundarioCLL.AutoSize = true;
            lblNumeroSecundarioCLL.BackColor = Color.Transparent;
            lblNumeroSecundarioCLL.Location = new Point(135, 152);
            lblNumeroSecundarioCLL.Name = "lblNumeroSecundarioCLL";
            lblNumeroSecundarioCLL.Size = new Size(84, 15);
            lblNumeroSecundarioCLL.TabIndex = 65;
            lblNumeroSecundarioCLL.Text = "2° TELEFONE : ";
            // 
            // txtEndereco
            // 
            txtEndereco.Enabled = false;
            txtEndereco.Location = new Point(225, 207);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(220, 23);
            txtEndereco.TabIndex = 45;
            // 
            // mskNumeroPrincipalCLL
            // 
            mskNumeroPrincipalCLL.Location = new Point(225, 120);
            mskNumeroPrincipalCLL.Mask = "(00) 00000-0000";
            mskNumeroPrincipalCLL.Name = "mskNumeroPrincipalCLL";
            mskNumeroPrincipalCLL.Size = new Size(120, 23);
            mskNumeroPrincipalCLL.TabIndex = 40;
            mskNumeroPrincipalCLL.TextAlign = HorizontalAlignment.Center;
            mskNumeroPrincipalCLL.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mskNumeroPrincipalCLL.ValidatingType = typeof(DateTime);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Location = new Point(144, 210);
            label8.Name = "label8";
            label8.Size = new Size(75, 15);
            label8.TabIndex = 56;
            label8.Text = "ENDEREÇO : ";
            // 
            // mskNascimento
            // 
            mskNascimento.Location = new Point(632, 30);
            mskNascimento.Mask = "00/00/0000";
            mskNascimento.Name = "mskNascimento";
            mskNascimento.Size = new Size(119, 23);
            mskNascimento.TabIndex = 47;
            mskNascimento.TextAlign = HorizontalAlignment.Center;
            mskNascimento.ValidatingType = typeof(DateTime);
            // 
            // mskCEP
            // 
            mskCEP.Location = new Point(225, 178);
            mskCEP.Mask = "00000000";
            mskCEP.Name = "mskCEP";
            mskCEP.Size = new Size(120, 23);
            mskCEP.TabIndex = 43;
            mskCEP.TextAlign = HorizontalAlignment.Center;
            mskCEP.ValidatingType = typeof(DateTime);
            // 
            // lblDatadeNasc
            // 
            lblDatadeNasc.AutoSize = true;
            lblDatadeNasc.BackColor = Color.Transparent;
            lblDatadeNasc.Location = new Point(481, 30);
            lblDatadeNasc.Name = "lblDatadeNasc";
            lblDatadeNasc.Size = new Size(145, 15);
            lblDatadeNasc.TabIndex = 41;
            lblDatadeNasc.Text = "DATA DE NASCIMENTO(*):\r\n";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Location = new Point(166, 181);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 55;
            label7.Text = "CEP (*) : ";
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.BackColor = Color.Transparent;
            lblSexo.Location = new Point(572, 62);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(54, 15);
            lblSexo.TabIndex = 46;
            lblSexo.Text = "SEXO (*):";
            // 
            // mskCPF
            // 
            mskCPF.Location = new Point(632, 91);
            mskCPF.Mask = "000.000.000-00";
            mskCPF.Name = "mskCPF";
            mskCPF.Size = new Size(119, 23);
            mskCPF.TabIndex = 50;
            mskCPF.TextAlign = HorizontalAlignment.Center;
            mskCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mskCPF.ValidatingType = typeof(DateTime);
            // 
            // lblCPF
            // 
            lblCPF.AutoSize = true;
            lblCPF.BackColor = Color.Transparent;
            lblCPF.Location = new Point(579, 95);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(47, 15);
            lblCPF.TabIndex = 49;
            lblCPF.Text = "CPF (*):";
            // 
            // lblCartaoSUS
            // 
            lblCartaoSUS.AutoSize = true;
            lblCartaoSUS.BackColor = Color.Transparent;
            lblCartaoSUS.Location = new Point(513, 123);
            lblCartaoSUS.Name = "lblCartaoSUS";
            lblCartaoSUS.Size = new Size(113, 15);
            lblCartaoSUS.TabIndex = 53;
            lblCartaoSUS.Text = "CARTÃO DO SUS(*) :";
            // 
            // mskSUS
            // 
            mskSUS.Location = new Point(632, 120);
            mskSUS.Mask = "00000000000  0000 0";
            mskSUS.Name = "mskSUS";
            mskSUS.Size = new Size(119, 23);
            mskSUS.TabIndex = 51;
            mskSUS.TextAlign = HorizontalAlignment.Center;
            mskSUS.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            mskSUS.ValidatingType = typeof(DateTime);
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            Controls.Add(cmbSexo);
            Controls.Add(cmbRaca);
            Controls.Add(txtNomeSocial);
            Controls.Add(label19);
            Controls.Add(txtNomeCompleto);
            Controls.Add(label2);
            Controls.Add(txtEstado);
            Controls.Add(lblRaca);
            Controls.Add(label12);
            Controls.Add(label3);
            Controls.Add(txtComplemento);
            Controls.Add(label10);
            Controls.Add(txtEmail);
            Controls.Add(txtCidade);
            Controls.Add(mskNumeroSecundarioCLL);
            Controls.Add(label11);
            Controls.Add(lblTelefone);
            Controls.Add(txtBairro);
            Controls.Add(label9);
            Controls.Add(lblNumeroSecundarioCLL);
            Controls.Add(txtEndereco);
            Controls.Add(mskNumeroPrincipalCLL);
            Controls.Add(label8);
            Controls.Add(mskNascimento);
            Controls.Add(mskCEP);
            Controls.Add(lblDatadeNasc);
            Controls.Add(label7);
            Controls.Add(lblSexo);
            Controls.Add(mskCPF);
            Controls.Add(lblCPF);
            Controls.Add(lblCartaoSUS);
            Controls.Add(mskSUS);
            Name = "UserControl1";
            Size = new Size(816, 489);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbSexo;
        private ComboBox cmbRaca;
        private TextBox txtNomeSocial;
        private Label label19;
        private TextBox txtNomeCompleto;
        private Label label2;
        private TextBox txtEstado;
        private Label lblRaca;
        private Label label12;
        private Label label3;
        private TextBox txtComplemento;
        private Label label10;
        private TextBox txtEmail;
        private TextBox txtCidade;
        private MaskedTextBox mskNumeroSecundarioCLL;
        private Label label11;
        private Label lblTelefone;
        private TextBox txtBairro;
        private Label label9;
        private Label lblNumeroSecundarioCLL;
        private TextBox txtEndereco;
        private MaskedTextBox mskNumeroPrincipalCLL;
        private Label label8;
        private MaskedTextBox mskNascimento;
        private MaskedTextBox mskCEP;
        private Label lblDatadeNasc;
        private Label label7;
        private Label lblSexo;
        private MaskedTextBox mskCPF;
        private Label lblCPF;
        private Label lblCartaoSUS;
        private MaskedTextBox mskSUS;
    }
}
