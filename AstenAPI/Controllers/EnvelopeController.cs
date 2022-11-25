using System;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AstenAssinaturaAPI.Models;
using System.Text.Json.Serialization;
using System.Text.Unicode;
using System.Text;
using System.Reflection.Metadata;
using Newtonsoft.Json.Linq;

namespace AstenAssinaturaAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EnvelopeController : ControllerBase
    {
        [HttpPost]
        public ActionResult InserirEnvelope()
        {
            string Connection = "https://plataforma.astenassinatura.com.br/api/inserirEnvelope";

            try
            {
                using (var client = new HttpClient())
                {
                var inserirEnvelope = new InserirEnvelope()
                {
                    Params = new Params()
                    {
                        Envelope = new Envelope()
                        {
                            descricao = "Nova Descricao",
                        }
                    },
                };


                var Documento = new Documento();

                var Signatario = new SignatarioEnvelope()
                {
                    ConfigAssinatura = new ConfigAssinatura()
                    {
                        emailSignatario = "arthurvasconcelosdelunafreire@gmail.com",
                    },
                };


                var SignatarioTecnico = new SignatarioEnvelope()
                {
                    ConfigAssinatura = new ConfigAssinatura()
                    {
                        emailSignatario = "prova.tecnica@avmb.com.br",
                    },
                };

                inserirEnvelope.Params.Envelope.listaSignatariosEnvelope.Add(Signatario);
                inserirEnvelope.Params.Envelope.listaSignatariosEnvelope.Add(SignatarioTecnico);

                    var jsonobjeto = JsonConvert.SerializeObject(inserirEnvelope).Replace("Params","params") ;
                    var content = new StringContent(jsonobjeto, Encoding.UTF8, "application/json");

                    var response = client.PostAsync(Connection, content);
                    response.Wait();

                    if (response.Result.IsSuccessStatusCode)
                    {
                        var result = response.Result.Content.ReadAsStringAsync();

                        var envelopeCriado = JsonConvert.DeserializeObject<Envelope>(result.Result);

                        return Ok(response.Result);
                    }

                    return NotFound();
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }

    }
}
