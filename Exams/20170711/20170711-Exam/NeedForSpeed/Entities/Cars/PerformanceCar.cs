﻿using System.Collections.Generic;
using System.Text;

public class PerformanceCar:Car
{
    private List<string> addOns;

    public PerformanceCar(string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability) 
        : base(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability)
    {
        this.HorsePower += this.HorsePower * 1 / 2;
        this.Suspension = this.Suspension * 3 / 4;
        this.addOns=new List<string>();
    }

    public override string ToString()
    {
       StringBuilder sb=new StringBuilder(base.ToString());
        if (this.addOns.Count>0)
        {
            sb.AppendLine($"Add-ons: " + string.Join(", ", this.addOns));
        }
        else
        {
            sb.AppendLine("Add-ons: None");
        }

        return sb.ToString().Trim();
    }

    public override void Tune(int tuneIndex, string addOn)
    {
        base.Tune(tuneIndex, addOn);
        this.addOns.Add(addOn);
    }
}
