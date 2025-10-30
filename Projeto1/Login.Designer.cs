namespace Projeto1
{
    partial class Login
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
            pnlPrincipal = new Panel();
            lblInvalida = new Label();
            txtSenha = new TextBox();
            lblSenha = new Label();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            pnlPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlPrincipal.Controls.Add(lblInvalida);
            pnlPrincipal.Controls.Add(txtSenha);
            pnlPrincipal.Controls.Add(lblSenha);
            pnlPrincipal.Controls.Add(lblUsuario);
            pnlPrincipal.Controls.Add(txtUsuario);
            pnlPrincipal.Location = new Point(12, 12);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(421, 153);
            pnlPrincipal.TabIndex = 0;
            // 
            // lblInvalida
            // 
            lblInvalida.AutoSize = true;
            lblInvalida.BackColor = Color.Yellow;
            lblInvalida.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblInvalida.ForeColor = Color.FromArgb(192, 0, 0);
            lblInvalida.Location = new Point(122, 112);
            lblInvalida.Name = "lblInvalida";
            lblInvalida.Size = new Size(178, 25);
            lblInvalida.TabIndex = 4;
            lblInvalida.Text = "Credencial Inválida!";
            lblInvalida.Visible = false;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(95, 61);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(274, 33);
            txtSenha.TabIndex = 3;
            txtSenha.KeyUp += txtSenha_KeyUp;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(16, 64);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(73, 25);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Senha: ";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(3, 11);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(86, 25);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuário: ";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(95, 8);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(274, 33);
            txtUsuario.TabIndex = 0;
            txtUsuario.KeyUp += txtUsuario_KeyUp;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 177);
            Controls.Add(pnlPrincipal);
            Name = "Login";
            Text = "Login";
            pnlPrincipal.ResumeLayout(false);
            pnlPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPrincipal;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private Label lblInvalida;
        private TextBox txtSenha;
        private Label lblSenha;
    }
}