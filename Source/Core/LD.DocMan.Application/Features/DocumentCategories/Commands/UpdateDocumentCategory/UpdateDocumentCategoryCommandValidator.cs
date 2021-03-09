using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace LD.DocMan.Application.Features.DocumentCategories.Commands.UpdateDocumentCategory
{
    class UpdateDocumentCategoryCommandValidator : AbstractValidator<UpdateDocumentCategoryCommand>
    {
        public UpdateDocumentCategoryCommandValidator()
        {
            RuleFor(dc => dc.Name)
                .NotNull()
                .NotEmpty().WithMessage("Document Category Name can not be null or empty.")
                .MaximumLength(150).WithMessage("Document Category Name can not be more than 150 characters.");
        }
    }
}
