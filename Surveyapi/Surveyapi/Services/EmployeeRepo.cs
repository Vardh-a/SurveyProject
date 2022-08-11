using Surveyapi.Models;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Surveyapi.Services
{
    public class EmployeeRepo : IRepo< Employee>
    {
        SqlConnection conn;
        public EmployeeRepo()
        {

        }
        public EmployeeRepo(IConfiguration configuration)
        {
            string strCon = configuration.GetConnectionString("conn");
            conn = new SqlConnection(strCon);
        }
        
        public async Task<Employee> Add(Employee item)
        {
            SqlCommand cmd = new SqlCommand("InsertEmp", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@EmployeeID", item.empid);
            cmd.Parameters.AddWithValue("@FirstName", item.fname);
            cmd.Parameters.AddWithValue("@LastName", item.lname);
            cmd.Parameters.AddWithValue("@MailID", item.mail);
            cmd.Parameters.AddWithValue("@Designation", item.desg);
            cmd.Parameters.AddWithValue("@Q1", item.q1);
            cmd.Parameters.AddWithValue("@Q2", item.q2);
            cmd.Parameters.AddWithValue("@Q3", item.q3);
            cmd.Parameters.AddWithValue("@Q4", item.q4);
            cmd.Parameters.AddWithValue("@Q5", item.q5);
            cmd.Parameters.AddWithValue("@Q6", item.q6);
            cmd.Parameters.AddWithValue("@Q7", item.q7);
            cmd.Parameters.AddWithValue("@Q8", item.q8);
            cmd.Parameters.AddWithValue("@Q9", item.q9);
            cmd.Parameters.AddWithValue("@Q10", item.q10);
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

        public IEnumerable<Employee> GetAll()
        {

            SqlDataAdapter da = new SqlDataAdapter("GetEmp", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            da.Fill(ds);
            List<Employee> productss = new List<Employee>();
            Employee product;
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                product = new Employee();
                product.sno = Convert.ToInt32(item[0].ToString());
                product.empid = Convert.ToInt32(item[1].ToString());
                product.fname = item[2].ToString();
                product.lname = item[3].ToString();
                product.mail = item[4].ToString();
                product.desg = item[5].ToString();
                product.q1 = item[6].ToString();
                product.q2 = item[7].ToString();
                product.q3 = item[8].ToString();
                product.q4 = item[9].ToString();
                product.q5 = item[10].ToString();
                product.q6 = item[11].ToString();
                product.q7 = item[12].ToString();
                product.q8 = item[13].ToString();
                product.q9 = item[14].ToString();
                product.q10 = Convert.ToInt32(item[0].ToString());
                productss.Add(product);
            }
            return productss;
        }
    }
}
