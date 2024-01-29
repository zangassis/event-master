using Swashbuckle.AspNetCore.Annotations;

namespace EventMaster.Models;

public class Event
{
    [SwaggerSchema(Description = "The unique event identifier through SwaggerSchema")]
    public Guid Id { get; set; }

    /// <summary>
    /// The name of the event.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The date of the event.
    /// </summary>
    public DateTime Date { get; set; }

    /// <summary>
    /// The location of the event.
    /// </summary>
    public string Location { get; set; }

    /// <summary>
    /// The list of speakers for the event.
    /// </summary>
    public List<string> Speakers { get; set; }
}