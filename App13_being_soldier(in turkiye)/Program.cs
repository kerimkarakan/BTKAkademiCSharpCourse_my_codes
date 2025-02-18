Console.Write("Enter your age: ");
int age = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter your gender (M/F): ");
char gender = Convert.ToChar(Console.ReadLine());

if((gender == 'M' || gender == 'm') && age >= 20){ // veyaları parantez içine alıp öncelik belirledik
    Console.WriteLine("You can be a soldier!");
}
else{
    Console.WriteLine("You cannot be a soldier!");

    if(age < 20 && gender != 'F' && gender != 'f'){
        Console.WriteLine("Your AGE and GENDER does not satisfy the conditions for being a soldier.");
    }
    else if(age < 20){
        Console.WriteLine("Your AGE does not satisfy the conditions for being a soldier.");
    }
    else{
        Console.WriteLine("Your GENDER does not satisfy the conditions for being a soldier.");
    }
}

//bu if else farklı bir şekilde de yapılabilir mesela insan kız veya yaşı 20 den küçükse gidemez yazarız else de askere gidebilir yazarız
