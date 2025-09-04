namespace setup
{
    public class FizzBuzz

    {
    }

    for (int i = 0; i < 100; i++)
    {
        fizz(i);
    }

    string fizz(int number)
    {
        if (number % 3 == 0)
        {
            return "Fizz";
        }
        else if (number % 5 == 0)
        {
            return "Buzz";
        }
        else if (number % 3 == 0 && number % 5 == 0)
        {
            return "FizzBuzz";
        } 

        return null;
    }
    
    }
