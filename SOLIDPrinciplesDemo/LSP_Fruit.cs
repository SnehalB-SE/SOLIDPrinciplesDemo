using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDPrinciplesDemo
{
    public abstract class LSP_Fruit
    {
        public abstract string GetColor();
    }
    public class Apple : LSP_Fruit
    {
        public override string GetColor()
        {
            return "Red";
        }
    }
    public class Orange : LSP_Fruit
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }
}
