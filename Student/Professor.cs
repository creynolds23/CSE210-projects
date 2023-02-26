public class Professor : Person
{
    DateTime _hireDate;

    public Professor(string name, Address addr, string email, DateTime hireDate) : base(name,addr,email)
    {
        _hireDate = hireDate;
    }
}