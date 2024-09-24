namespace NeuroDomain;

public class CellMembrane(
    bool isLeaky, 
    InterCellularMembrane interCellularMembrane, 
    ExtraCellularMembrane extraCellularMembrane)
{
    public bool IsLeaky { get; init; } = isLeaky;
    public InterCellularMembrane InterCellularMembrane { get; init; } = interCellularMembrane;
    public ExtraCellularMembrane ExtraCellularMembrane { get; init; } = extraCellularMembrane;
}

public class InterCellularMembrane
{
    public List<Ion> Ions { get; set; }
}

public class ExtraCellularMembrane
{
    public  List<Ion> Ions { get; set; }
}