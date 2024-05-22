public class Domino
{
    public int Left { get; set; }
    public int Right { get; set; }

    public Domino(int left, int right, int maxDots)
    {
        if (left < 0 || left > maxDots || right < 0 || right > maxDots)
        {
            throw new ArgumentException("Number of dots on a domino cannot exceed the maximum number of dots.");
        }

        Left = left;
        Right = right;
    }

    public override string ToString()
    {
        return "[" + Left + "," + Right + "]";
    }
}