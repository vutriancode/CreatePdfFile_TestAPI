using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CreateDocumentWithTemplate.Models;

namespace CreateDocumentWithTemplate.Contexts
{
    public class DocumentContext : DbContext
    {
        public DocumentContext(DbContextOptions option) : base(option) { }
        public DbSet<DocumentTemplate> DocumentTemplates { get; set; }
        public DbSet<PersionBlog> PersionBlogs { get; set; }
        public DbSet<WorkingNote> WorkingNotes { get; set; }
    }
    }