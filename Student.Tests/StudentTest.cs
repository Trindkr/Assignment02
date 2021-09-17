using System;
using Xunit;

namespace Student.Tests
{
    public class StudentTest
    {


        //Case: New
        //[InlineData(new Student(]
        //Case: Dropout
        //[InlineData(new Student(1,"henning","olsen", Status.Dropout, new DateTime(2008, 5,1), new DateTime(2009, 3,1), new DateTime(2010, 3,1)), new DateTime(2010,4,2), Status.Dropout)]
        //Case: Graduated
        //[InlineData(new Student(1,"anne","svensen", Status.Active,new DateTime(2008, 5,1),new DateTime(2010, 3,1),new DateTime(2010, 3,1)), new DateTime(2010,4,2), Status.Graduated)]
        [Fact]
        public void Status_isOnlyReadable_Active()
        {
            var s1 = new Student(1,"bob","hansen", Status.Active, new DateTime(2008, 5,1),new DateTime(2010, 3,1),new DateTime(2010, 3,1));
            var date = new DateTime(2009,4,2);
            var output = s1.getStudentStatus(date);

            Assert.Equal(output ,Status.Active);
        }

        [Fact]
        public void Status_isOnlyReadable_New()
        {
            var s1 = new Student(1,"ib","karlsen", Status.New,new DateTime(2008, 5,1),new DateTime(2010, 3,1),new DateTime(2010, 3,1));
            var date = new DateTime(2005,4,2);
            var output = s1.getStudentStatus(date);

            Assert.Equal(output, Status.New);
        }


    }
}
