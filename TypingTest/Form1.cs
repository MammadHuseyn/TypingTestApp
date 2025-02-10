using System.Diagnostics.Tracing;
using System;
using System.Windows.Forms;
using System.Drawing;

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
        int count = 0;

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
        // checking if the word user wrote is same with the word in the 1st word in the label

        string inputWords = txtInput_TextChanged.Text;
        string[] labelWords = label1.Text.Split(' ');

        // Check each letter of the input word
        bool isCorrect = true;
        for (int i = 0; i < inputWords.Length; i++)
        {
            if (i >= labelWords[count].Length || inputWords[i] != labelWords[count][i])
            {
                isCorrect = false;
                break;
            }
        }
        if (count == 5)
        {
                count = 0;
                List<string> randomWords = GetRandomWords(5);
                label1.Text = string.Join(" ", randomWords);
            }
            if (isCorrect)
        {
            txtInput_TextChanged.BackColor = Color.Green;

            // if the word is correct, then we will remove the word from the label, add a new word to the label from randomwords, and clear the textbox
            if ((inputWords == labelWords[count]))
            {
                if (count == 5)
                {
                    count = 0;
                    List<string> randomWords = GetRandomWords(5);
                    label1.Text = string.Join(" ", randomWords);
                }
                else { 
                    count++;
                    //labelWords = labelWords.Skip(1).ToArray();
                    //string randomWord = GetRandomWords(1)[0];
                    //label1.Text = string.Join(" ", labelWords) + " " + randomWord;
                    txtInput_TextChanged.Text = "";
                    txtInput_TextChanged.BackColor = Color.White;
                        label1.Text += $"<span style='color:green'>{labelWords[count]}</span>";
                }
               
            }
        }
        else
        {
            txtInput_TextChanged.BackColor = Color.Red;
        }

        //HighlightCorrectPart(inputWords, labelWords[0]);
    }


        private void HighlightCorrectPart(string input, string label)
        {
            int i = 0;
            while (i < input.Length && i < label.Length && input[i] == label[i])
            {
                i++;
            }

            // Create a new label with colored text
            label1.Text = "";
            for (int j = 0; j < label.Length; j++)
            {
                if (j < i)
                {
                    label1.Text += $"<span style='color:green'>{label[j]}</span>";
                }
                else
                {
                    label1.Text += $"<span style='color:black'>{label[j]}</span>";
                }
            }
        }
    }

}
