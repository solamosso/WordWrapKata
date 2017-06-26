using NFluent;
using NUnit.Framework;

namespace WordWrapKata
{
    public class WordWraptests
    {
        [Test]
        public void should_returnaaa_when_5()
        {
            var actual = Wrapper.Wrap("aaa", 5);    
            Check.That(actual).IsEqualTo("aaa");
        }

        [Test]
        public void should_return_aaa_bs_aa_when_input_is_aaa_s_aa()
        {
            
            var actual = Wrapper.Wrap("aaa aa",3);
            Check.That(actual).IsEqualTo("aaa\naa");
        }

        [Test]
        public void should_returnabsabsaa_when_input_is_3()
        {
            var actual = Wrapper.Wrap("a aaa", 3);
            Check.That(actual).IsEqualTo("a\naaa");
        }

        [Test]
        public void should_return_wrapped_text_when_colunm_number_is_at_the_same_position_as_the_space()
        {
            var actual = Wrapper.Wrap("aaaaa",3);
            Check.That(actual).IsEqualTo("aaa\naa");
        }


        [TestCase("aaaaaa bbbb cccc",6, "aaaaaa\nbbbb\ncccc")]
        [TestCase("aaaaaa bbbb cccc",6, "aaaaaa\nbbbb\ncccc")]
        [TestCase("aaaaaa bbbb cccc",6, "aaaaaa\nbbbb\ncccc")]
        [TestCase("aaaaaa bbbb cccc",6, "aaaaaa\nbbbb\ncccc")]
        [TestCase("aaaaaa bbbb cccc",6, "aaaaaa\nbbbb\ncccc")]
        [TestCase("aaa bbb", 6, "aaa\nbbb")]
        [TestCase("aaa bbbb", 6, "aaa\nbbbb")]
        [TestCase("aaa bbbb", 7, "aaa\nbbbb")]
        [TestCase("aaaaaa bbbbcccc", 6, "aaaaaa\nbbbbcc\ncc")]
        [TestCase("aaaaaa bbbb cccc",6, "aaaaaa\nbbbb\ncccc")]
        public void should_break_input_text_given_a_column_number(string input, int columnNumber, string expected)
        {
            var actual = Wrapper.Wrap(input, columnNumber);
            Check.That(actual).IsEqualTo(expected);
        }

    }
}
