namespace WinFormsApp13
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel1 = new Panel();
            panel2 = new Panel();
            btnSintomas = new Guna.UI2.WinForms.Guna2Button();
            btnSaude = new Guna.UI2.WinForms.Guna2Button();
            btnCadastro = new Guna.UI2.WinForms.Guna2Button();
            panelContainer = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightBlue;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 28);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Controls.Add(btnSintomas);
            panel2.Controls.Add(btnSaude);
            panel2.Controls.Add(btnCadastro);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 28);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 48);
            panel2.TabIndex = 1;
            // 
            // btnSintomas
            // 
            btnSintomas.CustomizableEdges = customizableEdges1;
            btnSintomas.DisabledState.BorderColor = Color.DarkGray;
            btnSintomas.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSintomas.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSintomas.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSintomas.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnSintomas.ForeColor = Color.White;
            btnSintomas.Location = new Point(538, 0);
            btnSintomas.Name = "btnSintomas";
            btnSintomas.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnSintomas.Size = new Size(262, 48);
            btnSintomas.TabIndex = 2;
            btnSintomas.Text = "Sintomas";
            btnSintomas.Click += btnSintomas_Click;
            // 
            // btnSaude
            // 
            btnSaude.CustomizableEdges = customizableEdges3;
            btnSaude.DisabledState.BorderColor = Color.DarkGray;
            btnSaude.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSaude.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSaude.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSaude.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnSaude.ForeColor = Color.White;
            btnSaude.Location = new Point(247, 0);
            btnSaude.Name = "btnSaude";
            btnSaude.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnSaude.Size = new Size(299, 48);
            btnSaude.TabIndex = 1;
            btnSaude.Text = "Saúde";
            btnSaude.Click += btnSaude_Click;
            // 
            // btnCadastro
            // 
            btnCadastro.CustomizableEdges = customizableEdges5;
            btnCadastro.DisabledState.BorderColor = Color.DarkGray;
            btnCadastro.DisabledState.CustomBorderColor = Color.DarkGray;
            btnCadastro.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnCadastro.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnCadastro.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastro.ForeColor = Color.White;
            btnCadastro.Location = new Point(-6, 0);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnCadastro.Size = new Size(257, 48);
            btnCadastro.TabIndex = 0;
            btnCadastro.Text = "Cadastro";
            btnCadastro.Click += btnCadastro_Click;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = SystemColors.Control;
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 76);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(800, 374);
            panelContainer.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelContainer);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            WindowState = FormWindowState.Minimized;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panelContainer;
        private Guna.UI2.WinForms.Guna2Button btnSintomas;
        private Guna.UI2.WinForms.Guna2Button btnSaude;
        private Guna.UI2.WinForms.Guna2Button btnCadastro;
    }
}
