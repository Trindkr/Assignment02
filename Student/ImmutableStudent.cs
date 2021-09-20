using System;
namespace Student
{

public record ImmutableStudent
{
    public int id { get; init; }
    public string givenName { get; init; }
    public string surName { get; init; }
    public DateTime startdate { get; init; }
    public DateTime endDate { get; init; }
    public DateTime graduationDate { get; init; }

    public Status1 status {
     get
            {
                if (endDate <= DateTime.Now)
                    return endDate != graduationDate ? Status1.Dropout : Status1.Graduated;
                if (startdate < DateTime.Now)
                {
                    return Status1.New;
                }
                return Status1.Active;
            } 
            init{}
            }


    public ImmutableStudent(int id, string givenName, string surName, DateTime startdate, DateTime endDate, DateTime graduationDate){
         this.id = id;
            this.givenName = givenName;
            this.surName = surName;
            this.startdate = startdate;
            this.endDate = endDate;
            this.graduationDate = graduationDate;
    }
    public String toString() {
            return $"{givenName} {surName} id: {id} ({status}) | Start: {startdate} End: {endDate} Graduation: {graduationDate}";
        }

}

}