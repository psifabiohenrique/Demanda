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
    public partial class Jogo : Form
    {
        public Configuracoes config;
        public Instrucao instrucao;
        public Instrucao instrucao_impulsividade;
        public EscolhaImagens escolha;
        public RankImagens rank;
        public Tarefa tarefa_impulsividade;

        public List<int> ordem_escolhas;

        public List<int> imagens_selecionadas;
        public List<int> imagens_ranqueadas;

        #region respostas
        public List<int> respostas1;
        public List<int> respostas2;
        public List<int> respostas3;
        public int numero_tarefas = 1;
        public string nome_tarefa = "Impulsividade";

        public Dictionary<string, List<int>> total_respostas = new Dictionary<string, List<int>>();

        #endregion
        public Jogo(List<int> ordem, Configuracoes config)
        {
            InitializeComponent();
            this.ordem_escolhas = ordem;
            this.config = config;
        }
        private void Jogo_Load(object sender, EventArgs e)
        {
            this.Instrucao("instrução");
        }
        public void Escolha_Imagem()
        {
            this.escolha = new EscolhaImagens(this);
            this.escolha.Show();
        }
        public void Rank_Imagens()
        {
            this.rank = new RankImagens(this, this.escolha.imagens_selecionadas, this.config);
            this.rank.Show();
        }
        public void Instrucao(string qual_instrucao)
        {
            this.instrucao_impulsividade = new Instrucao(this, qual_instrucao, this.config);
            this.instrucao_impulsividade.Show();
        }
        public void Tarefa(int imagem)
        {
            this.tarefa_impulsividade = new Tarefa(this, imagem, this.nome_tarefa, this.numero_tarefas);
            this.tarefa_impulsividade.Show();
        }
        private void Jogo_TextChanged(object sender, EventArgs e)
        {
            if (this.Text == "instrução")
            {
                Escolha_Imagem();
            }
            if(this.Text == "instrução_impulsividade")
            {
                int imagem = Pega_Imagem_Ranqueada(this.ordem_escolhas[0]);
                this.Tarefa(this.escolha.imagens_selecionadas[imagem]);
            }
            if (this.Text == "instrução_impulsividade2")
            {
                int imagem = Pega_Imagem_Ranqueada(this.ordem_escolhas[0]);
                this.Tarefa(this.escolha.imagens_selecionadas[imagem]);
            }
            if (this.Text == "instrução_demanda")
            {
                int imagem = Pega_Imagem_Ranqueada(this.ordem_escolhas[0]);
                this.Tarefa(this.escolha.imagens_selecionadas[imagem]);
            }
            if (this.Text == "instrução_demanda2")
            {
                int imagem = Pega_Imagem_Ranqueada(this.ordem_escolhas[0]);
                this.Tarefa(this.escolha.imagens_selecionadas[imagem]);
            }

            if (this.Text == "Escolha_Imagens")
            {
                Rank_Imagens();
            }
            if (this.Text == "RankImagens")
            {
                this.imagens_ranqueadas = this.rank.imagens_ranqueadas;
                this.Instrucao("instrução_impulsividade");
            }
            if (this.Text == "tarefa_" + this.nome_tarefa + this.numero_tarefas)
            {
                if (respostas1 == null)
                {
                    respostas1 = tarefa_impulsividade.respostas;
                    this.numero_tarefas += 1;
                    int imagem = Pega_Imagem_Ranqueada(this.ordem_escolhas[1]);
                    this.Tarefa(this.escolha.imagens_selecionadas[imagem]);
                } 
                else if (respostas2 == null)
                {
                    respostas2 = tarefa_impulsividade.respostas;
                    this.numero_tarefas += 1;
                    int imagem = Pega_Imagem_Ranqueada(this.ordem_escolhas[2]);
                    this.Tarefa(this.escolha.imagens_selecionadas[imagem]);
                } 
                else
                {
                    this.numero_tarefas = 1;
                    // Aqui é necessário salvar os valores das respostas e voltar as variáveis para nulo
                    this.total_respostas.Add($"{this.nome_tarefa} {this.ordem_escolhas[0]}", respostas1);
                    this.total_respostas.Add($"{this.nome_tarefa} {this.ordem_escolhas[1]}", respostas2);
                    this.total_respostas.Add($"{this.nome_tarefa} {this.ordem_escolhas[2]}", tarefa_impulsividade.respostas);


                    respostas1 = null;
                    respostas2 = null;
                    if(this.nome_tarefa == "Demanda2")
                    {
                        string nome_arquivo = DateTime.Now.ToString().Replace(@"/", "_").Replace(":", "-") + ".txt";
                        try
                        {
                            using (StreamWriter file = new StreamWriter(System.Environment.CurrentDirectory + @"\dados\" + nome_arquivo))
                                foreach (var entry in this.total_respostas) 
                                {
                                    file.Write($"[{entry.Key.ToString()} --> [");
                                    foreach (var dado in entry.Value) file.Write($"{dado.ToString()}, ");
                                    file.WriteLine("]");
                                } 
                        } 
                        catch (Exception ex)
                        {
                            Directory.CreateDirectory(System.Environment.CurrentDirectory + @"\dados\");
                            using (StreamWriter file = new StreamWriter(System.Environment.CurrentDirectory + @"\dados\" + nome_arquivo))
                                foreach (var entry in this.total_respostas)
                                {
                                    file.Write($"[{entry.Key.ToString()} --> [");
                                    foreach (var dado in entry.Value) file.Write($"{dado.ToString()}, ");
                                    file.WriteLine("]");
                                }
                        }
                        MessageBox.Show("Obrigado por participar desta pesquisa!");
                        this.Close();
                    } else if (this.nome_tarefa == "Impulsividade")
                    {
                        this.Instrucao("instrução_demanda");
                        this.nome_tarefa = "Demanda";
                    } else if (this.nome_tarefa == "Impulsividade2")
                    {
                        this.Instrucao("instrução_demanda2");
                        this.nome_tarefa = "Demanda2";
                    } else if (this.nome_tarefa == "Demanda")
                    {
                        this.Instrucao("instrução_impulsividade2");
                        this.nome_tarefa = "Impulsividade2";
                    }
                }
            }
        }
        private int Pega_Imagem_Ranqueada(int rank)
        {
            int index = 0; ;
            for(int i = 0; i < this.imagens_ranqueadas.Count(); i++)
            {
                if (this.imagens_ranqueadas[i] == rank)
                {
                    index = i;
                } 
            }
            return index;
        }
    }
}
