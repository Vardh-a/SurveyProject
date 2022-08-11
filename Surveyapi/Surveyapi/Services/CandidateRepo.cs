using Surveyapi.Models;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Surveyapi.Services
{
    public class CandidateRepo : IRepo< Candidate>
    {
        SqlConnection conn;
        public CandidateRepo()
        {

        }
        public CandidateRepo(IConfiguration configuration)
        {
            string strCon = configuration.GetConnectionString("conn");
            conn = new SqlConnection(strCon);
        }

        public async Task<Candidate> Add(Candidate item)
        {
            SqlCommand cmd = new SqlCommand("InsertCandi", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FName", item.fname);
            cmd.Parameters.AddWithValue("@LName", item.lname);
            cmd.Parameters.AddWithValue("@MailId", item.mail);
            cmd.Parameters.AddWithValue("@Experience", item.experience);
            cmd.Parameters.AddWithValue("@Q1", item.cq1);
            cmd.Parameters.AddWithValue("@Q2", item.cq2);
            cmd.Parameters.AddWithValue("@Q3", item.cq3);
            cmd.Parameters.AddWithValue("@Q4", item.cq4);
            cmd.Parameters.AddWithValue("@Q5", item.cq5);
            cmd.Parameters.AddWithValue("@Q6", item.cq6);
            cmd.Parameters.AddWithValue("@Q7", item.cq7);
            cmd.Parameters.AddWithValue("@Q8", item.cq8);
            cmd.Parameters.AddWithValue("@Q9", item.cq9);
            cmd.Parameters.AddWithValue("@Q10", item.cq10);
            if (conn.State == ConnectionState.Open)
                conn.Close();
            try
            {
                conn.Open();
                int Result = cmd.ExecuteNonQuery();
                if (Result > 0)
                    return item;
            }
            catch (Exception e)
            {
                Debug.Write(e.Message);
            }
            finally
            {
                conn.Close();
            }
            return null;
        }

        public IEnumerable<Candidate> GetAll()
        {

            SqlDataAdapter da = new SqlDataAdapter("GetCandi", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds);
            List<Candidate> productss = new List<Candidate>();
            Candidate product;
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                product = new Candidate();
                product.sno = Convert.ToInt32(item[0].ToString());
                product.fname = item[1].ToString();
                product.lname = item[2].ToString();
                product.mail = item[3].ToString();
                product.experience = item[4].ToString();
                product.cq1 = item[5].ToString();
                product.cq2 = item[6].ToString();
                product.cq3 = item[7].ToString();
                product.cq4 = item[8].ToString();
                product.cq5 = item[9].ToString();
                product.cq6 = item[10].ToString();
                product.cq7 = item[11].ToString();
                product.cq8 = item[12].ToString();
                product.cq9 = item[13].ToString();
                product.cq10 = Convert.ToInt32(item[14].ToString());
                productss.Add(product);
            }
            return productss;
        }
    }
}
