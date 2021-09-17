using System;

namespace Student
{
    public class Student
    {
        int id;
        string givenName, surName;
        enum Status
        {
            New,
            Active,
            Dropout,
            Graduated
        }
        DateTime startDate,endDate, graduationDate;
        
        public Student(int id, string givenName, string surName, Status staus, DateTime startdate, DateTime endDate, DateTime graduationDate)
        {
            this.id = id;
            this.givenName = givenName;
            this.surName = surName;
            this.staus = status;
            this.startDate = startDate;
            this.endDate = endDate;
            this.graduationDate = graduationDate;

        }

        public Status getStudentStatus(DateTime nowDate)
        {

            return null;
        }

    }

    
}
