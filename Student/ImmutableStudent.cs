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

    public Status status {
     get
            {
                if (endDate <= DateTime.Now)
                    return endDate != graduationDate ? Status.Dropout : Status.Graduated;
                if (startdate < DateTime.Now && DateTime.Now < startdate.AddYears(1))
                {
                    return Status.New;
                }
                return Status.Active;
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