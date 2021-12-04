using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Models;

namespace Api.Bussines
{
    public class CasasBL
    {

        internal CasasResponse GetCasas(Casas body)
        {
            CasasResponse response = new CasasResponse() {salida = new List<int>()};
            List<int> ltsCasas = body.lstCasas.ToList();
            int count = 0;
            while (body.dias > count)
            {
                response.salida = new List<int>();
                for (int i = 0; i < ltsCasas.Count(); i++)
                {
                    int Vec1;
                    int Vec2;
                    if (i == 0)
                        Vec1 = 0;
                    else
                        Vec1 = ltsCasas[i-1];
                    if (i == 7)
                        Vec2 = 0;
                    else
                        Vec2 = ltsCasas[i + 1];
                    if (Vec1 == Vec2)
                        response.salida.Add(0);
                    else
                        response.salida.Add(1);
                }
                ltsCasas.Clear();
                ltsCasas= response.salida;               
                count += 1;
            }
            response.dias = body.dias;
            response.lstCasas = body.lstCasas;
            response.salida = ltsCasas;
            return  response;
        }
    }
}
