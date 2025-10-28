namespace Projeto1
{
    partial class AjudaSobre
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
            panel1 = new Panel();
            lblDesenvolvedores = new Label();
            lblDesenvolvedor2 = new Label();
            lblDesenvolvedor1 = new Label();
            lblVersao = new Label();
            lblPrograma = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(lblDesenvolvedores);
            panel1.Controls.Add(lblDesenvolvedor2);
            panel1.Controls.Add(lblDesenvolvedor1);
            panel1.Controls.Add(lblVersao);
            panel1.Controls.Add(lblPrograma);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(277, 189);
            panel1.TabIndex = 0;
            // 
            // lblDesenvolvedores
            // 
            lblDesenvolvedores.AutoSize = true;
            lblDesenvolvedores.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDesenvolvedores.Location = new Point(3, 42);
            lblDesenvolvedores.Name = "lblDesenvolvedores";
            lblDesenvolvedores.Size = new Size(163, 25);
            lblDesenvolvedores.TabIndex = 9;
            lblDesenvolvedores.Text = "Desenvolvedores:";
            // 
            // lblDesenvolvedor2
            // 
            lblDesenvolvedor2.AutoSize = true;
            lblDesenvolvedor2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDesenvolvedor2.Location = new Point(3, 120);
            lblDesenvolvedor2.Name = "lblDesenvolvedor2";
            lblDesenvolvedor2.Size = new Size(211, 25);
            lblDesenvolvedor2.TabIndex = 8;
            lblDesenvolvedor2.Text = "Pedro Durães de Freitas";
            // 
            // lblDesenvolvedor1
            // 
            lblDesenvolvedor1.AutoSize = true;
            lblDesenvolvedor1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDesenvolvedor1.Location = new Point(3, 81);
            lblDesenvolvedor1.Name = "lblDesenvolvedor1";
            lblDesenvolvedor1.Size = new Size(266, 25);
            lblDesenvolvedor1.TabIndex = 7;
            lblDesenvolvedor1.Text = "Karen Lorena Fernandes Fróes";
            // 
            // lblVersao
            // 
            lblVersao.AutoSize = true;
            lblVersao.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVersao.Location = new Point(238, 162);
            lblVersao.Name = "lblVersao";
            lblVersao.Size = new Size(31, 17);
            lblVersao.TabIndex = 6;
            lblVersao.Text = "v1.0";
            // 
            // lblPrograma
            // 
            lblPrograma.AutoSize = true;
            lblPrograma.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrograma.Location = new Point(82, 10);
            lblPrograma.Name = "lblPrograma";
            lblPrograma.Size = new Size(132, 21);
            lblPrograma.TabIndex = 5;
            lblPrograma.Text = "VisualStudio2022";
            // 
            // AjudaSobre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 213);
            Controls.Add(panel1);
            Name = "AjudaSobre";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblDesenvolvedores;
        private Label lblDesenvolvedor2;
        private Label lblDesenvolvedor1;
        private Label lblVersao;
        private Label lblPrograma;
    }
}