

Console.WriteLine("Hello, World");


Team firebirds = new Team("Firebirds");

Team bulldogs = new Team("Bulldogs");




Player john = new Player("John Henderson", 12);
// john.Display();
Player tim = new Player("Tim Nunn", 13);


firebirds.AddPlayer(john);
firebirds.AddPlayer(tim);

firebirds.DisplayRoster();

Player bill = new Player("Bill Nicholson", 55);
Player spud = new Player("Spud Webb", 32);

bulldogs.AddPlayer(bill);
bulldogs.AddPlayer(spud);
bulldogs.DisplayRoster();

Match match1 = new Match(firebirds, bulldogs);
match1.DecideWin();

bulldogs.DisplayRoster();
firebirds.DisplayRoster();