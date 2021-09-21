using System;

namespace Student
{
    public class Student
    {
        public readonly int id ;
        string givenName, surName;
       public Status Status{get{ if (endDate <= DateTime.Now)
                    return endDate != graduationDate ? Status.Dropout : Status.Graduated;
                if (startDate < DateTime.Now && DateTime.Now < startDate.AddYears(1))
                {
                    return Status.New;
                }
                return Status.Active;
        }}
        DateTime startDate, endDate, graduationDate;
        
        public Student(int id, string givenName, string surName, DateTime startdate, DateTime endDate, DateTime graduationDate)
        {
            this.id = id;
            this.givenName = givenName;
            this.surName = surName;
            this.startDate = startdate;
            this.endDate = endDate;
            this.graduationDate = graduationDate;

        }


        // public Status getStudentStatusFromDate(DateTime nowDate) {
        //     if (this.startDate > nowDate) 
        //     { 
        //         return Status.New;
        //     }
        //     else if (nowDate < this.graduationDate && this.endDate == this.graduationDate) 
        //     { 
        //         return Status.Active;
        //     }
        //     else if(nowDate >= this.graduationDate && this.endDate == this.graduationDate) 
        //     {
        //         return Status.Graduated;
        //     }
        //     else 
        //     { 
        //         return Status.Dropout; 
        //     }
        // }
           
        public String toString() {
            return $"{givenName} {surName} id: {id} ({Status}) | Start: {startDate} End: {endDate} Graduation: {graduationDate}";
        }
    }

 

    public enum Status
        {
            New,
            Active,
            Dropout,
            Graduated
        }  
        //  public enum Status1
        // {
        //     New,
        //     Active,
        //     Dropout,
        //     Graduated
        // }  
}

