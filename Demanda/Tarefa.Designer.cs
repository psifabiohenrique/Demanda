namespace Demanda
{
    partial class Tarefa
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
            lbl_porcentagem = new Label();
            lbl_valor_intervalo = new Label();
            lbl_negrito = new Label();
            btn_continuar = new Button();
            lbl_com_protecao = new Label();
            lbl_sem_protecao = new Label();
            lbl_intrucao2 = new Label();
            lbl_intrucao = new Label();
            pcb_imagem = new PictureBox();
            hsb_resposta = new HScrollBar();
            pnl_conteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcb_imagem).BeginInit();
            SuspendLayout();
            // 
            // pnl_conteudo
            // 
            pnl_conteudo.BorderStyle = BorderStyle.FixedSingle;
            pnl_conteudo.Controls.Add(lbl_porcentagem);
            pnl_conteudo.Controls.Add(lbl_valor_intervalo);
            pnl_conteudo.Controls.Add(lbl_negrito);
            pnl_conteudo.Controls.Add(btn_continuar);
            pnl_conteudo.Controls.Add(lbl_com_protecao);
            pnl_conteudo.Controls.Add(lbl_sem_protecao);
            pnl_conteudo.Controls.Add(lbl_intrucao2);
            pnl_conteudo.Controls.Add(lbl_intrucao);
            pnl_conteudo.Controls.Add(pcb_imagem);
            pnl_conteudo.Controls.Add(hsb_resposta);
            pnl_conteudo.ForeColor = SystemColors.ControlText;
            pnl_conteudo.Location = new Point(0, 0);
            pnl_conteudo.Margin = new Padding(3, 4, 3, 4);
            pnl_conteudo.Name = "pnl_conteudo";
            pnl_conteudo.Size = new Size(1463, 911);
            pnl_conteudo.TabIndex = 0;
            // 
            // lbl_porcentagem
            // 
            lbl_porcentagem.AutoSize = true;
            lbl_porcentagem.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_porcentagem.Location = new Point(893, 604);
            lbl_porcentagem.Name = "lbl_porcentagem";
            lbl_porcentagem.Size = new Size(48, 25);
            lbl_porcentagem.TabIndex = 10;
            lbl_porcentagem.Text = "50%";
            lbl_porcentagem.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_valor_intervalo
            // 
            lbl_valor_intervalo.BorderStyle = BorderStyle.FixedSingle;
            lbl_valor_intervalo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_valor_intervalo.ForeColor = SystemColors.ControlText;
            lbl_valor_intervalo.Location = new Point(843, 446);
            lbl_valor_intervalo.Name = "lbl_valor_intervalo";
            lbl_valor_intervalo.Size = new Size(154, 78);
            lbl_valor_intervalo.TabIndex = 9;
            lbl_valor_intervalo.Text = "Valor ou Intervalo";
            lbl_valor_intervalo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_negrito
            // 
            lbl_negrito.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_negrito.ForeColor = SystemColors.ControlText;
            lbl_negrito.Location = new Point(394, 280);
            lbl_negrito.Name = "lbl_negrito";
            lbl_negrito.Size = new Size(992, 78);
            lbl_negrito.TabIndex = 8;
            lbl_negrito.Text = "No entanto, ela confidenciou recentemente que não faz uso de métodos contraceptivos.";
            lbl_negrito.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_continuar
            // 
            btn_continuar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_continuar.Location = new Point(46, 782);
            btn_continuar.Margin = new Padding(3, 4, 3, 4);
            btn_continuar.Name = "btn_continuar";
            btn_continuar.Size = new Size(1333, 75);
            btn_continuar.TabIndex = 7;
            btn_continuar.Text = "Continuar";
            btn_continuar.UseVisualStyleBackColor = true;
            btn_continuar.Click += btn_continuar_Click;
            // 
            // lbl_com_protecao
            // 
            lbl_com_protecao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_com_protecao.Location = new Point(1237, 505);
            lbl_com_protecao.Name = "lbl_com_protecao";
            lbl_com_protecao.Size = new Size(142, 141);
            lbl_com_protecao.TabIndex = 6;
            lbl_com_protecao.Text = "Eu definitivamente teria sexo com proteção";
            lbl_com_protecao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_sem_protecao
            // 
            lbl_sem_protecao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_sem_protecao.Location = new Point(457, 505);
            lbl_sem_protecao.Name = "lbl_sem_protecao";
            lbl_sem_protecao.Size = new Size(142, 141);
            lbl_sem_protecao.TabIndex = 5;
            lbl_sem_protecao.Text = "Eu definitivamente teria sexo sem proteção";
            lbl_sem_protecao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_intrucao2
            // 
            lbl_intrucao2.BorderStyle = BorderStyle.FixedSingle;
            lbl_intrucao2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_intrucao2.ForeColor = SystemColors.ControlText;
            lbl_intrucao2.Location = new Point(394, 358);
            lbl_intrucao2.Name = "lbl_intrucao2";
            lbl_intrucao2.Size = new Size(992, 78);
            lbl_intrucao2.TabIndex = 4;
            lbl_intrucao2.Text = "Aqui tem uma Instrução";
            lbl_intrucao2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_intrucao
            // 
            lbl_intrucao.BorderStyle = BorderStyle.FixedSingle;
            lbl_intrucao.Font = new Font("Segoe UI", 12.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_intrucao.ForeColor = SystemColors.ControlText;
            lbl_intrucao.Location = new Point(394, 57);
            lbl_intrucao.Name = "lbl_intrucao";
            lbl_intrucao.Size = new Size(992, 223);
            lbl_intrucao.TabIndex = 3;
            lbl_intrucao.Text = "Aqui tem uma Instrução";
            lbl_intrucao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pcb_imagem
            // 
            pcb_imagem.Location = new Point(46, 77);
            pcb_imagem.Margin = new Padding(3, 4, 3, 4);
            pcb_imagem.Name = "pcb_imagem";
            pcb_imagem.Size = new Size(265, 476);
            pcb_imagem.SizeMode = PictureBoxSizeMode.StretchImage;
            pcb_imagem.TabIndex = 2;
            pcb_imagem.TabStop = false;
            // 
            // hsb_resposta
            // 
            hsb_resposta.LargeChange = 1;
            hsb_resposta.Location = new Point(602, 547);
            hsb_resposta.Name = "hsb_resposta";
            hsb_resposta.Size = new Size(631, 40);
            hsb_resposta.TabIndex = 1;
            hsb_resposta.Value = 50;
            hsb_resposta.ValueChanged += hsb_resposta_ValueChanged;
            // 
            // Tarefa
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1474, 925);
            Controls.Add(pnl_conteudo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Tarefa";
            Text = "TarefaImpulsividade";
            WindowState = FormWindowState.Maximized;
            pnl_conteudo.ResumeLayout(false);
            pnl_conteudo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcb_imagem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnl_conteudo;
        private PictureBox pcb_imagem;
        private Label lbl_intrucao;
        private Label lbl_sem_protecao;
        private Label lbl_intrucao2;
        private Label lbl_com_protecao;
        private Button btn_continuar;
        private HScrollBar hsb_resposta;
        private Label lbl_negrito;
        private Label lbl_valor_intervalo;
        private Label lbl_porcentagem;
    }
}