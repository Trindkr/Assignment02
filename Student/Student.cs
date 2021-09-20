using System;

namespace Student
{
    public class Student
    {
        public readonly int id ;
        string givenName, surName;
        Status status;
        DateTime startDate, endDate, graduationDate;
        
        public Student(int id, string givenName, string surName, Status status, DateTime startdate, DateTime endDate, DateTime graduationDate)
        {
            this.id = id;
            this.givenName = givenName;
            this.surName = surName;
            this.status = status;
            this.startDate = startdate;
            this.endDate = endDate;
            this.graduationDate = graduationDate;

        }

        public Status getStudentStatusFromDate(DateTime nowDate) {
            if (this.startDate > nowDate) 
            { 
                return Status.New;
            }
            else if (nowDate < this.graduationDate && this.endDate == this.graduationDate) 
            { 
                return Status.Active;
            }
            else if(nowDate >= this.graduationDate && this.endDate == this.graduationDate) 
            {
                return Status.Graduated;
            }
            else 
            { 
                return Status.Dropout; 
            }
        }
           
        public String toString() {
            return $"{givenName} {surName} id: {id} ({status}) | Start: {startDate} End: {endDate} Graduation: {graduationDate}";
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
