using System;
using Xunit;

namespace Student.Tests
{
    public class ImmutableStudentTest
    {
        [Fact]
        public void PrintInformation_ImmutableStudent_ToString()
        {
            var s1 = new ImmutableStudent(1,"bob","hansen", new DateTime(2008, 5, 1), new DateTime(2010, 3, 1),new DateTime(2010, 3, 1));
            var output = $"{s1.givenName} {s1.surName} id: {s1.id} ({s1.status}) | Start: {s1.startdate} End: {s1.endDate} Graduation: {s1.graduationDate}";
          
          
            Assert.Equal( s1.toString(), output);
        }
          [Fact]
        public void Compare_ImmutableStudent_and_Student_With_Equal()
        {
            var s1 = new ImmutableStudent(1,"bob","hansen", new DateTime(2008, 5, 1), new DateTime(2010, 3, 1),new DateTime(2010, 3, 1));
            var student2 = s1 with {};
          
            Assert.True(s1.Equals(student2));
        }
    }
}
