using System;
using System.Threading;
using System.Threading.Tasks;
using LD.DocMan.Domain.Common;
using LD.DocMan.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LD.DocMan.Persistence
{
    public class DocManDbContext : DbContext
    {
        public DocManDbContext(DbContextOptions<DocManDbContext> options) : base(options)
        {

        }

        public DbSet<Document> Documents { get; set; }
        public DbSet<DocumentCategory> DocumentCategories { get; set; }
        public DbSet<DocumentType> DocumentTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(DocManDbContext).Assembly);

            var bankStatementGuid = Guid.Parse("{EF9E4ECE-CEC3-41DB-BD02-A3AC2081C00F}");
            var fullDisclosureGuid = Guid.Parse("{3DC15F1A-AA93-4F3E-9E72-94E577EB620D}");
            var creditReportGuid = Guid.Parse("{F3000CD3-97B2-41C3-B905-A1155C10DF8C}");
            var fraudReportGuid = Guid.Parse("{2FBC5E31-24BF-4542-8141-37D39658F1C7}");

            modelBuilder.Entity<DocumentType>().HasData(new DocumentType { DocumentTypeId = bankStatementGuid, Name = "Bank Statements" });
            modelBuilder.Entity<DocumentType>().HasData(new DocumentType { DocumentTypeId = fullDisclosureGuid, Name = "Full Disclosures" });
            modelBuilder.Entity<DocumentType>().HasData(new DocumentType { DocumentTypeId = creditReportGuid, Name = "Credit Report" });
            modelBuilder.Entity<DocumentType>().HasData(new DocumentType { DocumentTypeId = fraudReportGuid, Name = "Fraud Report" });

            var assetsGuid = Guid.Parse("{17D67A29-0403-4B86-84AE-5AAF132798DD}");
            var disclosureGuid = Guid.Parse("{820C10F9-07B8-45AE-9D2D-3274470FDB3D}");
            var creditGuid = Guid.Parse("{4185DCCC-3FC6-4814-A514-C29BA1DDAFD5}");
            var miscGuid = Guid.Parse("{06127FDE-2BEA-4C77-8090-F6E2C8BF35B6}");

            modelBuilder.Entity<DocumentCategory>().HasData(new DocumentCategory { DocumentCategoryId = assetsGuid, Name = "Assets" });
            modelBuilder.Entity<DocumentCategory>().HasData(new DocumentCategory { DocumentCategoryId = disclosureGuid, Name = "Disclosures" });
            modelBuilder.Entity<DocumentCategory>().HasData(new DocumentCategory { DocumentCategoryId = creditGuid, Name = "Credit" });
            modelBuilder.Entity<DocumentCategory>().HasData(new DocumentCategory { DocumentCategoryId = miscGuid, Name = "Miscellaneous" });

            var bankStatementDocGuid = Guid.Parse("{F3469168-AB07-4B00-B509-05B701493584}");
            var fullDisclosureDocGuid = Guid.Parse("{F4E4CAD9-386C-473C-BE5C-7EAFDD5480AD}");
            var creditReportDocGuid = Guid.Parse("{7C2738F0-7908-4897-AC81-7B36EDD6418D}");
            var fraudReportDocGuid = Guid.Parse("{22C4D9E0-2C88-4E9B-9A61-98C5D9F09C76}");

            modelBuilder.Entity<Document>().HasData(new Document { DocumentId = bankStatementDocGuid, LoanNumber = "1234", DocumentTypeId = bankStatementGuid, Name = "BofA Bank Statement", BorrowerNumber = 1 });
            modelBuilder.Entity<Document>().HasData(new Document { DocumentId = fullDisclosureDocGuid, LoanNumber = "1234", DocumentTypeId = fullDisclosureGuid, Name = "Full Disclosures", BorrowerNumber = 1 });
            modelBuilder.Entity<Document>().HasData(new Document { DocumentId = creditReportDocGuid, LoanNumber = "1234", DocumentTypeId = creditReportGuid, Name = "Credco Credit Report", BorrowerNumber = 1 });
            modelBuilder.Entity<Document>().HasData(new Document { DocumentId = fraudReportDocGuid, LoanNumber = "1234", DocumentTypeId = fraudReportGuid, Name = "FraudGuard Report" });

        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.LastModifiedDate = DateTime.Now;
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
