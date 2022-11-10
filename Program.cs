// See https://aka.ms/new-console-template for more information

// type name = 'expression'


//int numar intreg
//byte - 0-255
//long - number super huge
//float- nunmbere cu virgula
// char - se stocheaza caractere ( un singur caracter)
// bool - true (1) sau false (0)
// string - siruri de caractere
// datetime- data
// poate sa tina numere intre anumite intervale- se pune f.
//double- douple precision, numere cu virgula. doar ca dif cu float te intinzi super super mult
//folosim double ca sa avem precizia cea mai buna
// var-  scapam de type . in mod automat variabila mea da direct. tot codul dupa o sa fie var. dar dupa o sa fie pe var
//acum la inceput definim manual- dupa trecem pe var. in teme nu e voie.
// o variabila este unica. numele sa fie cat mai explicativ si logic.

// type casting- putem duce int -= long -= float --=double . fiecare incape in cealanta
// problema este invers, de la double la float la long la int la char
//cw prescurtare pentru console.writeline()

//sa vrei de la utilizare input  - console.readline() // by default string

// control k, control c - add comments.

// comentariile nu prea ajuta la un clean code

// operatori aritmetici
// + addition
// - substraction
// * multiplication
// / division
// ++ increment
// -- decrement
// % modulus ne returneaza rezultatul impartirii la nr ce dam noi
/*int number = 100;
float number2 = 100.2f;
char character = 'a';
string nyName = "Alex";

int firstnum = 5;
int secondnum = 3;
int sum = firstnum + secondnum;


string name = Console.ReadLine();
Console.WriteLine(sum);
Console.WriteLine(number);
Console.WriteLine("Salut" + name);

// asta este un programel pentru convert , input catre ce ne intereseaza pe noi
string input = Console.ReadLine();
int age = Convert.ToInt32(input);
Console.WriteLine("varsta este de "+age);


// operatori
int summary = 3 + 2;
double num1 = 10;
double num2 = 3;
double div = num1 / num2;
Console.WriteLine(div); */
/*
int number = 5;
int secondnum = number++; // increment se intampla dupa linia de cod. daca vreau sa apara 6 second numer pun -- inainte de variabila
int result = 10 % 3;
Console.WriteLine(result);
*/

// operatori de assignare , = de ex , dar mai multi si alti operatori

//int x = 5;
//x = x + 5;
// += 6; -=4

// operator de comparare
// == equal to
// != not equal
// > greater than
// < less than
// >= greater or equal to
// <= less or equal to

//operatori logici
// && logical and
// || logical or
// ! logical not



// block if
// if

/*bool conditie = true;
if (conditie) 
{

}*/

// if , else ( se executa daca conditia este falsa
// este si ideea de else if . in general de evitat.  ideea e sa mergem cat mai putine if else if else

int day = 6; // vreau sa afisceze ziua de sambata, sa evit else if else if . la fiecare o console.writeline ( miercuri )
switch (day)
{
    case 0:
        Console.WriteLine("luni");

        break;
    case 1:
        Console.WriteLine("marti");
        break;
    default:
        Console.WriteLine("ziua nu este ");
        break;
}

