string pin = "1234";
string guess = "";
while(pin != guess){
    Console.Write("Enter the pin: ");
    guess = Console.ReadLine();

    if(guess != pin){
        Console.WriteLine("Your pin is not correct. Try again.");
    }
}

Console.WriteLine("Your pin is correct!");