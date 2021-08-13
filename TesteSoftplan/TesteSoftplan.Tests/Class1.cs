using System;
using TesteSoftplan.Data;
using TesteSoftplan.Services;
using Xunit;

namespace TesteSoftplan.Tests
{
    public class Class1
    {
        JurosService service;
        public Class1(JurosService service)
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
