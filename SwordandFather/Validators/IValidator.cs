namespace SwordandFather.Validators
{
    public interface IValidator<TToValidate>
    {
        bool Validate(TToValidate itemToValidate);
    }
}