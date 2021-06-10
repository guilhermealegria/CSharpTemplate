using System;
using Xunit;

namespace TestIlab
{
    public class EfetuarPesquisaGoogleTest
    {
        public PaginaGoogleHome euVou;
        [Fact]
        public void Test1()
        {
            string url = "https://www.google.com/";
            string texto = "iLab Quality";
            euVou = new PaginaGoogleHome();
            euVou.abrirChrome();
            euVou.maximizarTela();
            euVou.navegarParaUrl(url);
            euVou.preencherCampoDePesquisa(texto);
            euVou.esperarUmtEmpo();
            Assert.True(euVou.verificarResultadoDePesquisa("iLAB – Software Quality Assurance"));
            euVou.capturaTela();
            euVou.fecharNavegador();
        }
    }
}
