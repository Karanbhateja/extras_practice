using System;
using System.Data;
using System.Data.SqlClient;

namespace ADO{
    class DbProgram{
        static void main(){
            new DbProgram().DbConnect();
            Console.ReadLine();
        }
        public void DbConnect(){
            string cs = "data source=.; database=testDB; integrated security=true;";
            using(SqlConnection conn = new SqlConnection(cs)){ //Step 1 Create conn obj
                SqlCommand cmd = new SqlCommand("Select * FROM Student",conn); //Step 2 Create cmd obj
                conn.open();
                // Step3 `ExecuteReader` from cmd object and stored in DataReader ref
                SqlDataReader data = cmd.ExecuteReader(); 
                // Step4 Read Data using `Read()` of `DataReader` object inside while loop;
                while(data.Read()){ 
                    Console.WriteLine("ID: {0}, Name: {1}, Number: {2}",data[0],data[1],data[2])
                }
            }
        }
    }
}
