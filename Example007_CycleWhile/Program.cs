Console.Clear();
//Console.SetCursorPosition(10,4);
//Console.WriteLine("+");

int xa = 40, ya = 1, xb = 1, yb = 30, xc = 80, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = 25, y = 15;

int count = 0;

while (count < 8000){
    int random = new Random().Next(0,3);

    if (random == 0){
        x = (x + xa)/2;
        y = (y + ya)/2;
    }
    if (random == 1){
        x = (x + xb)/2;
        y = (y + yb)/2;
    }
    if (random == 2){
        x = (x + xc)/2;
        y = (y + yc)/2;
    }

    Console.SetCursorPosition(x,y);
    Console.WriteLine("+");
    count++;
}
Console.SetCursorPosition(1,31);
    Console.WriteLine("+");


