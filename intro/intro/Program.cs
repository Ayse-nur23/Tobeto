// 1-100 arası asal sayılar


using System.Text.Encodings.Web;

for (int i = 1; i <= 100; i++)
{
    int result = 0;
    for (int j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            result = 1;
            break;
        }
    }
    if (result == 0)
    {
        Console.WriteLine(i);
    }
}



int term = 10;

// karakter dizisidir.
string information = "İhtiyaç Kredisi";

char firstLetter = 'A';

Console.WriteLine(information[0]);
Console.WriteLine(information[1]);
Console.WriteLine(information[2]);
Console.WriteLine(information[3]);
Console.WriteLine(information[4]);

double dollarToday = 27.40;
double dollarYesterday = 27.70;

if (dollarToday > dollarYesterday)
{
    Console.WriteLine("UP");
}
else if (dollarToday < dollarYesterday)
{
    Console.WriteLine("DOWN");
}
else
{
    Console.WriteLine("EQUAL");
}

string button1 = "<button>Giriş Yap</button>";
string button2 = "<button>Çıkış Yap</button>";

bool isLoggedIn = false;
if (isLoggedIn)
{
    Console.WriteLine(button2);
}
else
{
    Console.WriteLine(button1);
}

string[] courses = new string[] { "C#", "Java", "C++", "Python", "JavaScript" };

Console.WriteLine("<ul>");
foreach (var course in courses)
{
    Console.WriteLine("<li>" + course + "</li>");
}
Console.WriteLine("</ul>");

Console.WriteLine("/////////////////");

Console.WriteLine("<ul>");
for (int i = 0; i < courses.Length; i++)
{
    Console.WriteLine("<li>" + courses[i] + "</li>");
}
Console.WriteLine("</ul>");




