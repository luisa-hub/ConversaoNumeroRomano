using System;
using System.Collections.Generic;
using System.Text;

 namespace NumerosRomanos.ConsoleApp
{
    public class NumerosArabicosParaRomanos
    {
        public int numeroArabico;
        public string numeroRomano;
       
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
            {10, "X" },
            {9, "IX" },
            {5, "V"},
            {4, "IV"},
            {1, "I" }

        };

       

        public NumerosArabicosParaRomanos(int valorArabico)
        {
            numeroArabico = valorArabico;
            numeroRomano = Converter(numeroArabico);
        }

        private string Converter(int valorArabico)
        {
            StringBuilder numeroRomano = new StringBuilder();
            int valorParaConversao = valorArabico;

            foreach (int valor in dicionarioArabicoRomano.Keys)
            {
                while (valorParaConversao >= valor)
                {
                    numeroRomano.Append(dicionarioArabicoRomano[valor]);
                    valorParaConversao -= valor;
                }
            }

            return numeroRomano.ToString();
        }






    }
}
