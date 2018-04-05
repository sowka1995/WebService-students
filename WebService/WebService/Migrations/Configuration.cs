namespace WebService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using WebService.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<StudentContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        /// <summary>
        /// Metoda wype³niaj¹ca bazê danych 100 rekordami studentów.
        /// Wywo³ywana przy migracji bazy do najnowszej
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(StudentContext context)
        {
            string[] firstNames = new string[] {
                "Bartosz", "Jakub", "Pawe³", "Micha³", "Adam",
                "Damian", "Agnieszka", "Magda", "Natalia", "Justyna"
            };

            string[] lastNames = new string[] {
                "Wasil", "Kowalski", "Sidor", "Sowa", "Trybek" ,
                "Sobiech", "Jod³owski", "Karpio", "Chmielewski"
            };

            Random random = new Random();
            for (int i = 1; i <= 100; i++)
            {
                Student student = new Student
                {
                    FirstName = firstNames[random.Next(firstNames.Length)],
                    LastName = lastNames[random.Next(lastNames.Length)],
                };
                context.Students.Add(student);
            }

            context.SaveChanges();
        }
    }
}
