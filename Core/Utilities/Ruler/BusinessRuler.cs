using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete.Errors;
using Core.Utilities.Results.Concrete.Success;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Ruler
{
    public static class BusinessRuler
    {
        public static IResult Test(params IResult[] rules)
        {
            string message = "";
            foreach (var rule in rules)
            {
                if (!rule.Success)
                    message += rule.Message + "\n";
            }
            if (message.Length > 0)
                return new ErrorResult(message);
            return new SuccessResult();
        } 
    }
}
