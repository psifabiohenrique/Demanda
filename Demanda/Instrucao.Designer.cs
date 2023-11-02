namespace Demanda
{
    partial class Instrucao
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
            pnl_conteudo = new Panel();
            btn_continuar = new Button();
            lbl_intrucao = new Label();
            pnl_conteudo.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_conteudo
            // 
            pnl_conteudo.Controls.Add(btn_continuar);
            pnl_conteudo.Controls.Add(lbl_intrucao);
            pnl_conteudo.Location = new Point(0, 0);
            pnl_conteudo.Name = "pnl_conteudo";
            pnl_conteudo.Size = new Size(1280, 720);
            pnl_conteudo.TabIndex = 0;
            // 
            // btn_continuar
            // 
            btn_continuar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_continuar.Location = new Point(12, 630);
            btn_continuar.Name = "btn_continuar";
            btn_continuar.Size = new Size(1256, 61);
            btn_continuar.TabIndex = 1;
            btn_continuar.Text = "Continuar";
            btn_continuar.UseVisualStyleBackColor = true;
            btn_continuar.Click += btn_continuar_Click;
            // 
            // lbl_intrucao
            // 
            lbl_intrucao.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_intrucao.Location = new Point(213, 9);
            lbl_intrucao.Name = "lbl_intrucao";
            lbl_intrucao.Size = new Size(845, 572);
            lbl_intrucao.TabIndex = 0;
            lbl_intrucao.Text = "Aqui tem uma instrução importante";
            lbl_intrucao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Instrucao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1280, 720);
            ControlBox = false;
            Controls.Add(pnl_conteudo);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Instrucao";
            ShowIcon = false;
            Text = "Instrucao";
            WindowState = FormWindowState.Maximized;
            ResizeEnd += Instrucao_ResizeEnd;
            pnl_conteudo.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_conteudo;
        private Label lbl_intrucao;
        private Button btn_continuar;
    }
}