using System;
using System.Collections.Generic;
using System.Text;

namespace Global.Utilities.Network;


public static class Web
{


    /// <summary>
    /// Agregar parámetros a una Url.
    /// </summary>
    /// <param name="baseUrl">Url base.</param>
    /// <param name="parameters">Parámetros.</param>
    public static Uri AddParameters(Uri baseUrl, Dictionary<string, string> parameters)
    {
        return new(AddParameters(baseUrl.ToString(), parameters));
    }



    /// <summary>
    /// Agregar parámetros a una Url.
    /// </summary>
    /// <param name="baseUrl">Url base.</param>
    /// <param name="parameters">Parámetros.</param>
    public static string AddParameters(string baseUrl, Dictionary<string, string> parameters)
    {
        // Crear un objeto UriBuilder con la URL base y la ruta
        var uriBuilder = new UriBuilder(baseUrl);

        // Agregar los parámetros a la cadena de consulta
        if (parameters.Count > 0)
        {
            var queryBuilder = new StringBuilder();
            foreach (var parameter in parameters)
            {
                queryBuilder.Append($"{Uri.EscapeDataString(parameter.Key)}={Uri.EscapeDataString(parameter.Value)}&");
            }

            queryBuilder.Length--;

            uriBuilder.Query = queryBuilder.ToString();
        }

        var finalUrl = uriBuilder.ToString();
        return finalUrl;

    }


}