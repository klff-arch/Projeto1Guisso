namespace Projeto1
{
    partial class ListaEstoque
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
            lblEstoqueMin = new Label();
            lstEstoque = new ListBox();
            pnlPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // pnlPrincipal
            // 
            pnlPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlPrincipal.Controls.Add(lstEstoque);
            pnlPrincipal.Controls.Add(lblEstoqueMin);
            pnlPrincipal.Location = new Point(12, 12);
            pnlPrincipal.Name = "pnlPrincipal";
            pnlPrincipal.Size = new Size(281, 426);
            pnlPrincipal.TabIndex = 0;
            // 
            // lblEstoqueMin
            // 
            lblEstoqueMin.AutoSize = true;
            lblEstoqueMin.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstoqueMin.Location = new Point(3, 10);
            lblEstoqueMin.Name = "lblEstoqueMin";
            lblEstoqueMin.Size = new Size(274, 25);
            lblEstoqueMin.TabIndex = 0;
            lblEstoqueMin.Text = "Produtos com estoque mínimo:";
            // 
            // lstEstoque
            // 
            lstEstoque.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstEstoque.FormattingEnabled = true;
            lstEstoque.ItemHeight = 21;
            lstEstoque.Location = new Point(31, 53);
            lstEstoque.Name = "lstEstoque";
            lstEstoque.Size = new Size(219, 340);
            lstEstoque.TabIndex = 1;
            // 
            // ListaEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 450);
            Controls.Add(pnlPrincipal);
            Name = "ListaEstoque";
            Text = "ListaEstoque";
            pnlPrincipal.ResumeLayout(false);
            pnlPrincipal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPrincipal;
        private ListBox lstEstoque;
        private Label lblEstoqueMin;
    }
}