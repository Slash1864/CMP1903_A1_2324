﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
        /*
         * The Die class should contain one property to hold the current die value,
         * and one method that rolls the die, returns and integer and takes no parameters.
         */

        //Field
        private int _Roll;

        //Property
        public int Roll
        {
            get { return _Roll; }
            set { _Roll = value; }
        }

        //Method
        //Randomly generates and returns random integers between 1 and 6. System must pause between generations otherwise all dice will be the same number.
        public int Generate()
        {
            Thread.Sleep(600);
            Random rnd = new Random();
            int number = rnd.Next(1, 7);
            return number;
        }


    }
}
