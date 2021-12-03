using System;

namespace RavexSolution.WebApi.DataAnnotations
{
    public class RangeAttribute
        : System.ComponentModel.DataAnnotations.RangeAttribute
    {
        private const string _ERROR_MESSAGE = "O campo {0} deve estar entre {1} e {2}.";

        public RangeAttribute(double minimum, double maximum)
            : base(minimum, maximum)
        {
            ErrorMessage = _ERROR_MESSAGE;
        }

        public RangeAttribute(int minimum, int maximum)
            : base(minimum, maximum)
        {
            ErrorMessage = _ERROR_MESSAGE;
        }

        public RangeAttribute(Type type, string minimum, string maximum)
            : base(type, minimum, maximum)
        {
            ErrorMessage = _ERROR_MESSAGE;
        }
    }
}