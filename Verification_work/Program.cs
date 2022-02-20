using static System.Console;

void Printgivenarry(string[] givenarry)
{
    Write (" [ ");
    for (int i = 0; i < givenarry.Length; i++)
    {
        Write($"\"{givenarry[i]}\"");
        if(i==givenarry.Length - 1)
        {
            Write(" , ");
        }
        


    }
    Write(" ] ");
} 

string[] givenarry = { "1234", ":))","Russia", "-34", "ferst", "Monday", "2 5","0" };
Printgivenarry(givenarry);