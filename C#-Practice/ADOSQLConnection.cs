using System;

namespace ADO{

    class Program{
        public static void Main(string[] args){
            Program obj = new Program();
        }

        public void Connecting(){
            string sc = "datasource=.;database=StudentDB;integrated security=SSPI";
            SqlConnection con = null;
            try{
                con = new SqlConnection(sc);
                con.Open();
                Console.WriteLine("Connection Successfull ");
            }
            
            catch(Exception e){
                Console.WriteLine("Error "+e);
            }

            finally{
                con.close();
                Console.WriteLine("Connection Closed ");
            }
        }
    }
}