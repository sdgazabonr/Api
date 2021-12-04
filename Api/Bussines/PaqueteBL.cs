using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Models;
namespace Api.Bussines
{
    public class PaqueteBL
    {
        internal PaqueteResponse GetPaquete(Paquete body)
        {
            PaqueteResponse response = new PaqueteResponse() { salida = new List<int>() };
            int total;
            int max = 0;
            for (int i = 0; i < body.lstPaquetes.Length; i++)
            {                
                for (int e = i + 1; e < body.lstPaquetes.Length; e++)
                {
                    total = body.lstPaquetes[i] + body.lstPaquetes[e] + 30;                   
                    bool result = max < body.lstPaquetes[i] || max < body.lstPaquetes[e];
                    if (total == body.tamanioCamion && result)
                    {
                        response.salida.Clear();
                        response.salida.Add(body.lstPaquetes[i]);
                        response.salida.Add(body.lstPaquetes[e]);
                        max = response.salida.Max();
                        continue;
                    }
                }
            }
            return response;
        }
    }
}
