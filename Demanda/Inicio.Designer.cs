namespace Demanda
{
    partial class Inicio
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
            btn_iniciar = new Button();
            gbx_ordem_preferencia = new GroupBox();
            rbt_decrescente = new RadioButton();
            rbt_crescente = new RadioButton();
            btn_gerarJson = new Button();
            gbx_ordem_preferencia.SuspendLayout();
            SuspendLayout();
            // 
            // btn_iniciar
            // 
            btn_iniciar.Location = new Point(131, 166);
            btn_iniciar.Name = "btn_iniciar";
            btn_iniciar.Size = new Size(176, 78);
            btn_iniciar.TabIndex = 0;
            btn_iniciar.Text = "Iniciar";
            btn_iniciar.UseVisualStyleBackColor = true;
            btn_iniciar.Click += btn_iniciar_Click;
            // 
            // gbx_ordem_preferencia
            // 
            gbx_ordem_preferencia.Controls.Add(rbt_decrescente);
            gbx_ordem_preferencia.Controls.Add(rbt_crescente);
            gbx_ordem_preferencia.Location = new Point(434, 154);
            gbx_ordem_preferencia.Name = "gbx_ordem_preferencia";
            gbx_ordem_preferencia.Size = new Size(200, 100);
            gbx_ordem_preferencia.TabIndex = 1;
            gbx_ordem_preferencia.TabStop = false;
            gbx_ordem_preferencia.Text = "Ordem de preferência";
            // 
            // rbt_decrescente
            // 
            rbt_decrescente.AutoSize = true;
            rbt_decrescente.Location = new Point(11, 52);
            rbt_decrescente.Name = "rbt_decrescente";
            rbt_decrescente.Size = new Size(71, 19);
            rbt_decrescente.TabIndex = 1;
            rbt_decrescente.Text = "10 - 5 - 1";
            rbt_decrescente.UseVisualStyleBackColor = true;
            // 
            // rbt_crescente
            // 
            rbt_crescente.AutoSize = true;
            rbt_crescente.Checked = true;
            rbt_crescente.Location = new Point(11, 27);
            rbt_crescente.Name = "rbt_crescente";
            rbt_crescente.Size = new Size(71, 19);
            rbt_crescente.TabIndex = 0;
            rbt_crescente.TabStop = true;
            rbt_crescente.Text = "1 - 5 - 10";
            rbt_crescente.UseVisualStyleBackColor = true;
            // 
            // btn_gerarJson
            // 
            btn_gerarJson.Location = new Point(696, 408);
            btn_gerarJson.Name = "btn_gerarJson";
            btn_gerarJson.Size = new Size(75, 23);
            btn_gerarJson.TabIndex = 2;
            btn_gerarJson.Text = "Gerar Json";
            btn_gerarJson.UseVisualStyleBackColor = true;
            btn_gerarJson.Click += btn_gerarJson_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_gerarJson);
            Controls.Add(gbx_ordem_preferencia);
            Controls.Add(btn_iniciar);
            Name = "Inicio";
            Text = "Demanda";
            gbx_ordem_preferencia.ResumeLayout(false);
            gbx_ordem_preferencia.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_iniciar;
        private GroupBox gbx_ordem_preferencia;
        private RadioButton rbt_decrescente;
        private RadioButton rbt_crescente;
        private Button btn_gerarJson;
    }
}