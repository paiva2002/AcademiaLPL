using AcademiaLPL.Domain.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Diagnostics;
using System.Text.Json;

namespace AcademiaLPL.Test
{
    [TestClass]
    public class UnitTestDomain
    {
        [TestMethod]
        public void TestModalidade()
        {
            Modalidade modalidade = new Modalidade(1, "muay thai", "arte das 8 armas", 90.00);

            Debug.WriteLine(JsonSerializer.Serialize(modalidade));

            Assert.AreEqual(modalidade.Nome, "muay thai");
            Assert.AreEqual(modalidade.Descricao, "arte das 8 armas");
            Assert.AreEqual(modalidade.Precomensal, 90.00);
        }
    }
}
