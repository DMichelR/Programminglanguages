namespace ConsoleApp1.May6;

public struct ComplexNumber
{
    public int Real;
    public int Imaginary;

    public override string ToString()
    {
        return "Real: " + Real + " Imaginary: " + Imaginary;
    }

    public ComplexNumber(int real, int imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    public static ComplexNumber operator +(ComplexNumber a, ComplexNumber b)
    {
        return new ComplexNumber(a.Real + b.Real, a.Imaginary + b.Imaginary);
    }

    public static ComplexNumber operator -(ComplexNumber a, ComplexNumber b)
    {
        return new ComplexNumber(a.Real - b.Real, a.Imaginary - b.Imaginary);
    }

    public static bool operator ==(ComplexNumber a, ComplexNumber b)
    {
        return (a.Real.Equals(b.Real) && a.Imaginary.Equals(b.Imaginary));
    }

    public static bool operator !=(ComplexNumber a, ComplexNumber b)
    {
        return !a.Equals(b);
    }
}