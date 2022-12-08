namespace Tests.Structs
{
    public class FigureAttributesTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void NewTestScriptSimplePasses()
        {
            FigureAttributes figureAttributes = new(1, 1, 1, 1, 1, 1);

            Assert.That(1, Is.EqualTo(figureAttributes.Move));
            Assert.That(1, Is.EqualTo(figureAttributes.Fight));
            Assert.That(1, Is.EqualTo(figureAttributes.Shoot));
            Assert.That(1, Is.EqualTo(figureAttributes.Armour));
            Assert.That(1, Is.EqualTo(figureAttributes.Will));
            Assert.That(1, Is.EqualTo(figureAttributes.Health));
        }
    }
}