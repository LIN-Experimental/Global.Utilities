namespace System;

public static class DateTimeExtensions
{

    /// <summary>
    /// Obtener la hora UTC -5 actual (Colombia, Perú.)
    /// </summary>
    public static DateTime Utc5 => DateTime.UtcNow.AddHours(-5);

}