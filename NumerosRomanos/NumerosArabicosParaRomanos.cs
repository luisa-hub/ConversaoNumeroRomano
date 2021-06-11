using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosRomanos
{
    public class NumerosArabicosParaRomanos
    {
        private int NumeroArabico { get; set; }
        public string NumeroRomano {get; }

        private Dictionary<int, string> dicionarioArabicoRomano = new Dictionary<int, string>
        {
            { 10000, "X̄" },
            { 9000, "ĪX̄" },
            { 8000, "V̄ĪĪĪ" },
            { 7000, "V̄ĪĪ" },
            { 6000, "V̄Ī" },
            { 5000, "V̄" },
            { 4000, "ĪV̄" },
            { 1000, "M" },
            { 900, "CM" },
            { 500, "D" },
            { 400, "CD"},
            {100, "C"},
            {90, "XC" },
            {50, "L"},
            {40, "XL"},
            {10, "X" },
            {9, "IX" },
            {5, "V"},
            {4, "IV"},
            {1, "I" }

        };



        public NumerosArabicosParaRomanos(int valorArabico)
        {
            NumeroArabico = valorArabico;
            NumeroRomano = ConverterParaRomano(NumeroArabico);
        }

        private string ConverterParaRomano(int valorArabico)
        {
            StringBuilder numeroRomano = new StringBuilder();
            int valorParaConversao = valorArabico;

            foreach (int chaveDicionario in dicionarioArabicoRomano.Keys)
            {
                while (valorParaConversao >= chaveDicionario)
                {
                    numeroRomano.Append(dicionarioArabicoRomano[chaveDicionario]);
                    valorParaConversao -= chaveDicionario;
                }
            }

            return numeroRomano.ToString();
        }
    }
}
