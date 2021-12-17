using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<StudentDb>(opt => opt.UseInMemoryDatabase("StudentList"));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/Studentitems", async (StudentDb db) =>
    await db.Students.ToListAsync());

app.MapGet("/Studentitems/complete", async (StudentDb db) =>
    await db.Students.Where(t => t.IsComplete).ToListAsync());

app.MapGet("/Studentitems/{id}", async (int id, StudentDb db) =>
    await db.Students.FindAsync(id)
        is Student Student
            ? Results.Ok(Student)
            : Results.NotFound());

app.MapPost("/Studentitems", async (Student Student, StudentDb db) =>
{
    db.Students.Add(Student);
    await db.SaveChangesAsync();

    return Results.Created($"/Studentitems/{Student.Id}", Student);
});

app.MapPut("/Studentitems/{id}", async (int id, Student inputStudent, StudentDb db) =>
{
    var Student = await db.Students.FindAsync(id);

    if (Student is null) return Results.NotFound();

    Student.Name = inputStudent.Name;
    Student.IsComplete = inputStudent.IsComplete;

    await db.SaveChangesAsync();

    return Results.NoContent();
});

app.MapDelete("/Studentitems/{id}", async (int id, StudentDb db) =>
{
    if (await db.Students.FindAsync(id) is Student Student)
    {
        db.Students.Remove(Student);
        await db.SaveChangesAsync();
        return Results.Ok(Student);
    }

    return Results.NotFound();
});

app.Run();

class Student
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool IsComplete { get; set; }
}

class StudentDb : DbContext
{
    public StudentDb(DbContextOptions<StudentDb> options)
        : base(options) { }

    public DbSet<Student> Students => Set<Student>();
}