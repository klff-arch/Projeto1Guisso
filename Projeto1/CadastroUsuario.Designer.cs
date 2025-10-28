namespace Projeto1
{
    partial class CadastroUsuario
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
            pnlPrincipal = new Panel();
            mskTelefone = new MaskedTextBox();
            lblTelefone = new Label();
            btnSalvar = new Button();
            chkGerente = new CheckBox();
            txtRepetirSenha = new TextBox();
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            lblRepetirSenha = new Label();
            lblSenha = new Label();
            lblUsuario = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            lblAviso = new Label();
            pnlPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlPrincipal.Controls.Add(lblAviso);
            pnlPrincipal.Controls.Add(mskTelefone);
            pnlPrincipal.Controls.Add(lblTelefone);
            pnlPrincipal.Controls.Add(btnSalvar);
            pnlPrincipal.Controls.Add(chkGerente);
            pnlPrincipal.Controls.Add(txtRepetirSenha);
            pnlPrincipal.Controls.Add(txtSenha);
            pnlPrincipal.Controls.Add(txtUsuario);
            pnlPrincipal.Controls.Add(lblRepetirSenha);
            pnlPrincipal.Controls.Add(lblSenha);
            pnlPrincipal.Controls.Add(lblUsuario);
            pnlPrincipal.Controls.Add(lblNome);
            pnlPrincipal.Controls.Add(txtNome);
            pnlPrincipal.Location = new Point(12, 12);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(476, 277);
            pnlPrincipal.TabIndex = 0;
            // 
            // mskTelefone
            // 
            mskTelefone.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mskTelefone.Location = new Point(152, 96);
            mskTelefone.Mask = "00 00000-0000";
            mskTelefone.Name = "mskTelefone";
            mskTelefone.Size = new Size(263, 33);
            mskTelefone.TabIndex = 23;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefone.Location = new Point(59, 99);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(87, 25);
            lblTelefone.TabIndex = 22;
            lblTelefone.Text = "Telefone:";
            // 
            // btnSalvar
            // 
            btnSalvar.AutoSize = true;
            btnSalvar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(398, 238);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 35);
            btnSalvar.TabIndex = 21;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // chkGerente
            // 
            chkGerente.AutoSize = true;
            chkGerente.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkGerente.Location = new Point(52, 238);
            chkGerente.Name = "chkGerente";
            chkGerente.Size = new Size(98, 29);
            chkGerente.TabIndex = 20;
            chkGerente.Text = "Gerente";
            chkGerente.UseVisualStyleBackColor = true;
            // 
            // txtRepetirSenha
            // 
            txtRepetirSenha.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRepetirSenha.Location = new Point(152, 188);
            txtRepetirSenha.Name = "txtRepetirSenha";
            txtRepetirSenha.PasswordChar = '*';
            txtRepetirSenha.Size = new Size(263, 33);
            txtRepetirSenha.TabIndex = 19;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(152, 140);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(263, 33);
            txtSenha.TabIndex = 18;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(152, 48);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(321, 33);
            txtUsuario.TabIndex = 17;
            // 
            // lblRepetirSenha
            // 
            lblRepetirSenha.AutoSize = true;
            lblRepetirSenha.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRepetirSenha.Location = new Point(5, 191);
            lblRepetirSenha.Name = "lblRepetirSenha";
            lblRepetirSenha.Size = new Size(145, 25);
            lblRepetirSenha.TabIndex = 16;
            lblRepetirSenha.Text = "Repetir a senha:";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(78, 143);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(68, 25);
            lblSenha.TabIndex = 15;
            lblSenha.Text = "Senha:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(65, 51);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(81, 25);
            lblUsuario.TabIndex = 14;
            lblUsuario.Text = "Usuário:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(79, 6);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(67, 25);
            lblNome.TabIndex = 13;
            lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            txtNome.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNome.Location = new Point(152, 3);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(321, 33);
            txtNome.TabIndex = 12;
            // 
            // lblAviso
            // 
            lblAviso.AutoSize = true;
            lblAviso.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAviso.ForeColor = Color.Maroon;
            lblAviso.Location = new Point(171, 224);
            lblAviso.Name = "lblAviso";
            lblAviso.Size = new Size(209, 21);
            lblAviso.TabIndex = 24;
            lblAviso.Text = "Verificação de senha inválida";
            lblAviso.Visible = false;
            // 
            // CadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 301);
            Controls.Add(pnlPrincipal);
            Name = "CadastroUsuario";
            Text = "Form1";
            pnlPrincipal.ResumeLayout(false);
            pnlPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPrincipal;
        private MaskedTextBox mskTelefone;
        private Label lblTelefone;
        private Button btnSalvar;
        private CheckBox chkGerente;
        private TextBox txtRepetirSenha;
        private TextBox txtSenha;
        private TextBox txtUsuario;
        private Label lblRepetirSenha;
        private Label lblSenha;
        private Label lblUsuario;
        private Label lblNome;
        private TextBox txtNome;
        private Label lblAviso;
    }
}
