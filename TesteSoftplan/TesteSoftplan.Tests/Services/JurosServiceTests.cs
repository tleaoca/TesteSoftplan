using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteSoftplan.Data;
using TesteSoftplan.Services;
using Xunit;

namespace TesteSoftplan.Tests.Services
{
    public class JurosServiceTests
    {
        JurosService service;
        public JurosServiceTests(JurosService service)
        {
            this.service = service;
        }

        [Fact]
        public void mostrarJ()
        {
            Juros juros = new Juros();
            decimal expected = 0.01M;
            decimal result = service.mostrarJ();
            Assert.Equal(expected, result);
        }
    }
}
