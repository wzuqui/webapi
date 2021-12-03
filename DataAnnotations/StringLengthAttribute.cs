namespace RavexSolution.WebApi.DataAnnotations
{
    public class StringLengthAttribute
        : System.ComponentModel.DataAnnotations.StringLengthAttribute
    {
        public StringLengthAttribute(int maximumLength)
            : base(maximumLength)
        {
            ErrorMessage = "O campo {0} deve ser uma string com comprimento máximo de {1}.";
        }
    }
}