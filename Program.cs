using System;
using System.Threading;

static class Program
{
    public static double ErgebnisCase3 { get; private set; }

    public static void Main()
    {
        Console.WriteLine("Hallo Das ist die erste Kollaborationssoftware von ILBA23\n");
        Thread.Sleep(1000);
        //User entscheidet welche Funktion er laufen haben will
        //SwitchCase + While

        string programlauft = "yes";
        while (programlauft == "yes")
        {
            //clean list to choose a calc function in console
            Console.WriteLine("Welche Funktion möchtest du ausführen?\n\n");
            Thread.Sleep(1000);
            Console.WriteLine("0 = Pythagoras\n1 = Addition\n2 = Subtraktion\n3 = Multiplikation\n4 = Division\n5 = Modulo\n6 = Potenzierung\n7 = Quadratwurzel\n8 = Kubikwurzel\n9 = Logarithmus\n10 = Logarithmusbasis10\n11 = Sinus\n12 = Cosinus\n13 = Tangens\n14 = Arcsinus\n15 = Arccosinus\n16 = Arctangens\n17 = HyperbolischerSinus\n18 = HyperbolischerCosinus\n19 = HyperbolischerTangens\n20 = GradZuBogenmaß\n21 = BogenmaßZuGrad\n22 = Binomialkoeffizient\n23 = Fakultät\n24 = Primzahltest\n25 = GGT\n26 = KGV\n27 = ArithmetischeReihe\n28 = GeometrischeReihe\n29 = Zinseszinsen\n30 = SummeErstenNPrimzahlen\r\n");
            String Entscheidung;
            Entscheidung = Console.ReadLine();

            switch (Entscheidung)
            {
                //Pythagoras
                case "0":
                    Console.WriteLine("Gib mir die erste Katete");
                    double katete1;
                    while (true)
                    {
                        try
                        {
                            katete1 = Convert.ToDouble(Console.ReadLine());
                            break; // exit the loop if conversion is successful
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                        }
                    }

                    Console.WriteLine("Gib mir die zweite Katete");
                    double katete2;
                    while (true)
                    {
                        try
                        {
                            katete2 = Convert.ToDouble(Console.ReadLine());
                            break; // exit the loop if conversion is successful
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                        }
                    }

                    double ErgebnisAufgabe1 = pytRechner(katete1, katete2);
                    Console.WriteLine(ErgebnisAufgabe1);
                    break;

                // Placeholder for case 1
                case "1": // Addition
                    double Summand1 = 0, Summand2 = 0;
                    Console.WriteLine("Gib mir die erste Summand");
                    while (true)
                    {
                        try
                        {
                            Summand1 = Convert.ToDouble(Console.ReadLine());
                            break; // exit loop if successful
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                        }
                    }

                    Console.WriteLine("Gib mir die zweite Summand");
                    while (true)
                    {
                        try
                        {
                            Summand2 = Convert.ToDouble(Console.ReadLine());
                            break; // exit loop if successful
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                        }
                    }

                    double SummevonSummand1und2 = addieren(Summand1, Summand2);
                    Console.WriteLine("Das Ergebnis lautet: " + SummevonSummand1und2);
                    break;

                // Placeholder for case 2
                case "2": // Subtraktion
                    double wert1 = 0, wert2 = 0;
                    Console.WriteLine("Bitte gib den ersten Wert ein");
                    while (true)
                    {
                        try
                        {
                            wert1 = Convert.ToDouble(Console.ReadLine());
                            break; // exit loop if successful
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                        }
                    }

                    Console.WriteLine("Bitte gib den zweiten Wert ein");
                    while (true)
                    {
                        try
                        {
                            wert2 = Convert.ToDouble(Console.ReadLine());
                            break; // exit loop if successful
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                        }
                    }

                    double ergebnisSubtraktion = Subtraktion(wert1, wert2);
                    Console.WriteLine($"Das Ergebnis der Subtraktion ist: {ergebnisSubtraktion}");
                    break;

                // Placeholder for case 3
                case "3":
                    double Multiplikand = 0, Multiplikator = 0;
                    Console.WriteLine("Gib mir bitte die erste zu multiplizierende Zahl");
                    while (true)
                    {
                        try
                        {
                            Multiplikand = Convert.ToDouble(Console.ReadLine());
                            break; // exit loop if successful
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                        }
                    }

                    Console.WriteLine("Gib mir bitte die zweite Zahl");
                    while (true)
                    {
                        try
                        {
                            Multiplikator = Convert.ToDouble(Console.ReadLine());
                            break; // exit loop if successful
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                        }
                    }

                    ErgebnisCase3 = Multiplikation(Multiplikand, Multiplikator);
                    Console.WriteLine(ErgebnisCase3);
                    break;

                // Placeholder for case 4
                case "4":
                    double number1 = 0, number2 = 0;
                    while(true)
                    {
                        try
                        {
                            Console.Write("Geben Sie die Number1 an: ");
                            number1 = Convert.ToDouble(Console.ReadLine());
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        try
                        {
                            Console.Write("Geben Sie die Number2 an: ");
                            number2 = Convert.ToDouble(Console.ReadLine());
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message); 
                        }

                        double result = number1 / number2;
                        if(number1 == 0|| number2 == 0)
                        {
                            Console.WriteLine("Kann nicht durch 0 dividieren");
                        }
                        Console.Write("Ihr Division Resultat: " + result + "\n");
                        break;
                    }
                    break;

                    //// Placeholder for case 5
                    double number1m = 0, number2m = 0;
                    Console.WriteLine("Gib mir die erste Zahl");
                    while (true)
                    {
                        try
                        {
                            number1m = Convert.ToDouble(Console.ReadLine());
                            break; // exit loop if successful
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                        }
                    }

                    Console.WriteLine("Gib mir die zweite Zahl");
                    while (true)
                    {
                        try
                        {
                            number2m = Convert.ToDouble(Console.ReadLine());
                            break; // exit loop if successful
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                        }
                    }

                    double resultModulo = BerechnungModulo(number1m, number2m);
                    Console.WriteLine("Das Ergebnis des Modulo lautet: " + resultModulo);
                    break;

                // Placeholder for case 6
                case "6":
                    double Basis = 0, Exponent = 0;
                    Console.WriteLine("Bitte gib die Basis ein");
                    while (true)
                    {
                        try
                        {
                            Basis = Convert.ToDouble(Console.ReadLine());
                            break; // exit loop if successful
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                        }
                    }

                    Console.WriteLine("Bitte gib den Exponenten ein");
                    while (true)
                    {
                        try
                        {
                            Exponent = Convert.ToDouble(Console.ReadLine());
                            break; // exit loop if successful
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                        }
                    }

                    double ErgebnisCase6 = Potenzierung(Basis, Exponent);
                    Console.WriteLine(ErgebnisCase6);
                    break;

                case "7":
                    double zahlQuadratwurzel = 0; // Unique variable name
                    Console.WriteLine("Gib mir die Zahl, von der du die Quadratwurzel berechnen möchtest");
                    while (true)
                    {
                        try
                        {
                            zahlQuadratwurzel = Convert.ToDouble(Console.ReadLine());
                            if (zahlQuadratwurzel >= 0) // Überprüfen, ob die Zahl nicht negativ ist
                            {
                                break; // exit loop if successful
                            }
                            else
                            {
                                Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine nicht-negative Zahl ein.");
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                        }
                    }

                    double ergebnisQuadratwurzel = BerechnungQuadratwurzel(zahlQuadratwurzel);
                    Console.WriteLine("Das Ergebnis der Quadratwurzel lautet: " + ergebnisQuadratwurzel);
                    break;

                // Placeholder for case 8
                case "8": // Kubikwurzel
                    double zahlKubikwurzel = 0; // Unique variable name
                    Console.WriteLine("Gib mir die Zahl, deren Kubikwurzel du berechnen möchtest:");
                    while (true)
                    {
                        try
                        {
                            zahlKubikwurzel = Convert.ToDouble(Console.ReadLine());
                            break; // exit loop if successful
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                        }
                    }

                    double kubikwurzelErgebnis = Kubikwurzel(zahlKubikwurzel);
                    Console.WriteLine($"Die Kubikwurzel von {zahlKubikwurzel} ist: {kubikwurzelErgebnis}");
                    break;


                // Placeholder for case 9
                case "9": //Logarithmus
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Von welcher Zahl möchten Sie den natürlichen Logarithmus wissen?");
                            BerechnetLogarithmus();
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                        }
                    }
                    break;

                    // Placeholder for case 10
                    double zahlLog = 0;
                    Console.WriteLine("Gib mir die Zahl, von der du den Logarithmus zur Basis 10 berechnen möchtest");
                    while (true)
                    {
                        try
                        {
                            zahlLog = Convert.ToDouble(Console.ReadLine());
                            if (zahlLog > 0) // Überprüfen, ob die Zahl positiv ist
                            {
                                break; // exit loop if successful
                            }
                            else
                            {
                                Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine positive Zahl ein.");
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                        }
                    }

                    double ergebnisLogarithmus = BerechnungLogarithmus(zahlLog);
                    Console.WriteLine("Das Ergebnis des Logarithmus zur Basis 10 lautet: " + ergebnisLogarithmus);
                    break;

                // Placeholder for case 11
                case "11": //Sinus
                    double WinkelInGrad = 0;
                    Console.WriteLine("Von welchem Winkel möchten sie den Sinus Wert?");
                    while (true)
                    {
                        try
                        {
                            WinkelInGrad = Convert.ToDouble(Console.ReadLine());
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                        }
                    }

                    double sinusWert = SinusInGrad(WinkelInGrad);
                    Console.WriteLine("Der Sinus von " + WinkelInGrad + " Grad ist " + sinusWert);
                    break;

                // Placeholder for case 12
                case "12":

                    Console.WriteLine("Gib die Zahl ein: ");

                    while (true)
                    {
                        try
                        {
                            double n12 = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Das Ergebnis ist: " + cosinus(n12));
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine gültige Zahl ein.");
                        }
                    }
                    break;

                    // Placeholder for case 13
                    double winkelGrad = 0;
                    Console.WriteLine("Gib mir den Winkel in Grad, von dem du den Tangens berechnen möchtest");
                    while (true)
                    {
                        try
                        {
                            winkelGrad = Convert.ToDouble(Console.ReadLine());
                            break; // exit loop if successful
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                        }
                    }

                    double ergebnisTangens = BerechnungTangens(winkelGrad);
                    Console.WriteLine("Das Ergebnis des Tangens des Winkels in Grad lautet: " + ergebnisTangens);
                    break;

                    // Placeholder for case 14
                    double wert = 0;
                    Console.WriteLine("Gib mir den Wert, von dem du den Arcsinus berechnen möchtest");
                    while (true)
                    {
                        try
                        {
                            wert = Convert.ToDouble(Console.ReadLine());
                            if (wert >= -1 && wert <= 1) // Überprüfen, ob der Wert im gültigen Bereich liegt
                            {
                                break; // exit loop if successful
                            }
                            else
                            {
                                Console.WriteLine("Ungültige Eingabe. Bitte geben Sie einen Wert zwischen -1 und 1 ein.");
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                        }
                    }

                    double ergebnisArcsinus = BerechnungArcsinus(wert);
                    Console.WriteLine("Das Ergebnis des Arcsinus des Werts lautet: " + ergebnisArcsinus + " Grad");
                    break;

                    // Placeholder for case 15
                    double wertCos = 0;
                    Console.WriteLine("Gib mir den Wert, von dem du den Arccosinus berechnen möchtest");
                    while (true)
                    {
                        try
                        {
                            wertCos = Convert.ToDouble(Console.ReadLine());
                            if (wertCos >= -1 && wertCos <= 1) // Überprüfen, ob der Wert im gültigen Bereich liegt
                            {
                                break; // exit loop if successful
                            }
                            else
                            {
                                Console.WriteLine("Ungültige Eingabe. Bitte geben Sie einen Wert zwischen -1 und 1 ein.");
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                        }
                    }

                    double ergebnisArccosinus = BerechnungArccosinus(wertCos);
                    Console.WriteLine("Das Ergebnis des Arccosinus des Werts lautet: " + ergebnisArccosinus + " Grad");
                    break;

                    // Placeholder for case 16
                    double wertTan = 0;
                    Console.WriteLine("Gib mir den Wert, von dem du den Arkustangens berechnen möchtest");
                    while (true)
                    {
                        try
                        {
                            wertTan = Convert.ToDouble(Console.ReadLine());
                            break; // exit loop if successful
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                        }
                    }

                    double ergebnisArkustangens = BerechnungArkustangens(wertTan);
                    Console.WriteLine("Das Ergebnis des Arkustangens des Werts lautet: " + ergebnisArkustangens + " Grad");
                    break;

                // Placeholder for case 17

                case "17":

                    Console.WriteLine("Bitte gib mir den ersten Wert an");
                    while (true)
                    {
                        try
                        {
                            double Sinus = Convert.ToDouble(Console.ReadLine());
                            double SinhWert = Hyperbolsinus(Sinus);
                            Console.WriteLine(SinhWert);
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                        }
                    }

                    break;


                    // Placeholder for case 18
                    double zahlCosh = 0;
                    Console.WriteLine("Gib mir die Zahl, von der du den hyperbolischen Cosinus berechnen möchtest");
                    while (true)
                    {
                        try
                        {
                            zahlCosh = Convert.ToDouble(Console.ReadLine());
                            break; // exit loop if successful
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                        }
                    }

                    double ergebnisCosh = BerechnungCosh(zahlCosh);
                    Console.WriteLine("Das Ergebnis des hyperbolischen Cosinus der Zahl lautet: " + ergebnisCosh);
                    break;

                // Placeholder for case 19
                case "19": // Hyperbolischer Tangens
                    double hyperbolicArgument = 0;

                    Console.Write("Gib mir die Zahl für den hyperbolischen Tangens: ");
                    while (true)
                    {
                        try
                        {
                            hyperbolicArgument = Convert.ToDouble(Console.ReadLine());
                            break; // exit loop if successful
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                        }
                    }

                    double hyperbolicTangentResult = HyperbolicTangent(hyperbolicArgument);
                    Console.WriteLine($"Der hyperbolische Tangens von {hyperbolicArgument} ist: {hyperbolicTangentResult}");
                    break;

                // Placeholder for case 20
                case "20": //Grad zu Bogenmasse
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Von Welchem Grad soll die Bogenmasse berechnet werden?");
                            double Grad20 = Convert.ToDouble(Console.ReadLine());
                            double Bogenmasse20 = GradZuBogenmasse(Grad20);
                            Console.WriteLine("Die Bogenmasse Von " + Grad20 + " Grad beträgt: " + Bogenmasse20);
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                        }
                    }
                    break;

                    // Placeholder for case 21
                    double bogenmaß = 0;
                    Console.WriteLine("Gib mir das Bogenmaß, das du in Grad umrechnen möchtest");
                    while (true)
                    {
                        try
                        {
                            bogenmaß = Convert.ToDouble(Console.ReadLine());
                            break; // exit loop if successful
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                        }
                    }

                    double ergebnisGrad = KonvertiereBogenmaßInGrad(bogenmaß);
                    Console.WriteLine("Das Ergebnis der Konvertierung von Bogenmaß in Grad lautet: " + ergebnisGrad + " Grad");
                    break;

                    // Placeholder for case 22
                    int n, k;
                    Console.WriteLine("Gib mir den Wert für n:");
                    while (true)
                    {
                        try
                        {
                            n = Convert.ToInt32(Console.ReadLine());
                            if (n >= 0) // Überprüfen, ob n eine nicht-negative ganze Zahl ist
                            {
                                break; // exit loop if successful
                            }
                            else
                            {
                                Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine nicht-negative ganze Zahl für n ein.");
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine ganze Zahl für n ein.");
                        }
                    }

                    Console.WriteLine("Gib mir den Wert für k:");
                    while (true)
                    {
                        try
                        {
                            k = Convert.ToInt32(Console.ReadLine());
                            if (k >= 0 && k <= n) // Überprüfen, ob k eine nicht-negative ganze Zahl ist und k <= n
                            {
                                break; // exit loop if successful
                            }
                            else
                            {
                                Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine nicht-negative ganze Zahl für k ein, die kleiner oder gleich n ist.");
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine ganze Zahl für k ein.");
                        }
                    }

                    long binomialkoeffizient = BerechnungBinomialkoeffizient(n, k);
                    Console.WriteLine($"Der Binomialkoeffizient C({n}, {k}) lautet: {binomialkoeffizient}");
                    break;

                    // Placeholder for case 23
                    int zahl;
                    Console.WriteLine("Gib mir die Zahl, von der du die Fakultät berechnen möchtest:");
                    while (true)
                    {
                        try
                        {
                            zahl = Convert.ToInt32(Console.ReadLine());
                            if (zahl >= 0) // Überprüfen, ob die Zahl nicht-negativ ist
                            {
                                break; // exit loop if successful
                            }
                            else
                            {
                                Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine nicht-negative ganze Zahl ein.");
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine ganze Zahl ein.");
                        }
                    }

                    long ergebnisFakultät = BerechnungFakultät(zahl);
                    Console.WriteLine($"Die Fakultät von {zahl} lautet: {ergebnisFakultät}");
                    break;

                    // Placeholder for case 24
                    int zahl4;
                    Console.WriteLine("Gib mir die Zahl, die du auf Primzahl überprüfen möchtest:");
                    while (true)
                    {
                        try
                        {
                            zahl4 = Convert.ToInt32(Console.ReadLine());
                            if (zahl4 >= 2) // Überprüfen, ob die Zahl größer oder gleich 2 ist (Primzahlen müssen größer als 1 sein)
                            {
                                break; // exit loop if successful
                            }
                            else
                            {
                                Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine ganze Zahl größer oder gleich 2 ein.");
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine ganze Zahl ein.");
                        }
                    }

                    bool istPrimzahl = PruefungAufPrimzahl(zahl4);
                    Console.WriteLine($"Die Zahl {zahl4} ist {(istPrimzahl ? "eine" : "keine")} Primzahl.");
                    break;

                // Placeholder for case 25
                case "25":
                    try
                    {
                        Console.WriteLine("Geben Sie die erste Zahl ein:");
                        int num10 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Geben Sie die zweite Zahl ein:");
                        int num20 = Convert.ToInt32(Console.ReadLine());

                        int ggt = FindeGGT(num10, num20);
                        Console.WriteLine($"Der größte gemeinsame Teiler von {num10} und {num20} ist: {ggt}");
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine ganze Zahl ein.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Ein unerwarteter Fehler ist aufgetreten: {ex.Message}");
                    }
                    break;

                // Placeholder for case 26
                case "26":
                    int zahl1, zahl2;
                    Console.WriteLine("Gib mir die erste Zahl:");
                    while (true)
                    {
                        try
                        {
                            zahl1 = Convert.ToInt32(Console.ReadLine());
                            break; // exit loop if successful
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine ganze Zahl ein.");
                        }
                    }

                    Console.WriteLine("Gib mir die zweite Zahl:");
                    while (true)
                    {
                        try
                        {
                            zahl2 = Convert.ToInt32(Console.ReadLine());
                            break; // exit loop if successful
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine ganze Zahl ein.");
                        }
                    }

                    int kgv = BerechnungKGV(zahl1, zahl2);
                    Console.WriteLine($"Das kleinste gemeinsame Vielfache von {zahl1} und {zahl2} lautet: {kgv}");
                    break;

                // Placeholder for case 27
                case "27":
                    double a = 0, d = 0;
                    int n1 = 0;

                    Console.WriteLine("Berechnung der Summe einer arithmetischen Reihe:\n");

                    Console.WriteLine("Gib mir das erste Glied a:");
                    while (true)
                    {
                        try
                        {
                            a = Convert.ToDouble(Console.ReadLine());
                            break; // exit loop if successful
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                        }
                    }

                    Console.WriteLine("Gib mir den konstanten Unterschied d:");
                    while (true)
                    {
                        try
                        {
                            d = Convert.ToDouble(Console.ReadLine());
                            break; // exit loop if successful
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                        }
                    }

                    Console.WriteLine("Gib mir die Anzahl der Glieder n:");
                    while (true)
                    {
                        try
                        {
                            n1 = Convert.ToInt32(Console.ReadLine());
                            break; // exit loop if successful
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine ganze Zahl ein.");
                        }
                    }

                    double ErgebnisArith = arithReiheSumme(a, d, n1);
                    Console.WriteLine($"Die Summe der arithmetischen Reihe ist: {ErgebnisArith}");
                    break;

                // Placeholder for case 28
                case "28":
                    double aGeom = 0, r = 0;
                    int nGeom = 0;

                    Console.WriteLine("Berechnung der Summe einer geometrischen Reihe:\n");

                    Console.WriteLine("Gib mir das erste Glied a:");
                    while (true)
                    {
                        try
                        {
                            aGeom = Convert.ToDouble(Console.ReadLine());
                            break; // exit loop if successful
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                        }
                    }

                    Console.WriteLine("Gib mir den Quotienten r:");
                    while (true)
                    {
                        try
                        {
                            r = Convert.ToDouble(Console.ReadLine());
                            break; // exit loop if successful
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                        }
                    }

                    Console.WriteLine("Gib mir die Anzahl der Glieder n:");
                    while (true)
                    {
                        try
                        {
                            nGeom = Convert.ToInt32(Console.ReadLine());
                            break; // exit loop if successful
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine ganze Zahl ein.");
                        }
                    }

                    double ErgebnisGeom = geomReiheSumme(aGeom, r, nGeom);
                    Console.WriteLine($"Die Summe der geometrischen Reihe ist: {ErgebnisGeom}");
                    break;

                // Placeholder for cases 29
                case "29":
                    {
                        Console.WriteLine("Bitte geben Sie den Anlagebetrag ein:");
                        double kapital = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Bitte geben Sie den Zinssatz ein (in Prozent):");
                        double zinssatz = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Bitte geben Sie die Anlagedauer in Jahren ein:");
                        int laufzeit = Convert.ToInt32(Console.ReadLine());

                        double endkapital = BerechneZinseszins(kapital, zinssatz, laufzeit);

                        Console.WriteLine($"Nach {laufzeit} Jahren beträgt das Kapital: {endkapital:F2} Franken");
                        Console.WriteLine("Drücken Sie eine beliebige Taste, um das Programm zu beenden.");
                        Console.ReadKey();
                        break;
                    }


                    // Placeholder for cases 30
                    int n2;
                    Console.WriteLine("Gib mir die Anzahl der ersten N Primzahlen, deren Summe du berechnen möchtest:");
                    while (true)
                    {
                        try
                        {
                            n2 = Convert.ToInt32(Console.ReadLine());
                            if (n2 > 0) // Überprüfen, ob die Anzahl positiv ist
                            {
                                break; // exit loop if successful
                            }
                            else
                            {
                                Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine positive ganze Zahl ein.");
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine ganze Zahl ein.");
                        }
                    }

                    long summePrimzahlen = BerechnungSummeErsterNPrimzahlen(n2);
                    Console.WriteLine($"Die Summe der ersten {n2} Primzahlen lautet: {summePrimzahlen}");
                    break;

                default:
                    Console.WriteLine("Ungültige Auswahl. Bitte wählen Sie eine gültige Operation.");
                    break;

            }

            Console.WriteLine("Soll das Programm nochmals laufen?  Falls Ja schreibe yes sonst beliebege Taste zum abbrechen");
            programlauft = Console.ReadLine();
        }

        Console.WriteLine("Danke und tschüss!");

    }


    // Funktion 0
    static double pytRechner(double a, double b)
    {
        double resultat;
        resultat = Math.Sqrt(a * a + b * b);
        return resultat;
    }

    //Funktion 1
    static double addieren(double summand1, double summand2)
    {
        return summand1 + summand2;
    }

    //Funktion 2
    static double Subtraktion(double a, double b)
    {
        return a - b;
    }

    //Funktion 3
    static double Multiplikation(double a, double b)
    {
        double Produkt;
        Produkt = a * b;
        return Produkt;
    }

    //Funktion 4
    static double Dividieren(double dividend, double divisor)
    {
        return dividend / divisor;
    }

    //Funktion 5
    static double BerechnungModulo(double number1m, double number2m)
    {
        return number1m % number2m;
    }

    //Funktion 6
    static double Potenzierung(double a, double b)
    {
        double Potenz;
        Potenz = Math.Pow(a, b);
        return Potenz;
    }

    //Funktion 7
    static double BerechnungQuadratwurzel(double zahlQuadratwurzel)
    {
        return Math.Sqrt(zahlQuadratwurzel);
    }

    //Funktion 8
    static double Kubikwurzel(double x)
    {
        return Math.Pow(x, 1.0 / 3.0);
    }

    //Funktion 9
    static void BerechnetLogarithmus()
    {
        double Wert9 = 0;
        Wert9 = Convert.ToDouble(Console.ReadLine());
        double ErgebnisCase10 = Math.Log(Wert9);
        Console.WriteLine("Der natürliche Logarithmus von " + Wert9 + " ist: " + ErgebnisCase10);
    }

    //Funktion 10
    static double BerechnungLogarithmus(double zahl)
    {
        return Math.Log10(zahl);
    }

    //Funktion 11
    static double SinusInGrad(double winkelInGrad)
    {
        double winkelInBogenmass = winkelInGrad * Math.PI / 180.0;
        double sinusWert = Math.Sin(winkelInBogenmass);
        return sinusWert;
    }

    static double cosinus(double n12)
    {
        Math.Cos(n12);
        return Math.Sin(n12);
    }

    //Funktion 13
    static double BerechnungTangens(double winkelGrad)
    {
        double winkelBogen = winkelGrad * (Math.PI / 180); // Umrechnung von Grad in Bogenmaß
        return Math.Tan(winkelBogen);
    }

    //Funktion 14
    static double BerechnungArcsinus(double wert)
    {
        // Math.Asin gibt das Ergebnis in Bogenmaß zurück, daher wird in Grad umgerechnet
        return Math.Asin(wert) * (180 / Math.PI);
    }

    //Funktion 15
    static double BerechnungArccosinus(double wertCos)
    {
        // Math.Acos gibt das Ergebnis in Bogenmaß zurück, daher wird in Grad umgerechnet
        return Math.Acos(wertCos) * (180 / Math.PI);
    }

    //Funktion 16
    static double BerechnungArkustangens(double wertTan)
    {
        // Math.Atan gibt das Ergebnis in Bogenmaß zurück, daher wird in Grad umgerechnet
        return Math.Atan(wertTan) * (180 / Math.PI);
    }

    //Funktion 17

    static double Hyperbolsinus(double a)
    {
        double SinhValue = Math.Sinh(a);
        return SinhValue;
    }

    //Funktion 18
    static double BerechnungCosh(double zahlCosh)
    {
        return Math.Cosh(zahlCosh);
    }

    //Funktion 19
    // Funktion zur Berechnung des hyperbolischen Tangens
    static double HyperbolicTangent(double x)
    {
        double eToX = Math.Pow(Math.E, x);
        double eToNegX = Math.Pow(Math.E, -x);

        double hyperbolicTangent = (eToX - eToNegX) / (eToX + eToNegX);

        return hyperbolicTangent;
    }

    //Funktion 20

    static double GradZuBogenmasse(double Grad20)
    {
        return Grad20 * Math.PI / 180.0;
    }

    //Funktion 21
    static double KonvertiereBogenmaßInGrad(double bogenmaß)
    {
        return bogenmaß * (180 / Math.PI);
    }

    //Funktion 22
    static long BerechnungBinomialkoeffizient(int n, int k)
    {
        if (k == 0 || k == n)
        {
            return 1;
        }

        long[,] binomial = new long[n + 1, k + 1];

        for (int i = 0; i <= n; i++)
        {
            for (int j = 0; j <= Math.Min(i, k); j++)
            {
                if (j == 0 || j == i)
                {
                    binomial[i, j] = 1;
                }
                else
                {
                    binomial[i, j] = binomial[i - 1, j - 1] + binomial[i - 1, j];
                }
            }
        }

        return binomial[n, k];
    }

    //Funktion 23
    static long BerechnungFakultät(int zahl)
    {
        if (zahl == 0 || zahl == 1)
        {
            return 1;
        }

        long fakultät = 1;

        for (int i = 2; i <= zahl; i++)
        {
            fakultät *= i;
        }

        return fakultät;
    }

    //Funktion 24
    static bool PruefungAufPrimzahl(int zahl4)
    {
        if (zahl4 < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(zahl4); i++)
        {
            if (zahl4 % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    //Funktion 25
    static int FindeGGT(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    //Funktion 26
    static int BerechnungKGV(int zahl1, int zahl2)
    {
        return Math.Abs(zahl1 * zahl2) / BerechnungGGT(zahl1, zahl2);
    }

    static int BerechnungGGT(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    //Funktion 27
    static double arithReiheSumme(double a, double d, int n)
    {
        return n / 2.0 * (2 * a + (n - 1) * d);
    }

    //Funktion 28
    static double geomReiheSumme(double a, double r, int n)
    {
        if (r == 1)
        {
            return n * a;
        }
        return a * (1 - Math.Pow(r, n)) / (1 - r);
    }

    //Funktion 29
    static double BerechneZinseszins(double kapital, double zinssatz, int laufzeit)
    {
        double endkapital = kapital * Math.Pow(1 + zinssatz / 100, laufzeit);
        return endkapital;
    }

    //Funktion 30
    static long BerechnungSummeErsterNPrimzahlen(int n)
    {
        int anzahlPrimzahlen = 0;
        long summe = 0;
        int zahl = 2; // Die erste Primzahl

        while (anzahlPrimzahlen < n)
        {
            if (PruefungAufPrimzahl(zahl))
            {
                summe += zahl;
                anzahlPrimzahlen++;
            }

            zahl++;
        }

        return summe;
        static bool PruefungAufPrimzahl(int zahl)
        {
            if (zahl < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(zahl); i++)
            {
                if (zahl % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}