namespace Errorhandling
{
        internal class Program
        {
            static void Main(string[] args)
            {
                int number1;
                int number2;
                double result = 0;
                int Checknumber1 = 0;
                int Checknumber2 = 0;
                double Finalnumber1 = 0;
                double Finalnumber2 = 0;
                string again = null;

                while (true)
                {

                    try
                    {
                        int[] numbers = new int[5];
                        numbers[0] = 0;
                        numbers[1] = 10;
                        numbers[2] = 20;
                        numbers[3] = 30;
                        numbers[4] = 40;

                        Console.WriteLine("Syötä Ensimmäinen luku 0-4");
                        number1 = Convert.ToInt32(Console.ReadLine());
                        Checknumber1 = numbers[number1];

                        Console.WriteLine("Syötä Toinen luku 0-4");
                        number2 = Convert.ToInt32(Console.ReadLine());
                        Checknumber2 = numbers[number2];

                        int check = Checknumber1 / Checknumber2;

                        Finalnumber1 = Checknumber1;
                        Finalnumber2 = Checknumber2;
                        result = Finalnumber1 / Finalnumber2;
                        Console.WriteLine($"Vastaus on: {result}");

                        while (true)
                        {
                            Console.WriteLine("Haluatko laskea uudelleen");
                            Console.WriteLine("1. Kyllä");
                            Console.WriteLine("2. Ei");
                            again = Console.ReadLine();

                            if (again == "1")
                            {
                                Console.WriteLine("Lasketaan uudelleen");
                                break;
                            }
                            else if (again == "2")
                            {
                                Console.WriteLine("Et halunnut laskea uudelleen");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Valitse jompikumpi vaihtoehto");
                            }
                        }
                        if (again == "2")
                        {
                            break;
                        }
                    }
                    catch (IndexOutOfRangeException e)
                    {
                        Console.WriteLine("Luvun on oltava väliltä 0-4");
                        Console.WriteLine(e.Message);
                    }
                    catch (System.FormatException s)
                    {
                        Console.WriteLine("Syöte ei ollut hyväksyttävä");
                        Console.WriteLine(s.Message);
                    }
                    catch (DivideByZeroException d)
                    {
                        Console.WriteLine("Nollalla ei voi jakaa!");
                        Console.WriteLine(d.Message);
                    }
                    finally
                    {
                        Console.WriteLine("Suoritetaan finally lohko");
                    }

                }

                Console.ReadKey();
            }
        }
    }