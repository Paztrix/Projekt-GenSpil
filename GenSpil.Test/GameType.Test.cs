using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenSpil;

namespace GenSpil.Tests
{
    [TestClass]
    public class GameTypeTests
    {
        [TestMethod]
        public void Constructor_SetsAllPropertiesCorrectly()
        {
            // Arrange / Opretter testdata til GameType-konstruktøren
            string name = "Risk";
            string description = "Strategisk krigsspil";
            int minAge = 12;
            int minPlayers = 2;
            int maxPlayers = 6;
            Genre genre = Genre.Campaign;

            // Act / Kalder konstruktøren med de værdier, der er arrangeret ovenfor
            var gameType = new GameType(name, description, minAge, minPlayers, maxPlayers, genre);

            // Assert / Tester om alle værdier sættes korrekt
            Assert.AreEqual(name, gameType.Name);
            Assert.AreEqual(description, gameType.Description);
            Assert.AreEqual(minAge, gameType.Age);
            Assert.AreEqual(minPlayers, gameType.MinPlayers);
            Assert.AreEqual(maxPlayers, gameType.MaxPlayers);
            Assert.AreEqual(genre, gameType.GameGenre);
        }

        [TestMethod]
        public void Constructor_SetsDefaultValues_WhenOptionalParametersNotProvided()
        {
            // Arrange / Opretter testdata - kun det påkrævede argument 'Name'
            string name = "Uno";

            // Act / Kalder konstruktøren med ovenstående argument
            var gameType = new GameType(name);

            // Assert / Tester om konstruktøren håndterer alle default-værdier korrekt
            Assert.AreEqual(name, gameType.Name);
            Assert.AreEqual("", gameType.Description);
            Assert.AreEqual(0, gameType.Age);
            Assert.AreEqual(0, gameType.MinPlayers);
            Assert.AreEqual(99, gameType.MaxPlayers);
            Assert.AreEqual(Genre.NA, gameType.GameGenre);
        }

        [TestMethod]
        public void Properties_CanBeModifiedAfterConstruction()
        // Verificerer at alle public settere fungerer, og at GameType-objekter kan ændres efter oprettelse
        {
            // Arrange / Opretter nyt GameType-objekt kun med navnet "Original"
            var gameType = new GameType("Original");

            // Act / Værdier ændres
            gameType.Name = "New Name";
            gameType.Description = "Updated description";
            gameType.Age = 18;
            gameType.MinPlayers = 3;
            gameType.MaxPlayers = 7;
            gameType.GameGenre = Genre.Familygame;

            // Assert / Tjekker om ændringerne blev gemt på objektet
            Assert.AreEqual("New Name", gameType.Name);
            Assert.AreEqual("Updated description", gameType.Description);
            Assert.AreEqual(18, gameType.Age);
            Assert.AreEqual(3, gameType.MinPlayers);
            Assert.AreEqual(7, gameType.MaxPlayers);
            Assert.AreEqual(Genre.Familygame, gameType.GameGenre);
        }
        [TestMethod]
        public void Constructor_AllowsEmptyName_WhenNoValidationIsImplemented()
        {
            // Arrange / Sætter et tomt navn
            string name = "";

            // Act / Kalder konstruktøren med ovenstående argument
            var gameType = new GameType(name);

            // Assert / Tester om et spil uden navn kan oprettes
            Assert.AreEqual("", gameType.Name);
        }
    }
}

