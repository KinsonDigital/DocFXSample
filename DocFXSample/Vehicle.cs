using System.Drawing;

namespace DocFXSample;

/// <summary>
/// Represents a vehicle that can be driven.
/// </summary>
public class Vehicle
{
    /// <summary>
    /// Gets or sets the color of the <see cref="Vehicle"/>.
    /// </summary>
    public Color Color { get; set; }

    /// <summary>
    /// Gets or sets the year of the <see cref="Vehicle"/>.
    /// </summary>
    public int Year { get; set; }

    /// <summary>
    /// Gets or sets the make of the <see cref="Vehicle"/>.
    /// </summary>
    public string Make { get; set; }

    /// <summary>
    /// Gets or sets the model of the <see cref="Vehicle"/>.
    /// </summary>
    public string Model { get; set; }
}
