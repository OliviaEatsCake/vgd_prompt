//this is my code for march 12, today I did units 3-4 of module four
//I learned how to use string concatenation and string interpolation, as well as how to merge interpolation with verbatim strings
string firstName = "cake";
string greeting = " I would appreciate";
string message = $"{greeting} {firstName}";
Console.WriteLine(message);
string name = "Chappell";
string output = $"Queen {name}!!!!!";
Console.WriteLine(output);
int version = 11;
string updateText = "Update to Windows";
Console.WriteLine($"{updateText} {version}");
string projectName = "chappell-roan<3";
Console.WriteLine($@"C:\output\{projectName}\Data");
