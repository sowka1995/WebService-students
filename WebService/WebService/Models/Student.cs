using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService.Models
{
    /// <summary>
    /// Model Studenta
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Klucz główny
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// Imię studenta
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Nazwisko studenta
        /// </summary>
        public string LastName { get; set; }
    }
}