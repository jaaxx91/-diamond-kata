namespace DiamondKata.Tests
{
    public class DiamondKataServiceTests
    {
        private DiamondKataService _diamondKataService;

        private static readonly Dictionary<char, string> _testCases = new Dictionary<char, string>
        {
            { 'A', "A" }
        };

        [SetUp]
        public void Setup()
        {
            _diamondKataService = new DiamondKataService();
        }

        [TestCaseSource(nameof(_testCases))]
        public void Should_ReturnDiamondPrint_WhenValidCharRequested_Returns(KeyValuePair<char, string> testCase)
        {
            // Act
            var diamondPrint = _diamondKataService.GetDiamondPrint(testCase.Key);

            // Assert
            Assert.Equals(testCase.Value, diamondPrint);
        }
    }
}