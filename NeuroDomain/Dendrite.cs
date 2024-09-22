using System;

namespace NeuroDomain;

public class DendriteEventArgs(
    decimal sodiumIonInflux, decimal calciumIonInflux, decimal voltage) : EventArgs
{
    public decimal SodiumIonInflux { get; init; } = sodiumIonInflux;
    public decimal CalciumIonInflux { get; init; } = calciumIonInflux;
    public decimal Voltage { get; init; } = voltage;
};

//public event EventHandler<DendriteEventArgs> DendriteInfluxReceived;

public class DendriteReceptorSite
{

}

/// <summary>
/// <param name="neuroTransmitter"></param>
/// <remarks>
/// A neuron has many dendrites, that look like tree like structures.
/// A single dendrite accepts many neurotransmitters from other neurons as inputs.
/// 
/// </remarks>
/// </summary>
public class Dendrite(NeuroTransmitter neuroTransmitterInput, DendriteReceptorSite receptorSite)
{
    public NeuroTransmitter NeuroTransmitterInput { get; init; } = neuroTransmitterInput;

    public DendriteReceptorSite ReceptorSite { get; init; } = receptorSite;
}