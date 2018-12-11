﻿using System;
using _01.WelcomeToPatterns.Abstract;

namespace _01.WelcomeToPatterns.QuackBehaviors
{
    public class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}