using EntityFrameworkCorePractice;

StudentContext dbContext = new StudentContext();

Student s = new()
{
    FullName = "Cram man",
    Email = "ilovecram@hotmail.com",
    DateOfBirth = new DateOnly(2000,1,1)
};

dbContext.Students.Add(s);
dbContext.SaveChanges();

Student s2 = new()
{
    FullName = "Grooble",
    Email = "theofficialgrooble@yahoo.com",
    DateOfBirth = new DateOnly(1500, 1, 1)
};

dbContext.Students.Add(s2);
dbContext.SaveChanges();

List<Student> allStudents = dbContext.Students.ToList();

foreach (Student stu in allStudents)
{
    Console.WriteLine($"{stu.FullName} has an email of {stu.Email}");
    Console.WriteLine();
}