using System;

namespace HomeworkT2L7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program 1");

            int a = 5;
            int b = 5;

            if(a==b)
            {
                Console.WriteLine($"{a} i {b} są równe");
            }
            else
            {
                Console.WriteLine($"{a} i {b} nie są równe");
            }

            /////////////////////////////////////////////////////////
            Console.WriteLine("Program 2");

            int liczba;
            Console.WriteLine("Podaj liczbę: ");
            liczba = int.Parse(Console.ReadLine());


            if(liczba % 2 == 0)
            {
                Console.WriteLine($"{liczba} jest liczbą parzystą");
            }
            else
            {
                Console.WriteLine($"{liczba} jest liczbą nieparzystą");
            }

            /////////////////////////////////////////////////////////
            Console.WriteLine("Program 3");
            int liczba1;
            Console.WriteLine("Podaj liczbę: ");
            liczba1 = int.Parse(Console.ReadLine());

            if (liczba>=0)
            {
                Console.WriteLine($"{liczba1} jest liczbą dodatnią");
            }
            else
            {
                Console.WriteLine($"{liczba1} jest liczbą ujemną");
            }
            /////////////////////////////////////////////////////////
            Console.WriteLine("Program 4");

            int rok;
            Console.WriteLine("Podaj rok: ");
            rok = int.Parse(Console.ReadLine());

            if (rok % 4 == 0)
            {
                Console.WriteLine($"{rok} jest rokiem przestępnym");
            }
            else
            {
                Console.WriteLine($"{rok} jest rokiem nieprzestępnym");
            }

            /////////////////////////////////////////////////////////
            Console.WriteLine("Program 5");

            int wiek;
            Console.WriteLine("Podaj wiek: ");
            wiek = int.Parse(Console.ReadLine());

            if (wiek>=21 && wiek<30)
            {
                Console.WriteLine("Możesz zostać posłem i premierem");
            }
            else if(wiek>=30 && wiek<35)
            {
                Console.WriteLine("Możesz zostać senatorem");
            }
            else if(wiek>=35)
            {
                Console.WriteLine("Możesz zostać prezydentem");
            }
            else
            {
                Console.WriteLine("Nie możesz jeszcze zostać posłem,premierem,senatorem lub prezydentem");
            }

            /////////////////////////////////////////////////////////
            Console.WriteLine("Program 6");

            int wzrost;
            Console.WriteLine("Podaj wzrost: ");
            wzrost = int.Parse(Console.ReadLine());

            if(wzrost <=140)
            {
                Console.WriteLine("Jesteś krasnoludem");
            }
            else if(wzrost>140 && wzrost<=160)
            {
                Console.WriteLine("Jesteś mały");
            }
            else if (wzrost > 160 && wzrost <= 180)
            {
                Console.WriteLine("Jesteś średni");
            }
            else if (wzrost > 180 && wzrost <= 200)
            {
                Console.WriteLine("Jesteś wysoki");
            }
            else
            {
                Console.WriteLine("Jesteś gigantem");
            }

            /////////////////////////////////////////////////////////
            Console.WriteLine("Program 7");

            int l1,l2,l3;
            Console.WriteLine("Podaj liczby: ");
            l1 = int.Parse(Console.ReadLine());
            l2 = int.Parse(Console.ReadLine());
            l3 = int.Parse(Console.ReadLine());

            if(l1 > l2 && l1>l3)
            {
                Console.WriteLine($"{l1} jest największa z podanych");
            }
            else if (l2 > l1 && l2 > l3)
            {
                Console.WriteLine($"{l2} jest największa z podanych");
            }
            else
            {
                Console.WriteLine($"{l3} jest największa z podanych");
            }

            /////////////////////////////////////////////////////////
            Console.WriteLine("Program 8");

            int matma, fizyka, chemia;
            Console.WriteLine("Podaj wynik matury z matematyki: ");
            matma = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wynik matury z fizyki: ");
            fizyka = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wynik matury z chemii: ");
            chemia = int.Parse(Console.ReadLine());
            int wynik = chemia + fizyka + chemia;
            int matfiz = matma + fizyka;
            int matchem = matma + chemia;

            if((matma>55 && fizyka>55 && chemia>45 && wynik>180 )|| (matfiz > 150 || matchem > 150))
            {
                Console.WriteLine("Kandydat dopuszczony do rekrutacji");
            }
            
            else
            {
                Console.WriteLine("Kandydat niedopuszczony do rekrutacji");
            }

            /////////////////////////////////////////////////////////
            Console.WriteLine("Program 9");

            int temp;
            Console.WriteLine("Podaj temperature: ");
            temp = int.Parse(Console.ReadLine());

            if(temp<0)
            {
                Console.WriteLine("Cholernie piździ");
            }
            else if(temp>0 && temp<=10)
            {
                Console.WriteLine("Zimno");
            }
            else if (temp > 10 && temp <= 20)
            {
                Console.WriteLine("Chłodno");
            }
            else if (temp > 20 && temp <= 30)
            {
                Console.WriteLine("W sam raz");
            }
            else if (temp > 30 && temp <= 40)
            {
                Console.WriteLine("Zaczyna być słabo, bo gorąco");
            }
            else
            {
                Console.WriteLine("A weź wyprowadzam się na Alaskę");
            }

            /////////////////////////////////////////////////////////
            Console.WriteLine("Program 10");

            int d1,d2,d3;
            Console.WriteLine("Podaj liczby: ");
            d1 = int.Parse(Console.ReadLine());
            d2 = int.Parse(Console.ReadLine());
            d3 = int.Parse(Console.ReadLine());

            if((d1<d2+d3) && (d2<d1+d3) && (d3<d2+d1))
            {
                Console.WriteLine("Można zbudować trójkąt");
            }
            else
            {
                Console.WriteLine("Nie można zbudować trójkąta");
            }

            /////////////////////////////////////////////////////////
            Console.WriteLine("Program 11");


            Console.WriteLine("Podaj ocene: ");
            int ocena = int.Parse(Console.ReadLine());

            switch(ocena)
            {
                case 1:
                    Console.WriteLine("Niedostateczny");
                    break;
                case 2:
                    Console.WriteLine("Dopuszczający");
                    break;
                case 3:
                    Console.WriteLine("Dostateczny");
                    break;
                case 4:
                    Console.WriteLine("Dobry");
                    break;
                case 5:
                    Console.WriteLine("Bardzo dobry");
                    break;
                case 6:
                    Console.WriteLine("Celujący");
                    break;
                default:
                    Console.WriteLine("Nie podałeś oceny");
                    break;
            }

            /////////////////////////////////////////////////////////
            Console.WriteLine("Program 12");

            Console.WriteLine("Podaj dzień: ");
            int dzien = int.Parse(Console.ReadLine());

            switch (dzien)
            {
                case 1:
                    Console.WriteLine("Poniedziałek");
                    break;
                case 2:
                    Console.WriteLine("Wtorek");
                    break;
                case 3:
                    Console.WriteLine("Środa");
                    break;
                case 4:
                    Console.WriteLine("Czwartek");
                    break;
                case 5:
                    Console.WriteLine("Piątek");
                    break;
                case 6:
                    Console.WriteLine("Sobota");
                    break;
                case 7:
                    Console.WriteLine("Niedziela");
                    break;
                default:
                    Console.WriteLine("Nie podałeś dnia");
                    break;
            }

            /////////////////////////////////////////////////////////
            Console.WriteLine("Program 13");


            Console.WriteLine("Podaj pierwszą liczbę: ");
            int f1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę: ");
            int f2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj numer operacji do wykonania: ");
            Console.WriteLine("1.Dodawanie");
            Console.WriteLine("2.Odejmowanie");
            Console.WriteLine("3.Mnożenie");
            Console.WriteLine("4.Dzielenie");

            int operation = int.Parse(Console.ReadLine());

            switch(operation)
            {
                case 1:
                    Console.WriteLine($"Wynik dodawania to {f1 + f2}");
                    break;
                case 2:
                    Console.WriteLine($"Wynik odejmowania to {f1 - f2}");
                    break;
                case 3:
                    Console.WriteLine($"Wynik mnożenia to {f1 * f2}");
                    break;
                case 4:
                    Console.WriteLine($"Wynik dzielenia to {f1 / f2}");
                    break;
                default:
                    Console.WriteLine("Wybrałeś nieistniejącą operacje");
                    break;
            }
        }
    }
}
