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
    public partial class RankImagens : Form
    {
        public List<int> imagens_selecionadas { get; set; }
        public List<int> imagens_ranqueadas { get; set; }
        private Form pai;
        private Configuracoes config;
        public RankImagens(Form pai, List<int> imagens, Configuracoes config)
        {
            InitializeComponent();
            imagens_selecionadas = imagens;
            this.RankImagens_ResizeEnd(this, EventArgs.Empty);
            this.Atualiza_Imagens();
            this.config = config;
            this.lbl_instrucao.Text = this.config.instrucao_rank_imagem;
            this.pai = pai;
        }

        private void RankImagens_ResizeEnd(object sender, EventArgs e)
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
        private void Atualiza_Imagens()
        {
            string caminho = System.Environment.CurrentDirectory;
            pcb_1.ImageLocation = caminho + @"\images\" + imagens_selecionadas[0] + ".png";
            pcb_2.ImageLocation = caminho + @"\images\" + imagens_selecionadas[1] + ".png";
            pcb_3.ImageLocation = caminho + @"\images\" + imagens_selecionadas[2] + ".png";
            pcb_4.ImageLocation = caminho + @"\images\" + imagens_selecionadas[3] + ".png";
            pcb_5.ImageLocation = caminho + @"\images\" + imagens_selecionadas[4] + ".png";
            pcb_6.ImageLocation = caminho + @"\images\" + imagens_selecionadas[5] + ".png";
            pcb_7.ImageLocation = caminho + @"\images\" + imagens_selecionadas[6] + ".png";
            pcb_8.ImageLocation = caminho + @"\images\" + imagens_selecionadas[7] + ".png";
            pcb_9.ImageLocation = caminho + @"\images\" + imagens_selecionadas[8] + ".png";
            pcb_10.ImageLocation = caminho + @"\images\" + imagens_selecionadas[9] + ".png";
        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            try
            {
                List<int> lista_bruta = new List<int>
                {
                    int.Parse(txb_1.Text), int.Parse(txb_2.Text), int.Parse(txb_3.Text),
                    int.Parse(txb_4.Text), int.Parse(txb_5.Text), int.Parse(txb_6.Text),
                    int.Parse(txb_7.Text), int.Parse(txb_8.Text), int.Parse(txb_9.Text),
                    int.Parse(txb_10.Text)
                };
                List<int> lista_arrumada = new List<int>();

                foreach (var item in lista_bruta)
                {
                    if (0 < item && item <= 10)
                    {
                        bool esta_na_lista = false;
                        foreach (var item1 in lista_arrumada)
                        {
                            if (item1 == item)
                            {
                                esta_na_lista = true;
                                this.lbl_aviso.Text = "A ordem das imagens não pode repetir!";
                                break;
                            }
                        }
                        if (!esta_na_lista)
                        {
                            lista_arrumada.Add(item);
                        }
                    }
                    else
                    {
                        this.lbl_aviso.Text = "Você deve numerar as imagens com valores entre 1 e 10";
                        break;
                    }
                }

                if (lista_arrumada.Count() == 10)
                {
                    imagens_ranqueadas = lista_arrumada;
                    this.Close();
                    this.pai.Text = "RankImagens";
                }
            }
            catch (Exception ex)
            {
                this.lbl_aviso.Text = "Você deve numerar as imagens com valores entre 1 e 10";
            }

        }
    }
}
