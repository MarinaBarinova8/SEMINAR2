// Задача 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. третья цифра слева.


 //Работает максимум для трехзначных (для однозначных, двухзначных, трехзначных)

void Numb3 (int num)
{
    if (num < -99 ||  num > 99)
    { 
        int n = 1;
        int digit_3 = num / n % 10;
        
     Console.WriteLine($"Your number is {digit_3}");
           
    }
    
    else Console.WriteLine("There is no third digit");
    
}

Console.Write("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());
Numb3 (num);




// вариант 2. Работает для четырехзначных, двухзначных, однозначных. для трехзначных не работает

/*void Numb3 (int num)
{
    if (num < -100 ||  num > 99)
    { 
        int n = 10;
        int digit_3 = num / n % 10;
        
        
     Console.WriteLine($"Your number is {digit_3}");
        
        
    }
    
    else Console.WriteLine("There is no third digit");
    
}

Console.Write("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());
Numb3 (num);
*/





// Вариант 3. Работает для пятизначных, двухзначных, однозначных. для трехзначных и четырехзначных не работает
/*void Numb3 (int num)
{
    if (num < -100 ||  num > 99)
    { 
        int n = 100;
        int digit_3 = num / n % 10;
        
        
     Console.WriteLine($"Your number is {digit_3}");
        
        
    }
    
    else Console.WriteLine("There is no third digit");
    
}

Console.Write("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());
Numb3 (num);
*/



//Вариант 4.  Работает для шестизначных, двухзначных, однозначных. для трехзначных и четырехзначных, пятизначных не работает

/*void Numb3 (int num)
{
    if (num < -100 ||  num > 99)
    { 
        int n = 1000;
        int digit_3 = num / n % 10;
        
        
     Console.WriteLine($"Your number is {digit_3}");
        
        
    }
    
    else Console.WriteLine("There is no third digit");
    
}

Console.Write("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());
Numb3 (num);
*/



// Вариант 5. Работает для семизначных, двухзначных, однозначных.  для трехзначных и четырехзначных, пятизначныхных, шестизначных не работает


/*void Numb3 (int num)
{
    if (num < -100 ||  num > 99)
    { 
        int n = 10000;
        int digit_3 = num / n % 10;
        
        
     Console.WriteLine($"Your number is {digit_3}");
        
        
    }
    
    else Console.WriteLine("There is no third digit");
    
}

Console.Write("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());
Numb3 (num);
*/