int x = 10;
x += 7; // This will be x = x + 7, x = 10 + 7 = 17;
x *= 2;// This will be x = x * 2, x = 17 * 2 = 34;
x -= 2; // This will be x = x - 2; x = 34 - 2 = 32;
x /= 2; // This will be x = x / 2; x = 34 / 2 = 16;
x %= 2; // This will be x = x % 2, X = 16 % 2 = 0;
x += 10; // This will be again add 10 with the 0, so x = 10;
x &= 3; // This will be x = x & 2,
x |= 2; 

Console.WriteLine($"This is the value of x = {x}");
