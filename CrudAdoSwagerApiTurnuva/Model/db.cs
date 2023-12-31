using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Reflection.Metadata.Ecma335;

namespace CrudAdoSwagerApiTurnuva.Model
{
	public class db
	{
		SqlConnection con = new SqlConnection("Server=AHMET\\SQLKODLAB;Database=Turnuva;Integrated Security=true;");

		public string AmatorCrud(Amatorler amatorler)
		{
			string islem = "";
			con.Open();
			using (SqlCommand cmd = new SqlCommand("CrudA", con))
			{
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@SporcuId", amatorler.SporcuId);
				cmd.Parameters.AddWithValue("@AdSoyad", amatorler.AdSoyad);
				cmd.Parameters.AddWithValue("@Seviye", amatorler.Seviye);
				cmd.Parameters.AddWithValue("@Puan", amatorler.Puan);
				cmd.Parameters.AddWithValue("@type", amatorler.type);
				cmd.ExecuteNonQuery();
			}
			con.Close();
			return islem;
		}

		public List<Amatorler> ListeAmator()
		{
			List<Amatorler> Aliste=new List<Amatorler> ();
			SqlCommand cmd = new SqlCommand();

			cmd.Connection = con;
			cmd.CommandType= CommandType.StoredProcedure; ;
			cmd.CommandText = "ListA";


			con.Open();
			SqlDataReader dr = cmd.ExecuteReader();

			while (dr.Read())
			{
				Amatorler amator = new Amatorler();
				amator.SporcuId = Convert.ToInt32(dr["SporcuId"]);
				amator.AdSoyad = dr["AdSoyad"].ToString();
				amator.Seviye = dr["Seviye"].ToString();
				amator.Puan = Convert.ToInt32(dr["Puan"]);
			}
			con.Close();
			return Aliste;
		}

		//-----------------------------------------
		public string ProfesyonelCrud(Profesyoneller profesyoneller)
		{
			string islem = "";
			con.Open();
			using (SqlCommand cmd = new SqlCommand("CrudP", con))
			{
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@SporcuId", profesyoneller.SporcuId);
				cmd.Parameters.AddWithValue("@AdSoyad", profesyoneller.AdSoyad);
				cmd.Parameters.AddWithValue("@Seviye", profesyoneller.Seviye);
				cmd.Parameters.AddWithValue("@Puan", profesyoneller.Puan);
				cmd.Parameters.AddWithValue("@type", profesyoneller.type);
				cmd.ExecuteNonQuery();
			}
			con.Close();
			return islem;
		}

		public List<Profesyoneller> ListeProfesyonel()
		{
			List<Profesyoneller> Pliste = new List<Profesyoneller>();
			SqlCommand cmd = new SqlCommand();

			cmd.Connection = con;
			cmd.CommandType = CommandType.StoredProcedure; ;
			cmd.CommandText = "ListP";

			con.Open();
			SqlDataReader dr = cmd.ExecuteReader();

			while (dr.Read())
			{
				Profesyoneller profesyoneller = new Profesyoneller();
				profesyoneller.SporcuId = Convert.ToInt32(dr["SporcuId"]);
				profesyoneller.AdSoyad = dr["AdSoyad"].ToString();
				profesyoneller.Seviye = dr["Seviye"].ToString();
				profesyoneller.Puan = Convert.ToInt32(dr["Puan"]);
			}
			con.Close();
			return Pliste;
		}

		//-----------------------------------------
		public string YıldızlarCrud(Yıldızlar yıldızlar)
		{
			string islem = "";
			con.Open();
			using (SqlCommand cmd = new SqlCommand("CrudP", con))
			{
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@SporcuId", yıldızlar.SporcuId);
				cmd.Parameters.AddWithValue("@AdSoyad", yıldızlar.AdSoyad);
				cmd.Parameters.AddWithValue("@Seviye", yıldızlar.Seviye);
				cmd.Parameters.AddWithValue("@Puan", yıldızlar.Puan);
				cmd.Parameters.AddWithValue("@type", yıldızlar.type);
				cmd.ExecuteNonQuery();
			}
			con.Close();
			return islem;
		}

		public List<Yıldızlar> ListeYıldız()
		{
			List<Yıldızlar> Yliste = new List<Yıldızlar>();
			SqlCommand cmd = new SqlCommand();

			cmd.Connection = con;
			cmd.CommandType = CommandType.StoredProcedure; ;
			cmd.CommandText = "ListY";

			con.Open();
			SqlDataReader dr = cmd.ExecuteReader();

			while (dr.Read())
			{
				Yıldızlar yıldızlar = new Yıldızlar();
				yıldızlar.SporcuId = Convert.ToInt32(dr["SporcuId"]);
				yıldızlar.AdSoyad = dr["AdSoyad"].ToString();
				yıldızlar.Seviye = dr["Seviye"].ToString();
				yıldızlar.Puan = Convert.ToInt32(dr["Puan"]);
			}
			con.Close();
			return Yliste;
		}
	}
}
