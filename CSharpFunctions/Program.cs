// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] mioArray = { 2, 6, 7, 5, 3, 9 };
StampaArray(mioArray);

int[] mioArray2 = ElevaArrayAlQuadrato(mioArray);
StampaArray(mioArray2);

int sommaArray = sommaElementiArray(mioArray);
Console.WriteLine(sommaArray);

int sommaArray2 = sommaElementiArray(mioArray2);
Console.WriteLine(sommaArray2);

// Dichiarazione delle funzioni

void StampaArray(int[] array)
{
    int ultimoIndiceArray = array.Length - 1;
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == ultimoIndiceArray)
        {
            Console.Write(array[i]);
        }
        else
        {
            Console.Write(array[i] + ", ");
        }
    }
    Console.WriteLine("]");
}

int Quadrato(int numero)
{ 

int potenza = numero * numero;
    return potenza;
}

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] copiaArray = (int[])array.Clone();
    for (int i = 0; i < array.Length; i++)
    {

        copiaArray[i] = Quadrato(copiaArray[i]);
    }
    return copiaArray;

}
int sommaElementiArray(int[] array)
{
    int[] copiaArray = (int[])array.Clone();

    int somma = 0;

    for (int i = 0; i < array.Length; i++)
    {
        somma = somma + copiaArray[i];
    }
    return somma;
}



    

