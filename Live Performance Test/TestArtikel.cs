using System;
using System.Configuration;
using Live_Performance.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Live_Performance_Test
{
    [TestClass]
    public class TestArtikel
    {
        [TestMethod]
        public void TestArtikelConstructor()
        {
            // Properties used declared
            Artikel artikel;
            int artikelId;
            string artikelNaam;
            Prijs artikelPrijs;

            for (int i = 0; i < 2; i++)
            {
                if (i == 0)
                {
                    // Arrange
                    Prijs prijs = new Prijs(1, 20);
                    artikel = new Artikel(1, "Zwembroek", prijs);

                    // Act
                    artikelId = artikel.Id;
                    artikelNaam = artikel.Naam;
                    artikelPrijs = artikel.Prijs;

                    // Assert
                    Assert.AreEqual(1, artikelId);
                    Assert.AreEqual("Zwembroek", artikelNaam);
                    Assert.AreEqual(prijs, artikelPrijs);
                }
                if (i == 1)
                {
                    // Arrange
                    Prijs prijs = new Prijs(1, 20);
                    artikel = new Artikel("Zwembroek", prijs);

                    // Act
                    artikelNaam = artikel.Naam;
                    artikelPrijs = artikel.Prijs;

                    // Assert
                    Assert.AreEqual("Zwembroek", artikelNaam);
                    Assert.AreEqual(prijs, artikelPrijs);
                }
            }
        }
    }
}
