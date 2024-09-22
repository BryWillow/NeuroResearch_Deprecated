namespace NeuroDomain;

public enum MembraneLocation
{
    InterCellular,
    ExtraCullular
}

public enum IonCharge
{
    Negative,
    Positive
}

/// <summary>
/// There are many types of Ions, but
/// we are only concerned with these types
/// </summary>
public enum IonType
{
    Potassium,
    Sodium
}

/// <summary>
/// </summary>
/// <param name="ionCharge"></param>
/// <param name="neuronIonType"></param>
/// <param name="membraneLocation"></param>
/// <remarks>
/// An Ion is a particle or molecule, that has a positive or negative electrical charge.
/// Many, many Ions surround neurons, both inside and outside the cell membrane.
/// </remarks>
public class Ion(IonCharge ionCharge, IonType ionType, MembraneLocation membraneLocation)
{  
    // Number of positively-charged moecules associated with this Ion.
    // Since both Potassium and Sodium have a +1 positive charge, we don't include the AnionCount here.
    public virtual CationCount { get; init; }

    // The number of molecules on the inside of the Ion relative to
    // the number of molecules on the outside of the Ion.
    // It's important to note that potassium 
    // I.e., 40 sodium molecules inside, and sodium molecules outside
    // yields a charge of 40 - 110 = -70 millivolts total charge.
    public virtual int IonCharge { get; init; } = ionCharge;

    // Potassium or Sodium.
    public virtual IonType IonType { get; init; } = ionType;

    // Inside or outside the neuron.
    public virtual MembraneLocation MembraneLocation { get; init; } = membraneLocation;
}

// Sodium ions cannot pass the cell membrane somewhat freely.
public class SodiumIon
{
    public const IonCharge IonChargeType = IonCharge.Positive;
}

// Potassium Ions can pass the cell membrane somewhat freely.
public class PotassiumIon
{
    public const IonCharge IonChargeType = IonCharge.Positive;
}