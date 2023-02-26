public class Student : Person
{
    int _studentId;
    int _seminars = 0;

    public Student(string name, Address addr, string email, int id): base(name,addr,email)
    {
        _studentId = id;
    }

    public int GetSeminarsTaken()
    {
        return _seminars;
    }
    public void TakeSeminar()
    {
        _seminars += 1;
    }
}