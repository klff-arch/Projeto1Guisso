namespace Projeto1
{
    partial class Sistema
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
            mnuPrincipal = new MenuStrip();
            mnuArquivo = new ToolStripMenuItem();
            mnuArquivoSair = new ToolStripMenuItem();
            mnuCadastro = new ToolStripMenuItem();
            mnuCadastroUsuario = new ToolStripMenuItem();
            mnuRelatorio = new ToolStripMenuItem();
            mnuRelatorioUsuarios = new ToolStripMenuItem();
            mnuAjuda = new ToolStripMenuItem();
            mnuAjudaSobre = new ToolStripMenuItem();
            staPrincipal = new StatusStrip();
            staAcesso = new ToolStripStatusLabel();
            mnuRelatorioEstoque = new ToolStripMenuItem();
            mnuCadastroCategoria = new ToolStripMenuItem();
            mnuCadastroProduto = new ToolStripMenuItem();
            mnuPrincipal.SuspendLayout();
            staPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // mnuPrincipal
            // 
            mnuPrincipal.Items.AddRange(new ToolStripItem[] { mnuArquivo, mnuCadastro, mnuRelatorio, mnuAjuda });
            mnuPrincipal.Location = new Point(0, 0);
            mnuPrincipal.Name = "mnuPrincipal";
            mnuPrincipal.Size = new Size(800, 24);
            mnuPrincipal.TabIndex = 0;
            mnuPrincipal.Text = "menuStrip1";
            // 
            // mnuArquivo
            // 
            mnuArquivo.DropDownItems.AddRange(new ToolStripItem[] { mnuArquivoSair });
            mnuArquivo.Name = "mnuArquivo";
            mnuArquivo.Size = new Size(61, 20);
            mnuArquivo.Text = "Arquivo";
            // 
            // mnuArquivoSair
            // 
            mnuArquivoSair.Name = "mnuArquivoSair";
            mnuArquivoSair.Size = new Size(93, 22);
            mnuArquivoSair.Text = "Sair";
            mnuArquivoSair.Click += mnuArquivoSair_Click;
            // 
            // mnuCadastro
            // 
            mnuCadastro.DropDownItems.AddRange(new ToolStripItem[] { mnuCadastroUsuario, mnuCadastroCategoria, mnuCadastroProduto });
            mnuCadastro.Name = "mnuCadastro";
            mnuCadastro.Size = new Size(66, 20);
            mnuCadastro.Text = "Cadastro";
            // 
            // mnuCadastroUsuario
            // 
            mnuCadastroUsuario.Name = "mnuCadastroUsuario";
            mnuCadastroUsuario.Size = new Size(180, 22);
            mnuCadastroUsuario.Text = "Usuário";
            mnuCadastroUsuario.Click += mnuCadastroUsuario_Click;
            // 
            // mnuRelatorio
            // 
            mnuRelatorio.DropDownItems.AddRange(new ToolStripItem[] { mnuRelatorioUsuarios, mnuRelatorioEstoque });
            mnuRelatorio.Name = "mnuRelatorio";
            mnuRelatorio.Size = new Size(66, 20);
            mnuRelatorio.Text = "Relatório";
            // 
            // mnuRelatorioUsuarios
            // 
            mnuRelatorioUsuarios.Name = "mnuRelatorioUsuarios";
            mnuRelatorioUsuarios.Size = new Size(180, 22);
            mnuRelatorioUsuarios.Text = "Usuários";
            mnuRelatorioUsuarios.Click += mnuRelatorioUsuarios_Click;
            // 
            // mnuAjuda
            // 
            mnuAjuda.DropDownItems.AddRange(new ToolStripItem[] { mnuAjudaSobre });
            mnuAjuda.Name = "mnuAjuda";
            mnuAjuda.Size = new Size(50, 20);
            mnuAjuda.Text = "Ajuda";
            // 
            // mnuAjudaSobre
            // 
            mnuAjudaSobre.Name = "mnuAjudaSobre";
            mnuAjudaSobre.Size = new Size(104, 22);
            mnuAjudaSobre.Text = "Sobre";
            mnuAjudaSobre.Click += mnuSobre_Click;
            // 
            // staPrincipal
            // 
            staPrincipal.Items.AddRange(new ToolStripItem[] { staAcesso });
            staPrincipal.Location = new Point(0, 428);
            staPrincipal.Name = "staPrincipal";
            staPrincipal.Size = new Size(800, 22);
            staPrincipal.TabIndex = 4;
            staPrincipal.Text = "statusStrip1";
            // 
            // staAcesso
            // 
            staAcesso.Name = "staAcesso";
            staAcesso.Size = new Size(84, 17);
            staAcesso.Text = "Último acesso:";
            // 
            // mnuRelatorioEstoque
            // 
            mnuRelatorioEstoque.Name = "mnuRelatorioEstoque";
            mnuRelatorioEstoque.Size = new Size(180, 22);
            mnuRelatorioEstoque.Text = "Estoque";
            // 
            // mnuCadastroCategoria
            // 
            mnuCadastroCategoria.Name = "mnuCadastroCategoria";
            mnuCadastroCategoria.Size = new Size(180, 22);
            mnuCadastroCategoria.Text = "Categoria";
            // 
            // mnuCadastroProduto
            // 
            mnuCadastroProduto.Name = "mnuCadastroProduto";
            mnuCadastroProduto.Size = new Size(180, 22);
            mnuCadastroProduto.Text = "Produto";
            // 
            // Sistema
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(staPrincipal);
            Controls.Add(mnuPrincipal);
            IsMdiContainer = true;
            MainMenuStrip = mnuPrincipal;
            Name = "Sistema";
            Text = "Sistema";
            FormClosing += Sistema_FormClosing;
            FormClosed += Sistema_FormClosed;
            mnuPrincipal.ResumeLayout(false);
            mnuPrincipal.PerformLayout();
            staPrincipal.ResumeLayout(false);
            staPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuPrincipal;
        private ToolStripMenuItem mnuArquivo;
        private ToolStripMenuItem mnuArquivoSair;
        private ToolStripMenuItem mnuCadastro;
        private ToolStripMenuItem mnuCadastroUsuario;
        private ToolStripMenuItem mnuRelatorio;
        private ToolStripMenuItem mnuRelatorioUsuarios;
        private ToolStripMenuItem mnuAjuda;
        private ToolStripMenuItem mnuAjudaSobre;
        private StatusStrip staPrincipal;
        private ToolStripStatusLabel staAcesso;
        private ToolStripMenuItem mnuCadastroCategoria;
        private ToolStripMenuItem mnuCadastroProduto;
        private ToolStripMenuItem mnuRelatorioEstoque;
    }
}