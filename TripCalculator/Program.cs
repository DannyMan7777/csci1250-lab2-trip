/*
 ==============================================================================
 * Name: Daniel McKinney
 * Course: CSCI 1250, Section 002
 * Assignment: Lab 02, Trip Calculator
 * Date: September 22, 2026
 * Description: Calculates the fuel, food, and work hours behind one road trip.
 ==============================================================================
 */

//Part 1: Road Trip

System.Console.WriteLine("  ============ Part 1: Road Trip ============");
Console.Write("Enter the round trip mileage (no nondecimal values): ");
double tripMileage = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the vehicle's gas mileage (no nondecimal values): ");
double gasMileage = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the price of gas (no nondecimal values): ");
double gasPrice = Convert.ToDouble(Console.ReadLine());

double gallonsNeeded = tripMileage / gasMileage;

double fuelCost = gallonsNeeded * gasPrice;

System.Console.WriteLine("\n  ===== RESULTS =====");
System.Console.WriteLine("Gallons of gas needed: " + gallonsNeeded.ToString("F2"));
System.Console.WriteLine("Cost of fuel: " + fuelCost.ToString("C"));

//Part 2: Pizza Party

const int PIZZA_SLICES = 8;

System.Console.WriteLine("\n  ============ Part 2: Pizza Party ============");
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

System.Console.WriteLine("\n  ===== RESULTS =====");
System.Console.WriteLine("Total slices of pizza: " + numberSlices.ToString("F0"));
System.Console.WriteLine("Slices per person: " + ((int)slicesPerPerson).ToString("F0"));
System.Console.WriteLine("Leftover slices: " + leftoverSlices.ToString("F0"));
System.Console.WriteLine("Total cost of pizzas: " + pizzaCost.ToString("C"));

//Part 3: Paycheck

const double TAX_RATE = 0.18;

System.Console.WriteLine("\n  ============ Part 3: Paycheck ============");
Console.Write("Enter the number of hours you work each week (no nondecimal values): ");
double hoursWorked = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter your hourly pay (no nondecimal values): ");
double hourlyPay = Convert.ToDouble(Console.ReadLine());

double grossPay = hoursWorked * hourlyPay;

double taxWithheld = grossPay * TAX_RATE;

double netPay = grossPay - taxWithheld;

System.Console.WriteLine("\n  ===== RESULTS =====");
System.Console.WriteLine("Your weekly gross pay: " + grossPay.ToString("C"));
System.Console.WriteLine("Taxes withheld weekly: " + taxWithheld.ToString("C"));
System.Console.WriteLine("Your weekly net pay: " + netPay.ToString("C"));

//Part 4: The Whole Trip

double tripTotalCost = fuelCost + pizzaCost;

double tripIndividualCost = tripTotalCost / numberGoing;

double netHourlyPay = netPay / hoursWorked;

double hoursNeeded = tripIndividualCost / netHourlyPay;

TimeSpan hoursNeededFormatted = TimeSpan.FromHours(hoursNeeded);

System.Console.WriteLine("\n  === FINAL RESULTS ===");
System.Console.WriteLine("Total trip cost: " + tripTotalCost.ToString("C"));
System.Console.WriteLine("Trip cost per person: " + tripIndividualCost.ToString("C"));
System.Console.WriteLine("Your hourly net pay: " + netHourlyPay.ToString("C"));
System.Console.WriteLine("Time you must work this week to cover your share (hh:mm): " + hoursNeededFormatted.ToString(@"hh\:mm"));

