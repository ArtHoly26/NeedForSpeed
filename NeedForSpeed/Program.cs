using NeedForSpeed;


Game NewGame = new Game(new List<Car>
{
    new SportCar("Ferrari","Красный"),
    new SportCar("BMV","Черный"),
    new SportCar("Audy","Серебристый"),
    new SportCar("Nissan","Желтый"),
    new SportCar("Bugaty","Голубой")
});

NewGame.PrintInfoMember();
Console.WriteLine();
NewGame.MashineReady();
NewGame.Races();
NewGame.ResultRace();