


using backend.models;
using System.Data.SqlClient;

string connection = "Server=DESKTOP-1BB3LE6;Database=WOLT; Trusted_Connection = True";
SqlConnection sqlConnection = new SqlConnection(connection);

List<product> products = new List<product>();

void CreateProduct()
{
    sqlConnection cmd = new SqlConnection("INSERT INTO Products VALUES('Hamburger', 2.2)", sqlConnection);
    cmd.ExecuteNonQuery();
    sqlConnection.Close();
}
void ReadData()
{

    SqlCommand cmd = new SqlCommand("Select * from Products", sqlConnection);
    sqlConnection.Open();
    var result = cmd.ExecuteReader();
    while (result.Read())
    {
        Console.WriteLine(result["name"]);
    }
    sqlConnection.Close();
}

void ShowProducts()
{
    products.ForEach(prod =>
    {
        Console.WriteLine(prod.name, prod.price);
    });
}



