using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumerosRomanos;

namespace NumerosRomanos.Tests
{
    [TestClass]
    public class ConversorNumeroArabico
    {
        
        [TestMethod]
        [DataRow("I", 1)]
        [DataRow("II", 2)]
        [DataRow("III", 3)]
        [DataRow("IV", 4)]
        [DataRow("V", 5)]
        [DataRow("VI", 6)]
        [DataRow("VII", 7)]
        [DataRow("VIII", 8)]
        [DataRow("IX", 9)]
        [DataRow("X", 10)]
        public void NumeroArabicoUmAo10(string romano, int arabico)
        {
            NumeroRomanoParaArabico numeroI = new NumeroRomanoParaArabico(romano);
            Assert.AreEqual(arabico, numeroI.NumeroArabico);
        }


        [TestMethod]
        [DataRow("XX", 20)]
        [DataRow("XXI", 21)]
        [DataRow("XXX", 30)]
        [DataRow("XXXV", 35)]
        [DataRow("XL", 40)]
        [DataRow("XLVI", 46)]
        [DataRow("L", 50)]
        [DataRow("LX", 60)]
        [DataRow("LXXX", 80)]
        [DataRow("XC", 90)]
        public void NumeroArabicoDecimais(string romano, int arabico)
        {
            NumeroRomanoParaArabico numeroDecimal = new NumeroRomanoParaArabico(romano);
            Assert.AreEqual(arabico, numeroDecimal.NumeroArabico);
        }

        [TestMethod]
        [DataRow("C", 100)]
        [DataRow("CC", 200)]
        [DataRow("CCC", 300)]
        [DataRow("CD", 400)]
        [DataRow("CDXXV", 425)]
        [DataRow("DXX", 520)]
        [DataRow("DC", 600)]
        [DataRow("DCC", 700)]
        [DataRow("DCCC", 800)]
        [DataRow("CM", 900)]
        public void NumeroArabicoCentenas(string romano, int arabico)
        {
            NumeroRomanoParaArabico numeroDecimal = new NumeroRomanoParaArabico(romano);
            Assert.AreEqual(arabico, numeroDecimal.NumeroArabico);
        }

        [TestMethod]
        [DataRow("ML", 1050)]
        [DataRow("MMXXVI", 2026)]
        [DataRow("ĪV̄", 4000)]
        [DataRow("V̄CXX", 5120)]
        [DataRow("V̄Ī", 6000)]
        [DataRow("V̄ĪĪCC", 7200)]
        [DataRow("V̄ĪĪĪ", 8000)]
        [DataRow("ĪX̄XV", 9015)]
        [DataRow("X̄", 10000)]
        [DataRow("X̄CCLVII", 10257)]
        public void NumeroArabicosMilhares(string romano, int arabico)
        {
            NumeroRomanoParaArabico numeroMilhar = new NumeroRomanoParaArabico(romano);
            Assert.AreEqual(arabico, numeroMilhar.NumeroArabico);
        }
    }
}
