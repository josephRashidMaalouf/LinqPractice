// See https://aka.ms/new-console-template for more information

using LinqPractice;

Console.WriteLine("Hello, World!");

List<Employee> employees = new Employees().EmployeeList;



// Where. Where används för att filtrera ut data ut en samling.
// Syntaxen är lista.Where(x => x.Age > 30);
//I exemplet ovan filtrerar vi ut alla personer som är äldre än 30 år.


//Övningar med Where

//1. filtrera ut alla personer som är äldre än 30 år och skriv ut listan till konsollen.


//2. filtrera ut alla personer som jobbar på avdelningen "Engineering" och skriv ut listan till konsollen.


//3. filtrera ut alla personer som har en lön över 70000 och skriv ut listan till konsollen.


//4. filtrera ut alla personer som har en lön över 70000 och är äldre än 30 år och skriv ut listan till konsollen.



// OrderBy. OrderBy används för att sortera data.
// Syntaxen är lista.OrderBy(x => x.Age);
// I exemplet ovan sorterar vi listan efter ålder.
// Om vi vill sortera i fallande ordning använder vi OrderByDescending.

//Övningar med OrderBy


//1. Sortera listan efter namn och skriv ut listan till konsollen.



//2. Sortera listan efter avdelning och skriv ut listan till konsollen.



//3. Sortera listan efter lön och skriv ut listan till konsollen.




//4. Sortera listan efter ålder i fallande ordning och skriv ut listan till konsollen.




// Select. Select används för att projicera data.
// Syntaxen är lista.Select(x => x.Name);
// I exemplet ovan projicerar vi ut alla namn från listan. Vi får då tillbaka en IEnumerable<string> med alla namn.


//Övningar med Select

//1. Skapa en lista av strängar med alla namn och skriv ut till konsollen.


//2. Skapa en lista av strängar med alla avdelningar och skriv ut till konsollen.


//3. Skapa en lista av ints med alla åldrar.


//4. AVANCERAD:
//Skapa en klass som heter Person med properties för Name, LastName och Age.
//Skapa en lista av Person-objekt och fyll den med relevant data från Employee-objekten.



//Linq metoder går att länka ihop. Detta gör att vi kan skriva flera metoder efter varandra.
//Exempel: lista.Where(x => x.Age > 30).OrderBy(x => x.Name);
//I exemplet ovan filtrerar vi ut alla personer som är äldre än  30 år och sorterar dem efter namn.


//Övningar med flera metoder


//1. Filtrera ut alla personer som är äldre än 30 år och sortera dem efter namn. Skriv ut listan till konsollen.


//2. Filtrera ut alla personer som jobbar på avdelningen "Engineering" och sortera dem efter lön. Skriv ut listan till konsollen.


//3. Filtrera ut alla personer som har en lön över 70000 och sortera dem efter ålder. Använd därefter select för att skapa en lista av strängar som innehåller namn och lön. Skriv ut listan till konsollen.


//4. AVANCERAD:
//Skapa en klass som heter Engineers med properties som du tycker är relevanta.
//Filtrera ut alla personer som jobbar på avdelningen "Engineering" och skapa en lista av Engineers-objekt som är sorterad efter ålder i fallander ordning. Skriv ut listan till konsollen.
