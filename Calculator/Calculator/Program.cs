using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Calculator
{
    class ChooseCalc {

        public void MainMenu(int nrChoose)
        {
            switch (nrChoose)
            {
                case 1:
                    Console.Clear();
                    BC bc = new BC();
                    bc.CalMain();
                    break;
                case 2:
                    Console.Clear();
                    BMI bmi = new BMI();
                    bmi.BMIMain();
                    break;
                case 3:
                    Console.Clear();
                    DC dc = new DC();
                    dc.DCMain();
                    break;
                case 4:
                    Console.Clear();
                    CalculatorMeWe calculatorMeWe = new CalculatorMeWe();
                    calculatorMeWe.MainCalc();
                    break;
                case 5:
                    System.Diagnostics.Process.GetCurrentProcess().Kill();
                    break;

                default:
                    Console.Clear();
                    bool falsee = false;
                    Menu menu = new Menu();
                    menu.MainCalc(falsee);
                    break;

            }
        }
    }
    class City
    {
        public String cityName;
        public int x;
        public int y;
    }
    public class DC
    {
        public void DCMain()
        {
            City wro = new City();
            wro.cityName = "Wrocław";
            wro.x = 210;
            wro.y = 140;
            City kat = new City();
            kat.cityName = "Katowice";
            kat.x = 350;
            kat.y = 60;
            City kra = new City();
            kra.cityName = "Kraków";
            kra.x = 410;
            kra.y = 40;
            City rze = new City();
            rze.cityName = "Rzeszów";
            rze.x = 540;
            rze.y = 35;
            City kie = new City();
            kie.cityName = "Kielce";
            kie.x = 460;
            kie.y = 120;
            City lub = new City();
            lub.cityName = "Lublin";
            lub.x = 590;
            lub.y = 170;
            City lod = new City();
            lod.cityName = "Łódź";
            lod.x = 370;
            lod.y = 225;
            City poz = new City();
            poz.cityName = "Poznań";
            poz.x = 200;
            poz.y = 280;
            City bia = new City();
            bia.cityName = "Białystok";
            bia.x = 640;
            bia.y = 370;
            City byd = new City();
            byd.cityName = "Bydgoszcz";
            byd.x = 265;
            byd.y = 370;
            City war = new Calculator.City();
            war.cityName = "Warszawa";
            war.x = 580;
            war.y = 265;
            City ols = new Calculator.City();
            ols.cityName = "Olsztyn";
            ols.x = 450;
            ols.y = 450;
            City szc = new Calculator.City();
            szc.cityName = "Szczecin";
            szc.x = 40;
            szc.y = 400;
            City gda = new Calculator.City();
            gda.cityName = "Gdańsk";
            gda.x = 320;
            gda.y = 530;
            City gdy = new Calculator.City();
            gdy.cityName = "Gdynia";
            gdy.x = 300;
            gdy.y = 550;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Distance calculator");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter first city");
            String WriteCity = Console.ReadLine();
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            WriteCity = textInfo.ToLower(WriteCity);
            WriteCity = textInfo.ToTitleCase(WriteCity);
            int y1 = 0;
            int x1 = 0;
            String cn1 = null;
            bool isTrue = false;
            while (isTrue == false)
            {
                switch (WriteCity)
                {
                    case "Wroclaw":
                        isTrue = true;
                        cn1 = "Wrocław";
                        x1 = wro.x;
                        y1 = wro.y;
                        break;
                    case "Poznan":
                        isTrue = true;
                        cn1 = "Poznań";
                        x1 = poz.x;
                        y1 = poz.y;
                        break;
                    case "Wrocław":
                        isTrue = true;
                        cn1 = "Wrocław";
                        x1 = wro.x;
                        y1 = wro.y;
                        break;
                    case "Poznań":
                        isTrue = true;
                        cn1 = "Poznań";
                        x1 = poz.x;
                        y1 = poz.y;
                        break;
                    case "Kielce":
                        isTrue = true;
                        cn1 = "Kielce";
                        x1 = kie.x;
                        y1 = kie.y;
                        break;
                    case "Gdansk":
                        isTrue = true;
                        cn1 = "Gdańsk";
                        x1 = gda.x;
                        y1 = gda.y;
                        break;
                    case "Gdańsk":
                        isTrue = true;
                        cn1 = "Gdańsk";
                        x1 = gda.x;
                        y1 = gda.y;
                        break;
                    case "Gdynia":
                        isTrue = true;
                        cn1 = "Gdynia";
                        x1 = gdy.x;
                        y1 = gdy.y;
                        break;
                    case "Szczecin":
                        isTrue = true;
                        cn1 = "Szczecin";
                        x1 = szc.x;
                        y1 = szc.y;
                        break;
                    case "Bydgoszcz":
                        isTrue = true;
                        cn1 = "Bydgoszcz";
                        x1 = byd.x;
                        y1 = byd.y;
                        break;
                    case "Katowice":
                        isTrue = true;
                        cn1 = "Katowice";
                        x1 = kat.x;
                        y1 = kat.y;
                        break;
                    case "Krakow":
                        isTrue = true;
                        cn1 = "Kraków";
                        x1 = kra.x;
                        y1 = kra.y;
                        break;
                    case "Kraków":
                        isTrue = true;
                        cn1 = "Kraków";
                        x1 = kra.x;
                        y1 = kra.y;
                        break;
                    case "Rzeszow":
                        isTrue = true;
                        cn1 = "Rzeszów";
                        x1 = rze.x;
                        y1 = rze.y;
                        break;
                    case "Rzeszów":
                        isTrue = true;
                        cn1 = "Rzeszów";
                        x1 = rze.x;
                        y1 = rze.y;
                        break;
                    case "Lublin":
                        isTrue = true;
                        cn1 = "Lublin";
                        x1 = lub.x;
                        y1 = lub.y;
                        break;
                    case "Warszawa":
                        isTrue = true;
                        cn1 = "Warszawa";
                        x1 = war.x;
                        y1 = war.y;
                        break;
                    case "Olsztyn":
                        isTrue = true;
                        cn1 = "Olsztyn";
                        x1 = ols.x;
                        y1 = ols.y;
                        break;
                    case "Białystok":
                        isTrue = true;
                        cn1 = "Białystok";
                        x1 = bia.x;
                        y1 = bia.y;
                        break;
                    case "Bialystok":
                        isTrue = true;
                        cn1 = "Białystok";
                        x1 = bia.x;
                        y1 = bia.y;
                        break;
                    case "Lodz":
                        isTrue = true;
                        cn1 = "Łódź";
                        x1 = lod.x;
                        y1 = lod.y;
                        break;
                    case "Łódź":
                        isTrue = true;
                        cn1 = "Łódź";
                        x1 = lod.x;
                        y1 = lod.y;
                        break;
                    default:
                        Console.WriteLine("This city does not egsist");
                        isTrue = false;
                        WriteCity = Console.ReadLine();
                        break;
                }
            }

            Console.WriteLine("Enter second city.");
            String WriteCity2 = Console.ReadLine();
            WriteCity2 = textInfo.ToLower(WriteCity2);
            WriteCity2 = textInfo.ToTitleCase(WriteCity2);
            int x2 = 0;
            int y2 = 0;
            String cn2 = null;
            isTrue = false;
            while (isTrue == false) {
                switch (WriteCity2)
                {
                    case "Wroclaw":
                        isTrue = true;
                        cn2 = "Wrocław";
                        x2 = wro.x;
                        y2 = wro.y;
                        break;
                    case "Wrocław":
                        isTrue = true;
                        cn2 = "Wrocław";
                        x2 = wro.x;
                        y2 = wro.y;
                        break;
                    case "Poznan":
                        isTrue = true;
                        cn2 = "Poznań";
                        x2 = poz.x;
                        y2 = poz.y;
                        break;
                    case "Poznań":
                        isTrue = true;
                        cn2 = "Poznań";
                        x2 = poz.x;
                        y2 = poz.y;
                        break;
                    case "Kielce":
                        isTrue = true;
                        cn2 = "Kielce";
                        x2 = kie.x;
                        y2 = kie.y;
                        break;
                    case "Gdansk":
                        isTrue = true;
                        cn2 = "Gdańsk";
                        x2 = gda.x;
                        y2 = gda.y;
                        break;
                    case "Gdańsk":
                        isTrue = true;
                        cn2 = "Gdańsk";
                        x2 = gda.x;
                        y2 = gda.y;
                        break;
                    case "Gdynia":
                        isTrue = true;
                        cn2 = "Gdynia";
                        x2 = gdy.x;
                        y2 = gdy.y;
                        break;
                    case "Szczecin":
                        isTrue = true;
                        cn2 = "Szczecin";
                        x2 = szc.x;
                        y2 = szc.y;
                        break;
                    case "Bydgoszcz":
                        isTrue = true;
                        cn2 = "Bydgoszcz";
                        x2 = byd.x;
                        y2 = byd.y;
                        break;
                    case "Katowice":
                        isTrue = true;
                        cn2 = "Katowice";
                        x2 = kat.x;
                        y2 = kat.y;
                        break;
                    case "Krakow":
                        isTrue = true;
                        cn2 = "Kraków";
                        x2 = kra.x;
                        y2 = kra.y;
                        break;
                    case "Kraków":
                        isTrue = true;
                        cn2 = "Kraków";
                        x2 = kra.x;
                        y2 = kra.y;
                        break;
                    case "Rzeszow":
                        isTrue = true;
                        cn2 = "Rzeszów";
                        x2 = rze.x;
                        y2 = rze.y;
                        break;
                    case "Rzeszów":
                        isTrue = true;
                        cn2 = "Rzeszów";
                        x2 = rze.x;
                        y2 = rze.y;
                        break;
                    case "Lublin":
                        isTrue = true;
                        cn2 = "Lublin";
                        x2 = lub.x;
                        y2 = lub.y;
                        break;
                    case "Warszawa":
                        isTrue = true;
                        cn2 = "Warszawa";
                        x2 = war.x;
                        y2 = war.y;
                        break;
                    case "Olsztyn":
                        isTrue = true;
                        cn2 = "Olsztyn";
                        x2 = ols.x;
                        y2 = ols.y;
                        break;
                    case "Bialystok":
                        isTrue = true;
                        cn2 = "Białystok";
                        x2 = bia.x;
                        y2 = bia.y;
                        break;
                    case "Białystok":
                        isTrue = true;
                        cn2 = "Białystok";
                        x2 = bia.x;
                        y2 = bia.y;
                        break;
                    case "Lodz":
                        isTrue = true;
                        cn2 = "Łódź";
                        x2 = lod.x;
                        y2 = lod.y;
                        break;
                    case "Łódź":
                        isTrue = true;
                        cn2 = "Łódź";
                        x2 = lod.x;
                        y2 = lod.y;
                        break;
                    default:

                        Console.WriteLine("This city does not egsist in our database");
                        WriteCity2 = Console.ReadLine();
                        break;
                }
            }
            int a = y1 - y2;
            if (a < 0)
            {
                a = a * -1;
            }
            int b = x1 - x2;
            if (b < 0)
            {
                b = b * -1;
            }
            double d = (a * a) + (b * b);
            d = Math.Sqrt(d);

            Console.WriteLine("From " + cn1 + " to " + cn2 + " is " + String.Format("{0:N2}", d) + " km in a straight line.");
            Console.WriteLine("1. Reset calculator");
            Console.WriteLine("2. Return to Main Menu");
            String ChoseRBS;
            bool AllDigits;
            ChoseRBS = Console.ReadLine();
            AllDigits = ChoseRBS.Any() && ChoseRBS.All(char.IsDigit);
            while (AllDigits == false)
            {
                Console.WriteLine("Wrong choice");
                ChoseRBS = Console.ReadLine();
                AllDigits = ChoseRBS.Any() && ChoseRBS.All(char.IsDigit);
            }
            int ChoseRB = int.Parse(ChoseRBS);
            isTrue = false;
            while (isTrue == false) {
                switch (ChoseRB)
                {
                    case 1:
                        Console.Clear();
                        isTrue = true;
                        DC dC = new DC();
                        dC.DCMain();
                        break;
                    case 2:
                        Console.Clear();
                        isTrue = true;
                        Menu menu = new Menu();
                        menu.MainCalc(true);
                        break;
                    default:
                        Console.Clear();
                        isTrue = false;
                        Console.Write("Wrong choice");
                        break;
                }
            }



        }
    }

    public class BMI
    {
        double weight = 0;
        double height = 0;
        double bmi = 0;

        public void BMIMain()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("BMI Calculator");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter weight:");
            String weightS = Console.ReadLine();
            bool AllDigits = weightS.Any() && weightS.All(char.IsDigit);
            while (AllDigits == false)
            {
                Console.WriteLine("Wrong weight");
                weightS = Console.ReadLine();
                AllDigits = weightS.Any() && weightS.All(char.IsDigit);
            }
            weight = double.Parse(weightS);
            Console.WriteLine("Enter height:");
            String heightS = Console.ReadLine();
            AllDigits = heightS.Any() && heightS.All(char.IsDigit);
            while (AllDigits == false)
            {
                Console.WriteLine("Wrong weight");
                heightS = Console.ReadLine();
                AllDigits = heightS.Any() && heightS.All(char.IsDigit);
            }
            height = double.Parse(heightS);

            bmi = weight / (height * height) * 10000;
            Console.WriteLine("Your BMI: " + "{0:N2}", bmi);
            if (bmi <= 18.5)
            {
                Console.WriteLine("You are too skinny. Correct BMI is 18.6 - 24.99. Eat more and healthily");
            }
            else
            {
                if (bmi == 18.51 && bmi <= 25)
                {
                    Console.WriteLine("Your weight is correct(18.6 - 24.99");
                }
                else
                {
                    if (bmi >= 25)
                    {
                        Console.WriteLine("Your weight is too big. Correct BMI is 18.6 - 24.99. Eat less and healthily");
                    }
                }
            }
            Console.WriteLine("1. Reset calculator");
            Console.WriteLine("2. Return to Main Menu");
            String ChoseRBS;
            ChoseRBS = Console.ReadLine();
            AllDigits = ChoseRBS.Any() && ChoseRBS.All(char.IsDigit);
            while (AllDigits == false)
            {
                Console.WriteLine("Wrong choice");
                ChoseRBS = Console.ReadLine();
                AllDigits = ChoseRBS.Any() && ChoseRBS.All(char.IsDigit);
            }
            int ChoseRB = int.Parse(ChoseRBS);
            bool isTrue = false;
            while (isTrue == false) {
                switch (ChoseRB)
                {
                    case 1:
                        isTrue = true;
                        Console.Clear();
                        BMI bmi = new BMI();
                        bmi.BMIMain();

                        break;
                    case 2:
                        isTrue = true;
                        Console.Clear();
                        Menu menu = new Menu();
                        menu.MainCalc(true);
                        break;
                    default:
                        isTrue = false;
                        Console.Clear();
                        Console.Write("Wrong choice");
                        break;
                }
            }
        }
    }

    public class BC
    {

        public void CalMain()
        {
            String firstS;
            double first;
            String secondS;
            double second;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Basic calculator");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Please enter first number");

            firstS = Console.ReadLine();
            bool allDigits = firstS.Any() && firstS.All(char.IsDigit);
            while (allDigits == false)
            {
                Console.WriteLine("Wrong number");
                firstS = Console.ReadLine();
                allDigits = firstS.Any() && firstS.All(char.IsDigit);
            }
            first = Double.Parse(firstS);
            Console.WriteLine("Plese enter second number");
            secondS = Console.ReadLine();
            allDigits = secondS.Any() && secondS.All(char.IsDigit);
            while (allDigits == false)
            {
                Console.WriteLine("Wrong number");
                secondS = Console.ReadLine();
                allDigits = secondS.Any() && secondS.All(char.IsDigit);
            }
            second = Double.Parse(secondS);
            double score = 0;
            Console.WriteLine("Choose action:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            String actionS;
            actionS = Console.ReadLine();
            allDigits = actionS.Any() && actionS.All(char.IsDigit);
            while (allDigits == false)
            {
                Console.WriteLine("Wrong number");
                actionS = Console.ReadLine();
                allDigits = actionS.Any() && actionS.All(char.IsDigit);
            }
            int action = 0;

            action = int.Parse(actionS);
            bool isTrue = false;
            while (isTrue == false) {
                switch (action)
                {
                    case 1:
                        isTrue = true;
                        score = first + second;
                        break;
                    case 2:
                        isTrue = true;
                        score = first - second;
                        break;
                    case 3:
                        isTrue = true;
                        score = first * second;
                        break;
                    case 4:
                        isTrue = true;
                        score = first / second;
                        break;
                    default:
                        isTrue = false;
                        Console.WriteLine("You don't choose any action");
                        break;

                }
            }
            Console.WriteLine("Score: " + score);
            Console.WriteLine("1. Reset calculator");
            Console.WriteLine("2. Return to Main Menu");
            String ChoseRBS;
            ChoseRBS = Console.ReadLine();
            allDigits = ChoseRBS.Any() && ChoseRBS.All(char.IsDigit);
            while (allDigits == false)
            {
                Console.WriteLine("Wrong choice");
                ChoseRBS = Console.ReadLine();
                allDigits = ChoseRBS.Any() && ChoseRBS.All(char.IsDigit);
            }
            int ChoseRB = int.Parse(ChoseRBS);
            isTrue = false;
            while (isTrue == false) {
                switch (ChoseRB) {
                    case 1:
                        isTrue = true;
                        BC bc = new BC();
                        bc.CalMain();

                        break;
                    case 2:
                        isTrue = true;
                        Menu menu = new Menu();
                        menu.MainCalc(true);
                        break;
                    default:
                        isTrue = false;
                        Console.Write("Wrong choice");

                        break;

                }
            }
        }
    }
    class Program
    {
        public static void Main()
        {
            Menu menu = new Menu();
            menu.MainCalc(true);
        }
    }
    public class Me
    {
       public double p;
        public String name;

    }
    public class CalculatorMeWe
    {

        public void MainCalc()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Calculator measures and weights");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1. Measures");
            Console.WriteLine("2. Weights");
            String mwS = Console.ReadLine();
            bool AllDigits = mwS.Any() && mwS.All(char.IsDigit);
            while (AllDigits == false)
            {
                Console.WriteLine("Wrong choice");
                mwS = Console.ReadLine();
                AllDigits = mwS.Any() && mwS.All(char.IsDigit);

            }
            int mw = int.Parse(mwS);
            bool isTrue = false;
            while (isTrue == false)
            {
                switch (mw)
                {
                    case 1:
                        isTrue = true;
                        Measures();
                        break;
                    case 2:
                        isTrue = true;
                        Weights();
                        break;
                    default:
                        isTrue = false;
                        Console.Clear();
                        Console.WriteLine("Wrong choice");
                        Console.WriteLine("1. Measures");
                        Console.WriteLine("2. Weights");
                        mwS = Console.ReadLine();
                        break;

                }
            }
        }
        public void Measures()
        {
            Me m = new Me();
            m.name = "Meter";
            m.p = 1;
            Me km = new Me();
            km.name = "Kilometer";
            km.p = 1000;
            Me dm = new Me();
            dm.name = "Decimeter";
            dm.p = 0.1;
            Me cm = new Me();
            cm.name = "Centymeter";
            cm.p = 0.01;
            Me mm = new Me();
            mm.name = "Millimeter";
            mm.p = 0.001;
            Me inc = new Me();
            inc.name = "Inch";
            inc.p = 0.0254;
            Me ft = new Me();
            ft.name = "Foot";
            ft.p = 0.3048;
            Me yd = new Me();
            yd.name = "Yard";
            yd.p = 0.9144;
            Me mi = new Me();
            mi.name = "Mile";
            mi.p = 1609.344;
            Console.Clear();
            Console.WriteLine("Measures");
            Console.WriteLine("1. Meter");
            Console.WriteLine("2. Kilometer");
            Console.WriteLine("3. Deimeter");
            Console.WriteLine("4. Centimeter");
            Console.WriteLine("5. Millimeter");
            Console.WriteLine("6. Micron");
            Console.WriteLine("7. Inch");
            Console.WriteLine("8. Foot");
            Console.WriteLine("9. Yard");
            Console.WriteLine("10. Land mile");
            String s = Console.ReadLine();
            bool AllDigits = s.Any() && s.All(char.IsDigit);
            while (AllDigits == false)
            {
                Console.WriteLine("Wrong choice!");
                s = Console.ReadLine();
                AllDigits = s.Any() && s.All(char.IsDigit);
            }
            int i = int.Parse(s);
            String name1;
            double x1;
            bool isTrue = false;
            while (isTrue == false)
            {
                switch (i)
                {
                    case 1:
                        name1 = m.name;
                        x1 = m.p;
                        isTrue = true;
                        break;
                    case 2:
                        name1 = km.name;
                        x1 = km.p;
                        isTrue = true;
                        break;
                    case 3:
                        name1 = dm.name;
                        x1 = dm.p;
                        isTrue = true;
                        break;
                    case 4:
                        name1 = cm.name;
                        x1 = cm.p;
                        isTrue = true;
                        break;
                    case 5:
                        name1 = mm.name;
                        x1 = mm.p;
                        isTrue = true;
                        break;
                    case 6:
                        isTrue = true;
                        break;
                    case 7:
                        isTrue = true;
                        break;
                    case 8:
                        isTrue = true;
                        break;
                    case 9:
                        isTrue = true;
                        break;
                    default:
                        isTrue = false;
                        break;
                }
            }
        }
        public void Weights()
        {

        }
    }

    class Menu
    {
        public void MainCalc(bool falsee)
        {
            Console.WriteLine("Welcome. This is your SuperCalculator3000. Choose type of calculator");
            Console.WriteLine("1. Basic calculator");
            Console.WriteLine("2. BMI calculator");
            Console.WriteLine("3. Distance calculator");
            Console.WriteLine("4. Calculator measures and weights");
            Console.WriteLine("5. Close program");
            if (falsee == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Wrong choice!");
                Console.ForegroundColor = ConsoleColor.White;
            }
            String calcString;
            int calc;
            calcString = Console.ReadLine();
            bool allDigits = calcString.Any() && calcString.All(char.IsDigit);
            while (allDigits == false)
            {
                Console.WriteLine("Wrong choice");
                calcString = Console.ReadLine();
                allDigits = calcString.Any() && calcString.All(char.IsDigit);
            }
            calc = int.Parse(calcString);
            ChooseCalc c1 = new ChooseCalc();
            c1.MainMenu(calc);
            Console.WriteLine(calc);
        }
       
    }
}
