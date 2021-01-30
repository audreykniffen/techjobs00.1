using System;
namespace TechJobsOO
{
    public class Employer
    { // accepts no argument and assigns the value of nextID ti ID field ++ next id #
    /// </summary>
        public int Id { get; set; }
        private static int nextId = 1;
        public string Value { get; set; }

        public Employer() // how to assign an ID
        { // assigns the value field. also initializes id for the object by calling 1st constructor statement
            Id = nextId;
            nextId++;
        }

        public Employer(string value) : this() //including : this() in any eMPLLYER CONSTRUCTOR MAKES INITIALIZING ID A DEFULT behavior
        {
            Value = value;
        }

        public override bool Equals(object obj)
        {
            return obj is Employer employer &&
                   Id == employer.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
