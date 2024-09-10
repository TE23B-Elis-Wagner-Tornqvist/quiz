using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

int score = 0;
bool isAnswerCorrect = false;
bool isAnswerCorrect2 = false;
bool isAnswerCorrect3 = false;   
bool isAnswerCorrect4 = false;
bool isAnswerCorrect5 = false;
bool isAnswerCorrect6 = false;
bool isAnswerCorrect7 = false;
bool isAnswerCorrect8 = false;
bool isAnswercorrect9 = false;


string rätt = 


while(true) {

Console.WriteLine("Hej spelare! Välkommen till en frågesport!");



Console.Clear();

Console.WriteLine($"poäng: {score}");



Console.WriteLine("Vad heter huvudstaden i Autralien?");



Console.WriteLine("");

Console.WriteLine(" a. melbourne");
Console.WriteLine(" b. sydney");
Console.WriteLine(" c. canberra");
Console.WriteLine(" d. Brisbane");

string answer = Console.ReadLine();

if(answer.ToLower() == "c") {

    isAnswerCorrect = true;

}

if(isAnswerCorrect) {

    score++;
    Console.WriteLine("Rätt svar!");
    Console.WriteLine($"Du har {score} poäng");
     Console.WriteLine("tryck på enter för att fortsätta");
     
    Console.ReadLine();

     
    

} else if(answer.ToLower() == "a" || answer.ToLower() == "b" || answer.ToLower() == "d") {

    isAnswerCorrect = false;

} if(isAnswerCorrect == false) {

    Console.WriteLine("Fel svar!");
    Console.WriteLine("tryck på enter för att fortsätta");
    Console.ReadLine();
   // score--;
}

Console.Clear();
Console.WriteLine($"poäng: {score}");

Console.WriteLine("Vad heter huvudstaden i USA?");
Console.WriteLine("");
Console.WriteLine(" a. New York");
Console.WriteLine(" b. Washington D.C");
Console.WriteLine(" c. Los Angeles");
Console.WriteLine(" d. san francisco");

answer = Console.ReadLine();

if(answer.ToLower() == "b") {

    isAnswerCorrect2 = true;

} if(isAnswerCorrect2) {
    score++;
    Console.WriteLine("Rätt svar!");
    Console.WriteLine($"Du har {score} poäng");
    Console.WriteLine("tryck på enter för att fortsätta");
    Console.ReadLine();
    

} else if(answer.ToLower() == "a" || answer.ToLower() == "c" || answer.ToLower() == "d") {

    isAnswerCorrect2 = false;

} if(isAnswerCorrect2 == false) {

    Console.WriteLine("Fel svar!");
    Console.WriteLine("tryck på enter för att fortsätta");
    Console.ReadLine();
    
    
   // score--;

}

Console.Clear();
Console.WriteLine($"poäng: {score}");

Console.WriteLine("Vad heter det högsta berget i världen?");
Console.WriteLine("");

Console.WriteLine(" a. Kebnekaise");
Console.WriteLine(" b. Manaslu");
Console.WriteLine(" c. K2");
Console.WriteLine(" d. Mount Everest");

answer = Console.ReadLine();

if(answer.ToLower() == "d") {
       isAnswerCorrect3 = true; 
    } if(isAnswerCorrect3 == true) {
         score++;
        Console.WriteLine("Rätt svar!");
        Console.WriteLine($"Du har {score} poäng");
        Console.WriteLine("tryck på enter för att fortsätta");
        Console.ReadLine();

        

} else if(answer.ToLower() == "a" || answer.ToLower() == "b" || answer.ToLower() == "c") {

    isAnswerCorrect3 = false;

} if(isAnswerCorrect3 == false) {

    Console.WriteLine("Fel svar!");
    Console.WriteLine("tryck på enter för att fortsätta");
    Console.ReadLine();
    //score--;



}
Console.Clear();
Console.WriteLine($"poäng: {score}");

Console.WriteLine("I vilken kontinent är världens största öken?");
Console.WriteLine("");
Console.WriteLine(" a. europa");
Console.WriteLine(" b. afrika");
Console.WriteLine(" c. antarktis");
Console.WriteLine(" d. asien");

answer = Console.ReadLine();

if(answer.ToLower() == "c") {

isAnswerCorrect4 = true;

} if(isAnswerCorrect4 == true) {
score++;
Console.WriteLine("Rätt svar!");
Console.WriteLine($"Du har {score} poäng");
Console.WriteLine("tryck på enter för att fortsätta");
Console.ReadLine();



} else if(answer.ToLower() == "a" || answer.ToLower() == "b" || answer.ToLower() == "d") {

    isAnswerCorrect4 = false;

} if(isAnswerCorrect4 == false) {


Console.WriteLine("fel svar!");
Console.WriteLine("tryck på enter för att fortsätta");
Console.ReadLine();

}

Console.Clear();
Console.WriteLine($"poäng: {score}");

Console.WriteLine("Vilket land har mest öar i världen?");
Console.WriteLine("");

Console.WriteLine(" a. Sverige");
Console.WriteLine(" b. Norge");
Console.WriteLine(" c. Indonesien");
Console.WriteLine(" d. Australien");

answer = Console.ReadLine();

if(answer == "a") {
isAnswerCorrect5 = true;

} if(isAnswerCorrect5 == true) {
score++;
Console.WriteLine("Rätt svar!");
Console.WriteLine($"Du har {score} poäng");
Console.WriteLine("tryck på enter för att fortsätta");
Console.ReadLine();

} else if(answer.ToLower() == "b" || answer.ToLower() == "c" || answer.ToLower() == "d") {

    isAnswerCorrect5 = false;

} if(isAnswerCorrect5 == false) {

Console.WriteLine("fel svar!");
Console.WriteLine("tryck på enter för att fortsätta");
Console.ReadLine();

}

Console.Clear();
Console.WriteLine($"poäng {score}");

Console.WriteLine("Hur många grannländer har Tyskland?");

Console.WriteLine("");

Console.WriteLine(" a. 9");
Console.WriteLine(" b. 6");
Console.WriteLine(" c. 10");
Console.WriteLine(" d. 4");

answer = Console.ReadLine();

if(answer == "a") {

isAnswerCorrect6 = true;

} if(isAnswerCorrect6 == true) {
score++;
Console.WriteLine("Rätt svar!");
Console.WriteLine($"Du har {score} poäng");
Console.WriteLine("tryck på enter för att fortsätta");
Console.ReadLine();

} else if (answer.ToLower() == "b" || answer.ToLower() == "c" || answer.ToLower() == "d") {

    isAnswerCorrect6 = false;

} if(isAnswerCorrect6 == false) {
 Console.WriteLine("fel svar!");
    Console.WriteLine("tryck på enter för att fortsätta");
Console.ReadLine();

}

Console.Clear();
Console.WriteLine($" poäng: {score}");

Console.WriteLine("Vad heter floden som rinner igenom paris?");

Console.WriteLine("");

Console.WriteLine(" a. Fiene");
Console.WriteLine(" b. Seine");
Console.WriteLine(" c. Donau");
Console.WriteLine(" d. jacksón");

answer = Console.ReadLine();

if(answer == "b") {

isAnswerCorrect7 = true;

} if(isAnswerCorrect7 == true) {

score++;
Console.WriteLine("Rätt svar!");
Console.WriteLine($"Du har {score} poäng");
Console.WriteLine("tryck på enter för att fortsätta");
Console.ReadLine();

} else if(answer.ToLower() == "b" || answer.ToLower() == "c" || answer.ToLower() == "d") {

    isAnswerCorrect7 = false;

} if(isAnswerCorrect7 == false) {
Console.WriteLine("fel svar!");
Console.WriteLine("tryck på enter för att fortsätta");
Console.ReadLine();

}

Console.Clear();
Console.WriteLine($" Du har {score} poäng");

Console.WriteLine("Vilket land är störst i världen?");
Console.WriteLine("");
Console.WriteLine(" a. USA");
Console.WriteLine(" b. Ryssland");
Console.WriteLine(" c. USA");
Console.WriteLine(" d. Kanada");

answer = Console.ReadLine();

if(answer.ToLower() == "b") {

isAnswerCorrect8 = true;

} if(isAnswerCorrect8 == true) {    
    score++;
    Console.WriteLine("Rätt svar!");
    Console.WriteLine($"Du har {score} poäng");
    Console.WriteLine("tryck på enter för att fortsätta");
    Console.ReadLine();


    }
    else if(answer.ToLower() == "a" || answer.ToLower() == "c" || answer.ToLower() == "d") {

    isAnswerCorrect8 = false;

} if(isAnswerCorrect8 == false) {
    Console.WriteLine("Fel svar!");
    Console.WriteLine("tryck på enter för att fortsätta");
    Console.ReadLine();


}


Console.Clear();
Console.WriteLine($"Du har {score} poäng");

Console.WriteLine("Vilket land har mest invånare");
Console.WriteLine("");

Console.WriteLine(" a. USA");
Console.WriteLine(" b. Sverige");
Console.WriteLine(" c. Kina");
Console.WriteLine(" d. Indien");

answer = Console.ReadLine();

if(answer.ToLower() == "d") {

isAnswercorrect9 = true;

} if(isAnswercorrect9 == true) {
    score++;
    Console.WriteLine("Rätt svar!");
    Console.WriteLine($"Du har {score} poäng");
    Console.WriteLine("tryck enter för att fortsätta");
    Console.ReadLine();

} else if(answer.ToLower() == "a" || answer.ToLower() == "b" || answer.ToLower() == "c") {

    isAnswercorrect9 = false;

} if(isAnswercorrect9 == false) {
    Console.WriteLine("Fel svar!");
    Console.WriteLine("tryck på enter för att fortsätta");
    Console.ReadLine();

}


}