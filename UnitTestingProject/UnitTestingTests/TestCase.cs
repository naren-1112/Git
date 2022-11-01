using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using UnitTestingProject;

namespace UnitTestingTests
{
    [TestFixture]
    public class Class_test
    {
        [TestCase]
        public void test_student()
        {
            Student s = new Student();
            s.student_id = 1;
            s.student_name = "Naren";
            Assert.AreEqual(s.student_id, 1);
        }
        [TestCase]
        public void test_subject()
        {
            Subject s = new Subject();
            s.subject_id = 101;
            s.subject_name = "Tamil";
            s.subject_marks = 100;
            Assert.AreEqual(s.subject_marks, 100);
        }
        [TestCase]
        public void test_teacher()
        {
            Teacher s = new Teacher();
            s.teacher_id = 1001;
            s.teacher_name = "Karthiga";
            Assert.AreEqual(s.teacher_name, "Karthiga");
        }
    }
}