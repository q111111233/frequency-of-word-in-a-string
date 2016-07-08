using Xunit;
using Frequency.Objects;

namespace Frequency
{
  public class WordFrequencyTests
  {
    [Fact]
    public void WordFrequency_test_normal_case()
    {
      WordFrequency word = new WordFrequency("password", "password is password");
      Assert.Equal(2, word.Find());
    }
    [Fact]
    public void WordFrequency_test_UpperToLower_case()
    {
      WordFrequency word = new WordFrequency("PASSWORD", "password is password");
      Assert.Equal(2, word.Find());
    }
    [Fact]
    public void WordFrequency_test_LowerToUpper_case()
    {
      WordFrequency word = new WordFrequency("password", "password is PASSWORD");
      Assert.Equal(2, word.Find());
    }

  }
}
