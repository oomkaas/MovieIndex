using MovieIndex;

namespace MovieUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestTitle()
        {
            Movie movie = new Movie(2002, "City of God", "Cidade de Deus", "Documentary, Thriller, Crime film, Drama", 8.6);
            Assert.AreEqual(movie[0], "City of God");
        }

        [TestMethod]
        public void TestUpdateDirector()
        {
            Movie movie = new Movie(2002, "City of God", "Cidade de Deus", "Documentary, Thriller, Crime film, Drama", 8.6);
            movie[1] = "Thembaaa";
            Assert.AreEqual(movie[1], "Thembaaa");
        }

        [TestMethod]
        public void TestGenre()
        {
            Movie movie = new Movie(2002, "City of God", "Cidade de Deus", "Documentary, Thriller, Crime film, Drama", 8.6);
            Assert.AreEqual(movie[3], "Documentary, Thriller, Crime film, Drama");
        }

        [TestMethod]
        public void TestRating()
        {
            Movie movie = new Movie(2002, "City of God", "Cidade de Deus", "Documentary, Thriller, Crime film, Drama", 8.6);
            Assert.AreEqual(movie[4], 8.6);
        }

        [TestMethod]
        public void TestUpdateYearUsingStringIndexer()
        {
            Movie movie = new Movie(2002, "City of God", "Cidade de Deus", "Documentary, Thriller, Crime film, Drama", 8.6);
            movie["year"] = 2021;
            Assert.AreEqual(movie["year"], 2021);
        }
    }
}