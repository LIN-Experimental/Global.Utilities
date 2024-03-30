namespace Global.Utilities;


public static class Math
{

    /// <summary>
    /// Numero a negativo.
    /// </summary>
    /// <param name="value">Numero</param>
    public static decimal ToNegative(this decimal value) => (value > 0) ? value * -1 : value;



    /// <summary>
    /// Numero a negativo.
    /// </summary>
    /// <param name="value">Numero</param>
    public static float ToNegative(this float value) => (value > 0) ? value * -1 : value;



    /// <summary>
    /// Numero a negativo.
    /// </summary>
    /// <param name="value">Numero</param>
    public static int ToNegative(this int value) => (value > 0) ? value * -1 : value;



    /// <summary>
    /// Numero a negativo.
    /// </summary>
    /// <param name="value">Numero</param>
    public static double ToNegative(this double value) => (value > 0) ? value * -1 : value;



    /// <summary>
    /// Numero a negativo.
    /// </summary>
    /// <param name="value">Numero</param>
    public static long ToNegative(this long value) => (value > 0) ? value * -1 : value;


}