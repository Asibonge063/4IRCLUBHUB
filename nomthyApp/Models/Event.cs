using System.ComponentModel.DataAnnotations;

public class Event
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Event title is required")]
    public string Title { get; set; }

    public string Description { get; set; }

    [DataType(DataType.DateTime)]
    [Required(ErrorMessage = "Event date is required")]
    public DateTime EventDate { get; set; }

    public string Location { get; set; }
    public string ImagePath { get; set; }
}