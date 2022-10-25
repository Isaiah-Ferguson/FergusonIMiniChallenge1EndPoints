using Microsoft.AspNetCore.Mvc;

namespace FergusonIMiniChallenge1EndPoints.Controllers;

[ApiController]
[Route("[controller]")]
public class MiniChallenge1EndPointController : ControllerBase
{
    [HttpGet]
    [Route("MiniChallenge1")]

    public string SayHello()
    {
        string name1 = "Isaiah";
        return $"This program will ask the user their name. \n Hello, what is your name? \n {name1} \n Hello, {name1}";
    }

    [HttpGet]
    [Route("MiniChallenge2")]

    public string AddingNumbers()
    {
        int num1 = 5;
        int num2 = 6;
        return $"This program will total the sum of 2 numbers. \nFor Example: {num1} + {num2} is \n{num1 + num2}";
    }


    [HttpGet]
    [Route("MiniChallenge3")]

    public string AskingQuestions()
    {
        string name2 = "Isaiah";
        return $"This program will ask two questions to the user for example \nHello, what is your name? \n{name2} \nNice too meet you {name2} \nWhat time did you go to the gym today? \nETC....";
    }

    [HttpGet]
    [Route("MiniChallenge4")]

    public string GreaterThanOrLessThan()
    {
string answer = "";
double Validnum = 0;
double Validnum2 = 0;
bool Truth = true;
bool Truth2 = true;
string num1 = "5";
string num2 = "6";

Truth = double.TryParse(num1, out Validnum);
Truth2 = double.TryParse(num2, out Validnum2);

if( Validnum > Validnum2)
{   
    return $"This program will prompt the user to input 2 numbers and will determin which number is greater or less than, for example \n{Validnum} is greater than  + {Validnum2} \n{Validnum2} + is Less than  + {Validnum}"; 
}
else if( Validnum < Validnum2 )
{
    return $"This program will prompt the user to input 2 numbers and will determin which number is greater or less than, for example \n{Validnum} is Less than {Validnum2} \n{Validnum2}  is greater than {Validnum}";
}
else if(num1 == num2)
{
   return $"{Validnum} Is equal too {Validnum2}";
}
   return answer = "end";
}

    [HttpGet]
    [Route("MiniChallenge5")]
    public string MadLib()
    {
     string AnimeTitle, reTry, Adjective, Size, Emotion, Food, Restaurant, celebrity, animeCharacter, shoe, num, num1;
     int realnum, realnum2, trunum3;

        return $"This program will promt the user for words and input them into a story. \nFor Example: \n AnimeTitle Is the best Adjective Anime ever! \n the main character's feet seems kinda Size \n I can't believed they named him after Celebrity \n The plot had so many twists i can't believe AnimeCharacter Showed up at the end! \n did you see when Celebrity Wore Shoe's I really wish he didn't wear those \n Honestly it made me kind of Emotion \n Anyway, Celebrity thought that RealNum1 + RealNum2 was 21 instead of TruNum ! what a memer!! \n I usually watch it at Restaurant I go there so often they usually give me free Food";
    }

    [HttpGet]
    [Route("MiniChallenge6")]

public string OddOrEven(){
double remainder = 0;
double validnum = 0;
bool isNumber = true;
string num;

num = "8";
isNumber = double.TryParse(num, out validnum);

if(!isNumber)
{
    return "Thats not a number.";
}
else
{
    if(remainder == (validnum % 2))
{
    return $"This program will promt the user to input a number and then tell them if it's odd or even. \nFor Example: \nYour number {num} is even";
}
else
{
    return $"Your number {num} is odd";
}}}

[HttpGet]
[Route("MiniChallenge7")]

public string ReverseIt()
{
string input = "Hello my name is Isaiah";
string revInput = "";

    for (int i = input.Length - 1;i >= 0; i--)
    {
        revInput = revInput + input[i];
    }
return $"This program will let the user input a string an output the reverse. \nFor Example: \n{input} | {revInput}";
} 


[HttpGet]
[Route("MiniChallenge8")]

public string Magic8Ball()
{
    int num = 0;
    Random randnum = new Random();
    num = randnum.Next(0, 9);
    string[] Magic8Ball = {"Doesn't look good", "Yes", "No", "We'll see", "Not likely", "More than likely", "Just give up", "Looking good", "Outlook undeterminded"};

    return $"This program will tell the user a random forturne. \nFor Example: \nThe Magic 8 Ball says '{Magic8Ball[num]}'";
}

[HttpGet]
[Route("MiniChallenge9")]

public string RestaurantPicker()
{
    int num2 = 0;
    Random Randm = new Random();
    num2 = Randm.Next(1, 9);
string[] fastFood = {"Mcdonalds", "Five Guys", "Jack N the Box",  "Burger King", "Wendy's", "PizzaHut", "Dominoes", "fired Pizza", "Little Ceaser's", "Costco Pizza"};
return $"This program will choose a random Restaurant for depending on the user's choices. \nFor Example: \nLets get some {fastFood[num2]}";
}
}