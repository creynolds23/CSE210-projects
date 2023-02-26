// See https://aka.ms/new-console-template for more information

Address addr = new Address("1234 My Street","Rexburg","ID","83440");

Person johnDoe = new Person("John Doe", addr, "john.doe@gmail.com" );

johnDoe.ShowAddress();


Student andres = new Student("Andres", addr, "andres@byui.edu", 12345);
Console.WriteLine($"Seminars Taken: {andres.GetSeminarsTaken()}");

andres.TakeSeminar();
Console.WriteLine($"Seminars Taken: {andres.GetSeminarsTaken()}");


Address addr2 = new Address("1234 Professor Dr","Rexburg","ID","83440");

Professor brotherHayes = new Professor("Brother Hayes", addr2, "hayesa@byui.edu", DateTime.Now);

brotherHayes.ShowAddress();
