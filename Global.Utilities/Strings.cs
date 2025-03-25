using System.ComponentModel;
using System.Reflection;
using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace Global.Utilities;


public static class Strings
{


    /// <summary>
    /// Obtener las iniciales de las palabras.
    /// </summary>
    public static string GetInitials(this string name)
    {

        name = name.Trim();
        string init = "";

        while (name.Contains("  "))
            name = name.Replace("  ", " ");

        var split = name.Split(' ');

        if (split.Length == 1 && split[0].Length > 0)
        {
            init = split[0][0].ToString();
            return init.ToUpper();
        }

        else if (split.Length >= 2 && split[0].Length > 0 && split[1].Length > 0)
        {
            init = split[0][0].ToString();
            init += split[1][0].ToString();
            return init.ToUpper();
        }

        return "?";

    }


    public static string IsNullOrEmptyThem(this string value, string replaceValue)
    {
       if (string.IsNullOrWhiteSpace(value))
            return replaceValue;
       return value;
    }

    public static string RemoveExtraSpaces(this string value)
    {
        return Regex.Replace(value.Trim(), @"\s+", " ");
    }


    /// <summary>
    /// Es un mail valido.
    /// </summary>
    /// <param name="email">Valor a evaluar.</param>
    public static bool IsValidMail(this string email)
    {
        // Expresión regular para validar el formato del correo electrónico
        var pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

        // Validar el correo electrónico utilizando la expresión regular
        var isValid = Regex.IsMatch(email, pattern);

        return isValid;
    }


    public static string GetDescription<T>(this T enumValue) where T : Enum
    {
        var field = enumValue.GetType().GetField(enumValue.ToString());
        var attribute = field.GetCustomAttribute<DescriptionAttribute>();
        return attribute?.Description ?? enumValue.ToString();
    }

    public static void AddToList<TKey, TValue>(this Dictionary<TKey, List<TValue>> dict, TKey key, TValue value)
    {
        if (!dict.ContainsKey(key))
            dict[key] = [];

        dict[key].Add(value);
    }



}