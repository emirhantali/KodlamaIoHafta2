using DataAccess.Abstracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes;

public class CourseDal :ICourseDal
{
    List<Course> courses;

    public CourseDal()
    {
        Course course = new Course();
        course.Id = 1;
        course.Name = "2024 - Yazılım Geliştirici Yetiştirme Kampı C#";
        course.Description = "Sıfırdan başlayıp yepyeni bir metodolojiyle profesyonelleşeceksiniz\r\n\r\n\r\nAdayların bir çoğu öğrenme döngüsü dediğim bir çıkmazın içinde.\r\n\r\nSürekli aynı konuları öğrenip daldan dala atlıyor.\r\n\r\nBu sorunun temelini programlamayı gerçek hayatla ilişkilendirememek olarak görüyorum.\r\n\r\nProgramlama teknolojilerinin hepsi aynı temele dayanır. Kampta bunu öğreneceksiniz.\r\n\r\nBu program sadece temel içerikleri değil baştan sona proje geliştirme deneyimlerini de kapsar.";
        course.CourseSalary = 0;

        Course course2 = new Course();
        course2.Id = 2;
        course2.Name = "(2022) Yazılım Geliştirici Yetiştirme Kampı (JAVA)";
        course2.Description = "Sıfırdan başlayıp yepyeni bir metodolojiyle profesyonelleşeceksiniz\r\n\r\n\r\nAdayların bir çoğu öğrenme döngüsü dediğim bir çıkmazın içinde.\r\n\r\nSürekli aynı konuları öğrenip daldan dala atlıyor.\r\n\r\nBu sorunun temelini programlamayı gerçek hayatla ilişkilendirememek olarak görüyorum.\r\n\r\nProgramlama teknolojilerinin hepsi aynı temele dayanır. Kampta bunu öğreneceksiniz.\r\n\r\nBu program sadece temel içerikleri değil baştan sona proje geliştirme deneyimlerini de kapsar.";
        course2.CourseSalary = 0;

        courses = new List<Course> { course, course2 };

    }
    public void Add(Course course)
    {
        courses.Add(course);
    }

    public void Delete(Course course)
    {
        courses.Remove(course);
    }

    public List<Course> GetAll()
    {
        return courses;
    }

    public void Update(Course course)
    {
        Console.WriteLine("Course is updated!");
    }














}
