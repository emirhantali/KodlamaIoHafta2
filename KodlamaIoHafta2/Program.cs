
using Business;
using DataAccess.Concretes;
using Entities;

CourseManager courseManager = new(new CourseDal());
List<Course> courses = courseManager.GetAll();

courseManager.Add(new Course
{
    Id = 3,
    Name = "Test",
    Description = "Test",
    CourseSalary = 5
});
//courseManager.Delete(courses.First());
courseManager.Update(new Course
{
    Id = 4,
    Name = "Test2",
    Description = "Test2",
    CourseSalary = 20
});



foreach (var course in courses)
{

    Console.WriteLine(course.Name + " / " + course.CourseSalary);


}



CategoryManager categoryManager = new(new CategoryDal());
List<Category> categories = categoryManager.GetAll();

categoryManager.Add(new Category
{
    Id = 3,
    Name = "Test"
});

//categoryManager.Delete(categories.First());
categoryManager.Update(new Category
{
    Id = 4,
    Name = "Test2"
});



foreach (var category in categories)
{

    Console.WriteLine(category.Name);


}



InstructorManager instructorManager = new(new InstructorDal());
List<Instructor> instructors = instructorManager.GetAll();

instructorManager.Add(new Instructor
{
    Id = 3,
    FirstName = "Ahmet",
    LastName = "Çakar"
});

//instructorManager.Delete(instructors.First());
instructorManager.Update(new Instructor
{
    Id = 4,
    FirstName = "Test2",
    LastName = "Test"
});




foreach (var ınstructor in instructors)
{
    Console.WriteLine(ınstructor.FirstName + " " + ınstructor.LastName);
}


















