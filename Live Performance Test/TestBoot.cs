using System;
using Live_Performance.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Live_Performance_Test
{
    [TestClass]
    public class TestBoot
    {
        [TestMethod]
        public void TestBootConstructor()
        {
            // Properties used declared
            Boot boot;
            int bootId;
            string bootNaam;
            string bootSoort;
            string bootAandrijving;
            int bootTankinhoud;
            Boottype bootBoottype;
            Prijs bootPrijs;

            for (int i = 0; i < 3; i++)
            {
                if (i == 0)
                {
                    // Arrange
                    Boottype boottype = new Boottype(1, "harry");
                    Prijs prijs = new Prijs(1, 20);
                    boot = new Boot("hendrik", "motorboot", "motorboot", 15, boottype, prijs);

                    // Act
                    bootNaam = boot.Naam;
                    bootSoort = boot.Soort;
                    bootAandrijving = boot.Aandrijving;
                    bootTankinhoud = boot.Tankinhoud;
                    bootBoottype = boot.Boottype;
                    bootPrijs = boot.Prijs;

                    // Assert
                    Assert.AreEqual("hendrik", bootNaam);
                    Assert.AreEqual("motorboot", bootSoort);
                    Assert.AreEqual("motorboot", bootAandrijving);
                    Assert.AreEqual(15, bootTankinhoud);
                    Assert.AreEqual(boottype, bootBoottype);
                    Assert.AreEqual(prijs, bootPrijs);
                }
                if (i == 1)
                {
                    // Arrange
                    Boottype boottype = new Boottype(1, "harry");
                    Prijs prijs = new Prijs(1, 20);
                    boot = new Boot(1, "hendrik", "motorboot", "motorboot", 15, boottype, prijs);

                    // Act
                    bootId = boot.Id;
                    bootNaam = boot.Naam;
                    bootSoort = boot.Soort;
                    bootAandrijving = boot.Aandrijving;
                    bootTankinhoud = boot.Tankinhoud;
                    bootBoottype = boot.Boottype;
                    bootPrijs = boot.Prijs;

                    // Assert
                    Assert.AreEqual(1, bootId);
                    Assert.AreEqual("hendrik", bootNaam);
                    Assert.AreEqual("motorboot", bootSoort);
                    Assert.AreEqual("motorboot", bootAandrijving);
                    Assert.AreEqual(15, bootTankinhoud);
                    Assert.AreEqual(boottype, bootBoottype);
                    Assert.AreEqual(prijs, bootPrijs);
                }
                if (i == 2)
                {
                    // Arrange
                    Boottype boottype = new Boottype(1, "harry");
                    Prijs prijs = new Prijs(1, 20);
                    boot = new Boot(1, "hendrik", "zeilboot", "spierkracht", boottype, prijs);

                    // Act
                    bootId = boot.Id;
                    bootNaam = boot.Naam;
                    bootSoort = boot.Soort;
                    bootAandrijving = boot.Aandrijving;
                    bootBoottype = boot.Boottype;
                    bootPrijs = boot.Prijs;

                    // Assert
                    Assert.AreEqual(1, bootId);
                    Assert.AreEqual("hendrik", bootNaam);
                    Assert.AreEqual("zeilboot", bootSoort);
                    Assert.AreEqual("spierkracht", bootAandrijving);
                    Assert.AreEqual(boottype, bootBoottype);
                    Assert.AreEqual(prijs, bootPrijs);
                }
            }
        }
    }
}
