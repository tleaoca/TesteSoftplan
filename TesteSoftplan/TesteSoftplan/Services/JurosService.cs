using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteSoftplan.Data;

namespace TesteSoftplan.Services
{
    public class JurosService
    {

        public string retornarUrl(string urlGithub)
        {
            urlGithub = "https://github.com/tleaoca/TesteSoftplan";
            return urlGithub;
        }
        public decimal mostrarJ()
        {
            Juros juros = new Juros();
            return juros.valorJuros;
        }

        public string calculoJ([FromBody] Juros juros)
        {
            var valorFinal1 = Math.Pow((double)(juros.valorJuros + 1), juros.Meses);
            var valorFinal2 = Convert.ToDouble(juros.valorInicial) * valorFinal1;

            return valorFinal2.ToString("F");
        }
    }
}
