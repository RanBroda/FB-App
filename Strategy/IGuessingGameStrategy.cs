﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFacebookFeatures.Strategy
{
    public interface IGuessingGameStrategy
    {
        string AnswerFormat(string format);
    }
}
