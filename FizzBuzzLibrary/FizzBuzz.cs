namespace FizzBuzzLibrary;
public class FizzBuzz
{
    public string GetResult(int nmbr)
    {
        string result = "";

        if (nmbr > 100) throw new Exception("Number exceeds 100");
        if (nmbr < 0) throw new Exception("Negative number");

        for (int ndx = 1; ndx < nmbr + 1; ndx++)
        {
            if (ndx % 3 == 0 && ndx % 5 == 0)
            {
                result += "FizzBuzz ";
            }
            else if (ndx % 3 == 0)
            {
                result += "Fizz ";
            }
            else if (ndx % 5 == 0)
            {
                result += "Buzz ";
            }
            else
            {

                result += ndx.ToString() + " ";
            }
        }

        return result;
    }
}