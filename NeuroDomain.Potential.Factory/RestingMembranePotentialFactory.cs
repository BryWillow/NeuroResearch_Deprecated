namespace NeuroDomain.Potential.Factory;

public class RestingMembranePotentialFactory
{
    private int _id = 0;
    private Dictionary<int, RestingMembrancePotential> _instances = new();

    public static RestingMembranePotential Create()
    {
        var instance = new RestingMembranePotential(++_id);
        _instances.Add(_id, instance);
        return;
    }

    public static RestingMembranePotential Create(int startingVoltage)
    {
        var instance = new RestingMembranePotential(++_id, startingVoltage);
        _instances.Add(_id, instance);
        return instance;
    }
}