int r_num = new Random().Next(1, 100);
int guess = 5;

Console.WriteLine("The number: "+ r_num);

do{
    Console.Write($"You have {guess} guesses. Enter a number between 1-100: ");
    int u_num = Convert.ToInt32(Console.ReadLine());
    guess--; // kullanıcının tahmin etme hakkını 1 tane azaltıyorum her seferinde

    if(u_num > r_num){
        Console.WriteLine("Enter a smaller number!");
    }
    else if(u_num < r_num){
        Console.WriteLine("Enter a bigger number!");
    }
    else{
        Console.WriteLine("Your guess is correct! Congratulations you won!");
        break;
    }

    if(guess == 0){
        Console.Write($"You are out of guesses. The number was {r_num} \nDo you want to continue playing? If yes press Y/y, if no press N/n: ");
        char answer = Convert.ToChar(Console.ReadLine());
        if(answer == 'Y' || answer == 'y'){
            guess = 5;
            r_num = new Random().Next(1, 100);
            Console.WriteLine("The number: "+ r_num);
        }
        else{
            Console.WriteLine("Game is over. \nThe number was "+ r_num);
            break;
        }
    }
} while(true);



