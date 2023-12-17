using System;
using System.Reflection;

Console.WriteLine("Welcome to Federal Income Tax Estimator");
Console.WriteLine("How Many W2's are you entering?");
Console.WriteLine($"Enter number");

double[] numbers = new double[50];
double total = 0;
double W2 = Convert.ToDouble(Console.ReadLine());
grossIncome();
double dTotal = 0;
int index2 = 0;
double[] dNumbers = new double[1000];
Console.WriteLine($"Enter your deduction number " + (index2 + 1) + " or -1 to Exit");
dNumbers[index2] = Convert.ToDouble(Console.ReadLine());

void grossIncome() //Calculates Gross Income
{
   
    for (int index = 0; index < W2; index++)
    {

        Console.WriteLine($"Enter W2 income number " + (index + 1));
        numbers[index] = Convert.ToDouble(Console.ReadLine());
        total = total + numbers[index];

    }
    Console.WriteLine("Your total gross income is " + total);
}



    while (dNumbers[index2] != -1) // Calculates deductions

    {


        dTotal = dTotal + dNumbers[index2];
        index2 = index2 + 1;

        Console.WriteLine($"Enter your deduction number " + (index2 + 1) + " or -1 to Exit");
        dNumbers[index2] = Convert.ToDouble(Console.ReadLine());

    }

    Console.WriteLine("Your total deductions are " + dTotal); //If total deductions are less than standard dedcutions
    if (dTotal < 12950)                                       // Sets standard deduction otherwise 
    {
        dTotal = 12950;
    }
    double adjGrossIncome = (total - dTotal);

    if (dTotal > total)
    {
        adjGrossIncome = 0;
    }

Console.WriteLine("Your total adjusted income is "+ adjGrossIncome);

double taxesOwed = 0;
double[] taxB = new double[7];
double[] taxBNum = { .10, .12, .22, .24, .32, .35, .37 };
double answer = 0;
Console.WriteLine($"If filing Single enter 1, If filling jointly enter 2");
answer= Convert.ToDouble(Console.ReadLine());
if (answer == 1)
{
    taxSingBrackCal();
} else if (answer == 2)
{
    taxJointBrackCal();
}


void taxJointBrackCal() //Calculates taxes at each tax bracket
{
    for (int l = 0; l < 7; l++)
    {
        taxB[l] = 0;

    }
    if (adjGrossIncome <= 20550)
    {
        taxB[0] = adjGrossIncome * 0.10;
    }

    if (adjGrossIncome > 20550)
    {
        taxB[0] = 20550 * 0.10;
    }



    if ((adjGrossIncome >= 20550) && (adjGrossIncome <= 83550))
    {
        taxB[1] = (adjGrossIncome - 20550) * 0.12;

    }

    if (adjGrossIncome > 83550)
    {
        taxB[1] = (83550 - 20550) * 0.12;
    }


    if (adjGrossIncome >= 83550 && adjGrossIncome <= 178150)
    {
        taxB[2] = (adjGrossIncome - 83550) * 0.22;
    }


    if (adjGrossIncome > 178150)
    {
        taxB[2] = (178150 - 83550) * 0.22;
    }


    if (adjGrossIncome >= 178150 && adjGrossIncome <= 340100)
    {
        taxB[3] = (adjGrossIncome - 178150) * 0.24;

    }
    if (adjGrossIncome > 340100)
    {
        taxB[3] = (340100 - 178150) * 0.24;
    }



    if (adjGrossIncome >= 340100 && adjGrossIncome <= 431900)
    {
        taxB[4] = (adjGrossIncome - 340100) * 0.32;
    }
    if (adjGrossIncome > 431900)
    {
        taxB[4] = (431900 - 340100) * 0.32;
    }


    if (adjGrossIncome >= 431900 && adjGrossIncome <= 647850)
    {
        taxB[5] = (adjGrossIncome - 431900) * 0.35;

    }
    if (adjGrossIncome > 647850)
    {
        taxB[5] = (647850 - 431900) * 0.35;
    }



    if (adjGrossIncome >= 647850)
    {
        taxB[6] = (adjGrossIncome - 647850) * 0.37;
    }


    for (int index4 = 0; index4 < 7; index4++)
    {
        taxesOwed += taxB[index4];

    }
}
void taxSingBrackCal() //Calculates taxes at each tax bracket
{
    for (int k = 0; k < 7; k++)
    {
        taxB[k] = 0;

    }
    if (adjGrossIncome <= 10275)
    {
        taxB[0] = adjGrossIncome * 0.10;
    }

    if (adjGrossIncome > 10275)
    {
        taxB[0] = 10275 * 0.10;
    }



    if ((adjGrossIncome >= 10275) && (adjGrossIncome <= 41775))
    {
        taxB[1] = (adjGrossIncome - 10275) * 0.12;

    }

    if (adjGrossIncome > 41775)
    {
        taxB[1] = (41775 - 10275) * 0.12;
    }


    if (adjGrossIncome >= 41775 && adjGrossIncome <= 89075)
    {
        taxB[2] = (adjGrossIncome - 41775) * 0.22;
    }


    if (adjGrossIncome > 89075)
    {
        taxB[2] = (89075 - 41775) * 0.22;
    }


    if (adjGrossIncome >= 89075 && adjGrossIncome <= 170050)
    {
        taxB[3] = (adjGrossIncome - 89075) * 0.24;

    }
    if (adjGrossIncome > 170050)
    {
        taxB[3] = (170050 - 89075) * 0.24;
    }



    if (adjGrossIncome >= 170050 && adjGrossIncome <= 215950)
    {
        taxB[4] = (adjGrossIncome - 170050) * 0.32;
    }
    if (adjGrossIncome > 215950)
    {
        taxB[4] = (215950 - 170050) * 0.32;
    }


    if (adjGrossIncome >= 215950 && adjGrossIncome <= 539900)
    {
        taxB[5] = (adjGrossIncome - 215950) * 0.35;

    }
    if (adjGrossIncome > 539900)
    {
        taxB[5] = (539900 - 215950) * 0.35;
    }



    if (adjGrossIncome >= 539900)
    {
        taxB[6] = (adjGrossIncome - 539900) * 0.37;
    }


    for (int index3 = 0; index3 < 7; index3++)
    {
        taxesOwed += taxB[index3];

    }
}
Output();

void Output() //Outputs Information in console
{
    Console.WriteLine(" -------------------------------------");
    Console.WriteLine("\n| Tax Bracket |  Taxes Owed           |");
    for (int j = 0; j < 7; j++)
    {
        Console.Write("\n| " + taxBNum[j] + "        |  $" + taxB[j]);

    }
    Console.WriteLine("\n-------------------------------------");
    Console.WriteLine("You owe $" + taxesOwed + " in taxes");
    if (adjGrossIncome != 0)
    {
        Console.WriteLine("Taxes as % of gross income " + (taxesOwed / total)*100 + "%");
        Console.WriteLine("Taxes as % of adjusted gross income " + (taxesOwed / adjGrossIncome)*100 + "%");
    }
    else
    {
        Console.WriteLine("Taxes as % of gross income " + "0" + "%");
        Console.WriteLine("Taxes as % of adjusted gross income " + "0" + "%");
    }
}


