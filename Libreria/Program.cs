// See https://aka.ms/new-console-template for more information
bool continua = true;
while (continua == true)
{
    Console.WriteLine("Cosa vuoi fare? Inserire libro (1), cancellare libro (2), Ricerca libro (3), Termina (4)");
    string scelta = Console.ReadLine();
    int iscelta;
    bool result = int.TryParse(scelta, out iscelta);
    if (result == true)
    {
        switch (iscelta)
        {
            case 1: // Inserisci libro
                Console.WriteLine("Inserimento libro");
                string titolo = Console.ReadLine();
                Console.WriteLine("Inserisci autore");
                string autore = Console.ReadLine();
                // Gestione lettura anno da utente
                bool ok = true;
                int year = 0;
                while (ok == true)
                {
                    Console.WriteLine("Inserisci anno");
                    string anno = Console.ReadLine();
                    bool corretto = int.TryParse(anno, out year);
                    if (corretto == true)
                        ok = false;
                }
                Console.WriteLine("Inserimento libro");
                break;
            case 2:
                Console.WriteLine("Cancellazione libro");
                break;
            case 3:
                Console.WriteLine("Ricerca libro");
                break;
            case 4:
                continua = false; //Per uscire dal ciclo while
                break;
            default:
                Console.WriteLine("Altro");
                break;

        }
    }
    else
    {
        Console.WriteLine("La scelta inserita non è correta");
    }
}
Console.WriteLine("Grazie per aver usato il programma");