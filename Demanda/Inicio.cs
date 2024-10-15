namespace Demanda
{
    public partial class Inicio : Form
    {
        private List<int> ordem_escolhas;
        public Configuracoes config;
        public Inicio()
        {
            InitializeComponent();
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            if (rbt_crescente.Checked)
            {
                this.ordem_escolhas = new List<int> { 1, 10 };
            }
            else if (rbt_decrescente.Checked)
            {
                this.ordem_escolhas = new List<int> { 10, 1 };
            }
            this.config = StringConfig.JsonDesserializar();
            Jogo jogo = new Jogo(this.ordem_escolhas, this.config);
            jogo.ShowDialog();
        }

        private void btn_gerarJson_Click(object sender, EventArgs e)
        {
            this.config = StringConfig.JsonDesserializar();
            StringConfig.JsonSerializar(this.config);
        }
    }
}