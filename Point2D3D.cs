
using System;

public class Point2D
{
    private float x = 0.0f;
    private float y = 0.0f;

    public Point2D() { }

    public Point2D(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public float GetX()
    {
        return x;
    }

    public void SetX(float x)
    {
        this.x = x;
    }

    public float GetY()
    {
        return y;
    }

    public void SetY(float y)
    {
        this.y = y;
    }

    public void SetXY(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    public float[] GetXY()
    {
        return new float[] { x, y };
    }

    public override string ToString()
    {
        return $"({x},{y})";
    }
}
public class Point3D : Point2D
{
    private float z = 0.0f;

    public Point3D() { }

    public Point3D(float x, float y, float z) : base(x, y)
    {
        this.z = z;
    }

    public float GetZ()
    {
        return z;
    }

    public void SetZ(float z)
    {
        this.z = z;
    }

    public void SetXYZ(float x, float y, float z)
    {
        SetXY(x, y);  // gọi hàm của lớp cha
        this.z = z;
    }

    public float[] GetXYZ()
    {
        return new float[] { GetX(), GetY(), z };
    }

    public override string ToString()
    {
        return $"({GetX()},{GetY()},{z})";
    }
}
class Program
{
    static void Main()
    {
        Point2D p2 = new Point2D(1, 2);
        Console.WriteLine(p2);  // (1,2)

        Point3D p3 = new Point3D(1, 2, 3);
        Console.WriteLine(p3);  // (1,2,3)

        Point2D test = new Point3D(1, 2, 3);
        Console.WriteLine(test); // (1,2,3) vì override ToString()
    }
}
