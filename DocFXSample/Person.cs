namespace DocFXSample;

/// <summary>
/// Represents a person that can drive a vehicle.
/// </summary>
public class Person
{
    /// <summary>
    /// Gets or sets the name of the person.
    /// </summary>
    /// <value></value>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the age of the person.
    /// </summary>
    /// <value></value>
    public int Age { get; set; }

    /// <summary>
    /// Gets or sets the <see cref="Vehicle"/> that the person owns.
    /// </summary>
    /// <value></value>
    public Vehicle Car { get; set; }
}
