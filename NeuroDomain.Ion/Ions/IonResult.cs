namespace NeuroDomain;

public class IonResult(IonType ionType, int ionId, int neuronId, MembraneLocation initialLocation)
{
    public IonType IonType { get; init; } = ionType;
    public int IonId { get; init; } = ionId;
    public int NeuronId { get; init; } = neuronId;
    public MembraneLocation MembraneLocation { get; set; } = initialLocation;
