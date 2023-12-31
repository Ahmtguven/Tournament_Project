using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Data;
using CrudAdoSwagerApiTurnuva.Model;

namespace CrudAdoSwagerApiTurnuva.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AmatorlerController : ControllerBase
	{
		db baglan = new db();

		[HttpGet]
		public List<Amatorler> Get()
		{
			var result = baglan.ListeAmator();
			return result;
		}

		[HttpPost]
		public string Post(Amatorler amatorler) 
		{
			string a = baglan.AmatorCrud(amatorler);
			return a;
		}

		[HttpPut("{id}")]
		public string Put(int id, Amatorler amatorler)
		{
			string a = "";
			amatorler.SporcuId = id;
			a = baglan.AmatorCrud(amatorler);
			return a;
		}

		[HttpDelete("{id}")]
		public string Delete(int id, Amatorler amatorler)
		{
			string a = "";
			amatorler.SporcuId = id;
			amatorler.type = "Delete";
			a = baglan.AmatorCrud(amatorler);
			return a;
		}
	}
}
