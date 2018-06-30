using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CTSStudent
{
    public class Student : ICloneable , IComparable<Student>
    {
        //first, middle and last name, SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty.
        // Use an enumeration for the specialties, universities and faculties.

        public string FirstName { get; private set; }
        public string MiddleName { get; private set; }
        public string LastName { get; private set; }
        public string SSN { get; private set; }
        public string PernamentAddres { get; private set; }
        public string MobilePhone { get; private set; }
        public string EMail { get; private set; }
        public string Course { get; private set; }
        public Specialty Specialty { get; private set; }
        public University University { get; private set; }
        public Faculty Faculty { get; private set; }

        public Student(string fName, string mName, string lName, string ssn, string permAddres, string phone,
            string mail, string course, Specialty specialty, University university, Faculty faculty)
        {
            this.FirstName = fName;
            this.MiddleName = mName;
            this.LastName = lName;
            this.SSN = ssn;
            this.PernamentAddres = permAddres;
            this.MobilePhone = phone;
            this.EMail = mail;
            this.Course = course;
            this.Specialty = specialty;
            this.University = university;
            this.Faculty = faculty;
        }

        public int CompareTo(Student other)
        {
            if (this.FirstName.CompareTo(other.FirstName) == 0)
            {
                return int.Parse(this.SSN).CompareTo(int.Parse(other.SSN));
            }
            else
            {
                return this.FirstName.CompareTo(other.FirstName);
            }
        }

        public override string ToString()
        {
            StringBuilder build = new StringBuilder();

            build.AppendLine(this.FirstName);
            build.AppendLine(this.MiddleName);
            build.AppendLine(this.LastName);
            build.AppendLine(this.SSN);
            build.AppendLine(this.PernamentAddres);
            build.AppendLine(this.MobilePhone);
            build.AppendLine(this.EMail);
            build.AppendLine(this.Course);
            build.AppendLine(this.Specialty.ToString());
            build.AppendLine(this.University.ToString());
            build.AppendLine(this.Faculty.ToString());

            return build.ToString().Trim();
        }

        public override bool Equals(object obj)
        {
            var secondStudent = (Student) obj;

            return EqualProperties(secondStudent);

        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        object ICloneable.Clone()
        {
            throw new NotImplementedException();
        }

        public Student Clone()
        {
            var clonedStudent = new Student(this.FirstName,this.MiddleName,this.LastName,this.SSN,this.PernamentAddres,this.MobilePhone,this.EMail,this.Course,this.Specialty,this.University,this.Faculty);

            return clonedStudent;
        }



        public static bool operator ==(Student firstStudent,Student secondStudent)
        {
            return firstStudent.Equals(secondStudent);
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !firstStudent.Equals(secondStudent);
        }

        private bool EqualProperties(Student secondStudent)
        {
            if (this.FirstName == secondStudent.FirstName && this.MiddleName == secondStudent.MiddleName &&
                this.LastName == secondStudent.LastName && this.SSN == secondStudent.SSN &&
                this.PernamentAddres == secondStudent.PernamentAddres &&
                this.MobilePhone == secondStudent.MobilePhone &&
                this.EMail == secondStudent.EMail && this.Course == secondStudent.Course &&
                this.Specialty == secondStudent.Specialty &&
                this.University == secondStudent.University && this.Faculty == secondStudent.Faculty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    
}
