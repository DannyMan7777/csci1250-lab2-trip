//Part 1: Road Trip

Console.Write("Enter the round trip mileage (no nonnumeric values): ");
double tripMileage = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the vehicle's gas mileage (no nonnumeric values): ");
double gasMileage = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the price of gas (no nonnumeric values): ");
double gasPrice = Convert.ToDouble(Console.ReadLine());

double gallonsNeeded = tripMileage / gasMileage;

double fuelCost = gallonsNeeded * gasPrice;

System.Console.WriteLine("Gallons of gas needed: " + gallonsNeeded.ToString("F2"));
System.Console.WriteLine("Cost of fuel: " + fuelCost.ToString("C"));

//Part 2: Pizza Party

const int PIZZA_SLICES = 8;

Console.Write("Enter the number of people going (no nonnumeric values): ");
int numberGoing = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the number of pizzas to purchase (no nonnumeric values): ");
int numberPizzas = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the price per pizza (no nonnumeric values): ");
double pizzaPrice = Convert.ToDouble(Console.ReadLine());

int numberSlices = numberPizzas * PIZZA_SLICES;

double slicesPerPerson = numberSlices / numberGoing;

int leftoverSlices = numberSlices % numberGoing;

double pizzaCost = numberPizzas * pizzaPrice;

System.Console.WriteLine("Total slices of pizza (no nonnumeric values): " + numberSlices.ToString("F0"));
System.Console.WriteLine("Slices per person (no nonnumeric values): " + ((int)slicesPerPerson).ToString("F0"));
System.Console.WriteLine("Leftover slices (no nonnumeric values): " + leftoverSlices.ToString("F0"));
System.Console.WriteLine("Total cost of pizzas (no nonnumeric values): " + pizzaCost.ToString("C"));

//Part 3: Paycheck

const double TAX_RATE = 0.18;

Console.Write("Enter the number of hours you will work this week (no nonnumeric values): ");
double hoursWorked = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter your hourly pay (no nonnumeric values): ");
double hourlyPay = Convert.ToDouble(Console.ReadLine());

double grossPay = hoursWorked * hourlyPay;

double taxWithheld = grossPay * TAX_RATE;

double netPay = grossPay - taxWithheld;

System.Console.WriteLine("This week's gross pay: " + grossPay.ToString("C"));
System.Console.WriteLine("Tax withheld: " + taxWithheld.ToString("C"));
System.Console.WriteLine("This week's net pay: " + netPay.ToString("C"));

//Part 4: The Whole Trip

