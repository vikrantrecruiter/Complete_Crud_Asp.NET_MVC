using CompleteCrud_ASP.NET_MVC.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CompleteCrud_ASP.NET_MVC.DataAccessLayer
{
    public class AddressDbContext
    {
        string cs = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;

       public List<CountryModel> GetCountry()
        {
            List<CountryModel> countries = new List<CountryModel>();
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("sp_GetCountryList", con);
            cmd.CommandType = CommandType.StoredProcedure;

            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();

            while(sdr.Read())
            {
                CountryModel countryModel = new CountryModel();

                countryModel.CountryId= Convert.ToInt32(sdr["CountryId"].ToString());
                countryModel.CountryName = sdr["CountryName"].ToString();
                countries.Add(countryModel);
            }
            return countries;
        }

        public List<StateModel> GetStateByCountryId(int countryid)
        {
            List<StateModel> states = new List<StateModel>();
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("sp_GetStateDataByCountryId", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CountryId", countryid);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while(sdr.Read())
            {
                StateModel stateModel = new StateModel();
                stateModel.StateId = Convert.ToInt32(sdr["StateId"].ToString());
                stateModel.StateName = sdr["StateName"].ToString();
                states.Add(stateModel);
            }
            return states;
        }

        public List<CityModel> GetCityByStateId(int stateid)
        {
            List<CityModel> cities = new List<CityModel>();
            SqlConnection con=new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand("sp_GetCityDataByStateId", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@StateId", stateid);
            con.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            while(sdr.Read())
            {
                CityModel cityModel = new CityModel();
                cityModel.CityId= Convert.ToInt32(sdr["CityId"].ToString());
                cityModel.CityName=sdr["CityName"].ToString();
                cities.Add(cityModel);
            }
            return cities;
        }
    }
}