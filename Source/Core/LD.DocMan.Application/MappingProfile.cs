using AutoMapper;
using LD.DocMan.Application.Features.DocumentCategories.Queries.GetDocumentCategoryDetails;
using LD.DocMan.Application.Features.DocumentCategories.Queries.GetDocumentCategoryList;
using LD.DocMan.Application.Features.Documents.Queries.GetDocumentDetail;
using LD.DocMan.Application.Features.Documents.Queries.GetDocumentList;
using LD.DocMan.Application.Features.DocumentTypes.Queries.GetDocumentTypeDetail;
using LD.DocMan.Application.Features.DocumentTypes.Queries.GetDocumentTypeList;
using LD.DocMan.Application.Features.DocutechPushbacks.Queries.GetDocutechPushbackDetail;
using LD.DocMan.Application.Features.DocutechPushbacks.Queries.GetDocutechPushbackList;
using LD.DocMan.Application.Models.ThirdParty.Docutech;
using LD.DocMan.Domain.Entities;

namespace LD.DocMan.Application
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Document, DocumentListVM>().ReverseMap();
            CreateMap<Document, DocumentDetailVM>();
            CreateMap<DocumentCategory, DocumentCategoryListVM>().ReverseMap();
            CreateMap<DocumentCategory, DocumentCategoryDetailsVM>();
            CreateMap<DocumentType, DocumentTypeListVM>().ReverseMap();
            CreateMap<DocumentType, DocumentTypeDetailVM>();
            CreateMap<DocutechPushback, DocutechPushbackListVM>().ReverseMap();
            CreateMap<DocutechPushback, DocutechPushbackDetailVM>();
        }
    }
}
