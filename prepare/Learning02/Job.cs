
 public class Job
{
    public string _Company;
    public string _JobTitle;
    public int _StartYear;
    public int _EndYear;


    public Job(string Company, string JobTitle, int StartYear, int EndYear)
    {
       _Company = Company;
       _JobTitle = JobTitle;
       _StartYear = StartYear;
       _EndYear = EndYear; 
    }

    public void DisplayJobDetails()
    {
       Console.WriteLine($"{_JobTitle} {(_Company)} {_StartYear}-{_EndYear}");
    }
}