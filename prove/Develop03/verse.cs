using System;

namespace ScriptureMemoryGame
{
    class Verse
    {
        public int Start { get; set; }
        public int End { get; set; }

        public Verse(int verse)
        {
            Start = verse;
            End = verse;
        }

        public Verse(int start, int end)
        {
            Start = start;
            End = end;
        }
    }
}

