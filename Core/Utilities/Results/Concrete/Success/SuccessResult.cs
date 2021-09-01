using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results.Concrete.Success
{
    public class SuccessResult:Result
    {
        public SuccessResult(string Message) : base(Message, true) { }        

        public SuccessResult() : base(true) { }
    }
}
