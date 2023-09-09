using Alarms;

var OFF = new DateTime(2023, 9, 9, 16, 0, 0);

//var OFF = DateTime.Now.AddMinutes(7.1);


//var alarms = new double []{ 7, 2 };
var alarms = new Alarm[2];
alarms[0] = new Alarm();
alarms[0].Time = new TimeOnly(15, 53, 00);
alarms[0].Tone = 18000;
alarms[0].Message = "Kid alarm triggered";

alarms[1] = new Alarm();
alarms[1].Time = new TimeOnly(15, 57, 00);
alarms[1].Tone = 14000;
alarms[1].Message = "Everyone alarm triggered";
var currentAlarm = 0;



do
{
    DateTime now = DateTime.Now;
    var timeleft = OFF - now;
    if (TimeOnly.FromDateTime(DateTime.Now) >= alarms[currentAlarm].Time)  
    {
        Console.WriteLine(alarms[currentAlarm].Message + timeleft.ToString(@"hh\:mm\:ss\ ffff"));
        Console.Beep(alarms[currentAlarm].Tone, 4000);
        currentAlarm++;
    }
    else
    {
        Console.WriteLine(DateTime.Now);
        Thread.Sleep(1000);
    }
    
    
   
} while(currentAlarm < alarms.Length);
