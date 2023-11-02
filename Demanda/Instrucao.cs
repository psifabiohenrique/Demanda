using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demanda
{
    public partial class Instrucao : Form
    {
        private Form pai;
        private string etapa;
        private Configuracoes config;
        public Instrucao(Form pai, string etapa, Configuracoes config)
        {
            InitializeComponent();
            this.pai = pai;
            this.MdiParent = this.pai;
            this.Instrucao_ResizeEnd(this, EventArgs.Empty);
            this.pnl_conteudo.Focus();
            this.etapa = etapa;
            this.config = config;
            if (etapa == "instrução")
            {
                this.lbl_intrucao.Text = config.instrucao1;
            } else if (etapa == "instrução_impulsividade")
            {
                this.lbl_intrucao.Text = config.instrucao2;
            } else if (etapa == "instrução_impulsividade2")
            {
                this.lbl_intrucao.Text = config.instrucao2;
            } else if (etapa == "instrução_demanda")
            {
                this.lbl_intrucao.Text = config.instrucao3;
            } else if (etapa == "instrução_demanda2")
            {
                this.lbl_intrucao.Text = config.instrucao3;
            }
        }

        private void Instrucao_ResizeEnd(object sender, EventArgs e)
        {
            Screen screen = Screen.PrimaryScreen;
            int altura = screen.Bounds.Height;
            int largura = screen.Bounds.Width;
            int y = pnl_conteudo.Location.Y;
            int x = pnl_conteudo.Location.X;
            if (altura > pnl_conteudo.Height)
            {
                y = (altura - pnl_conteudo.Height) / 2;
            }
            if (largura > pnl_conteudo.Width)
            {
                x = (largura - pnl_conteudo.Width) / 2;
            }
            pnl_conteudo.Location = new Point(x, y);
        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            //this.MdiParent.Text = "instrução";
            this.Close();
            this.pai.Text = this.etapa;
        }
    }
}
