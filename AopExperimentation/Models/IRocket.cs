﻿using System;
using System.Threading.Tasks;

namespace AopExperimentation.Models
{
    public interface IRocket
    {
        int CalculateSum(int a, int b);
        void DoSomething(string str);
        void ThrowException();
        void DoNotProfile();


        string Model { get; set; }
        public event EventHandler OnLanded;

        Task<string> TakeOff();

        ISettings Settings { get; }
    }
}