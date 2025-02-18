string[] names = new string[3];
double[] avgs = new double[3];

for(int i = 0; i < names.Length; i++){
    Console.Write($"Enter the name of the student {i+1}: ");
    names[i] = Console.ReadLine();

    Console.Write($"Enter the average grade of the student {i+1}: ");
    avgs[i] = Convert.ToDouble(Console.ReadLine());
}

string title1 = "Student Name";
string title2 = "Average";

Console.WriteLine($"{title1, -18} | {title2, 15}");
Console.WriteLine("------------------------------------"); // 36 tane

for(int i = 0; i < names.Length; i++){
    Console.WriteLine($"{names[i], -18} | {avgs[i], 15}");
}

double sum_of_all_avg = 0;

foreach(var avg in avgs){
    sum_of_all_avg += avg;
}

double class_avg = sum_of_all_avg / avgs.Length;
Console.WriteLine($"Class average: {class_avg:f2}"); // f2 virgülden sonra 2 basamak göstermesini sağlıyor

double biggest_avg = Double.MinValue;
string name_of_student_w_biggest_avg = "";

for(int i = 0; i < avgs.Length; i++){
    if(avgs[i] > biggest_avg){
        biggest_avg = avgs[i];
        name_of_student_w_biggest_avg = names[i];
    }
}
Console.WriteLine($"The student that has the biggest average: {name_of_student_w_biggest_avg}");