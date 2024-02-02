namespace Calculator;

public class Vector2Calculator
{
    public Vector2 Add(Vector2 left, Vector2 right)
    {
        return new Vector2
        {
            X = left.X + right.X,
            Y = left.Y + right.Y,
        };
    }
    
    public Vector2 Substract(Vector2 left, Vector2 right)
    {
        return new Vector2
        {
            X = left.X - right.X,
            Y = left.Y + right.Y,
        };
    }
}