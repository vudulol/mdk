﻿using System;
using System.Collections.Generic;

namespace Spesivcev
{
    public class Linear : IEquationInterface
    {
        protected List<float> X;
        public List<float> Solve(float a, float b, float c)
        {
            if (a == 0)
            {
                throw new Exception("Такое уравнение не существует");
            }
            MyLog.Log("Это линейное уровнение");
            return X = new List<float>() { -b / a };
        }
    }
}