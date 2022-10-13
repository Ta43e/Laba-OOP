using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA6
{
    public class MyException : Exception
    {
        private string exceptionClass;

        public string ExceptionClass
        {
            get { return exceptionClass; }
        }
        public MyException() { }
        public MyException(string message) : base(message) { }
        public MyException(string message, string ExceptionClass) : base(message)
        {
           exceptionClass = ExceptionClass;
        }
    }

    public class ErrorInMass : MyException
    {
        public int Mass;
        public ErrorInMass() { }

        public ErrorInMass(string message)  :base(message) { }

        public ErrorInMass(string message, string ExceptionClass) : base(message) { }
        public ErrorInMass(string message, int Mass) : base(message) 
        {
            this.Mass = Mass;
        }

        public ErrorInMass(string message, string ExceptionClass, int mass) : base(message, ExceptionClass)
        {
           Mass = mass;
        }
    }

    public class ErrorInCost : MyException 
    {
        public int Cost;
        public ErrorInCost() { }
        public ErrorInCost(string message) : base(message) { }
        public ErrorInCost(string message, string exceptionClass) : base(message) { }
        public ErrorInCost(string message, int cost) : base(message)
        {
            Cost = cost;
        }
        public ErrorInCost(string message, string exceptionClass, int cost) : base(message, exceptionClass)
        {
            Cost = cost;
        }
    }


}
