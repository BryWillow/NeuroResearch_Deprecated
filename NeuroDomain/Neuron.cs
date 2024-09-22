namespace NeuroDomain;

/// <summary>
/// <param name="neuroTransmitter"></param>
/// <param name="actionPotential"></param>
/// <remarks>
/// NEURON:
/// * We have approximately 86 million in our body.
/// * Its purpose is to receive electro-chemical synaptic inputs from an axon.
/// * They have the appreance of branches.
/// * They carry these inputs to the Soma, or cell body of the neuron.
/// * Most dendrites have a myelinatic sheath.
/// * Some dendrites can become damaged by diseseases like MS.
/// </remarks>
/// </summary>
public class Neuron(
    IonChannel ionChannel,
    CellMembrane cellMembrane,
    NeuroTransmitter neuroTransmitter,
    ActionPotential actionPotential)
{
    public RestingMembranePotential RestingPotential { get; set; }; 
    public IonChannel IonChannel { get; init; } = ionChannel;
    public CellMembrane CellMembrane { get; init; } = cellMembrane;
    public NeuroTransmitter NeuroTransmitter { get; init; } = neuroTransmitter; 
    public ActionPotential ActionPotential { get; init; } = actionPotential;
}