namespace UniversityLabEF
{
    // Adds sample departments and students, the same students as Week 8.
    // It needs the DbSets in AppDbContext, so it is commented out until Task 3.
    public static class SampleData
    {
        // Task 3: remove the comments from this method (select it and press Ctrl+K, Ctrl+U).
        // public static int Seed(AppDbContext db)
        // {
        //     if (db.Departments.Any())
        //         return 0;   // already seeded

        //     Department computing = new Department("Cybersecurity and Computing", "Design, Informatics and Business");
        //     Department games = new Department("Games", "Design, Informatics and Business");
        //     Department arts = new Department("Arts", "Design, Informatics and Business");

        //     computing.AddStudent(new Student("NI003", "Amira", new DateTime(2005, 5, 20), "07000 000003", "3 Perth Road", "2400123", "BSc Computing"));
        //     games.AddStudent(new Student("NI004", "Ben", new DateTime(2004, 11, 8), "07000 000004", "4 Perth Road", "2400456", "BSc Computer Games"));
        //     computing.AddStudent(new Student("NI005", "Chloe", new DateTime(2005, 2, 14), "07000 000005", "12 Nethergate", "2400789", "BSc Computing"));
        //     computing.AddStudent(new Student("NI006", "Daniel", new DateTime(2003, 9, 30), "07000 000006", "7 Hawkhill", "2401012", "BSc Ethical Hacking"));
        //     computing.AddStudent(new Student("NI007", "Eilidh", new DateTime(2005, 7, 1), "07000 000007", "21 Seagate", "2401345", "BSc Cybersecurity"));
        //     arts.AddStudent(new Student("NI008", "Farah", new DateTime(2004, 3, 17), "07000 000008", "9 Lochee Road", "2401678", "BA Computer Arts"));

        //     db.Departments.AddRange(computing, games, arts);
        //     return db.SaveChanges();
        // }
    }
}
