using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace CUMCIS.Models
{
    public class InfoSys
    {
        private MySqlConnection CreateConnection()
        {
            string connection = "server=localhost;database=myproject;user=root;password=@Newuser2019;port=3306";
            MySqlConnection con = new MySqlConnection(connection);
            con.Open();
            return con;
        }

        public List<Myembro> myems = new List<Myembro>();

        public void addMyembroToDB (Myembro mem)
        {
            var con = this.CreateConnection ();
            string cmdText = $"insert into myembro values({mem.id}, '{mem.fname}', '{mem.lname}', '{mem.suffix}', '{mem.gender}', '{mem.bdate.ToString("yyyy-MM-dd HH:mm:ss")}', '{mem.age}', '{mem.grp}', '{mem.contact}', '{mem.email}', '{mem.address}', '{mem.stat}', '{mem.mname}', '{mem.marital}', '{mem.husbandname}', '{mem.wifename}', '{mem.children}', '{mem.anniv.ToString("yyyy-MM-dd HH:mm:ss")}', '{mem.dod.ToString("yyyy-MM-dd HH:mm:ss")}')"; 
            MySqlCommand  cmd = new MySqlCommand (cmdText, con); // preparing your command

            cmd.ExecuteNonQuery();
        }

        public void UpdateMyembro(Myembro mem)
        {
            var con = this.CreateConnection();
            string cmdText = $"update myembro set fname='{mem.fname}', lname='{mem.lname}', mname='{mem.mname}', suffix='{mem.suffix}', gender='{mem.gender}', bdate='{mem.bdate.ToString("yyyy-MM-dd HH:mm:ss")}', age={mem.age}, grp='{mem.grp}', contact='{mem.contact}', email='{mem.email}', address='{mem.address}', stat='{mem.stat}', marital='{mem.marital}', husbandname='{mem.husbandname}', wifename='{mem.wifename}', children='{mem.children}', weddinganniv='{mem.anniv.ToString("yyyy-MM-dd HH:mm:ss")}', dod='{mem.dod.ToString("yyyy-MM-dd HH:mm:ss")}' where id={mem.id}";
            MySqlCommand cmd = new MySqlCommand(cmdText, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void deleteMyembro (int id)
        {
            var con = this.CreateConnection();
            string cmdText = $"delete from myembro where id = {id}";
            MySqlCommand cmd = new MySqlCommand (cmdText, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

       public List<Myembro> SearchName(string searchpamore)
        {
            List<Myembro> mem = new List<Myembro>();
            var con = this.CreateConnection();

            string cmdText = $"select * from myembro where fname like '%{searchpamore}%'";

            MySqlCommand cmd = new MySqlCommand(cmdText, con);

            var result = cmd.ExecuteReader();
            while(result.Read())
            {
                Myembro m = new Myembro ();
                m.id = Convert.ToInt32(result["id"]);
                m.fname = result["fname"].ToString();
                m.lname = result["lname"].ToString();
                m.grp = result ["grp"].ToString();
                m.suffix = result ["suffix"].ToString();
                m.address = result ["address"].ToString();
                m.contact = result ["contact"].ToString();
                m.email = result ["email"].ToString();
                mem.Add(m);
            }

            con.Close();
            return mem;
        }

        public List<Myembro> getMyembroFromDB()
        {
            List<Myembro> mem = new List<Myembro> ();
            var con = this.CreateConnection();
            MySqlCommand cmd = new MySqlCommand ("select * from myembro", con);
            var result = cmd.ExecuteReader();

            while(result.Read())
            {
                Myembro memb = new Myembro();
                memb.id = Convert.ToInt32(result["id"]);
                memb.fname = result ["fname"].ToString();
                memb.lname = result ["lname"].ToString();
                memb.grp = result ["grp"].ToString();
                memb.suffix = result ["suffix"].ToString();
                memb.address = result ["address"].ToString();
                memb.contact = result ["contact"].ToString();
                memb.email = result ["email"].ToString();
                mem.Add(memb);
                
            }
            con.Close();
            return mem;
        }

        public Myembro getmyembro (int id)
        {
        var con = this.CreateConnection();
        string cmdText = $"select * from myembro where id = {id}";
        MySqlCommand cmd = new MySqlCommand (cmdText, con);
        var result = cmd.ExecuteReader();
        Myembro mem = new Myembro();
        while(result.Read())
        {
            mem.id = Convert.ToInt32(result["id"]);
            mem.fname = result ["fname"].ToString();
            mem.lname = result ["lname"].ToString();
            mem.suffix = result ["suffix"].ToString();
            mem.gender = result ["gender"].ToString();
            mem.bdate = Convert.ToDateTime(result["bdate"]);
            mem.age = Convert.ToInt32(result["age"]);
            mem.grp = result ["grp"].ToString();
            mem.contact = result ["contact"].ToString();
            mem.email = result ["email"].ToString();
            mem.address = result ["address"].ToString();
            mem.stat = result ["stat"].ToString();
            mem.mname = result ["mname"].ToString();
            mem.marital = result ["marital"].ToString();
            //mem.husbandname = result ["husbandname"].ToString();
            //mem.wifename = result ["wifename"].ToString();
            //mem.children = result ["children"].ToString();
            //mem.anniv = result ["weddinganniv"].ToString();
            //mem.dod = Convert.ToInt32(result["dod"]);
        }
        con.Close();
        return mem;
        }



    }

}