﻿namespace Creational.AbstractFactory.Model;

public abstract class DishWithMeat
{
    protected MeatType MeatType { get; set; }
}

public class PierogiWithMeat : DishWithMeat
{
    public Guid Guid { get; }
    public int Count { get; }
    public PierogiTypes Type { get; }

    public PierogiWithMeat(int count, MeatType meatType)
    {
        Guid = Guid.NewGuid();
        Count = count;
        Type = PierogiTypes.WithMeat;
        MeatType = meatType;
    }

    public override string ToString()
    {
        return $"Guid: {Guid}, Count: {Count}, Type: {Type}, MeatType: {MeatType}";
    }
}