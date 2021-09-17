using System;
using Xunit;

namespace Student.Tests
{
    public class Student
    {
        [Theory]
        //Case: Active
        [InlineData(new Student(1,"bob","hansen",new Status(Active),new DateTime(2008, 5,1),new DateTime(2010, 3,1),new DateTime(2010, 3,1)), new DateTime(2009,4,2), new Staus(Active))]
        //Case: New
        [InlineData(new Student(1,"ib","karlsen",new Status(New),new DateTime(2008, 5,1),new DateTime(2010, 3,1),new DateTime(2010, 3,1)), new DateTime(2005,4,2), new Staus(New))]
        //Case: Dropout
        [InlineData(new Student(1,"henning","olsen",new Status(Dropout),new DateTime(2008, 5,1),new DateTime(2009, 3,1),new DateTime(2010, 3,1)), new DateTime(2010,4,2),, new Staus(Dropout))]
        //Case: Graduated
        [InlineData(new Student(1,"anne","svensen",new Status(Active),new DateTime(2008, 5,1),new DateTime(2010, 3,1),new DateTime(2010, 3,1)), new DateTime(2010,4,2),, new Staus(Graduated))]
        public void Status_isOnlyReadable(Student student, DateTime nowDate, Status expected)
        {

            Assert.Equal(getStudentStatus(nowDate),expected);

        }
    }
}
