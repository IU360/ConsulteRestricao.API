using ConsulteRestricao.Api.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsulteRestricao.Api
{
    public class RestricaoRequest
    {

        private string _UserEncoded = "";
        private string _Dominio = "";        

        /// <summary>
        /// Classe para realizar as requisições
        /// </summary>
        /// <param name="usuario">email do usuário</param>
        /// <param name="senha">senha do usuário</param>
        /// <param name="Homolog">Definir "True" para Ambiente de Homologação e "False" para Ambiente de Produção</param>
        public RestricaoRequest(string usuario, string senha, bool Homolog)
        {
            _UserEncoded = System.Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes(usuario + ":" + senha));
            if (Homolog)
                _Dominio = "https://apiteste.consulterestricao.com.br";
            else
                _Dominio = "https://api.consulterestricao.com.br";
        }


        /// <summary>
        /// Metodo que retorna todos os produtos habilitados para o cliente
        /// /// o retorno é do tipo Produto[]
        /// </summary>
        /// <returns></returns>
        public Produto[] ListarProduto()
        {
            String URI = _Dominio + "/api/ListarProdutos";

            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(URI);
            request.Method = "GET";
            request.Headers.Add("Authorization", "Basic " + _UserEncoded);
            request.ContentType = "application/xml";

            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                { 
                      
                    using (Stream dataStream = response.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(dataStream))
                        {
                            String result = String.Empty;
                            result = reader.ReadToEnd();

                            return XMLHelpers.DeserializeXMLToObject<Produto[]>(result);
                        }
                    }
                }
            }
            catch (WebException Webex)
            {
                var response = (HttpWebResponse)Webex.Response;
                if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    throw new Exception(Webex.Message, Webex);
                }
                using (Stream dataStream = Webex.Response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(dataStream))
                    {
                        String result = String.Empty;
                        result = reader.ReadToEnd();

                        throw new Exception(result, Webex);
                    }
                }
            }
            catch (Exception ex)
            {   
                throw ex;   
            }
        }


        /// <summary>
        /// Metodo que Realiza a consulta
        /// O retorno é do tipo ResultadoConsulta
        /// </summary>
        /// <param name="filtro">Parametros para a consulta</param>
        /// <returns></returns>
        public ResultadoConsulta Consultar(FiltroConsulta filtro)
        {
            String URI = _Dominio + "/api/Consulta";

            String encoded = _UserEncoded;

            String requestXml = XMLHelpers.SerializeObjectToXML<FiltroConsulta>(filtro);
            byte[] bytes;
            bytes = System.Text.Encoding.ASCII.GetBytes(requestXml);

            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(URI);
            request.Method = "POST";
            request.Headers.Add("Authorization", "Basic " + encoded);
            request.ContentType = "application/xml";

            request.ContentLength = bytes.Length;
            using (Stream requestStream = request.GetRequestStream())
            {
                requestStream.Write(bytes, 0, bytes.Length);
            }

            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {   
                    using (Stream dataStream = response.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(dataStream))
                        {
                            String result = String.Empty;
                            result = reader.ReadToEnd();

                            return XMLHelpers.DeserializeXMLToObject<ResultadoConsulta>(result);
                        }
                    }
                }
            }
            catch (WebException Webex)
            {   
                using (Stream dataStream = Webex.Response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(dataStream))
                    {
                        String result = String.Empty;
                        result = reader.ReadToEnd();

                        throw new Exception(result, Webex);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
