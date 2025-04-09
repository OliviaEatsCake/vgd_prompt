//this is my code for april 9
//i learned how to use equations with bedmas, how to increment and decrement, turnication and how to prevent it, how to make all math equations and how to capture the remainder in division



int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quot = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quot);

decimal decimalQuotient = 7.0m / 5;
Console.WriteLine($"Decimal quotient: {decimalQuotient}");

int first = 7;
int second = 5;
decimal quotient = (decimal)first / (decimal)second;
Console.WriteLine(quotient);

Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}");
Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}");

int value1 = 3 + 4 * 5;
int value2 = (3+4)*5;
Console.WriteLine(value1);
Console.WriteLine(value2);


int value = 1;
value = value + 1;
Console.WriteLine("first increment " + value);
value +=1;
Console.WriteLine("second increment " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value -1;
Console.WriteLine("first decrement: " + value);

value-=1;
Console.WriteLine("Third decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);
Console.WriteLine("Third decrement: " + value);

int valu = 1;
valu++;
Console.WriteLine("First: " + valu);
Console.WriteLine($"Second: {valu++}");
Console.WriteLine("third: "+ valu);
Console.WriteLine("fourth: " + (++valu));
