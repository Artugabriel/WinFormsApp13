namespace WinFormsApp13.Usercontrol
{
    partial class UserControl3
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
            cmbEmcaminhar = new ComboBox();
            cmbClassRisco = new ComboBox();
            txtSintomas = new TextBox();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            SuspendLayout();
            // 
            // cmbEmcaminhar
            // 
            cmbEmcaminhar.FormattingEnabled = true;
            cmbEmcaminhar.Location = new Point(274, 160);
            cmbEmcaminhar.Name = "cmbEmcaminhar";
            cmbEmcaminhar.Size = new Size(121, 23);
            cmbEmcaminhar.TabIndex = 11;
            // 
            // cmbClassRisco
            // 
            cmbClassRisco.FormattingEnabled = true;
            cmbClassRisco.Location = new Point(274, 102);
            cmbClassRisco.Name = "cmbClassRisco";
            cmbClassRisco.Size = new Size(121, 23);
            cmbClassRisco.TabIndex = 10;
            // 
            // txtSintomas
            // 
            txtSintomas.Location = new Point(274, 220);
            txtSintomas.Multiline = true;
            txtSintomas.Name = "txtSintomas";
            txtSintomas.Size = new Size(313, 110);
            txtSintomas.TabIndex = 9;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(209, 223);
            label22.Name = "label22";
            label22.Size = new Size(59, 15);
            label22.TabIndex = 8;
            label22.Text = "Sintomas:";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(137, 105);
            label21.Name = "label21";
            label21.Size = new Size(131, 15);
            label21.TabIndex = 7;
            label21.Text = "Classificação de Risco : ";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(160, 163);
            label20.Name = "label20";
            label20.Size = new Size(108, 15);
            label20.TabIndex = 6;
            label20.Text = "Emcaminhamento:";
            // 
            // UserControl3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            Controls.Add(cmbEmcaminhar);
            Controls.Add(cmbClassRisco);
            Controls.Add(txtSintomas);
            Controls.Add(label22);
            Controls.Add(label21);
            Controls.Add(label20);
            Name = "UserControl3";
            Size = new Size(816, 489);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbEmcaminhar;
        private ComboBox cmbClassRisco;
        private TextBox txtSintomas;
        private Label label22;
        private Label label21;
        private Label label20;
    }
}
