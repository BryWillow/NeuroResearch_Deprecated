namespace NeuroDomain;

public enum MembraneLocation
{
    InterCellular,
    ExtraCullular
}

/// <summary>
/// Ions can only have a positive or negative charge.
/// They cannot be neutral.
/// </summary>
/// 
/// <remarks>
/// Ions with a negative charge are called Anions.
/// Ions with a positive charge are called Cations.
/// </remarks>
public enum IonCharge
{
    Negative, // Anions
    Positive  // Cations
}

/// <summary>
/// "Common" Ion types that exist within the brain.
/// </summary>
/// 
/// <remarks>
/// Other types of Ions do exist throught the body.
/// TODO: Read up on the Common Ion Effect.
/// https://en.wikipedia.org/wiki/Common-ion_effect
/// </remarks>
public enum IonType
{
    Calcium,
    Chloride,
    Potassium,
    Sodium
}

/// <summary>
/// </summary>
/// <param name="ionCharge"></param>
/// <param name="neuronIonType"></param>
/// <param name="membraneLocation"></param>
/// 
/// <remarks>
/// An Ion is an Atom or group of Atoms with a positive or negative electrical charge.
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