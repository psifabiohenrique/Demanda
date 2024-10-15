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
            instrucao1 = "A seguir serão apresentadas 20 imagens de homens, todos maiores de idade, com diferentes características. Por favor, selecione 10 imagens que correspondam aqueles que você considera mais atraentes, baseado apenas no critério físico.";
            instrucao2 = "Esse questionário apresenta uma situação com várias escolhas hipotéticas. Faça suas escolhas como se fossem reais, mesmo sabendo que essas escolhas não acontecerão. Não existem respostas certas ou erradas, apenas sua decisão pessoal. Por favor, para responder as questões desconsidere o fato de estar em uma relação monogâmica, caso esteja.";
            instrucao3 = "Por favor leia atentamente ao texto abaixo:\n Sua melhor amiga, que costuma ter o comportamento sexual semelhante ao seu e tem uma idade próxima acabou de ligar para falar dobre uma festa onde conheceu alguém por quem se interessou. Eles acabaram de fazer sexo sem usa proteção. Sua amiga ficou muito satisfeita com o ocorrido, e te diz: \"eu me diverti muito e ele era muito atraente. Estou animada para vê-lo de novo!\". Um mês após a experiência sua amiga relata estar sentindo enjoos constantes, atraso na menstruação e muito cansaço, assim suspeitando de uma gravidez. Ela está profundamente devastada, com medo de que toda sua vida tenha acabado e chorando incontrolavelmente.";
            instrucao4 = "Por favor leia atentamente ao texto abaixo:\n Sua melhor amiga, que costuma ter o comportamento sexual semelhante ao seu e tem uma idade próxima acabou de ligar para falar dobre uma festa onde conheceu alguém por quem se interessou. Eles acabaram de fazer sexo sem usa proteção. Sua amiga ficou muito satisfeita com o ocorrido, e te diz: \"eu me diverti muito e ele era muito atraente. Estou animada para vê-lo de novo!\". Um mês após a experiência sua amiga relata estar sentindo enjoos constantes, atraso na menstruação e muito cansaço, assim suspeitando de uma gravidez. Ela está profundamente devastada, com medo de que toda sua vida tenha acabado e chorando incontrolavelmente.";
            instrucao_rank_imagem = "Numere de 1 a 10 as imagens de acordo com sua preferência sexual, sendo 1 o homem que você tem mais atração sexual e 10 o de menor atração sexual";
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
