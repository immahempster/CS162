using System;

class Program
{
    static void Main(string[] args)
    {
        TestBoneyardConstructor();
        TestBoneyardDraw();
        TestBoneyardShuffle();
    }

    static void TestBoneyardConstructor()
    {
        Boneyard boneyard = new Boneyard(6);

        Console.WriteLine("Testing Boneyard constructor");
        Console.WriteLine("NumDominos. Expecting 28. " + boneyard.NumDominos);
        Console.WriteLine("IsEmpty. Expecting false. " + boneyard.IsEmpty);
        Console.WriteLine("ToString. Expect a list of 28 dominos.\n" + boneyard.ToString());
        Console.WriteLine();
    }

    static void TestBoneyardDraw()
    {
        Boneyard boneyard = new Boneyard(6);
        Domino domino = boneyard.Draw();

        Console.WriteLine("Testing Boneyard draw");
        Console.WriteLine("NumDominos. Expecting 27. " + boneyard.NumDominos);
        Console.WriteLine("IsEmpty. Expecting false. " + boneyard.IsEmpty);
        Console.WriteLine("Drawn Domino. Expect a domino. " + domino);
        Console.WriteLine();
    }

    static void TestBoneyardShuffle()
    {
        Boneyard boneyard = new Boneyard(6);
        boneyard.Shuffle();

        Console.WriteLine("Testing Boneyard shuffle");
        Console.WriteLine("NumDominos. Expecting 28. " + boneyard.NumDominos);
        Console.WriteLine("IsEmpty. Expecting false. " + boneyard.IsEmpty);
        Console.WriteLine("ToString. Expect a shuffled list of 28 dominos.\n" + boneyard.ToString());
        Console.WriteLine();
    }
}