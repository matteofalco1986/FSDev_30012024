using System;

namespace CreatePersona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {

                Console.WriteLine("Ciao, come stai oggi?");
                Console.ReadLine();
                Console.WriteLine("Bene. Vuoi creare una persona?");
                Console.ReadLine();
                Persona myPerson = new Persona();
                Console.WriteLine("Ottimo. Scrivi di seguito nome, cognome ed età della persona che desideri creare");

                Console.Write("Nome: ");
                myPerson.Nome = Console.ReadLine();

                Console.Write("Cognome: ");
                myPerson.Cognome = Console.ReadLine();

                Console.Write("Eta: ");
                string myAge = Console.ReadLine();
                myPerson.Eta = int.Parse(myAge);

                Console.WriteLine("La persona che hai creato è: ");
                Console.WriteLine(myPerson.GetDettagli());
            }

            Console.WriteLine("Ora creo io una persona.");
            Persona otherPerson = new Persona("Caio", "Re di tutta l'Inghilterra");
            Console.WriteLine("Non so tuttavia quanti anni ha questa nuova persona. Puoi aiutarmi te?");
            Console.ReadLine();
            Console.WriteLine("Ottimo. Inserisci l'età qui di seguito");
            string otherPersonAge = Console.ReadLine();
            otherPerson.Eta = int.Parse(otherPersonAge);
            Console.WriteLine("La persona creata è:");
            Console.WriteLine(otherPerson.GetDettagli());
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
            _nome = "Mario";
            _cognome = "Rossi";
            _eta = 35;
            Console.WriteLine("\nDefault constructor called for Persona");
        }

        public Persona(string nome = "", string cognome = "", int eta = 0)
        {
            _nome = nome;
            _cognome = cognome;
            _eta = eta;
            Console.WriteLine("\nConstructor with default values called for Persona");
        }

        // DESTRUCTOR
        ~Persona()
        {
            Console.WriteLine("Destructor called for Persona");
        }



    }
}