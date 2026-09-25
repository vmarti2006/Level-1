using System.Runtime.CompilerServices;
internal class Program
{
    private static void Main(string[] args)
    {
        
        string ComprobaEdat(int edat, int edatminima)
        {
            if (edat < edatminima) { return "Endavant cavaller! Ja pots entrar al castell."; }
            return "Ho sento cavaller, no pots entrar al castell.";
        }
        
        var edatminima = 18;
        int edat = 0;
        int comptador = 0;
        var resultat="";

        do{
        try {
            // Info
            Console.WriteLine("Quina edat tens? ");
            var edat_1 = Console.ReadLine()!;
            edat = int.Parse(edat_1);

            if (edat < 0 || edat > 130)
            {
                throw new Exception("Aquesta edat es imposible");
            }
            comptador++;
            //Comprovar la contraseña

            resultat = ComprobaEdat(edat, edatminima);

            //Imprimir resultat
            Console.WriteLine(resultat);
        ;
        }
        catch (FormatException)
        {
            Console.WriteLine("La edat a de ser un numero");
        }
        catch (Exception ex) 
        { Console.WriteLine(ex.Message); }
        }
        while(resultat!="Endavant cavaller! Ja pots entrar al castell." && comptador==1);
        
    }
}