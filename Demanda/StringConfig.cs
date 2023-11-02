using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Demanda
{
    public static class StringConfig
    {
        public static bool JsonSerializar(Configuracoes cfg)
        {
            Configuracoes config = cfg;
            var strJson = JsonConvert.SerializeObject(config, Formatting.Indented);
            try
            {
                using (StreamWriter sw = new StreamWriter(System.Environment.CurrentDirectory + @"\Configuracao.json"))
                {
                    sw.WriteLine(strJson);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return true;
        }
        public static Configuracoes JsonDesserializar()
        {
            try
            {
                var strJson = "";
                using (StreamReader sr = new StreamReader(System.Environment.CurrentDirectory + @"\Configuracao.json"))
                {
                    strJson = sr.ReadToEnd();
                }

                Configuracoes retorno =  JsonConvert.DeserializeObject<Configuracoes>(strJson);
                if (retorno != null)
                {
                    //MessageBox.Show(retorno);
                    return retorno;
                }
                else
                {
                    Configuracoes cfg = new Configuracoes();
                    cfg.Set_Padrao();
                    return cfg;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Configuracoes cfg = new Configuracoes();
                cfg.Set_Padrao();
                return cfg;
            }

        }
    }

    public class Configuracoes
    {
        public string instrucao1;
        public string instrucao2;
        public string instrucao3;
        public string instrucao4;
        public string instrucao_rank_imagem;

        public Configuracoes()
        {

        }
        public void Set_Padrao()
        {
            instrucao1 = "A seguir serão apresentadas 20 imagens de mulheres, todas maiores de idade, com diferentes características. Por favor, selecione 10 imagens que correspondam àquelas que você considera mais atraentes, baseado apenas no critério físico.";
            instrucao2 = "Este questionário apresenta uma situação com várias escolhas hipotéticas. Faça suas escolhas como se fossem reais, mesmo sabendo que essas escolhas não acontecerão. Não existem respostas certas ou erradas, apenas sua decisão pessoal.";
            instrucao3 = "Este questionário apresenta uma situação com várias escolhas hipotéticas. Faça suas escolhas como se fossem reais, mesmo sabendo que essas escolhas não acontecerão. Não existem respostas certas ou erradas, apenas sua decisão pessoal";
            instrucao4 = "Por favor leia atentamente o texto abaixo: Seu melhor amigo, que costuma ter comportamento sexual semelhante ao seu e tem uma idade próxima, acabou de ligar para falar sobre uma festa onde conheceu alguém por quem se interessou. Eles acabaram fazendo sexo sem usar proteção. Seu amigo ficou muito satisfeito com o ocorrido, e te diz: “Eu me diverti muito e ela era muito atraente. Estou animado para vê-la de novo!” Um mês após a experiência, seu amigo recebeu uma mensagem no celular falando que a mulher está grávida dele. Ele está profundamente devastado, com medo de que toda a sua vida tenha acabado e chorando incontrolavelmente.";
            instrucao_rank_imagem = "Numere de 1 a 10 as imagens de acordo com sua preferência sexual, sendo 1 a mulher que você tem mais atração sexual e 10 a de menor atração sexual";
        }
        public bool Check_integrit()
        {
            if (instrucao1 != null && instrucao2 != null && instrucao3 != null)
            {
                return true;
            }
            else return false;
        }
    }
}
