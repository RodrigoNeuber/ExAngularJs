using Api2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api2.Controllers
{
    public class ProdutoController : ApiController
    {
        static List<Produto> _listaDeProdutos = new List<Produto>
        {
            new Produto {Id = 1, Name = "iPhone 6s", Category = "Hardware", Price = 3999, Url = "http://www.promoinfo.com.br/img/anuncios/120519.jpg", },
            new Produto {Id = 2, Name = "iPhone 6s Plus", Category = "Hardware", Price = 4999, Url = " http://www.pontofrio-imagens.com.br/Control/ArquivoExibir.aspx?IdArquivo=253903758", },
            new Produto {Id = 3, Name = "iPad", Category = "Hardware", Price = 1000, Url = "http://ll-us-i5.wal.co/dfw/dce07b8c-85ec/k2-_e831335a-b9b7-4845-962b-605edff41b05.v1.jpg-4ef1a8c5d0e909bd4863e029a87125a8945e1069-optim-450x450.jpg", }
        };

        public IHttpActionResult Get()
        {
            return Ok(_listaDeProdutos);
        }

        public IHttpActionResult Get(int id)
        {
            var produto = _listaDeProdutos.Find(x => x.Id == id);
            return Ok(produto);
        }

        // POST: api/Product
        public IHttpActionResult Post ([FromBody] Produto produto)
        {
            _listaDeProdutos.Add(produto);
            return Ok();
        }

        // PUT: api/Product/5
        public void Put (int id, [FromBody]string value)
        {

        }

        // DELETE: api/Product/5
        public void Delete (int id)
        {

        }
    }
}
