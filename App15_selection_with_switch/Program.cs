Console.Write("Enter the average of the grades: ");
int avg = Convert.ToInt32(Console.ReadLine());

string status = avg switch{
    >= 85 => "You got Takdir Belgesi!", // bunu "=>" ise gibi düşnebilirsin 
    >= 70 => "You got Teşekkür Belgesi!",
    >= 50 => "You passed!",
    _ => "You failed!!!"
};

Console.WriteLine(status);
