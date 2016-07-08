using Xunit;
using Frequency.Objects;

namespace Frequency
{
  public class WordFrequencyTests
  {
    [Fact]
    public void WordFrequency_test_normal_case()
    {
      RepeatCounter word = new RepeatCounter("password", "password is password");
      Assert.Equal(2, word.CountRepeats());
    }
    [Fact]
    public void WordFrequency_test_UpperToLower_case()
    {
      RepeatCounter word = new RepeatCounter("PASSWORD", "password is password");
      Assert.Equal(2, word.CountRepeats());
    }
    [Fact]
    public void WordFrequency_test_LowerToUpper_case()
    {
      RepeatCounter word = new RepeatCounter("password", "password is PASSWORD");
      Assert.Equal(2, word.CountRepeats());
    }
    [Fact]
    public void WordFrequency_test_EmptyString_case()
    {
      RepeatCounter word = new RepeatCounter("password", "");
      Assert.Equal(0, word.CountRepeats());
    }
    [Fact]
    public void WordFrequency_test_WithPunctuation_case()
    {
      RepeatCounter word = new RepeatCounter("password", "password is 'password'!");
      Assert.Equal(2, word.CountRepeats());
    }

  }
}
