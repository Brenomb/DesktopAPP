using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;

namespace BLL
{
    public class CEndereco
    {
        public readonly HttpClient _httpClient;

        public CEndereco()
        {
            _httpClient = new HttpClient();
        }
        public CEP Consultar(string CepConsulta)
        {
            //CEP cepRetorno = new CEP();
            //cepRetorno.bairro = "";
            //cepRetorno.logradouro = "";
            //cepRetorno.complemento = "";
            //cepRetorno.ddd = "";
            //cepRetorno.localidade = "";
            //cepRetorno.cep = "";
            //cepRetorno.uf = "";

            return _httpClient.GetFromJsonAsync<CEP>($"https://viacep.com.br/ws/{CepConsulta}/json/").Result; ;
        }
    }
}
