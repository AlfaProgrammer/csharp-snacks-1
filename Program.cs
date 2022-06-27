// See https://aka.ms/new-console-template for more information



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

