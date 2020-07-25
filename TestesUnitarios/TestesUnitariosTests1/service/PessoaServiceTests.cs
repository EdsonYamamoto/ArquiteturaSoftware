using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestesUnitarios.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestesUnitarios.model;

namespace TestesUnitarios.service.Tests
{
    [TestClass()]
    public class PessoaServiceTests
    {
        PessoaService p;
        //[TestMethod()]
        public PessoaServiceTests() {
            p = new PessoaService();
        }

        [TestMethod()]
        public void VerficadorPessoaTest()
        {
            Pessoa pessoa = new Pessoa();
            p.VerficadorPessoa(pessoa);
        }
    }
}