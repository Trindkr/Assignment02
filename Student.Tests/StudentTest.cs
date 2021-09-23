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
