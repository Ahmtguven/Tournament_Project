using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Data;
using CrudAdoSwagerApiTurnuva.Model;

namespace CrudAdoSwagerApiTurnuva.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class YıldızlarController : ControllerBase
	{
		db baglan = new db();

		[HttpGet]
		public List<Yıldızlar> Get()
		{
			var result = baglan.ListeYıldız();
			return result;
		}

		[HttpPost]
		public string Post(Yıldızlar yıldızlar)
		{
			string a = baglan.YıldızlarCrud(yıldızlar);
			return a;
		}

		[HttpPut("{id}")]
		public string Put(int id, Yıldızlar yıldızlar)
		{
			string a = "";
			yıldızlar.SporcuId = id;
			a = baglan.YıldızlarCrud(yıldızlar);
			return a;
		}

		[HttpDelete("{id}")]
		public string Delete(int id, Yıldızlar yıldızlar)
		{
			string a = "";
			yıldızlar.SporcuId = id;
			yıldızlar.type = "Delete";
			a = baglan.YıldızlarCrud(yıldızlar);
			return a;
		}
	}
}
