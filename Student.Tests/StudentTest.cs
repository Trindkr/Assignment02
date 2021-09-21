using System;
using Xunit;

namespace Student.Tests
{
    public class StudentTest
    {
        [Fact]
        public void Status_isOnlyReadable_Active()
        {
           var start = new DateTime(2020,9,9);
            var end = new DateTime(2023,7,7);
            var grad = new DateTime(2023,7,7);

            var s1 = new Student(1,"bob","hansen", start, end,grad);

       

            Assert.Equal(Status.Active, s1.Status);
           
        }

        [Fact]
        public void Test_StudentStatus_New() {
           var start = new DateTime(2020,12,12);
            var end = new DateTime(2023,7,7);
            var grad = new DateTime(2023,7,7);

            var s1 = new Student(1,"bob","hansen", start, end,grad);
            Assert.Equal(Status.New, s1.Status);
        }

        [Fact]
        public void Test_StudentStatus_Graduated() {
               var start = new DateTime(2020,9,9);
            var end = new DateTime(2021,7,7);
            var grad = new DateTime(2021,7,7);

            var s1 = new Student(1,"bob","hansen", start, end,grad);
            Assert.Equal(Status.Graduated, s1.Status);
        }

        [Fact]
        public void Test_StatudentStatus_Dropout() {
            var start = new DateTime(2020,9,9);
            var end = new DateTime(2021,7,7);
            var grad = new DateTime(2022,7,7);

            var s1 = new Student(1,"bob","hansen", start, end,grad);
            Assert.Equal(Status.Dropout, s1.Status);
        }

        [Fact]
        public void Test_StudentStatus_Active() {
             var start = new DateTime(2020,9,9);
            var end = new DateTime(2023,7,7);
            var grad = new DateTime(2023,7,7);

            var s1 = new Student(1,"bob","hansen", start, end,grad);
            Assert.Equal(Status.Active, s1.Status);
        }

        // [Fact]
        // public void Status_isOnlyReadable_New()
        // {
        //     var s2 = new Student(2,"ib","karlsen", new DateTime(2008, 5, 1), new DateTime(2010, 3, 1), new DateTime(2010, 3, 1));
        //     var date1 = new DateTime(2005, 4, 2);
        //     var date2 = new DateTime(2008, 5, 1); // EDGE

        //     var output1 = s2.getStudentStatusFromDate(date1);
        //     var output2 = s2.getStudentStatusFromDate(date2);

        //     Assert.Equal(Status.New, output1);
        //     Assert.NotEqual(Status.New, output2);
        // }

        // [Fact]
        // public void Status_isOnlyReadable_Dropout()
        // {
        //     var s3 = new Student(3,"henning","olsen", Status.Dropout, new DateTime(2008, 5, 1), new DateTime(2009, 3, 1), new DateTime(2010, 3, 1));
        //     var date1 = new DateTime(2010, 4, 2);
        //     var date2 = new DateTime(2011, 4, 2);
        //     var date3 = new DateTime(2007, 1, 1);

        //     var output1 = s3.getStudentStatusFromDate(date1);
        //     var output2 = s3.getStudentStatusFromDate(date2);
        //     var output3 = s3.getStudentStatusFromDate(date3);

        //     Assert.Equal(Status.Dropout, output1);
        //     Assert.Equal(Status.Dropout, output2);
        //     Assert.NotEqual(Status.Dropout, output3);
        // }

        // [Fact]
        // public void Status_isOnlyReadable_Graduated()
        // {
        //     var s4 = new Student(4, "anne","svensen", Status.Active, new DateTime(2008, 5, 1), new DateTime(2010, 3, 1), new DateTime(2010, 3, 1));
        //     var date1 = new DateTime(2010, 4, 2);
        //     var date2 = new DateTime(2009, 4, 2);
        //     var date3 = new DateTime(2010, 3, 1);
            
        //     var output1 = s4.getStudentStatusFromDate(date1);
        //     var output2 = s4.getStudentStatusFromDate(date2);
        //     var output3 = s4.getStudentStatusFromDate(date3);

        //     Assert.Equal(Status.Graduated, output1);
        //     Assert.NotEqual(Status.Graduated, output2);
        //     Assert.Equal(Status.Graduated, output3);
        // }

        [Fact]
        public void Id_SetOnlyOnClassCreated() 
        {
            var start = new DateTime(2020,9,9);
            var end = new DateTime(2023,7,7);
            var grad = new DateTime(2023,7,7);

            var s1 = new Student(1,"bob","hansen", start, end,grad);
            Assert.Equal(Status.Active, s1.Status);
            var output = s1.id;

            Assert.NotEqual(2, output);
        }
         [Fact]
        public void ToStringMethod() 
        {
            var start = new DateTime(2025,9,9);
            var end = new DateTime(2024,7,7);
            var grad = new DateTime(2024,7,7);

            var s1 = new Student(1,"bob","hansen", start, end,grad);
            var output = $"bob hansen id: 1 (Active) | Start: {start} End: {end} Graduation: {grad}";          
          
            Assert.Equal( s1.toString(), output);
        }
        
    }
}
