﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciplesPart1
{
    class Teachers : Person
    {
        public Discipline[] Subjects { get; private set; }

        public List<string> TeacherComments { get; private set; }

        public Teachers(string name , int age,Discipline[] subjects) : base(name,age)
        {
            Subjects = subjects;
        }

        public void Add(string comment)
        {
            TeacherComments.Add(comment);
        }

    }

    class Discipline
    {
        public string Name { get; private set; }

        public int Lectures { get; private set; }

        public int Exercises { get; private set; }

        public List<string> DisciplineComments { get; private set; }

        public Discipline(string name, int lectures, int exercises)
        {
            Name = name;
            Lectures = lectures;
            Exercises = exercises;
        }

        public void Add(string comment)
        {
            DisciplineComments.Add(comment);
        }
    }
}
