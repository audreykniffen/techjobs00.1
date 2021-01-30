using System;
namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public string Name { get; set; } //only string
        public Employer EmployerName { get; set; } //class
        public Location EmployerLocation { get; set; } // class
        public PositionType JobType { get; set; } // class
        public CoreCompetency JobCoreCompetency { get; set; } // class

        // TODO: Add the two necessary constructors.

        // TODO: Generate Equals() and GetHashCode() methods.
    }
}


// jobs class notes:
/* 
 * 
 * fields/properties: Id (number), Name (string), EmployerName (Employer object), 
 * EmployerLocation (Location object), JobType (PositionType object), 
 * JobCoreCompetency (CoreCompetency object)
Two constructors: the first constructor will have no parameters and will
assign a value to the id property for a Job object and increment the id
field for the class; the second constructor will have 5 parameters to
assign to the 5 remaining properties for a Job object and calls the
first constructor, in order to assign the id property for the Job object.
[See Employer.cs for a working pattern that could satisfy this particular spec]
Methods: Equals(), GetHashCode(), and ToString().


Code a constructor to initialize the id field with a unique value. This
constructor should take no parameters.
Code a second constructor that takes 5 parameters and assigns values to
name, employerName, employerLocation, jobType, and jobCoreCompetency. Also,
this constructor should call the first in order to initialize the id field.
Generate the Equals() and GetHashCode() methods. Consider two Job objects equal
when their id fields match.

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

needs necessary constructors, then i can define the equals() method.
use unit testing to verify if parts of job class will work.
tdd to build the tostring method. a coupel of requireents on ht etwo string fn
in the job class. (colons after property names)
if a field is empty method shoudl add data not avaiable after the label
tests start small and simple and get more complex because each test needs ot tur green
after two string, 

*/
 