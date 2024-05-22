using System;
using System.Collections.Generic;
using System.Linq;

public class Boneyard
{
    private List<Domino> dominos;
    private int maxDots;

    public Boneyard(int maxDots)
    {
        this.maxDots = maxDots;
        dominos = new List<Domino>();

        for (int left = 0; left <= maxDots; left++)
        {
            for (int right = left; right <= maxDots; right++)
            {
                dominos.Add(new Domino(left, right, maxDots));
            }
        }
    }

    public int NumDominos
    {
        get { return dominos.Count; }
    }

    public Domino this[int index]
    {
        get { return dominos[index]; }
        set { dominos[index] = value; }
    }

    public Domino Draw()
    {
        if (NumDominos > 0)
        {
            Domino domino = dominos.First();
            dominos.RemoveAt(0);
            return domino;
        }
        return null;
    }

    public bool IsEmpty
    {
        get { return NumDominos == 0; }
    }

    public void Shuffle()
    {
        var random = new Random();
        dominos = dominos.OrderBy(x => random.Next()).ToList();
    }

    public override string ToString()
    {
        return string.Join(", ", dominos);
    }
}