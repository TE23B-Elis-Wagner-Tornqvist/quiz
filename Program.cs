using System.Data.Common;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

void rätt(ref int score) {                    //refererar till score så att jag kan ändra valutan av score
    score++;
    Console.WriteLine("""
   _____                         _   _ 
  / ____|                       | | | |
 | |     ___  _ __ _ __ ___  ___| |_| |
 | |    / _ \| '__| '__/ _ \/ __| __| |
 | |___| (_) | |  | | |  __/ (__| |_|_|
  \_____\___/|_|  |_|  \___|\___|\__(_)
                                       
                                       
""");
    Console.WriteLine("Rätt svar!");
    Console.WriteLine($"Du har {score} poäng");                      //en funktion så att jag slipper skriva samma kod om och omg igen. funktion om man svarar rätt
    Console.WriteLine("tryck enter för att fortsätta");         
    Console.ReadLine();


}

void fel(ref int score) {

score--;

Console.WriteLine("""

 __          __                    _ 
 \ \        / /                   | |
  \ \  /\  / / __ ___  _ __   __ _| |
   \ \/  \/ / '__/ _ \| '_ \ / _` | |
    \  /\  /| | | (_) | | | | (_| |_|
     \/  \/ |_|  \___/|_| |_|\__, (_)
                              __/ |  
                             |___/   

""");

 Console.WriteLine("Fel svar!");
 Console.WriteLine($"Du har {score} poäng");                  //säger hur många poäng du har
    Console.WriteLine("tryck på enter för att fortsätta");         //också en funktion fast för om man svarar fel
    Console.ReadLine();

}

string input() {

while(true) {
string input = Console.ReadLine().ToLower() ?? string.Empty;
if(input.Length == 1 && "abcd".Contains(input)) {
    return input;
} else {

    Console.WriteLine("Du måste skriva a,b,c eller d!");
}

    }


}





int score = 0; //poängen börjar på 0

while(true) {     // så att koden loopas
 



Console.WriteLine("Hej spelare! Välkommen till en frågesport!");
Console.WriteLine("Du kommer att få 10 frågor och för varje rätt svar får du 1 poäng och för varje fel svar förlorar du 1 poäng");
Console.WriteLine("Lycka till!");
Console.WriteLine("tryck enter för att starta spelet");
Console.ReadLine();
Console.Clear();
Console.WriteLine($"poäng: {score}");         //skriver ut poängen högst upp
Console.WriteLine("Vad heter huvudstaden i Autralien?");





Console.WriteLine("");        //space mellan fråga och alternativen

Console.WriteLine(" a. melbourne");
Console.WriteLine(" b. sydney"); 
Console.WriteLine(" c. canberra");       //alternativen
Console.WriteLine(" d. Brisbane");

string answer = input(); //s

if(answer.ToLower() == "c") {       //ifall ma nskriver in c så är svaret rätt och det som är i if satsen körs
   
    rätt(ref score);  // här skriver den allt som är i funktionen rätt
    
} else if(answer.ToLower() == "a" || answer.ToLower() == "b" || answer.ToLower() == "d") { //ifall man skriver in a,b eller d så är svaret fel och det som står i else if satsen körs
     fel(ref score);      //skriver/gör allt som är i funktionen fel
}

Console.Clear();                              // clear console från förra frågan
Console.WriteLine($"poäng: {score}");    // skirver om poängen högst upp

Console.WriteLine("Vad heter huvudstaden i USA?");
Console.WriteLine("");
Console.WriteLine(" a. New York");                   //samma som förra frågan
Console.WriteLine(" b. Washington D.C");
Console.WriteLine(" c. Los Angeles");
Console.WriteLine(" d. san francisco");

answer = input();





if(answer.ToLower() == "b") {
     rätt(ref score);                                   // allt detta är samma som förra frågan

} else if(answer.ToLower() == "a" || answer.ToLower() == "c" || answer.ToLower() == "d") {
    fel(ref score);

}

Console.Clear();
Console.WriteLine($"poäng: {score}");

Console.WriteLine("Vad heter det högsta berget i världen?");
Console.WriteLine("");

Console.WriteLine(" a. Kebnekaise");
Console.WriteLine(" b. Manaslu");            //samma som förra frågan
Console.WriteLine(" c. K2");
Console.WriteLine(" d. Mount Everest");

answer = input();

if(answer.ToLower() == "d") {
     rätt(ref score);

} else if(answer.ToLower() == "a" || answer.ToLower() == "b" || answer.ToLower() == "c") {
     fel(ref score);

}
Console.Clear();
Console.WriteLine($"poäng: {score}");

Console.WriteLine("I vilken kontinent är världens största öken?");
Console.WriteLine("");
Console.WriteLine(" a. europa");
Console.WriteLine(" b. afrika");                 //samma
Console.WriteLine(" c. antarktis");
Console.WriteLine(" d. asien");

answer = input();

if(answer.ToLower() == "c") {
    rätt(ref score);

} else if(answer.ToLower() == "a" || answer.ToLower() == "b" || answer.ToLower() == "d") {
    fel(ref score);

}

Console.Clear();
Console.WriteLine($"poäng: {score}");

Console.WriteLine("Vilket land har mest öar i världen?");
Console.WriteLine("");

Console.WriteLine(" a. Sverige");
Console.WriteLine(" b. Norge");               //samma
Console.WriteLine(" c. Indonesien");
Console.WriteLine(" d. Australien");

answer = input();

if(answer == "a") {
    rätt(ref score);
    
} else if(answer.ToLower() == "b" || answer.ToLower() == "c" || answer.ToLower() == "d") {
     fel(ref score);

}

Console.Clear();
Console.WriteLine($"poäng {score}");

Console.WriteLine("Hur många grannländer har Tyskland?");

Console.WriteLine("");

Console.WriteLine(" a. 9");
Console.WriteLine(" b. 6");   //samma
Console.WriteLine(" c. 10");
Console.WriteLine(" d. 4");

answer = input();

if(answer == "a") {
    rätt(ref score);

} else if (answer.ToLower() == "b" || answer.ToLower() == "c" || answer.ToLower() == "d") {
    fel(ref score);

}

Console.Clear();
Console.WriteLine($" poäng: {score}");

Console.WriteLine("Vad heter floden som rinner igenom paris?");

Console.WriteLine("");

Console.WriteLine(" a. Fiene");      //samma
Console.WriteLine(" b. Seine");
Console.WriteLine(" c. Donau");
Console.WriteLine(" d. jacksón");

answer = input();

if(answer == "b") {
    rätt(ref score);

} else if(answer.ToLower() == "b" || answer.ToLower() == "c" || answer.ToLower() == "d") {
    fel(ref score);

}

Console.Clear();
Console.WriteLine($" Du har {score} poäng");

Console.WriteLine("Vilket land är störst i världen?");
Console.WriteLine("");
Console.WriteLine(" a. USA");
Console.WriteLine(" b. Ryssland");      //samma
Console.WriteLine(" c. USA");
Console.WriteLine(" d. Kanada");

answer = input();

if(answer.ToLower() == "b") {
    rätt(ref score); 

} else if(answer.ToLower() == "a" || answer.ToLower() == "c" || answer.ToLower() == "d") {
     fel(ref score);

}


Console.Clear();
Console.WriteLine($"Du har {score} poäng");

Console.WriteLine("Vilket land har mest invånare");
Console.WriteLine("");

Console.WriteLine(" a. USA");
Console.WriteLine(" b. Sverige");     //samma
Console.WriteLine(" c. Kina");
Console.WriteLine(" d. Indien");

answer = input();

if(answer.ToLower() == "d") {
 rätt(ref score); }

else if(answer.ToLower() == "a" || answer.ToLower() == "b" || answer.ToLower() == "c") {
 fel(ref score);
}

Console.Clear();
Console.WriteLine($"Du har {score} poäng");

Console.WriteLine("");
Console.WriteLine("Detta är sista frågan! ");
Console.WriteLine("");
Console.WriteLine("Vilket lands population är gladast i hela världen?");
Console.WriteLine("");

Console.WriteLine(" a. USA");
Console.WriteLine(" b. Sverige");     //samma
Console.WriteLine(" c. Peru");
Console.WriteLine(" d. Finland");

answer = input();

if(answer.ToLower() == "d") {

    rätt(ref score);

} else if(answer.ToLower() == "a" || answer.ToLower() == "b" || answer.ToLower() == "c") {

    fel(ref score);

}


Console.Clear();

Console.WriteLine($"Ditt slutgiltiga poäng är: {score}"); //skriver ut slutgiltiga poängen
Console.WriteLine("Dessa är kraven för de olika betygen du kan få:");
Console.WriteLine("<=0 poäng = F");
Console.WriteLine("0-3 poäng = E");
Console.WriteLine("4-5 poäng = D");
Console.WriteLine("5-6 poäng = C");               //skriver ut vilka poäng man behöver för olika betyg
Console.WriteLine("7-8 poäng = B");
Console.WriteLine("9-10 poäng = A");

Console.WriteLine("tryck enter för att se ditt betyg");
Console.ReadLine();
Console.Clear();

Console.WriteLine($"eftersom du fick {score} poäng så får du betyget:");         //skriver igen ut hur många betyg man fick

if(score <= 0) {
    Console.WriteLine("F");
} else if(score >= 0 && score <= 3) {
    Console.WriteLine("E");
} else if(score >= 4 && score <= 5) {             // de olika alternativen för de olika mängden poäng man fick
    Console.WriteLine("D");
} else if(score >= 6 && score <= 7) {
    Console.WriteLine("C");
} else if(score >= 8 && score <= 9) {
    Console.WriteLine("B");
} else if(score == 10) {
    Console.WriteLine("A");

}

Console.WriteLine("Vill du spela igen? (ja/nej)");


string playAgain = Console.ReadLine() ?? string.Empty;      

if(playAgain.ToLower() == "nej") {       // ifall spelaren skriver nej, stängs konsolen ner
    break;
} else if(playAgain.ToLower() == "ja") {
    score = 0;
    Console.Clear();          // om spelaren skriver ja så börjar spelet om genom att starta loopen från början och poängen blir 0
    continue;

}

 

}







