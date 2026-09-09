using System.Security.Cryptography;
using static SplashKitSDK.SplashKit;
string name;
WriteLine("what is your name:");
name= ReadLine();

double km;
WriteLine("How far have you travelled so far ? enter km:");
km=Convert.ToDouble(ReadLine());

double minutes;
WriteLine("How long has it taken? enter minutes:");
minutes=Convert.ToDouble(ReadLine());

double averagespeed;
averagespeed=km*60/minutes;

double km2;
WriteLine("How far do you have to go?Enter km2:");
km2=Convert.ToDouble(ReadLine());

double minutes2;
minutes2=(km2/averagespeed)*60;

double totaldistance;
totaldistance=km+km2;

double totaltime;
totaltime=minutes+minutes2;
WriteLine("CALCULATE DISTANCE TIME SPEED OF " +name+".");
WriteLine("Hi" +name+".");
WriteLine("km you travelled "+km);
WriteLine("Minute you have taken " +minutes+ " minutes");
WriteLine("your average speed is " + averagespeed+ " km/h");
WriteLine("km you want to travel more: " +km2+ " km");
WriteLine("You will take another " +minutes2+ " minute before you arrive");
WriteLine("Total distance will be " +totaldistance+ " km/h");
WriteLine("Total time will be " +totaltime+ " minute");

WriteLine("Thanks......");



