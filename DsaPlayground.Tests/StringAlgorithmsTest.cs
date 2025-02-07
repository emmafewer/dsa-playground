

namespace DsaPlayground.Tests
{
    [TestFixture]
    public class StringAlgorithmsTests
    {
        public static IEnumerable<TestCaseData> UniqueStringTestCases()
        {
            yield return new TestCaseData("hello").Returns(false);
            yield return new TestCaseData("world").Returns(true);
            yield return new TestCaseData("abc").Returns(true);
            yield return new TestCaseData("aabb").Returns(false);
            yield return new TestCaseData("a").Returns(true);
        }
        
        [Test, TestCaseSource(nameof(UniqueStringTestCases))]
        public bool IsUnique_ReturnsCorrectResult(string input)
        {
            return StringAlgorithms.IsUnique(input);
        }

        [Test, TestCaseSource(nameof(UniqueStringTestCases))]
        public bool IsUniqueInPlace_ReturnsCorrectResult(string input)
        {
            return StringAlgorithms.IsUniqueInPlace(input);
        }

        public static IEnumerable<TestCaseData> PermutationsTestCases()
        {
            yield return new TestCaseData("abc", "cab").Returns(true);
            yield return new TestCaseData("abca", "cab").Returns(false);
            yield return new TestCaseData("motion", "niotom").Returns(true);
            yield return new TestCaseData("niotom", "motioe").Returns(false);
        }

        [Test, TestCaseSource(nameof(PermutationsTestCases))]
        public bool IsPermutationUsingHashtable_ReturnsCorrectResult(string input1, string input2)
        {
            return StringAlgorithms.IsPermutationUsingHashtable(input1, input2);
        }
        
        [Test, TestCaseSource(nameof(PermutationsTestCases))]
        public bool IsPermutationUsingSorting_ReturnsCorrectResult(string input1, string input2)
        {
            return StringAlgorithms.IsPermutationUsingSorting(input1, input2);
        }

        public static IEnumerable<TestCaseData> UrlifyTestCases()
        {
            yield return new TestCaseData(new char[8] {'h', 'e', ' ', 'l', 'l', 'o', ' ', ' '}, 6).Returns(new char[8] {'h', 'e', '%', '2', '0', 'l', 'l', 'o'});
        }

        [Test, TestCaseSource(nameof(UrlifyTestCases))]
        public char[] Urlify_ReturnsCorrectResult(char[] input, int expected)
        {
            return StringAlgorithms.UrlifyString(input, expected);
        }
    }
}