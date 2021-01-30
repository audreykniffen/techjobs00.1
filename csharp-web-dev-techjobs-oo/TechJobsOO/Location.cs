using System;
namespace TechJobsOO
{
    public class Location
    {
        public int Id { get; set; }
        private static int nextId = 1;
        public string Value { get; set; }

        public Location()
        {
            Id = nextId;
            nextId++;
        }

        public Location (string value) : this() //including : this() in any eMPLLYER CONSTRUCTOR MAKES INITIALIZING ID A DEFULT behavior
        {
            this.Value = value;
        }

        // TODO: Add a second constructor to this class that uses the Location() constructor and sets the value of the value field. 1
        // 1) it should call the first constructor to initialize the id field 2) it must also initialize the value field for a new location object

        public override bool Equals(object obj)
        {
            return obj is Location location &&
                   Id == location.Id;
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
