using System;

namespace ADO{

    class Program{
        public static void Main(string[] args){
            Program obj = new Program();
            obj.Connecting();
        }

        public void Connecting(){
            string sc = "datasource=.;database=StudentDB;integrated security=SSPI";
            SqlConnection con = null;
            SqlCommand cmd = new SqlCommand("Select * From Student", con)
            try{
                con = new SqlConnection(sc);
                con.Open();
                Console.WriteLine("Connection Successfull ");

                SqlDataReader data = cmd.ExecuteReader();
                while(data.Read()){
                    Console.WriteLine("ID: " + data[0] + "Name: " + data[1] + "Number: " + data[2]);
                }
            }
            
            catch(Exception e){
                Console.WriteLine("Error "+e);
            }

            finally{
                con.Close();
                Console.WriteLine("Connection Closed ");
            }
        }
    }
}