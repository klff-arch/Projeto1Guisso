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
            mnuCadastro = new ToolStripMenuItem();
            mnuRelatorio = new ToolStripMenuItem();
            mnuAjuda = new ToolStripMenuItem();
            mnuArquivoSair = new ToolStripMenuItem();
            mnuCadastroUsuario = new ToolStripMenuItem();
            mnuRelatorioUsuarios = new ToolStripMenuItem();
            mnuSobre = new ToolStripMenuItem();
            mnuPrincipal.SuspendLayout();
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
            // mnuCadastro
            // 
            mnuCadastro.DropDownItems.AddRange(new ToolStripItem[] { mnuCadastroUsuario });
            mnuCadastro.Name = "mnuCadastro";
            mnuCadastro.Size = new Size(66, 20);
            mnuCadastro.Text = "Cadastro";
            // 
            // mnuRelatorio
            // 
            mnuRelatorio.DropDownItems.AddRange(new ToolStripItem[] { mnuRelatorioUsuarios });
            mnuRelatorio.Name = "mnuRelatorio";
            mnuRelatorio.Size = new Size(66, 20);
            mnuRelatorio.Text = "Relatório";
            // 
            // mnuAjuda
            // 
            mnuAjuda.DropDownItems.AddRange(new ToolStripItem[] { mnuSobre });
            mnuAjuda.Name = "mnuAjuda";
            mnuAjuda.Size = new Size(50, 20);
            mnuAjuda.Text = "Ajuda";
            // 
            // mnuArquivoSair
            // 
            mnuArquivoSair.Name = "mnuArquivoSair";
            mnuArquivoSair.Size = new Size(93, 22);
            mnuArquivoSair.Text = "Sair";
            // 
            // mnuCadastroUsuario
            // 
            mnuCadastroUsuario.Name = "mnuCadastroUsuario";
            mnuCadastroUsuario.Size = new Size(180, 22);
            mnuCadastroUsuario.Text = "Usuário";
            // 
            // mnuRelatorioUsuarios
            // 
            mnuRelatorioUsuarios.Name = "mnuRelatorioUsuarios";
            mnuRelatorioUsuarios.Size = new Size(180, 22);
            mnuRelatorioUsuarios.Text = "Usuários";
            // 
            // mnuSobre
            // 
            mnuSobre.Name = "mnuSobre";
            mnuSobre.Size = new Size(180, 22);
            mnuSobre.Text = "Sobre";
            // 
            // Sistema
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mnuPrincipal);
            MainMenuStrip = mnuPrincipal;
            Name = "Sistema";
            Text = "Sistema";
            mnuPrincipal.ResumeLayout(false);
            mnuPrincipal.PerformLayout();
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
        private ToolStripMenuItem mnuSobre;
    }
}