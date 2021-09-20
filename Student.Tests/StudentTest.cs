using System;
using Xunit;

namespace Student.Tests
{
    public class StudentTest
    {
        [Fact]
        public void Status_isOnlyReadable_Active()
        {
            var s1 = new Student(1,"bob","hansen", Status.Active, new DateTime(2008, 5, 1), new DateTime(2010, 3, 1),new DateTime(2010, 3, 1));
            var date1 = new DateTime(2009, 4, 2);
            var date2 = new DateTime(2008, 5, 1);
            var date3 = new DateTime(2010, 3, 1);


            var output1 = s1.getStudentStatusFromDate(date1);
            var output2 = s1.getStudentStatusFromDate(date2);
            var output3 = s1.getStudentStatusFromDate(date3);

            Assert.Equal(Status.Active, output1);
            Assert.Equal(Status.Active, output2);
            Assert.NotEqual(Status.Active, output3);
        }

        [Fact]
        public void Status_isOnlyReadable_New()
        {
            var s2 = new Student(2,"ib","karlsen", Status.New, new DateTime(2008, 5, 1), new DateTime(2010, 3, 1), new DateTime(2010, 3, 1));
            var date1 = new DateTime(2005, 4, 2);
            var date2 = new DateTime(2008, 5, 1); // EDGE

            var output1 = s2.getStudentStatusFromDate(date1);
            var output2 = s2.getStudentStatusFromDate(date2);

            Assert.Equal(Status.New, output1);
            Assert.NotEqual(Status.New, output2);
        }

        [Fact]
        public void Status_isOnlyReadable_Dropout()
        {
            var s3 = new Student(3,"henning","olsen", Status.Dropout, new DateTime(2008, 5, 1), new DateTime(2009, 3, 1), new DateTime(2010, 3, 1));
            var date1 = new DateTime(2010, 4, 2);
            var date2 = new DateTime(2011, 4, 2);
            var date3 = new DateTime(2007, 1, 1);

            var output1 = s3.getStudentStatusFromDate(date1);
            var output2 = s3.getStudentStatusFromDate(date2);
            var output3 = s3.getStudentStatusFromDate(date3);

            Assert.Equal(Status.Dropout, output1);
            Assert.Equal(Status.Dropout, output2);
            Assert.NotEqual(Status.Dropout, output3);
        }

        [Fact]
        public void Status_isOnlyReadable_Graduated()
        {
            var s4 = new Student(4, "anne","svensen", Status.Active, new DateTime(2008, 5, 1), new DateTime(2010, 3, 1), new DateTime(2010, 3, 1));
            var date1 = new DateTime(2010, 4, 2);
            var date2 = new DateTime(2009, 4, 2);
            var date3 = new DateTime(2010, 3, 1);
            
            var output1 = s4.getStudentStatusFromDate(date1);
            var output2 = s4.getStudentStatusFromDate(date2);
            var output3 = s4.getStudentStatusFromDate(date3);

            Assert.Equal(Status.Graduated, output1);
            Assert.NotEqual(Status.Graduated, output2);
            Assert.Equal(Status.Graduated, output3);
        }

        [Fact]
        public void Id_SetOnlyOnClassCreated() 
        {
            var s1 = new Student(1,"bob","hansen", Status.Active, new DateTime(2008, 5, 1), new DateTime(2010, 3, 1),new DateTime(2010, 3, 1));

            // s1.id = 2;
            var output = s1.id;

            Assert.NotEqual(2, output);
        }
         [Fact]
        public void ToStringMethod() 
        {
            var s1 = new Student(1,"bob","hansen", Status.Active, new DateTime(2008, 5, 1), new DateTime(2010, 3, 1),new DateTime(2010, 3, 1));
            var output = "bob hansen id: 1 (Active) | Start: 01.05.2008 00.00.00 End: 01.03.2010 00.00.00 Graduation: 01.03.2010 00.00.00";
          
          
            Assert.Equal( s1.toString(), output);
        }
        
    }
}
