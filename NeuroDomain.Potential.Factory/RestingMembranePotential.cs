/// <summary>
/// Maintains the voltage, in millivolts of a neuron.
/// If the voltage exceeds the threshold, then this class dispatches an event.
/// <remarks>
/// All numbers below are measured in millivolts.
/// </remarks>
/// </summary>
/// 
/// <param name="membraneId"></param>
/// <param name="startingVoltage"></param>
public class RestingMembranePotential
{   
    internal RestingMembranePotential(int restingMembranePotentialId, int startingVoltage) 
    {
        RestingMembranePotentialId = restingMembranePotentialId;
        StartingVoltage = startingVoltage;
    }

    public event EventHandler<MembranePotentialChangedEventArgs>  MillivoltThresholdReached;

    private int _voltageChangeCount = 0;

    // Measured in millivolts. Scientifically proven.
    public static readonly int RestingPotentialAverage = -70;

    // Measured in millivolts. Scientifically proven.
    public static readonly int RestingPotentialHigh = -70;

    // Measured in millivolts. Scientifically proven.
    public static readonly int RestingPotentialLow = -90;

    public int RestingMembranePotentialId { get; internal init } = membraneId;

    public int StartingVoltage { get; init; } = startingVoltage;

    public int CurrentVoltage { get; set; } = startingVoltage;

    public int VoltageChange => StartingVoltage - CurrentVoltage;

    public bool IsAtRest => CurrentVoltage >= RestingPotentialLow && CurrentVoltage <= RestingPotentialHigh;

    /// <summary>
    /// <remarks>
    /// The goal is to reach a resting potential of ~ -70 millivolts.
    /// There are three ways we can achieve this. This method is the first way.
    /// Specifically, a neuron pumps 3 Sodium Ions out, and pulls 2 Potassium Ions in. 
    /// This process is called SodiumPotassiumAtpAses. While this process doesn't make
    /// make a large impact to the overall charge to the neuron, it does help some.
    /// Also, itt "sets the stage", as the neuron will overall have more Positively-Charged 
    /// Potassium Ions within the cell, and less Negatively-Charged Sodium Ions out of the cell.
    /// This process is achieved through ATP.
    /// </remarks>
    /// </summary>
    public void ApplySodiumPotassiumAtpAses(int ionCount = 1)
    {
        _voltageChangeCount++;
        CheckRaiseEvent();
    }

    /// <summary>
    /// <remarks>
    /// Potassium, and NOT sudium can flow freely through "Leak Channels". 
    /// Note that "Leak Channels" are always open to Potassium. 
    /// flow freely through the cell membrane. Hence, Potassium starts leaving
    /// cell through these channels. Also Note that Potassium cells are gennerally
    /// bound to negative ions, called Anions. PotassiumAnions cannot pass through
    /// the leak channel, only the Potassium ions. Hence, whenever potassium ions
    /// leave the cell through leak channels, it leaves negatively-charged Anion
    /// cells behind, and the negative charge from the Antion cells start to accumulate.
    /// Note that this could keep happening until approximately -90 millivolts.
    /// </remarks>
    /// </summary>
    public void ApplyPotassiumIonChannelLeak(int ionCount = 1)
    {
        _voltageChangeCount++;
        CheckRaiseEvent();
    }

    /// <summary>
    /// <remarks>
    /// </remarks>
    /// </summary>
    public void ApplyLeakSodiumIonChanneLeakl(int ionCount = 1)
    {
        _voltageChangeCount++;
        CheckRaiseEvent();
    }

    private void CheckRaiseEvent()
    {
        if (IsAtRest)
            return;
    }

    private void RaiseEvent()
    {
        MillivoltThresholdReached?.Invoke(
            this,
            new MembranePotentialChangedEventArgs(
                membranePotentialId: MembraneId,
                currentMillivolts: CurrentVoltage,
                voltageChangeCount: _voltageChangeCount
        ));
    }
}

public class MembranePotentialChangedEventArgs(
    int membranePotentialId, 
    int currentMillivolts, 
    int voltageChangeCount) : EventArgs
{
    public int MembranePotentialId = membranePotentialId;
    public int CurrentMillivolts = currentMillivolts;
    public int VoltageChangeCount = voltageChangeCount;
}