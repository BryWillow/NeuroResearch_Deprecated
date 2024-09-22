namespace NeuroDomain;

/// <summary>
/// Relays action potentials away from a neuron's body.
/// </summary>
/// <param name="protectiveLayer">description</param>
/// <param name="length">description</param>
public class Axon(Axolemma? protectiveLayer, decimal length)
{
    public Axolemma? ProtectiveLayer { get; init; } = protectiveLayer;    
    public decimal Length { get; init; } = length;
}