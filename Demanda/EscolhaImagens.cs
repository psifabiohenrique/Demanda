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
    public partial class EscolhaImagens : Form
    {
        public List<int> imagens_selecionadas = new List<int>();
        public List<string> indices_imagens;
        private Form pai;
        public EscolhaImagens(Form pai)
        {
            InitializeComponent();
            this.InicializaImagens();
            this.pai = pai;
            this.MdiParent = this.pai;
            this.EscolhaImagens_ResizeEnd(this, EventArgs.Empty);

            this.indices_imagens = new List<string>
            {
                "pcb_0",  "pcb_1",  "pcb_2",  "pcb_3",  "pcb_4",
                "pcb_5",  "pcb_6",  "pcb_7",  "pcb_8",  "pcb_9",
                "pcb_10", "pcb_11", "pcb_12", "pcb_13", "pcb_14",
                "pcb_15", "pcb_16", "pcb_17", "pcb_18", "pcb_19"
            };
            this.pnl_conteudo.Focus();

        }

        private void InicializaImagens()
        {
            string caminho = System.Environment.CurrentDirectory;
            pcb_0.ImageLocation = caminho + @"\images\" + 0 + ".png";
            pcb_1.ImageLocation = caminho + @"\images\" + 1 + ".png";
            pcb_2.ImageLocation = caminho + @"\images\" + 2 + ".png";
            pcb_3.ImageLocation = caminho + @"\images\" + 3 + ".png";
            pcb_4.ImageLocation = caminho + @"\images\" + 4 + ".png";
            pcb_5.ImageLocation = caminho + @"\images\" + 5 + ".png";
            pcb_6.ImageLocation = caminho + @"\images\" + 6 + ".png";
            pcb_7.ImageLocation = caminho + @"\images\" + 7 + ".png";
            pcb_8.ImageLocation = caminho + @"\images\" + 8 + ".png";
            pcb_9.ImageLocation = caminho + @"\images\" + 9 + ".png";

            pcb_10.ImageLocation = caminho + @"\images\" + 10 + ".png";
            pcb_11.ImageLocation = caminho + @"\images\" + 11 + ".png";
            pcb_12.ImageLocation = caminho + @"\images\" + 12 + ".png";
            pcb_13.ImageLocation = caminho + @"\images\" + 13 + ".png";
            pcb_14.ImageLocation = caminho + @"\images\" + 14 + ".png";
            pcb_15.ImageLocation = caminho + @"\images\" + 15 + ".png";
            pcb_16.ImageLocation = caminho + @"\images\" + 16 + ".png";
            pcb_17.ImageLocation = caminho + @"\images\" + 17 + ".png";
            pcb_18.ImageLocation = caminho + @"\images\" + 18 + ".png";
            pcb_19.ImageLocation = caminho + @"\images\" + 19 + ".png";
        }

        private void EscolhaImagens_ResizeEnd(object sender, EventArgs e)
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

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox? pb = sender as PictureBox;
            if (pb.BorderStyle == BorderStyle.None)
            {
                pb.BorderStyle = BorderStyle.Fixed3D;

                for (int i = 0; i < indices_imagens.Count(); i++)
                {
                    if (pb.Name == indices_imagens[i])
                    {
                        imagens_selecionadas.Add(i);
                    }
                }
            }
            else if (pb.BorderStyle == BorderStyle.Fixed3D)
            {
                pb.BorderStyle = BorderStyle.None;
                for (int i = 0; i < indices_imagens.Count(); i++)
                {
                    if (pb.Name == indices_imagens[i])
                    {
                        imagens_selecionadas.Remove(i);
                    }
                }
            }

            int numero_imagens = imagens_selecionadas.Count();
            lbl_quantidade.Text = $"Imagens Selecionadas: {numero_imagens}";
        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            int numero = imagens_selecionadas.Count();
            if (numero == 10)
            {
                this.Close();
                this.pai.Text = "Escolha_Imagens";
            }
            else if (numero < 10)
            {
                lbl_quantidade.Text = $"Você precisa selecionar 10 imagens.\n Total Selecionadas: {numero}";
            }
            else if (numero > 10)
            {
                lbl_quantidade.Text = $"Você precisa selecionar 10 imagens.\n Total Selecionadas: {numero}";
            }
        }
    }
}
