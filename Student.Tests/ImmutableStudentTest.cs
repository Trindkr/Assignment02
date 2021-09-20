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
            var output = "bob hansen id: 1 (Graduated) | Start: 01.05.2008 00.00.00 End: 01.03.2010 00.00.00 Graduation: 01.03.2010 00.00.00";
          
          
            Assert.Equal( s1.toString(), output);
        }
          [Fact]
        public void Compare_ImmutableStudent_and_Student_With_Equal()
        {
            var s1 = new ImmutableStudent(1,"bob","hansen", new DateTime(2008, 5, 1), new DateTime(2010, 3, 1),new DateTime(2010, 3, 1));
            var s2 = new Student(1,"bob","hansen",Status.Active, new DateTime(2008, 5, 1), new DateTime(2010, 3, 1),new DateTime(2010, 3, 1));

          
            Assert.True(s1.Equals(s2));
        }
    }
}
