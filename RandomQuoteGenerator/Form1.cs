using System;
using System.Windows.Forms;

namespace RandomQuoteGenerator
{
    public partial class Form1 : Form
    {
        public string[] quotes =
        {
                "The way to get started is to quit talking and begin doing",
                "If life were predictable it would cease to be life, and be without flavor.",
                "If you set your goals ridiculously high and it's a failure, you will fail above everyone else's success.",
                "Life is what happens when you're busy making other plans.",
                "Spread love everywhere you go. Let no one ever come to you without leaving happier."
        };

        public string[] quoteAuthors =
        {
            "Jeremy",
            "Phil",
            "Bill",
            "Ted",
            "Jason"
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRandomQuote_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int start2 = random.Next(0, quotes.Length);
            txtRandomQuote.Text = quotes[start2] + " - " + quoteAuthors[start2];
        }
    }
}
