using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{

    [TestClass] // only want one public class inside namespace
    //test method inside . each will be a different unit test

    public class JobTests
    {
        Job testJob1;
        Job testJob2;
        Job testJob3;



        [TestInitialize]
        public void CreateTestJobAndFields()
        {

            testJob1 = new Job("Servant", new Employer("cats"), new Location("house"), new PositionType("servant"), new CoreCompetency("canOpener"));
            testJob2 = new Job("Servant", new Employer("cats"), new Location("house"), new PositionType("servant"), new CoreCompetency("canOpener"));
            testJob3 = new Job("Servant", new Employer("cats"), new Location("house"), new PositionType("servant"), new CoreCompetency("canOpener"));

        }


        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();
            Assert.IsTrue(job2.Id - job1.Id == 1);

        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {

            Assert.IsTrue(testJob1.Name == "Servant");
            Assert.IsTrue(testJob1.EmployerName.Value == "cats");
            Assert.IsTrue(testJob1.EmployerLocation.Value == "house");
            Assert.IsTrue(testJob1.JobCoreCompetency.Value == "servant");
            Assert.IsTrue(testJob1.JobType.Value == "canOpener");
        }


        [TestMethod] //Generate two Job objects that have identical field values EXCEPT for id. Test that Equals() returns false. --> Assert.isFalse//
        public void TestJobsForEquality()
        {
            Assert.IsFalse(testJob2.Equals(testJob3));
        }

        [TestMethod]
        public void TestJobToString()
        {

            Assert.IsTrue(testJob1.ToString().Contains($"ID: " + testJob1.Id));
            Assert.IsTrue(testJob1.ToString().Contains($"Name: " + testJob1.Name));
            Assert.IsTrue(testJob1.ToString().Contains($"Employer: " + testJob1.EmployerName.Value));
            Assert.IsTrue(testJob1.ToString().Contains($"Location: " + testJob1.EmployerLocation.Value));
            Assert.IsTrue(testJob1.ToString().Contains($"PositionType: " + testJob1.JobType.Value));
            Assert.IsTrue(testJob1.ToString().Contains($"CoreCompetency: " + testJob1.JobCoreCompetency.Value));

        }

        [TestMethod]
        public void StringLength()
        {
            string testString = testJob2.ToString();
            Assert.AreEqual(testString[0], testString[testString.Length - 1]);

        }

        [TestMethod]
        public void TestOutput()
        {
            string testString = $"\nID: {testJob2.Id}\n Name: {testJob2.Name}\n Employer: {testJob2.EmployerName.Value}\n Location: Data Not Available\n Position Type: Data Not Available\n Core Competency: {testJob2.JobCoreCompetency.Value}\n";
            Assert.AreEqual(testJob2.ToString(), testString);
        }
    }
}


