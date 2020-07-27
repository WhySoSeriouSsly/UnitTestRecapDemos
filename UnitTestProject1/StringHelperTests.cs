using Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
 
    [TestClass]
    public class StringHelperTests
    {
        [TestMethod]
        public void Girilenifadeninbasindakivesonundakiazlabosluklarsilinmedlir()
        {
            //Arrange:Hazirlik
            var ifade = "   Ertan Eryılmaz  ";
            var beklenen = "Ertan Eryılmaz";

            //Act:Eylem->Gerceklesen deger istediğim fonksiyonu calıstır.
            var gerceklesen = StringHelper.FazlaBoslukSil(ifade);

            //Assert:Test gecip gecmicekmi
            Assert.AreEqual(beklenen, gerceklesen);
        }
        [TestMethod]
        public void GirilenifadeninicindekiFazlaBosluklarSilinmelidir()
        {
            //Arrange:Hazirlik
            var ifade = "Ertan  Eryılmaz   Ertan  Eryılmaz      Suleyman  Arif  Duran";
            var beklenen = "Ertan Eryılmaz Ertan Eryılmaz Suleyman Arif Duran";

           //Act:Eylem->Gerceklesen deger istediğim fonksiyonu calıstır.
            var gerceklesen = StringHelper.FazlaBoslukSil(ifade);

           //Assert:Test gecip gecmicekmi
            Assert.AreEqual(beklenen, gerceklesen);
        }
    }
}

