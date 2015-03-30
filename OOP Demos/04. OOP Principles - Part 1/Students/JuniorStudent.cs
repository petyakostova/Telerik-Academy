namespace Students
{
    using System.Collections.Generic;

    public class JuniorStudent : Person
    {
        private List<int> allMarks;

        public JuniorStudent()
        {
            allMarks = new List<int>();
        }

        // encapsulation
        public List<int> Marks
        {
            get
            {
                // don't want someone to clear the marks so instead of 
                // return this.allMarks; =>
                return new List<int>(this.allMarks);
            }
        }

        public void AddMark(int mark)
        {
            this.allMarks.Add(mark);
        }

        public override string ToString()
        {
            return string.Join(" ", this.Marks);
        }

        protected override IEnumerable<string> Courses
        {
            get
            {
                return new HashSet<string> { "Fundamentals of C#", "C# Part 2" }; 
            }
        }
    }
}
