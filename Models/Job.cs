namespace HouseDairy.Models;

public class Jobs
{
    public Guid Id { get; set; }

    public DateOnly Date { get; set; } // date of job was started

    public string JobName { get; set; } // name of job

    public string JobType { get; set; } // type of job (self done, purchased job, negotiations, purchase, research, ....)

    public string Area { get; set; } // house or garden (yard)

    public List<HouseObject> Objects { get; set; } //exact places, where job was applied (room, place of room like window, floor, ets.)

    public string? JobDescription { get; set; }

    public List<Media>? Media { get; set; }
}
