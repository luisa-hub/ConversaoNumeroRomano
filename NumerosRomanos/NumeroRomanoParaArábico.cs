using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosRomanos
{
    public class NumeroRomanoParaArabico
    {
        private String NumeroRomano { get; set; }
        public int NumeroArabico { get; }

        private Dictionary<char, int> dicionarioRomanoArabico = new Dictionary<char, int>
        {
            {'x',  10000 },          
            {'v', 5000 },       
            { 'M', 1000 },
            { 'D' , 500},
            {'C', 100},
            {'L', 50},
            {'X', 10 },
            { 'V', 5},
            { 'I', 1 }

        };

        public NumeroRomanoParaArabico(string valorRomano)
        {
            SubstituirTraco(ref valorRomano);
            NumeroArabico = ConverterParaArabico(valorRomano);
            NumeroRomano = valorRomano;
        }

        private int ConverterParaArabico(string valorRomano)
        {
           
            int valorArabico= 0;

            for (int i = 0; i < valorRomano.Length; i++)
            {
                if (SeValorForMenorQueOProximo(valorRomano, i))
                {
                    valorArabico += dicionarioRomanoArabico[valorRomano[i + 1]] - dicionarioRomanoArabico[valorRomano[i]];
                    i++;
                    continue;
                }

                valorArabico += dicionarioRomanoArabico[valorRomano[i]];
            }
            return valorArabico;

           
        }

        private bool SeValorForMenorQueOProximo(string valorRomano, int i)
        {
            return i != valorRomano.Length - 1 && dicionarioRomanoArabico[valorRomano[i]] < dicionarioRomanoArabico[valorRomano[i + 1]];
        }

        private static string SubstituirTraco(ref string valorRomano)
        {
            valorRomano.ToUpper();
            if ((valorRomano.Contains("X̄")) || (valorRomano.Contains("V̄")) || (valorRomano.Contains("X̄")))
            {
               
                valorRomano = valorRomano.Replace("Ī", "M");
                valorRomano = valorRomano.Replace("V̄", "v");
                valorRomano = valorRomano.Replace("X̄", "x");
            }

            return valorRomano;
        }


    }
}
