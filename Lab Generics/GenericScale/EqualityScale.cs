namespace GenericScale;

public class EqualityScale<T> where T : struct,
                                        IComparable,
                                        IComparable<T>,
                                        IConvertible,
                                        IEquatable<T>,
                                        IFormattable
{
    public EqualityScale(T left, T right)
    {
        Left = left;
        Right = right;
    }

    public T Left { get; set; }
    public T Right { get; set; }
    public bool AreEqual()
    {
        if (Left.CompareTo(Right) > 0 && Right.CompareTo(Left) > 0)
        {
            return false;
        }
        return true;
    }
}
