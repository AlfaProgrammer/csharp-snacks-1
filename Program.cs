// See https://aka.ms/new-console-template for more information

/*SNACK5*/
/*
   Chiedere all'utente di inserire un numero
   Se il numero è pari stampare il numero stesso, se è dispari stampare il successivo 
 */

Console.WriteLine("Inserisci un numero: ");
int userNumber = int.Parse(Console.ReadLine());

int nToPrint;
if (userNumber % 2 == 0)
{
    nToPrint = userNumber;
}
else {
    nToPrint = userNumber + 1;
}

Console.WriteLine($"Il tuo numero è: {nToPrint}");

/*SNACK 4*/
int somma = 0;
double media;
int contatore = 0;
for (int i = 2; i <= 10; i++)
{
    somma += i;
    contatore++;
}

media = somma / contatore;
Console.WriteLine($"La somma dei numer è {somma}");
Console.WriteLine($"La media dei numer è {media}");


/*SNACK 3*/

int[] numbers = new int[10];
int sum = 0;

Console.WriteLine("Inserisci un numero: ");

for (int i = 0; i < numbers.Length; i++) {
    int userNumber = int.Parse(Console.ReadLine());
    sum += userNumber;
}

Console.WriteLine(sum);  
