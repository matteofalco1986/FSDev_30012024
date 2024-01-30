using System;

namespace CreatePersona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isDone = false;

            Console.WriteLine("Ciao, come stai oggi?");
            Console.ReadLine();
            Console.WriteLine("Vuoi creare una persona?");
            if (Console.ReadLine() == "no")
            {
                Console.WriteLine("Bene, grazie per NON aver usato il nostro programma");
                return;
            }

            Persona myPerson = new Persona();
            while (!isDone)
            {
                Console.WriteLine("Ottimo. Scrivi di seguito nome, cognome ed età della persona che desideri creare");


                bool isCorrect = false;
                while (!isCorrect)
                {
                    Console.Write("Nome: ");
                    myPerson.Nome = Console.ReadLine();
                    if (myPerson.Nome.Length < 2)
                    {
                        Console.WriteLine("Il nome della persona deve essere almeno di due caratteri");
                        Console.WriteLine("Per piacere, inserisci un nome valido");
                    }
                    else
                    {
                        isCorrect = true;
                    }
                }

                isCorrect = false;
                Console.WriteLine("Ora inserisci il cognome.");
                while (!isCorrect)
                {
                    Console.Write("Cognome: ");
                    myPerson.Cognome = Console.ReadLine();
                    if (myPerson.Cognome.Length < 2)
                    {
                        Console.WriteLine("Il cognome della persona deve essere almeno di due caratteri");
                        Console.WriteLine("Per piacere, inserisci un cognome valido");
                    }
                    else
                    {
                        isCorrect = true;
                    }
                }

                isCorrect = false;
                while (!isCorrect)
                {
                    Console.Write("Eta: ");
                    string myAge = Console.ReadLine();
                    myPerson.Eta = int.Parse(myAge);
                    if(myPerson.Eta < 0)
                    {
                        Console.WriteLine("La tua persona non può avere meno di 0 anni.");
                        Console.WriteLine("Per piacere, inserisci un età valida: ");
                    }
                    else
                    {
                        isCorrect = true;
                    }
                }

                Console.WriteLine("La persona che hai creato è: ");
                Console.WriteLine(myPerson.GetDettagli());

                Console.WriteLine("Vuoi creare un'altra persona?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "no")
                {
                    isDone = true;
                }
            }




            isDone = false;
            Console.WriteLine("Ok ora creo io una persona.");
            while (!isDone)
            {
                Persona otherPerson = new Persona("Caio", "Re di tutta l'Inghilterra");
                Console.WriteLine("Non so quanti anni ha questa nuova persona. Puoi aiutarmi te?");
                Console.ReadLine();
                Console.WriteLine("Ottimo. Inserisci l'età qui di seguito");
                string otherPersonAge = Console.ReadLine();
                otherPerson.Eta = int.Parse(otherPersonAge);
                Console.WriteLine("La persona creata è:");
                Console.WriteLine(otherPerson.GetDettagli());
                Console.WriteLine("Vuoi creare un'altra persona?");
                string answer = Console.ReadLine().ToLower();
                if (answer == "no")
                {
                    isDone = true;
                    Console.WriteLine("Grazie per aver usato il nostro programma. Tanti saluti");
                }
                else
                {
                    Console.WriteLine("Ok, creiamo un'altra persona.");
                }
            }
        }
    }


    public class Persona
    {
        // FIELDS
        private string _nome;
        private string _cognome;
        private int _eta;

        // PROPERTIES
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }
        public string Cognome
        {
            get
            {
                return _cognome;
            }
            set
            {
                _cognome = value;
            }
        }
        public int Eta
        {
            get
            {
                return _eta;
            }
            set
            {
                if (value >= 0)
                {
                    _eta = value;
                }
            }
        }

        // GET ALL DETAILS
        public string GetDettagli()
        {
            return $"{Nome} {Cognome} e ha {Eta} anni.";
        }

        // CONSTRUCTORS

        public Persona()
        {
            _nome = "";
            _cognome = "";
            _eta = -1;
            Console.WriteLine("\nDefault constructor called for Persona\n");
        }

        public Persona(string nome = "", string cognome = "", int eta = 0)
        {
            _nome = nome;
            _cognome = cognome;
            _eta = eta;
            Console.WriteLine("\nConstructor with default values called for Persona\n");
        }

        // DESTRUCTOR
        ~Persona()
        {
            Console.WriteLine("Destructor called for Persona\n");
        }
    }
}