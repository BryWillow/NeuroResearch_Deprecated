namespace NeuroDomain;

public enum IonChannelType
{
    LeakySodium,
    VoltageGated,
    LigandGated
}

// A type of Ion Channel that stays open all the time.
public class IonLeakChannel : IonChannel
{
}

// Controls the distribution of the ions.
// There are specific types of ion channels - ones that allow potassium to cross the cell membrane, etc.
public class IonChannel
{
    // Small pores in the cell membrane that allow the passage of ions.
    // (1) Establish a resting membrane potential
    // (2) Shape action potentials
    // (3) Control the flow of ions across secretory and epitheleal cells.
    // (4) Regulate cell volume
    // (5) Located within the membrane of all excitable cells
}