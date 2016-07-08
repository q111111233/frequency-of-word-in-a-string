using Xunit;
using Frequency.Objects;

namespace Frequency
{
  public class WordFrequencyTests
  {
    [Fact]
    public void Palindromes_test_fail()
    {
      WordFrequency word = new WordFrequency("password", "password is password");
      Assert.Equal(2, word.Find());
    }

  }
}
