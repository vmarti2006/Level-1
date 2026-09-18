// introduccio
Console.WriteLine("Nota de pràctiques: ");
var not_prac = Console.ReadLine()!;
int np = Int32.Parse(not_prac);

Console.WriteLine("Nota de  l'examen: ");
var not_exa = Console.ReadLine()!;
int ne = Int32.Parse(not_exa);

// Calcul
float prob = (np + ne) /2;
int final = (np + ne) /2;

// Resultat

Console.WriteLine($"La nota final és {prob} o sigui un {final}");