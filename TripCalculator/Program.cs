//Part 1: Road Trip

Console.Write("Enter the round trip mileage (no nondecimal values): ");
double tripMileage = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the vehicle's gas mileage (no nondecimal values): ");
double gasMileage = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the price of gas (no nondecimal values): ");
double gasPrice = Convert.ToDouble(Console.ReadLine());

double gallonsNeeded = tripMileage / gasMileage;

double fuelCost = gallonsNeeded * gasPrice;

System.Console.WriteLine("Gallons of gas needed: " + gallonsNeeded.ToString("F2"));
System.Console.WriteLine("Cost of fuel: " + fuelCost.ToString("C"));
System.Console.WriteLine();

//Part 2: Pizza Party

const int PIZZA_SLICES = 8;

Console.Write("Enter the number of people going (no nondecimal values): ");
int numberGoing = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the number of pizzas to purchase (no nondecimal values): ");
int numberPizzas = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the price per pizza (no nondecimal values): ");
double pizzaPrice = Convert.ToDouble(Console.ReadLine());

int numberSlices = numberPizzas * PIZZA_SLICES;

double slicesPerPerson = numberSlices / numberGoing;
//Lines 37 and 42 convert remaining slices in a more practical format.
int leftoverSlices = numberSlices % numberGoing;

double pizzaCost = numberPizzas * pizzaPrice;

System.Console.WriteLine("Total slices of pizza (no nondecimal values): " + numberSlices.ToString("F0"));
System.Console.WriteLine("Slices per person (no nondecimal values): " + ((int)slicesPerPerson).ToString("F0"));
System.Console.WriteLine("Leftover slices (no nondecimal values): " + leftoverSlices.ToString("F0"));
System.Console.WriteLine("Total cost of pizzas (no nondecimal values): " + pizzaCost.ToString("C"));
System.Console.WriteLine();

//Part 3: Paycheck

const double TAX_RATE = 0.18;

Console.Write("Enter the number of hours you work each week (no nondecimal values): ");
double hoursWorked = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter your hourly pay (no nondecimal values): ");
double hourlyPay = Convert.ToDouble(Console.ReadLine());

double grossPay = hoursWorked * hourlyPay;

double taxWithheld = grossPay * TAX_RATE;

double netPay = grossPay - taxWithheld;

System.Console.WriteLine("Your weekly gross pay: " + grossPay.ToString("C"));
System.Console.WriteLine("Taxes withheld weekly: " + taxWithheld.ToString("C"));
System.Console.WriteLine("Your weekly net pay: " + netPay.ToString("C"));
System.Console.WriteLine();

//Part 4: The Whole Trip

double tripTotalCost = fuelCost + pizzaCost;

double tripIndividualCost = tripTotalCost / numberGoing;

double netHourlyPay = netPay / hoursWorked;

double hoursNeeded = tripIndividualCost / netHourlyPay;

TimeSpan hoursNeededFormatted = TimeSpan.FromHours(hoursNeeded);

System.Console.WriteLine();
System.Console.WriteLine("Total trip cost: " + tripTotalCost.ToString("C"));
System.Console.WriteLine("Trip cost per person: " + tripIndividualCost.ToString("C"));
System.Console.WriteLine("Your hourly net pay: " + netHourlyPay.ToString("C"));
System.Console.WriteLine("Time you must work this week to cover your share (hh:mm): " + hoursNeededFormatted.ToString(@"hh\:mm"));

