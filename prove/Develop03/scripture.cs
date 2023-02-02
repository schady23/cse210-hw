using System;
using System.Collections.Generic;
using System.Text;

namespace ScriptureMemoryGame
{
    class Scripture
    {
        public string Reference { get; set; }
        public string Text { get; set; }
        public List<string> Words { get; set; }
        public List<string> HiddenWords { get; set; }

        public Scripture(string reference, string text)
        {
            Reference = reference;
            Text = text;
            Words = new List<string>(text.Split(" "));
            HiddenWords = new List<string>();
        }

        public void DisplayScripture()
        {
            StringBuilder sb = new StringBuilder();
            foreach (string word in Words)
            {
                if (HiddenWords.Contains(word))
                {
                    sb.Append("_ ");
                }
                else
                {
                    sb.Append(word + " ");
                }
            }
            Console.WriteLine(Reference + ": " + sb.ToString());
        }

        public void HideWord()
        {
            Random rnd = new Random();
            int index = rnd.Next(0, Words.Count);
            HiddenWords.Add(Words[index]);
        }
    }
}