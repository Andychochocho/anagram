using Xunit;
using Anagrams;
using System;
using System.Collections.Generic;


namespace AnagramTest
{
  public class AnagramTester
  {
    [Fact]
    public void IsWord_forWordEqualingSameWord_input1()
    {
      string input1 = "beard";
      string input2 = "beard";
      Anagram newAnagram = new Anagram(input1, input2);
      Assert.Equal(input1, newAnagram.CompareInputs());
    }

    [Fact]
    public void IsWord_forWordNotEqualingSameWord_input1()
    {
      string input1 = "frog";
      string input2 = "superman";
      Anagram newAnagram = new Anagram(input1,input2);
      Assert.Equal(input1, newAnagram.CompareInputs());
    }

    [Fact]
    public void IsWord_ForWordIsAnagramOfSameWord_input2()
    {
      string input1 = "and";
      string input2 = "dna";

      Anagram newAnagram = new Anagram(input1,input2);

      Assert.Equal(input2, newAnagram.CompareInputs());
    }
    [Fact]
    public void IsWord_ForWordIsPartOfSameWord_input1()
    {
      string input1 = "hat";
      string input2 = "that";

      Anagram newAnagram = new Anagram(input1,input2);

      Assert.Equal(input1, newAnagram.CompareInputs());
    }
  }
}
