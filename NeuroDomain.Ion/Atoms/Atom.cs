namespace NeuroDomain;

/// <summary>
/// This abstraction represents a particle with a neutral charge.
/// If it becomes charged, then the resulting Ion is provided.
/// </summary>
/// 
/// <remarks>
/// An Atom has the same number of Electrons and Protons, and hence has a Neutral electrical charge.
/// However, Atoms can gain or lose electrons in a variety of ways, through a process called Ionization.
/// More information on this process can be found here:
/// https://energyeducation.ca/encyclopedia/Ionization 
/// When this happens, the Atom becoms an Ion.
/// TODO: Understand how Atoms can have a charge (neutrons?) without being an ion.
/// I think this is possible.
/// </remarks>
public class Atom(IonType ionType, int electronCount, int neutronCount, int protonCount)
{
    public IonType IonType { get; set; }
    public int ElectonCount { get; set; } = electronCount;
    public int NeutronCount { get; set; } = neutronCount;
    public int ProtonCount { get; set; } = protonCount;

    /// <summary>
    /// The atom now has a negative electrical charge, making it an Ion.
    /// </summary>
    /// <param name="electronsGained"></param>
    /// <returns>The resulting Ion now that the Atom now has an electrical charge.</returns>
    public Ion GainElectron(int electronsGained)
    {
        ProtonCount++;
        return DoIonization();
    }

    /// <summary>
    /// The Atom now has a positive electrical charge, making it an Ion.
    /// </summary>
    /// <param name="electronsLost"></param>
    /// <returns>The resulting Ion, now that the Atom now has an electrical charge.</returns>
    public Ion LoseElectron(int electronsLost)
    {
        ProtonCount--;
        return DoIonization();
    }

    private Ion DoIonization()
    {
        throw new NotImplementedException();
    }
}