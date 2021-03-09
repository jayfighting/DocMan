using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace LD.DocMan.Application.Features.DocumentCategories.Commands.CreateDocumentCategory
{
    public class CreateDocumentCategoryCommandValidator : AbstractValidator<CreateDocumentCategoryCommand>
    {
        public CreateDocumentCategoryCommandValidator()
        {
            RuleFor(dc => dc.Name)
                .NotNull()
                .NotEmpty().WithMessage("Document Category Name can not be null or empty.")
                .MaximumLength(150).WithMessage("Document Category Name can not be more than 150 characters.");
        }
    }
}
