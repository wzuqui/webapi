using System;

namespace RavexSolution.WebApi.DataAnnotations
{
    public class RangeAttribute
        : System.ComponentModel.DataAnnotations.RangeAttribute
    {
        private const string _ERROR_MESSAGE = "O campo {0} deve estar entre {1} e {2}.";

        public RangeAttribute(double pMinimum
            , double pMaximum)
            : base(pMinimum, pMaximum)
        {
            ErrorMessage = _ERROR_MESSAGE;
        }

        public RangeAttribute(int pMinimum
            , int pMaximum)
            : base(pMinimum, pMaximum)
        {
            ErrorMessage = _ERROR_MESSAGE;
        }

        public RangeAttribute(Type pType
            , string pMinimum
            , string pMaximum)
            : base(pType, pMinimum, pMaximum)
        {
            ErrorMessage = _ERROR_MESSAGE;
        }
    }
}