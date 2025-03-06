// See https://aka.ms/new-console-template for more information
using Cvicenie2_triedy;
using System.Globalization;

var person1 = new Person();
person1.FirstName = "John";
person1.LastName = "Carrot";
person1.Gender = Gender.UNKNOWN;

var person2 = new Person { FirstName = "Jane",LastName = "Carrot", Gender = Gender.FEMALE };
var jano2 = new Person
{
    FirstName = "Ján",
    LastName = "Mrkvička",
    Gender = Gender.MALE,
    Birthdate = DateTime.Parse("31.12.1985", new CultureInfo("sk"))
};

var jano3 = new Person("Ján", "Mrkvička", new DateTime(1985, 12, 31), Gender.MALE);

bool result = jano2.Equals(jano3);
var jano4 = new Person("Ján", "Mrkvička", null);
Console.WriteLine(result);
Console.WriteLine($"{jano4.FirstName}, {jano4.LastName},{jano4.Birthdate.Value.Day}.{jano4.Birthdate.Value.Month}.{jano4.Birthdate.Value.Year}, age: {jano4.Age}, gender: {jano4.Gender}");
