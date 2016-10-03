using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Code_Challenge_8_CSharp
{
    class TotalWordsRecord
    {
        String word;
        long occurrences;

        public String getWord()
        {
            return this.word;
        }

        public long getOccurrences()
        {
            return this.occurrences;
        }

        public void setWord(String inputWord)
        {
            this.word = inputWord;
        }

        public void setOccurrences(long inputOccurrences)
        {
            this.occurrences = inputOccurrences;
        }

        //@Override
        public override bool Equals(Object obj)
        {
            bool equalsTest = false;
            if (((TotalWordsRecord)obj).word.Equals(this.word))
            {
                equalsTest = true;
            }
            return equalsTest;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
