using FluentValidation;
using MvcFluentValidation.Models;

namespace MvcFluentValidation.ModelValidators
{
    public class FluentDataModelValidator : AbstractValidator<FluentDataModel>
    {
        public FluentDataModelValidator()
        {
           RuleFor(x => x.ValString1)
            .NotNull();
            RuleFor(x => x.ValString2)
                .NotNull()
                .Length(6, 100);
        }
        
    }
}