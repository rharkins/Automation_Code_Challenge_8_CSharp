using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automation_Code_Challenge_8_CSharp
{
    class WebsiteWordsRecord
    {
        String word;
        String website;
        long occurrences;

        public String getWord()
        {
            return this.word;
        }

        public String getWebsite()
        {
            return this.website;
        }

        public long getOccurrences()
        {
            return this.occurrences;
        }

        public void setWord(String inputWord)
        {
            this.word = inputWord;
        }

        public void setWebsite(String inputWebsite)
        {
            this.website = inputWebsite;
        }

        public void setOccurrences(long inputOccurrences)
        {
            this.occurrences = inputOccurrences;
        }

        //@Override
        public override bool Equals(Object obj)
        {
            bool equalsTest = false;
            if (((WebsiteWordsRecord)obj).word.Equals(this.word) && ((WebsiteWordsRecord)obj).website.Equals(this.website))
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
