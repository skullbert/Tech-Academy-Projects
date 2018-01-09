using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeStudentCourses
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void assignment1Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a List of Courses (add three example Courses ...
             * make up the details).  Each Course should have at least two
             * Students enrolled in them.  Use Object and Collection
             * Initializers.  Then, iterate through each Course and print
             * out the Course's details and the Students that are enrolled in
             * each Course.
             */            

            List<Course> courses = new List<Course>() {
                new Course() {CourseId=100,Name="Psychology",Students= new List<Student>(){
                    new Student() {StudentId=1,Name="Danny Zuco" },
                    new Student() {StudentId=2,Name="Sandy Newman" }
                    }
                },
                new Course() {CourseId=200,Name="Algebra",Students= new List<Student>(){
                    new Student() {StudentId=3,Name="Donny Zico" },
                    new Student() {StudentId=4,Name="Sindy Nowman" }
                    }
                } ,
                new Course() {CourseId=300,Name="Biology",Students= new List<Student>(){
                    new Student() { StudentId=5,Name="Denny Zaco"},
                    new Student() {StudentId=6,Name="Sundy Nawman" }
                    }
                }

             };

            foreach (Course course in courses)
            {
                resultLabel.Text += String.Format("<br/>{0} - {1}", course.CourseId,course.Name);
                foreach (var student in course.Students)
                {
                    resultLabel.Text += String.Format("<br/>&nbsp&nbsp {0} - {1}", student.StudentId, student.Name);
                }
            }
        }


        

        protected void assignment2Button_Click(object sender, EventArgs e)
        {
            /*
             * Create a Dictionary of Students (add three example Students
             * ... make up the details).  Use the StudentId as the 
             * key.  Each student must be enrolled in two Courses.  Use
             * Object and Collection Initializers.  Then, iterate through
             * each student and print out to the web page each Student's
             * info and the Courses the Student is enrolled in.
             */

            Dictionary<int, Student> students = new Dictionary<int, Student>
            {
                {1, new Student { StudentId=1,Name="Winnie the Pooh",Courses= new List<Course>()
                {
                    new Course() {CourseId=200,Name="Honey Gathering 101" },
                    new Course() {CourseId=300,Name="Avoiding Bees" }
                }
                } },
                {2, new Student {StudentId=2,Name="Tigger",Courses=new List<Course>()
                {
                    new Course() {CourseId=400,Name="Bouncing" },
                    new Course() {CourseId=500,Name="What Tiggers Do Best" }
                }
                } },
                {3,new Student {StudentId=3,Name="Piglet",Courses=new List<Course>()
                {
                    new Course() {CourseId=600,Name="How to be Confident" },
                    new Course() {CourseId=700,Name="More than a Best Friend" }
                }
                } }
            };

            foreach (KeyValuePair<int,Student> student in students)
            {
                resultLabel.Text += String.Format("<br/>{0} - {1}", student.Value.StudentId,
                                                                    student.Value.Name);

                foreach (var course in student.Value.Courses)
                {
                    resultLabel.Text += String.Format("<br/>&nbsp&nbsp{0} - {1}",course.CourseId,
                                                                                 course.Name);
                }
            }
        }

        protected void assignment3Button_Click(object sender, EventArgs e)
        {
            /*
             * We need to keep track of each Student's grade (0 to 100) in a 
             * particular Course.  This means at a minimum, you'll need to add 
             * another class, and depending on your implementation, you will 
             * probably need to modify the existing classes to accommodate this 
             * new requirement.  Give each Student a grade in each Course they
             * are enrolled in (make up the data).  Then, for each student, 
             * print out each Course they are enrolled in and their grade.
             */

            List<Student> students = new List<Student>()
            {
                new Student() { StudentId=1,Name="Winnie the Pooh",Courses= new List<Course>()
                {
                    new Course() {CourseId=200,Name="Honey Gathering 101",Grades=90 },
                    new Course() {CourseId=300,Name="Avoiding Bees",Grades=70 }
                }
                },
                new Student() {StudentId=2,Name="Tigger",Courses=new List<Course>()
                {
                    new Course() {CourseId=400,Name="Bouncing",Grades=100 },
                    new Course() {CourseId=500,Name="What Tiggers Do Best",Grades=95 }
                }
                },
                new Student() {StudentId=3,Name="Piglet",Courses=new List<Course>()
                {
                    new Course() {CourseId=600,Name="How to be Confident",Grades=70 },
                    new Course() {CourseId=700,Name="More than a Best Friend",Grades=90 }
                },
                }
            };

            foreach (Student student in students)
            {
                resultLabel.Text += String.Format("<br/>{0} - {1}", student.StudentId, student.Name);

                foreach (var course in student.Courses)
                {
                    resultLabel.Text += String.Format("<br/>{0} - {1} - Grade: {2}", course.CourseId, course.Name, course.Grades);
                }
            }

        }    
    }
}