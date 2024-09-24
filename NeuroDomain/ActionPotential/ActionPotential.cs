namespace NeuroDomain;

public class ActionPotentialFiredEventArgs(decimal thresholdVoltage, decimal currentVoltage) : EventArgs
{
    public decimal ThresholdVoltage { get; init; } = thresholdVoltage;
    public decimal CurrentVoltage { get; init; } = currentVoltage;
}

// TODO: What can be negative for test case purposes
public class ActionPotentialVoltage(decimal thresholdMilliVolts, decimal restingMilliVolts)
{
    private decimal _currentMilliVolts;

    public event EventHandler<ActionPotentialFiredEventArgs> ThresholdVoltageReached;

    // On average, usually around 70 millivolts.
    public decimal RestingMilliVolts { get; init; } = restingMilliVolts;

    // When the number of millivolts in the neuron exceeds
    // this threshold, then an action potential is fired.
    public decimal ThresholdMilliVolts { get; init; } = thresholdMilliVolts;

    // The current number of millivolts in the neuron.
    public decimal CurrentMilliVolts => _currentMilliVolts;

    // TODO: What causes an increase of millivolts? A burst of sodium ions?
    public void AddMilliVolts(decimal milliVolts)
    {
        _currentMilliVolts += milliVolts;
        if (_currentMilliVolts > ThresholdMilliVolts)
        {
            ThresholdVoltageReached?.Invoke(
                this, 
                new ActionPotentialFiredEventArgs(ThresholdMilliVolts, _currentMilliVolts));
        }
    }
}

// Neuron:
// Surrounded by a cell membrane that separates the 
// Intercellular environment:
// Extra cellular environment: 
// Each of these environments have ions.
// Ions play a role in whether an action potential will occur.
// Postively charged sodium ions - greater concentration outside the neuron.
// Positively charge potassium ions - greater concentration inside the neuron.
// Ion Channels. Some are specific to certain stimuli. Some are open all the time - leak channels.
// The membrane of the cell doesn't make it easy for ions to just pass through it.
// Neurons have a lot of potassium leak channels, and a few sodium leak channels.
// Hence, potassium cann pass through the neuron rather freely, while sodium cannot.
// Sodium potassium pump pumps sodium outside of the cell.
// Sodium potassium pump pumps potassium into the cell.
// Pumps 2 potassium ions in for every 3 sodium ions it pumps out.
// Consider diffusion and electromagnetic forces.
// Electromagnetic forces encourage 2 of the same charge ions to move apart, 2 different to move together.
// Membrane potential -- see 4:00 minutes
// Influx of Depolarization - when electrical charge moves closer to 0.
// The action potentional is a spreading fire that moves down the axon.



// In it's simplest form it's an electrical impulse.
public class ActionPotential(MembranePotential membranePotential, ActionPotentialVoltage actionPotentialVoltage)
{
    public event EventHandler<ActionPotentialFiredEventArgs> ThresholdVoltageReached;
    public decimal ThresholdVoltage { get; init; } = actionPotentialVoltage.ThresholdMilliVolts;
    public MembranePotential MembranePotential { get; init; } = membranePotential;

    private void OnMembranePotentialChanged(object? sender, MembranePotentialEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void OpenVoltageGates()
    {
        throw new NotImplementedException();        
    }

    public void AddNewSodiumIon(decimal ionMillivolts)
    {
        throw new NotImplementedException();
        /*
        _currentMillivolts += ionMillivolts;
        if (_currentMillivolts > ThresholdVoltage)
        {
            ThresholdVoltageReached?.Invoke(
                this, 
                new ActionPotentialFiredEventArgs(ThresholdVoltage, _currentMillivolts));
        }
        */
    }

    // When an action potential occurs, voltage-gated ion channels open.
    // This causes external an influx of sodium ions due to diffusion and electro-magnetic force.
    // This causes even more depolarization to happen.
    // These are called Post-Synaptic Potentials and can shoot up to +40 millivolts.
    // When the qd5ion potentional has reached its peak, then the neuron gates begin to close.
    // Now potassium rushes out of the cell and helps re-polarize the neuron back to its resting potential.
    // This regenerates the action potential at the next portion of the axon.
    // Many axons are covered in Myelon which causes the action potential to 
    // spread more easily down the axon.
    // Myelin helps to slow things down by using cells of Mandier.
    // The process of the action potential of the action potential jumping down the axon is saltutory conduction.
    // After a neuron has fired an aciton potential a neuron cannot fire another anotion potention for a brief period:
    // This brief period is called the absolute refactory period.
    // Also, when an action potential is done, then neuron becomes hyper-polaarized

    // An influx of ions causes the electrical charge to move closer to 0.
    // The neuron keeps track of the influx of ions, say, in milliseconds.
    // If the millivolts of each ion flowing into the neuron causes
    // the accumulated voltage to become greater than a threshold voltage
    // then an action potential is fired.
}