namespace NeuroDomain;

public class MembranePotentialEventArgs(
    decimal potassiumMillivoltsInside, 
    decimal sodiumMillivoltsOutside,
    bool isDepolarizing,
    bool isDepolarized,
    bool isPostSynapticPotential) : EventArgs
{
    public decimal PotassiumMillivoltsInside { get; init; } = potassiumMillivoltsInside;
    public decimal SodiumMillivoltsOutside { get; init; } = sodiumMillivoltsOutside;
    public bool IsDepolarizing { get; init; } = isDepolarizing;
    public bool IsDepolarized { get; init; } = isDepolarized;
    public bool IsPostSynapticPotential { get; init; } = isPostSynapticPotential;
}

public class MembranePotential(
    decimal restingPotential,
    decimal potassiumMillivoltsInside,
    decimal sodiumMillivoltsOutside,
    bool isDepolarizing,
    bool isDepolarized,
    bool isPostSynapticPotential)
{
    public event EventHandler<MembranePotentialEventArgs> MembranePotentialChanged;

    // ~70 millivolts on average.
    public decimal RestingPotential { get; init; } = restingPotential;

    public decimal PotassiumMillivoltsInside 
    { 
        get => potassiumMillivoltsInside;
        set
        {
            if (potassiumMillivoltsInside != value)
            {
                potassiumMillivoltsInside = value;
                RaiseEvent();
            }
        }    
    } 

    public decimal SodiumMillivoltsOutside 
    { 
        get => sodiumMillivoltsOutside;
        set
        {
            if (sodiumMillivoltsOutside != value)
            {
                sodiumMillivoltsOutside = value;
                RaiseEvent();
            }
        }
    } 

    public bool IsDepolarizing 
    { 
        get => isDepolarizing;
        set 
        {
            if (isDepolarizing != value)
            {
                isDepolarizing = value;
                RaiseEvent();
            }
        }
    } 

    public bool IsDepolarized 
    { 
        get => isDepolarized;
        set
        {
            if (isDepolarized != value)
            {
                isDepolarized = value;
                RaiseEvent();
            }
        }
    } 

    public bool IsPostSynapticPotential 
    { 
        get => isPostSynapticPotential;
        set
        {
            if (isPostSynapticPotential != value)
            {
                isPostSynapticPotential = value;
                RaiseEvent();
            }
        }
    } 

    public void RaiseEvent()
    {
        MembranePotentialChanged?.Invoke(
            this,
            new MembranePotentialEventArgs(
                potassiumMillivoltsInside: PotassiumMillivoltsInside,
                sodiumMillivoltsOutside:   SodiumMillivoltsOutside,
                isDepolarizing:            IsDepolarizing,
                isDepolarized:             IsDepolarized,
                isPostSynapticPotential:   IsPostSynapticPotential));
    }
}