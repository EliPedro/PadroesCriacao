using System.Collections.Generic;

namespace Singleton
{
    public class Configuracao
    {
        private static Configuracao Instance { get; set; }
        private Dictionary<string, string> Config { get; set; }

        public Configuracao()
        {
            this.Config = new Dictionary<string, string>();
            this.Config.Add("time-zone", "America/Sao_Paulo");
            this.Config.Add("currency-code","BRL");
        }

        public static Configuracao GetInstance()
        {
            if(Configuracao.Instance == null)
            {
                Configuracao.Instance = new Configuracao();
            }

            return Configuracao.Instance;
        }

        public string GetPropriedade(string propriedade)
        {
            return Config[propriedade];        
        }
    }
}
