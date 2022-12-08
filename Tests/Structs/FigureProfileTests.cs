namespace Tests.Structs
{
    public class FigureProfileTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void NewTestScriptSimplePasses()
        {
            FigureProfile figureProfile = new("Lucas", Gender.MALE);
            Assert.Multiple(() =>
            {
                Assert.That(figureProfile.Name, Is.EqualTo("Lucas"));
                Assert.That(figureProfile.Gender, Is.EqualTo(Gender.MALE));
            });
        }
    }
}
