// 3rd Day at BTK Akademi C# Programming Course

Console.Write("Enter your height (cm): ");
double h = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter your weight (kg): ");
double w = Convert.ToDouble(Console.ReadLine());

double hW = h / 100; // cm yi metre ye dönüştürdük

double hWi = w / (hW * hW);

Console.WriteLine($"Your height-weight index is {hWi:f2}");

if(hWi <= 18.5){
    Console.WriteLine("You are thin.");
}
else if(hWi <= 25){
    Console.WriteLine("You have normal height-weight index.");
}
else if(hWi < 30){
    Console.WriteLine("You are fat.");
}
else{ // more than 30
    Console.WriteLine("You are overweight.");
}

