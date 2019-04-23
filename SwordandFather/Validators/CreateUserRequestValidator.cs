using SwordandFather.Models;
using System;

namespace SwordandFather.Validators
{
    public class CreateUserRequestValidator : IValidator<CreateUserRequest>
    {
        public bool Validate(CreateUserRequest requestToValidate)
        {
            return !(string.IsNullOrEmpty(requestToValidate.Username)
                || string.IsNullOrEmpty(requestToValidate.Password));
        }
    }
}
