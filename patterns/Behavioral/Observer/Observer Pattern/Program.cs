


var bonkart = new ZiraatBank();

var samilOb = new SamilObserver();

bonkart.Register(samilOb, new UserModel("Samil", 123, 1000));

bonkart.NotifyByName("Samil");

class ZiraatBank
{
    private Dictionary<IObserver, UserModel> observers = new();

    public void Register(IObserver observer, UserModel user)
    {
        observers.TryAdd(observer, user);
    }

    public void NotifyByName(string name)
    {
        foreach (var observer in observers)
        {
            if (observer.Value.Name==name)
            {
                observer.Key.Notify(observer.Value);
            }
            
        }
    }
}




class SamilObserver : IObserver
{
    public void Notify(UserModel user)
    {
        Console.WriteLine("Hacı sana para geldi yeni bakiyen: " + user.Amount);
    }
}



interface IObserver
{
    void Notify(UserModel user);
}

class UserModel
{
    public string Name { get; set; }
    public int AccountNo { get; set; }
    public int Amount { get; set; }


    public UserModel(string name, int accountNo, int amount)
    {
        Name = name;
        AccountNo = accountNo;
        Amount = amount;
    }
    
}