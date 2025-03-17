//this is my code for march 17, level 5+ of unit 4
//i practiced how to use unicode, special characters and verbatim strings. 
string projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
string englishVersion = $@"C:\Exercise\{projectName}\Data.txt";
string russianVersion = $@"C:\Exercise\{projectName}\ru-RU\data.txt";
Console.Write($" View English output:\n\t\t{englishVersion}\n");
Console.WriteLine($"{russianMessage}: \n\t\t{russianVersion}\n");
