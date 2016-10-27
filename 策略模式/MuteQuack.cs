﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 策略模式
{
    public class MuteQuack : IQuackBehavior
    {
        public void quack()
        {
            Console.Write("<< Silence >>");
        }
    }
}
