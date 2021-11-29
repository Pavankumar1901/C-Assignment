using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccination_Assignment
{
    class Program
    {
        
        static void Main(string[] args)
        {
           
            int i = 2000;
            int RegistraionNumber;
            string BenifiseryName, Date;
            long PhoneNumber;
            string city, Vaccine;
            int Age, DosageDone;
            string Gender;
            int UserChoise;
            Console.WriteLine("******************************************");
            Console.WriteLine("VACCINATION CENTER");
            Console.WriteLine("******************************************");
            Console.WriteLine("Choose any option ");
            Console.WriteLine("1.Benifisery Registraion\n2.Vaccination\n3.exit");
            UserChoise = int.Parse(Console.ReadLine());
            switch (UserChoise)
            {
                case 1:
                    BenifiseryDetails Detail = new BenifiseryDetails();
                    {
                        Console.WriteLine("Enter the Benifisery Name");
                        BenifiseryName = Console.ReadLine();
                        Console.WriteLine("Enter the Benifisery age");
                        Age = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the Benifisery Gender");
                        Gender = Console.ReadLine();
                        Console.WriteLine("Enter the Benifisery Phone number");
                        PhoneNumber = long.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the Benifisery City");
                        city = Console.ReadLine();

                        i = i + 1;
                        Console.WriteLine("Your Registraion is successful and your registration number is {0}", i);
                        Console.WriteLine("Do you want to Continue");
                        
                    }
                    break;

                case 2:
                    BenifiseryDetails Detail1 = new BenifiseryDetails();
                    {
                        RegistraionNumber = 1000;
                        BenifiseryName = "pavan";
                        PhoneNumber = 3655584545;
                        city = "chennai";
                        Age = 23;
                        Gender = "Male";
                        DosageDone = 0;
                       


                    }
                    BenifiseryDetails Detail2 = new BenifiseryDetails();
                    {
                        RegistraionNumber = 1001;
                        BenifiseryName = "Raj";
                        PhoneNumber = 3655345446545;
                        city = "Virudhunagar";
                        Age = 34;
                        Gender = "Male";
                        DosageDone = 1;
                        Date = "2 / 2 / 2020";


                    }
                    BenifiseryDetails Detail3 = new BenifiseryDetails();
                    {
                        RegistraionNumber = 1002;
                        BenifiseryName = "Ganesh";
                        PhoneNumber = 3685554545;
                        city = "Vilupuram";
                        Age = 23;
                        Gender = "Male";
                        DosageDone = 2;
                        Date = "3/ 3 / 2020";



                    }
                    List<BenifiseryDetails> BenifiseryDetails = new List<BenifiseryDetails>(3);
                    BenifiseryDetails.Add(Detail1);
                    BenifiseryDetails.Add(Detail2);
                    BenifiseryDetails.Add(Detail3);
                    Console.WriteLine("Enter the Benifisery Register number");
                    RegistraionNumber = int.Parse(Console.ReadLine());
                    if (RegistraionNumber == 1000)
                    {
                        Console.WriteLine("Choose any one");
                        Console.WriteLine("1.Take Vaccination\n2.Vaccination history\n3.next due Date\n4.Exit");
                        UserChoise = int.Parse(Console.ReadLine());
                        if (UserChoise == 1)
                        {
                            Detail1 = BenifiseryDetails[0];
                            Console.WriteLine("RegistraionNumber={0}\n BenifiseryName={1}\nPhoneNumber={2},\ncity={3}\n Age={4}\n Gender={5}", RegistraionNumber, BenifiseryName, PhoneNumber, city, Age, Gender);

                        }
                        if (UserChoise == 2)
                        {
                           
                        }
                        if (UserChoise == 3)
                        {

                        }
                    }

                    else if (RegistraionNumber == 1001)
                    {
                        Console.WriteLine("Choose any one");
                        Console.WriteLine("1.Take Vaccination\n2.Vaccination history\n3.next due Date\n4.Exit");
                        UserChoise = int.Parse(Console.ReadLine());
                        if (UserChoise == 1)
                        {
                            Detail1 = BenifiseryDetails[1];
                            Console.WriteLine("RegistraionNumber={0}\n BenifiseryName={1}\nPhoneNumber={2},\ncity={3}\n Age={4}\n Gender={5}", RegistraionNumber, BenifiseryName, PhoneNumber, city, Age, Gender);

                        }
                        if (UserChoise == 2)
                        {

                        }
                        if (UserChoise == 3)
                        {

                        }




                    }
                    else if (RegistraionNumber == 1002)
                    {

                        Console.WriteLine("Choose any one");
                        Console.WriteLine("1.Take Vaccination\n2.Vaccination history\n3.next due Date\n4.Exit");
                        UserChoise = int.Parse(Console.ReadLine());
                        if (UserChoise == 1)
                        {
                            Detail1 = BenifiseryDetails[2];
                            Console.WriteLine("RegistraionNumber={0}\n BenifiseryName={1}\nPhoneNumber={2},\ncity={3}\n Age={4}\n Gender={5}", RegistraionNumber, BenifiseryName, PhoneNumber, city, Age, Gender);

                        }
                        if (UserChoise == 2)
                        {

                        }
                        if (UserChoise == 3)
                        {

                        }


                    }
                    else if (RegistraionNumber != 1000 && RegistraionNumber != 1001 && RegistraionNumber != 1002)
                    {
                        Console.WriteLine("Vaccination Not done yet " );
                        Console.WriteLine("Enter the vaccine you want?");
                        Vaccine = Console.ReadLine();
                        if (Vaccine == "Covaccine") 
                        {
                            Console.WriteLine("Vaccination done");
                        }
                        else if (Vaccine == "Covisheiled")
                        {
                            Console.WriteLine("Vaccination done");
                        }



                    }
                    break;





                case 3:

                    Console.WriteLine("Thankyou let's Make India covid Free");
                    break;

            }
            Console.ReadKey();




        }
    }
}



























