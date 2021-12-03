namespace RavexSolution.WebApi.DataAnnotations
{
    public class RequiredAttribute
        : System.ComponentModel.DataAnnotations.RequiredAttribute
    {
        public RequiredAttribute()
        {
            ErrorMessage = "O campo {0} é obrigatório.";
        }
    }
}