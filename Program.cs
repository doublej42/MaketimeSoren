var OFF = new DateTime(2023, 3, 4, 16, 0, 0);


do
{
    DateTime now = DateTime.Now;
    var timeleft = OFF - now;
    Console.WriteLine(timeleft.TotalMinutes.ToString("N2"));
    Console.Beep();
    Thread.Sleep(1000);
} while(true);
