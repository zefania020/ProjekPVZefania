using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//1
using System.Data.SqlClient;

namespace AplikasiPetshop
{
	public class Koneksi
	{
		//2
       	public SqlConnection GetConn() 
       	{ 
           	SqlConnection Conn = new SqlConnection(); 
           	Conn.ConnectionString = "Data Source=LAPTOP-B2OT493M; initial catalog=Petshop; integrated security=true"; 
           	return Conn; 
       	} 
	}
}
