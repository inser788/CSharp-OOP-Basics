﻿public class AirMonument : Monument
{
    public AirMonument(string name,int airAffinity) 
        : base(name)
    {
        this.AirAffinity = airAffinity;
    }

    public int AirAffinity { get; protected set; }
    public override int GetMonumentBonus()
    {
        return this.AirAffinity;
    }

    public override string ToString()
    {
        return $"{base.ToString()} Air Affinity: {this.AirAffinity}";
    }
}

