using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebService.Models
{
    /// <summary>
    /// Kontekst Studentów
    /// </summary>
    public class StudentContext : DbContext
    {
        /// <summary>
        /// Konstruktor
        /// </summary>
        public StudentContext() : base("name=StudentContext")
        {

        }

        /// <summary>
        /// Tabela studentów
        /// </summary>
        public DbSet<Student> Students { get; set; }
    }
}
