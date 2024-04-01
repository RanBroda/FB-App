using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.Strategy
{
    class GuessByYear : IGuessingGameStrategy
    {
        public string AnswerFormat(string PicDate)
        {
            return PicDate.Split('/')[2].Split(' ')[0];
        }
    }
}
