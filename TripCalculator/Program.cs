//Part 1: Road Trip

Console.Write("Enter the round trip mileage: ");
int tripMileage = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the vehicle's gas mileage: ");
int gasMileage = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the price of gas: ");
double gasPrice = Convert.ToDouble(Console.ReadLine());

double gallonsNeeded = tripMileage / (double)gasMileage;

double fuelCost = gallonsNeeded * gasPrice;

System.Console.WriteLine("Gallons of gas needed: " + gallonsNeeded.ToString("F2"));
System.Console.WriteLine("Cost of fuel: " + fuelCost.ToString("C"));

//Part 2: Pizza Party



//Part 3: Paycheck

//Part 4: The Whole Trip

