using System.Collections.ObjectModel;

// get current time
var utcNow = DateTime.UtcNow;

Console.WriteLine(utcNow);
Console.WriteLine(utcNow.ToLocalTime());
Console.WriteLine(utcNow.IsDaylightSavingTime());

// convert to another time zone
TimeZoneInfo london = TimeZoneInfo.FindSystemTimeZoneById("Europe/London");
Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(utcNow, london));

Console.WriteLine("Creating DateTimes *******************************");
// create a specific date/time
DateTime utcTime = new DateTime(1970, 01, 01, 01, 00, 00, DateTimeKind.Utc);
Console.WriteLine(utcTime);

// simpler version
utcTime = new DateTime(1980, 01, 01);
Console.WriteLine(utcTime);

Console.WriteLine("Calculating with DateTimes *******************************");
// some calculations
utcTime = utcTime.AddDays(5);
Console.WriteLine(utcTime);

TimeSpan passedTime = new TimeSpan(8,0,0);
DateTime endtime = utcTime.Add(passedTime);
Console.WriteLine(endtime);

//formatting datetimes
Console.WriteLine("Formating DateTimes *******************************");
Console.WriteLine(endtime.ToLongDateString());
Console.WriteLine(endtime.ToShortDateString());
Console.WriteLine(endtime.ToShortTimeString());
Console.WriteLine(endtime.ToString("dd.MM.yyyy"));


// Parsing datetimes
String dateExample01 = "01/10/2009 7:34 PM";
String dateExample02 = "10.01.2009 19:34";
String dateExample03 = "10-1-2009 19:34";
String dateExample04 = "10.01.1999 12:34:01";

Console.WriteLine(DateTime.Parse(dateExample01));

//using offset type, to store UTC offset
DateTimeOffset dtoNow = DateTimeOffset.Now;
Console.WriteLine(dtoNow);