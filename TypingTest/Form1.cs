using System.Diagnostics.Tracing;
using System;
using System.Windows.Forms;


namespace TypingTest
{
    public partial class Form1 : Form
    {
        private Random random;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
        }

        string[] words = { "about", "above",
            "add", "after", "again",
            "air", "all", "almost", "along",
            "also", "always", "America", "an",
            "and", "animal", "another", "answer",
            "any", "are", "around", "as", "ask",
            "at", "away", "back", "be", "because",
            "been", "before", "began", "begin",
            "being", "below", "between", "big",
            "book", "both", "boy", "but", "by",
            "call", "came", "can", "car", "carry",
            "change", "children", "city", "close",
            "come", "could", "country", "cut", "day",
            "did", "different", "do", "does", "don't",
            "down", "each", "earth", "eat", "end", "enough",
            "even", "every", "example", "eye", "face",
            "family", "far", "father", "feet", "few",
            "find", "first", "follow", "food", "for",
            "form", "found", "four", "from", "get",
            "girl", "give" };

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> randomWords = GetRandomWords(5);
            label1.Text = string.Join(" ", randomWords);
        }

        private List<string> GetRandomWords(int count)
        {
            List<string> selectedWords = new List<string>();
            for (int i = 0; i < count; i++)
            {
                int index = random.Next(words.Length);
                selectedWords.Add(words[index]);
            }
            return selectedWords;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtInput_TextChanged_TextChanged(object sender, EventArgs e)
        {
            // cheking if the word use wrote is same with the word in the 1st word in the label
            string[] inputWords = txtInput_TextChanged.Text.Split(' ');
            string[] labelWords = label1.Text.Split(' ');
            for (int i = 0; i < inputWords.Length; i++)
            {
                if (inputWords[i] == labelWords[i])
                {
                    txtInput_TextChanged.BackColor = Color.Green;
                }
                else
                {
                    txtInput_TextChanged.BackColor = Color.Red;
                }
            }

        }
    }
}
