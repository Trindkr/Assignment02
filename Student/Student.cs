using System;

namespace Student
{
    public class Student
    {
        int id;
        string givenName, surName;
        public Status status;
        DateTime startDate,endDate, graduationDate;
        
        public Student(int id, string givenName, string surName, Status status, DateTime startdate, DateTime endDate, DateTime graduationDate)
        {
            this.id = id;
            this.givenName = givenName;
            this.surName = surName;
            this.status = status;
            this.startDate = startDate;
            this.endDate = endDate;
            this.graduationDate = graduationDate;

        }

        public Status getStudentStatus(DateTime nowDate)
        {

            //throw new NotImplementedException();
            return Status.Active;
        }

    }

    public enum Status
        {
            New,
            Active,
            Dropout,
            Graduated
        }  
}
