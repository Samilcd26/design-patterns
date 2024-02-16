
var firstInstanceRequest = Database.GetInstance();


var secondInstanceRequest = Database.GetInstance();
   
if (firstInstanceRequest == secondInstanceRequest)
{
    Console.WriteLine("Both instances are the same");
}
else
{
    Console.WriteLine("Both instances are different");
}

class Database
{
    private static Database instance =null;
    public static Database Instance => instance ?? (instance = new Database());

    private Database()
    {

    }

    
}




