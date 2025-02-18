namespace App44_static_method_variable_name;

public class Help_programming{
    public static bool IsValid(string name){
        Console.WriteLine($"{name} is being checked...");
        if(char.IsDigit(name[0])){
            return false;
        }
        foreach(char ch in name){
            if(char.IsWhiteSpace(ch)){
                return false;
            }
            if(char.IsSymbol(ch)){
                return false;
            }
            if(char.IsPunctuation(ch)){
                return false;
            }
        }
        return true;

    }

}
