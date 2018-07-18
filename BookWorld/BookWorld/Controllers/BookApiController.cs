using BookWorld.Models;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace BookWorld.Controllers
{
    public class BookApiController : ApiController
    {

        public HttpResponseMessage GetBook()
        {
            var book = new BookViewModel
            {
                Name = "Name1",
                Author = "Author",
                Price = 15
            };
            return ToJson(book);
        }

        public HttpResponseMessage SaveBook(BookViewModel book)
        {
           
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        protected HttpResponseMessage ToJson(dynamic obj)
        {
            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");
            return response;
        }
    }
}
