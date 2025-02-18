bool valid = false;

do{
 Console.Write("Enter your password: ");
 string password = Console.ReadLine();

 int letters = 0, numbers = 0, special_char = 0;

 if(password.Length >= 6){
    foreach(char ch in password){
        if(char.IsLetter(ch)){
            letters++;
        }
        else if(char.IsDigit(ch)){
            numbers++;
        }
        else if(char.IsSymbol(ch) || char.IsPunctuation(ch)){
            special_char++;
        }
    }
    if(numbers > 0 && letters > 0 && special_char > 0){
        Console.WriteLine("The password is valid.");
        valid = true;
    }
    else{
        Console.WriteLine("Your password should contain letters, numbers and special characters. Please try again.");
    }
 }
 else{
    Console.WriteLine("Your password should contain at least 6 characters.");
 }
} while(valid == false);