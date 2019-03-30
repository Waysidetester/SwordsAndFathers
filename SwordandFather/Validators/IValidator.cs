namespace SwordandFather.Controllers
{
    public interface IValidator<TToValidate>
    {
        bool Validate(TToValidate itemToValidate);
    }
}