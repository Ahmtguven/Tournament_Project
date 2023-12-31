using CrudAdoSwagerApiTurnuva.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlClient;
using System.Data;

namespace CrudAdoSwagerApiTurnuva.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProfesyonellerController : ControllerBase
	{
		db baglan = new db();

		[HttpGet]
		public List<Profesyoneller> Get()
		{
			var result = baglan.ListeProfesyonel();
			return result;
		}

		[HttpPost]
		public string Post(Profesyoneller profesyoneller)
		{
			string a = baglan.ProfesyonelCrud(profesyoneller);
			return a;
		}

		[HttpPut("{id}")]
		public string Put(int id, Profesyoneller profesyoneller)
		{
			string a = "";
			profesyoneller.SporcuId = id;
			a = baglan.ProfesyonelCrud(profesyoneller);
			return a;
		}

		[HttpDelete("{id}")]
		public string Delete(int id, Profesyoneller profesyoneller)
		{
			string a = "";
			profesyoneller.SporcuId = id;
			profesyoneller.type = "Delete";
			a = baglan.ProfesyonelCrud(profesyoneller);
			return a;
		}
	}
}
