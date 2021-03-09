using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace LD.DocMan.Application.Features.DocumentTypes.Commands.UpdateDocumentType
{
    public class UpdateDocumentTypeCommandValidator : AbstractValidator<UpdateDocumentTypeCommand>
    {
        public UpdateDocumentTypeCommandValidator()
        {
            RuleFor(dt => dt.Name)
                .NotEmpty().WithMessage("Document Type Name is required.")
                .NotNull()
                .MaximumLength(100).WithMessage("Document Type Name can not be more than 100 characters.");

            RuleFor(dt => dt.OrderId)
                .NotNull()
                .GreaterThanOrEqualTo(1).WithMessage("Document Type OrderId can not be less than 1.")
                .LessThanOrEqualTo(10000).WithMessage("Document Type OrderId can not be greater than 10,000.");

            RuleFor(dt => dt.MainBranch)
                .MaximumLength(100).WithMessage("Document Type Main Branch can not be more than 100 characters.");

            RuleFor(dt => dt.SecBranch1)
                .MaximumLength(100).WithMessage("Document Type Secondary Branch 1 can not be more than 100 characters.");

            RuleFor(dt => dt.SecBranch2)
                .MaximumLength(100).WithMessage("Document Type Secondary Branch 2 can not be more than 100 characters.");

            RuleFor(dt => dt.AdrTrustedMinimumThreshold)
                .GreaterThanOrEqualTo(0).WithMessage("Adr Trusted Threshold can not be negative.")
                .LessThanOrEqualTo(100).WithMessage("Adr Trusted Threshold can not be greater than 100%.");
        }
    }
}
