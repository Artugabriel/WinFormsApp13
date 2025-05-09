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
            textBox10 = new TextBox();
            label10 = new Label();
            textBox11 = new TextBox();
            label11 = new Label();
            textBox12 = new TextBox();
            label12 = new Label();
            textBox13 = new TextBox();
            label13 = new Label();
            SuspendLayout();
            // 
            // textBox10
            // 
            textBox10.Location = new Point(190, 185);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(186, 23);
            textBox10.TabIndex = 33;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(136, 193);
            label10.Name = "label10";
            label10.Size = new Size(48, 15);
            label10.TabIndex = 32;
            label10.Text = "Raça(*):";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(190, 145);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(186, 23);
            textBox11.TabIndex = 31;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(87, 153);
            label11.Name = "label11";
            label11.Size = new Size(98, 15);
            label11.TabIndex = 30;
            label11.Text = "Cartao do SUS(*):";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(190, 106);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(186, 23);
            textBox12.TabIndex = 29;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(136, 113);
            label12.Name = "label12";
            label12.Size = new Size(48, 15);
            label12.TabIndex = 28;
            label12.Text = "Sexo(*):";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(190, 66);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(186, 23);
            textBox13.TabIndex = 27;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(55, 74);
            label13.Name = "label13";
            label13.Size = new Size(130, 15);
            label13.TabIndex = 26;
            label13.Text = "Data de Nascimento(*):";
            // 
            // UserControl2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBox10);
            Controls.Add(label10);
            Controls.Add(textBox11);
            Controls.Add(label11);
            Controls.Add(textBox12);
            Controls.Add(label12);
            Controls.Add(textBox13);
            Controls.Add(label13);
            Name = "UserControl2";
            Size = new Size(816, 489);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox10;
        private Label label10;
        private TextBox textBox11;
        private Label label11;
        private TextBox textBox12;
        private Label label12;
        private TextBox textBox13;
        private Label label13;
    }
}
