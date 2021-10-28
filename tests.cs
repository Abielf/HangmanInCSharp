using Xunit;

namespace HangmanCSharp
{

public class Tests {
    [Fact]
    public void testEasy(){
        string e = "easy";
        Answer t = new Answer();
        string test=t.validateChoice(e);
        Assert.Equal(5,test.Length);
    }
    public void testMed(){
        string m = "medium";
        Answer t = new Answer();
        string test=t.validateChoice(m);
        Assert.Equal(7,test.Length);

    }
    public void testHard(){
        string h = "hard";
        Answer t = new Answer();
        string test=t.validateChoice(h);
        Assert.Equal(9,test.Length);
    }
        public void testBadChoice(){
        string b = "whatever";
        Answer t = new Answer();
        string test=t.validateChoice(b);
        Assert.Equal("Not yet set",test);
    }

    }
}