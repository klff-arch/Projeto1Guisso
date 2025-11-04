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
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblSucesso = new Label();
            lblAviso = new Label();
            mskTelefone = new MaskedTextBox();
            lblTelefone = new Label();
            btnSalvar = new Button();
            txtRepetirSenha = new TextBox();
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            lblRepetirSenha = new Label();
            lblSenha = new Label();
            lblUsuario = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            radGerente = new RadioButton();
            radVendedor = new RadioButton();
            radCaixa = new RadioButton();
            pnlPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlPrincipal.Controls.Add(radCaixa);
            pnlPrincipal.Controls.Add(radVendedor);
            pnlPrincipal.Controls.Add(radGerente);
            pnlPrincipal.Controls.Add(txtEmail);
            pnlPrincipal.Controls.Add(lblEmail);
            pnlPrincipal.Controls.Add(lblSucesso);
            pnlPrincipal.Controls.Add(lblAviso);
            pnlPrincipal.Controls.Add(mskTelefone);
            pnlPrincipal.Controls.Add(lblTelefone);
            pnlPrincipal.Controls.Add(btnSalvar);
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
            pnlPrincipal.Size = new Size(476, 330);
            pnlPrincipal.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 14.25F);
            txtEmail.Location = new Point(152, 90);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(263, 33);
            txtEmail.TabIndex = 27;
            txtEmail.KeyUp += txtEmail_KeyUp;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 14.25F);
            lblEmail.Location = new Point(80, 93);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(70, 25);
            lblEmail.TabIndex = 26;
            lblEmail.Text = "E-mail:";
            // 
            // lblSucesso
            // 
            lblSucesso.AutoSize = true;
            lblSucesso.Font = new Font("Segoe UI", 12F);
            lblSucesso.ForeColor = Color.DarkGreen;
            lblSucesso.Location = new Point(171, 261);
            lblSucesso.Name = "lblSucesso";
            lblSucesso.Size = new Size(203, 21);
            lblSucesso.TabIndex = 25;
            lblSucesso.Text = "Usuário criado com sucesso";
            lblSucesso.Visible = false;
            // 
            // lblAviso
            // 
            lblAviso.AutoSize = true;
            lblAviso.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAviso.ForeColor = Color.Maroon;
            lblAviso.Location = new Point(171, 261);
            lblAviso.Name = "lblAviso";
            lblAviso.Size = new Size(209, 21);
            lblAviso.TabIndex = 24;
            lblAviso.Text = "Verificação de senha inválida";
            lblAviso.Visible = false;
            // 
            // mskTelefone
            // 
            mskTelefone.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mskTelefone.Location = new Point(152, 136);
            mskTelefone.Mask = "\\(00\\)00000\\-0000";
            mskTelefone.Name = "mskTelefone";
            mskTelefone.Size = new Size(263, 33);
            mskTelefone.TabIndex = 23;
            mskTelefone.KeyUp += mskTelefone_KeyUp;
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefone.Location = new Point(63, 139);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(87, 25);
            lblTelefone.TabIndex = 22;
            lblTelefone.Text = "Telefone:";
            // 
            // btnSalvar
            // 
            btnSalvar.AutoSize = true;
            btnSalvar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalvar.Location = new Point(388, 287);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 35);
            btnSalvar.TabIndex = 21;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtRepetirSenha
            // 
            txtRepetirSenha.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRepetirSenha.Location = new Point(152, 225);
            txtRepetirSenha.Name = "txtRepetirSenha";
            txtRepetirSenha.PasswordChar = '*';
            txtRepetirSenha.Size = new Size(263, 33);
            txtRepetirSenha.TabIndex = 19;
            txtRepetirSenha.KeyUp += txtRepetirSenha_KeyUp;
            // 
            // txtSenha
            // 
            txtSenha.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenha.Location = new Point(152, 180);
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.Size = new Size(263, 33);
            txtSenha.TabIndex = 18;
            txtSenha.KeyUp += txtSenha_KeyUp;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(152, 48);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(263, 33);
            txtUsuario.TabIndex = 17;
            txtUsuario.KeyUp += txtUsuario_KeyUp;
            // 
            // lblRepetirSenha
            // 
            lblRepetirSenha.AutoSize = true;
            lblRepetirSenha.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRepetirSenha.Location = new Point(5, 228);
            lblRepetirSenha.Name = "lblRepetirSenha";
            lblRepetirSenha.Size = new Size(145, 25);
            lblRepetirSenha.TabIndex = 16;
            lblRepetirSenha.Text = "Repetir a senha:";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSenha.Location = new Point(80, 183);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(68, 25);
            lblSenha.TabIndex = 15;
            lblSenha.Text = "Senha:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(69, 51);
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
            txtNome.Size = new Size(263, 33);
            txtNome.TabIndex = 12;
            txtNome.KeyUp += txtNome_KeyUp;
            // 
            // radGerente
            // 
            radGerente.AutoSize = true;
            radGerente.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radGerente.Location = new Point(16, 293);
            radGerente.Name = "radGerente";
            radGerente.Size = new Size(97, 29);
            radGerente.TabIndex = 30;
            radGerente.TabStop = true;
            radGerente.Text = "Gerente";
            radGerente.UseVisualStyleBackColor = true;
            // 
            // radVendedor
            // 
            radVendedor.AutoSize = true;
            radVendedor.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radVendedor.Location = new Point(137, 293);
            radVendedor.Name = "radVendedor";
            radVendedor.Size = new Size(112, 29);
            radVendedor.TabIndex = 31;
            radVendedor.TabStop = true;
            radVendedor.Text = "Vendedor";
            radVendedor.UseVisualStyleBackColor = true;
            // 
            // radCaixa
            // 
            radCaixa.AutoSize = true;
            radCaixa.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radCaixa.Location = new Point(276, 293);
            radCaixa.Name = "radCaixa";
            radCaixa.Size = new Size(76, 29);
            radCaixa.TabIndex = 32;
            radCaixa.TabStop = true;
            radCaixa.Text = "Caixa";
            radCaixa.UseVisualStyleBackColor = true;
            // 
            // CadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 354);
            Controls.Add(pnlPrincipal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
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
        private TextBox txtRepetirSenha;
        private TextBox txtSenha;
        private TextBox txtUsuario;
        private Label lblRepetirSenha;
        private Label lblSenha;
        private Label lblUsuario;
        private Label lblNome;
        private TextBox txtNome;
        private Label lblAviso;
        private Label lblSucesso;
        private Label lblEmail;
        private TextBox txtEmail;
        private RadioButton radCaixa;
        private RadioButton radVendedor;
        private RadioButton radGerente;
    }
}
