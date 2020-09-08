using System;
using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    public void Add(string student, int grade)
    {
        roster.Add(new Student(student,grade));
    }

    public IEnumerable<string> Roster()
    {
        return roster        
            .OrderBy(s => s.Name)
            .OrderBy(s => s.Grade)
            .Select(s => s.Name)
            .ToArray<string>();
    }

    public IEnumerable<string> Grade(int grade)
    {
        return roster        
            .Where(s => s.Grade == grade)
            .OrderBy(s => s.Name)
            .Select(s => s.Name)
            .ToArray<string>();
    }

    private List <Student> roster = new List <Student>(); 

    private struct Student 
    {
        public string Name { get; }
        public int Grade { get; }

        public Student(string name, int grade) 
        {
            Name = name;
            Grade = grade;
        }       
    }
}