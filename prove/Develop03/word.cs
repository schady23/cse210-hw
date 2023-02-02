using System;

namespace ScriptureMemoryGame
{
    class Word
    {
        public string Value { get; set; }
        public bool IsHidden { get; set; }

        public Word(string value)
        {
            Value = value;
            IsHidden = false;
        }

        public void Hide()
        {
            IsHidden = true;
        }
    }
}