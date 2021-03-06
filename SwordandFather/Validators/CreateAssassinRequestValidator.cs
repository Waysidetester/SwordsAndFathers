﻿using SwordandFather.Models;

namespace SwordandFather.Validators
{
    public class CreateAssassinRequestValidator : IValidator<CreateAssassinRequest>
    {
        public bool Validate(CreateAssassinRequest assassin)
        {
            return !(string.IsNullOrEmpty(assassin.CatchPhrase)
                || string.IsNullOrEmpty(assassin.CodeName)
                || string.IsNullOrEmpty(assassin.PreferredWeapon));
        }
    }
}