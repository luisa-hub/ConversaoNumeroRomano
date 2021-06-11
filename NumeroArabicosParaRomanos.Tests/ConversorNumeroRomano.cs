using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumerosRomanos;

namespace NumeroRomanos.Tests
{
    [TestClass]
    public class ConversorNumeroRomano
    {

       

        [TestMethod]
        public void NumeroRomanoI()
        {
            NumerosArabicosParaRomanos numeroUm = new NumerosArabicosParaRomanos(1);
            Assert.AreEqual("I", numeroUm.NumeroRomano);
        }

        [TestMethod]
        public void NumeroRomanoIX()
        {
            NumerosArabicosParaRomanos numeroNove = new NumerosArabicosParaRomanos(9);
            Assert.AreEqual("IX", numeroNove.NumeroRomano);
        }

        [TestMethod]
        public void NumeroRomanoX()
        {
            NumerosArabicosParaRomanos numeroDez = new NumerosArabicosParaRomanos(10);
            Assert.AreEqual("X", numeroDez.NumeroRomano);
        }

        [TestMethod]
        public void NumeroRomanoXXXV()
        {
            NumerosArabicosParaRomanos numeroTrintaCinco = new NumerosArabicosParaRomanos(35);
            Assert.AreEqual("XXXV", numeroTrintaCinco.NumeroRomano);
        }

        [TestMethod]
        public void NumeroRomanoL()
        {
            NumerosArabicosParaRomanos numeroCinquenta = new NumerosArabicosParaRomanos(50);
            Assert.AreEqual("L", numeroCinquenta.NumeroRomano);
        }

        [TestMethod]
        public void NumeroRomanoC()
        {
            NumerosArabicosParaRomanos numeroCem = new NumerosArabicosParaRomanos(100);
            Assert.AreEqual("C", numeroCem.NumeroRomano);
        }

        [TestMethod]
        public void NumeroRomanoCDXX()
        {
            NumerosArabicosParaRomanos numeroQuatrocentosEVinte = new NumerosArabicosParaRomanos(420);
            Assert.AreEqual("CDXX", numeroQuatrocentosEVinte.NumeroRomano);
        }

        [TestMethod]
        public void NumeroRomanoM()
        {
            NumerosArabicosParaRomanos numeroMil = new NumerosArabicosParaRomanos(1000);
            Assert.AreEqual("M", numeroMil.NumeroRomano);
        }

        [TestMethod]
        public void NumeroRomanoX̄()
        {
            NumerosArabicosParaRomanos numeroDezMil = new NumerosArabicosParaRomanos(10000);
            Assert.AreEqual("X̄", numeroDezMil.NumeroRomano);

        }



    }
}
