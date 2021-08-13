using System;
using System.Collections;
using System.Collections.Generic;
using TesteSoftplan.Data;
using TesteSoftplan.Services;
using Xunit;

namespace JurosTests
{
    public class UnitTest1 : IClassFixture<JurosService>
    {
        JurosService service = new JurosService();


        public UnitTest1(JurosService service)
        {
            this.service = service;
        }
        [Fact]
        public void Test1()
        {
            decimal expected = 0.01M;
            decimal result = service.mostrarJ();
            Assert.Equal(expected, result);
        }       
    }
}
