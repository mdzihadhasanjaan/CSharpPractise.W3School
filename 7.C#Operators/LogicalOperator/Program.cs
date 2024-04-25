int x = 5;
int y = 6;
Console.WriteLine($"Is x less than 10 and less than y: {x < 10 && x < y} "); //returns true because x is less than 10 and less than y.
Console.WriteLine($"Is x greater than 10 or less than y:{x > 10 || x < y}"); // return true because one of the statement is true.
Console.WriteLine($"Is x not greater than 10 or less than y: {!(x > 10 || x < y)}"); // returns reverse answer.
