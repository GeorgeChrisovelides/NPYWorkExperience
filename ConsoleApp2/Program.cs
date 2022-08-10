                            // METHODS

static void SayHi(string name, int age)
{
    Console.WriteLine("Hello " + name + " you are " + age);
}

SayHi("Bob", 34); // calling new method
SayHi("Jim", 12);

                            // RETURN STATEMENTS

static int cube(int num)  // int can also be double, array  etc
{
    int result = num * num * num;

    return result;
}
/*
Console.WriteLine(cube(6));
int number = cube(5);
Console.WriteLine(number);
*/
                            // IF STATEMENTS    

bool isMale = false;
bool isTall = false;

if (isMale && isTall)  // && means and
{
    Console.WriteLine("You are a tall male");
} else if (isMale && !isTall) {   // ! is negation operator
    Console.WriteLine("You are a short male");

} else if (!isMale && isTall) {
    Console.WriteLine("You are not male but you are tall");
}else
{    
    Console.WriteLine("You are not male and not tall");
}



if (isMale || isTall)  // || means or
{
    Console.WriteLine("You are either tall or male");
}
else
{
    Console.WriteLine("You are neither tall or male");
}



static int GetMax(int num1, int num2, int num3)  // comparatives, == means equivalent, != means not equals
{
    int result;

    if (num1 >= num2 && num1 >= num3)
    {
        result = num1;
    }
    else if (num2 >= num1 && num2 >= num3)
    {
        result = num2;
    }
    else
    {
        result = num3;
    }
    
        

    return result;
}

Console.WriteLine(GetMax(2, 6, 7));

int test = 45;
Console.WriteLine(int.Parse(test.ToString()));




new Thread(() =>
{

    Thread.CurrentThread.IsBackground = true;

    int TimeBetweenTriggers = 5;

    DateTime TriggerTime = DateTime.Now;

    while (true)
    {
        DateTime dateTimeNow = DateTime.Now;

        if (dateTimeNow > TriggerTime.AddSeconds(TimeBetweenTriggers))
        {
            
            Console.WriteLine("event triggered " + DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00") );

            TriggerTime = DateTime.Now;
        }
        else
        {
            Thread.Sleep(100);
        }

    }


}).Start();

Console.ReadLine();