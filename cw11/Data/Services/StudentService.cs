using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using cw11.Models;

namespace cw11.Repository
{
    public class StudentService : IStudentService
    { 
        public static List<Student> Students = new List<Student>()
        {
            new Student 
            {
                IdStudent = 1,
                Avatar = "https://www.shareicon.net/data/512x512/2016/07/03/790265_people_512x512.png",
                FirstName = "Sample",
                LastName = "Student",
                BirthDate = DateTime.Now.AddYears(-22),
                Studies = "Managment"
            },

            new Student
            {
                IdStudent = 2,
                Avatar = "https://www.shareicon.net/data/512x512/2016/07/03/790265_people_512x512.png",
                FirstName = "Jan",
                LastName = "Kowalski",
                BirthDate = DateTime.Now.AddYears(-21),
                Studies = "Computer Sience"
            },

            new Student
            {
                IdStudent = 3,
                Avatar = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRIXIrqiW3R5OstWAjkuFvNwvjYHRaTmwEQWg&usqp=CAU",
                FirstName = "Piotr",
                LastName = "Jakowski",
                BirthDate = DateTime.Now.AddYears(-23),
                Studies = "Digital Systems"
            },
            
            new Student
            {
                IdStudent = 4,
                Avatar = "https://cdn1.iconfinder.com/data/icons/user-pictures/100/female1-512.png",
                FirstName = "Lolla",
                LastName = "Shmidt",
                BirthDate = DateTime.Now.AddYears(-24),
                Studies = "Computer Sience"
            },

            new Student
            {
                IdStudent = 5,
                Avatar = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRIXIrqiW3R5OstWAjkuFvNwvjYHRaTmwEQWg&usqp=CAU",
                FirstName = "Adam",
                LastName = "Niejeski",
                BirthDate = DateTime.Now.AddYears(-34),
                Studies = "Digital Systems"
            },

            new Student
            {
                IdStudent = 6,
                Avatar = "https://cdn1.iconfinder.com/data/icons/user-pictures/100/female1-512.png",
                FirstName = "Karolina",
                LastName = "Olewska",
                BirthDate = DateTime.Now.AddYears(-22),
                Studies = "Computer Sience"
            }
        };

        public void DeleteStudent(int ID)
        {
            var student = GetStudent(ID);

            if (student != null)
                Students.Remove(student);
        }

        public Student GetStudent(int ID) => Students.Find(student => student.IdStudent == ID);

    }
}
