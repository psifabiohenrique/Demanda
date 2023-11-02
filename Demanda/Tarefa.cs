using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demanda
{
    public partial class Tarefa : Form
    {
        private Form pai;
        public List<int> lista = new List<int>();
        private int pergunta_atual = 1;
        public List<int> respostas = new List<int>();
        private int numero_tarefa;
        private string nome_tarefa;
        public Tarefa(Form pai, int imagem, string nome_tarefa, int numero_tarefa)
        {
            InitializeComponent();
            this.pai = pai;
            this.numero_tarefa = numero_tarefa;
            this.nome_tarefa = nome_tarefa;
            this.TarefaImpulsividade_ResizeEnd(this, EventArgs.Empty);
            this.Iniciar();
            pcb_imagem.ImageLocation = System.Environment.CurrentDirectory + @"\images\" + imagem + ".png";
            btn_continuar.Visible = false;
        }
        private void TarefaImpulsividade_ResizeEnd(object sender, EventArgs e)
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
        private void Iniciar()
        {
            this.hsb_resposta.Value = 50;
            if (this.nome_tarefa == "Impulsividade")
            {
                string valor = Valor_Condicao();
                this.lbl_intrucao.Text = "Imagine que você está prestes a ter relações sexuais com esta pessoa, você pode escolher entre fazê-lo agora, sem preservativo, ou esperar o prazo X para fazê-lo com preservativo. A pessoa que está disposta a fazer sexo com você é sua conhecida e você sabe que não possui nenhuma IST";
                this.lbl_intrucao2.Text = $"Você deve esperar {valor} para fazer sexo com preservativo ou fazê-lo imediatamente sem proteção. Nesse caso você:";
                this.lbl_valor_intervalo.Text = $"Tempo de espera: {valor}";
                this.lbl_sem_protecao.Text = "Eu definitivamente teria sexo sem proteção";
                this.lbl_com_protecao.Text = "Eu definitivamente teria sexo com proteção";
            }
            if (this.nome_tarefa == "Impulsividade2")
            {
                string valor = Valor_Condicao();
                this.lbl_intrucao.Text = "Por favor leia atentamente o texto abaixo: Seu melhor amigo, que costuma ter comportamento sexual semelhante ao seu e tem uma idade próxima, acabou de ligar para falar sobre uma festa onde conheceu alguém por quem se interessou. Eles acabaram fazendo sexo sem usar proteção. Seu amigo ficou muito satisfeito com o ocorrido, e te diz: “Eu me diverti muito e ela era muito atraente. Estou animado para vê-la de novo!” Um mês após a experiência, seu amigo recebeu uma mensagem no celular falando que a mulher está grávida dele. Ele está profundamente devastado, com medo de que toda a sua vida tenha acabado e chorando incontrolavelmente.";
                this.lbl_intrucao2.Text = $"Você deve esperar {valor} para fazer sexo com preservativo ou fazê-lo imediatamente sem proteção. Nesse caso você:";
                this.lbl_valor_intervalo.Text = $"Tempo de espera: {valor}";
                this.lbl_sem_protecao.Text = "Eu definitivamente teria sexo sem proteção";
                this.lbl_com_protecao.Text = "Eu definitivamente teria sexo com proteção";
            }
            else if (this.nome_tarefa == "Demanda")
            {
                string valor = Valor_Condicao();
                this.lbl_intrucao.Text = "Imagine que você está no supermercado local e tem a possibilidade de fazer uma compra de preservativo para utilizar hoje à noite com a pessoa da imagem. Pense que esses preservativos serão a única forma de proteção que vocês podem utilizar, que você não tenha preservativos guardados de dias anteriores, não possa obtê-los de outra fonte e que você possui sua renda típica em mãos para comprar esse item. Você sabe que a pessoa da imagem não possui nenhuma IST.";
                this.lbl_intrucao2.Text = $"Você se dirige ao caixa e só há um modelo de preservativo disponível, uma unidade por pacote, que custa {valor}, nessa situação você:";
                this.lbl_valor_intervalo.Text = $"Valor: {valor}";
                this.lbl_sem_protecao.Text = "Eu definitivamente não compraria camisinha";
                this.lbl_com_protecao.Text = "Eu definitivamente compraria camisinha";
            }
            else if (this.nome_tarefa == "Demanda2")
            {
                string valor = Valor_Condicao();
                this.lbl_intrucao.Text = "Por favor leia atentamente o texto abaixo: Seu melhor amigo, que costuma ter comportamento sexual semelhante ao seu e tem uma idade próxima, acabou de ligar para falar sobre uma festa onde conheceu alguém por quem se interessou. Eles acabaram fazendo sexo sem usar proteção. Seu amigo ficou muito satisfeito com o ocorrido, e te diz: “Eu me diverti muito e ela era muito atraente. Estou animado para vê-la de novo!” Um mês após a experiência, seu amigo recebeu uma mensagem no celular falando que a mulher está grávida dele. Ele está profundamente devastado, com medo de que toda a sua vida tenha acabado e chorando incontrolavelmente.";
                this.lbl_intrucao2.Text = $"Você se dirige ao caixa e só há um modelo de preservativo disponível, uma unidade por pacote, que custa {valor}, nessa situação você:";
                this.lbl_valor_intervalo.Text = $"Valor: {valor}";
                this.lbl_sem_protecao.Text = "Eu definitivamente não compraria camisinha";
                this.lbl_com_protecao.Text = "Eu definitivamente compraria camisinha";
            }
        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            this.respostas.Add(this.hsb_resposta.Value);
            if (this.nome_tarefa == "Impulsividade" || this.nome_tarefa == "Impulsividade2")
            {
                if (this.pergunta_atual < 8) // 8
                {
                    this.pergunta_atual++;
                    this.Iniciar();
                    this.Visible = false;
                    this.Visible = true;
                }
                else
                {
                    this.Close();
                    this.pai.Text = "tarefa_" + this.nome_tarefa + this.numero_tarefa;
                }
                this.btn_continuar.Visible = false;
            }
            else
            {
                if (this.pergunta_atual < 17) // 17
                {
                    this.pergunta_atual++;
                    this.Iniciar();
                    this.Visible = false;
                    this.Visible = true;
                }
                else
                {
                    this.Close();
                    this.pai.Text = "tarefa_" + this.nome_tarefa + this.numero_tarefa;
                }
                this.btn_continuar.Visible = false;
            }
        }

        private void hsb_resposta_ValueChanged(object sender, EventArgs e)
        {
            this.lbl_porcentagem.Text = hsb_resposta.Value.ToString() + "%";
            this.btn_continuar.Visible = true;
        }

        private string Valor_Condicao()
        {
            if (this.nome_tarefa == "Demanda" || this.nome_tarefa == "Demanda2")
            {
                String[] valores = { "R$ 0,50;", "R$ 1,00;", "R$ 3,00;", "R$ 5,00;", "R$ 7,50;", "R$ 10,00;", "R$ 12,50;", "R$ 15,00;", "R$ 17,50;", "R$ 20,00;", "R$ 25,00;", "R$ 35,00;", "R$ 50,00;", "R$ 75,00;", "R$ 100,00;", "R$ 125,00;", "R$ 150,00" };
                return valores[this.pergunta_atual - 1];
            }
            else
            {
                String[] valores = { "1 h", "3 h", "6 h", "1 dia", "3 dias", "1 semana", "1 mês", "3 meses" };
                return valores[this.pergunta_atual - 1];
            }
        }
    }
}
