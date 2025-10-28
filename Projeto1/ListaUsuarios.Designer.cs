namespace Projeto1
{
    partial class ListaUsuarios
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
            lstUsuarios = new ListBox();
            lblListaUsuarios = new Label();
            pnlPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlPrincipal.Controls.Add(lstUsuarios);
            pnlPrincipal.Controls.Add(lblListaUsuarios);
            pnlPrincipal.Location = new Point(12, 12);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(182, 197);
            pnlPrincipal.TabIndex = 0;
            // 
            // lstUsuarios
            // 
            lstUsuarios.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstUsuarios.FormattingEnabled = true;
            lstUsuarios.ItemHeight = 25;
            lstUsuarios.Location = new Point(29, 52);
            lstUsuarios.Name = "lstUsuarios";
            lstUsuarios.Size = new Size(120, 79);
            lstUsuarios.TabIndex = 3;
            // 
            // lblListaUsuarios
            // 
            lblListaUsuarios.AutoSize = true;
            lblListaUsuarios.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblListaUsuarios.Location = new Point(12, 12);
            lblListaUsuarios.Name = "lblListaUsuarios";
            lblListaUsuarios.Size = new Size(154, 25);
            lblListaUsuarios.TabIndex = 2;
            lblListaUsuarios.Text = "Lista de Usuários";
            // 
            // ListaUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(206, 221);
            Controls.Add(pnlPrincipal);
            Name = "ListaUsuarios";
            Text = "Form2";
            pnlPrincipal.ResumeLayout(false);
            pnlPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPrincipal;
        private ListBox lstUsuarios;
        private Label lblListaUsuarios;
    }
}