using static System.Console;

void Printgivenarry(string[] givenarray)
{
    Write ("[");
    for (int i = 0; i < givenarray.Length; i++)
    {
        Write($"\"{givenarray[i]}\"");
        if(i!=givenarray.Length - 1)
        {
            Write(", ");
        }
       
    }
    Write("] ");
} 

int AmountOfElements(string [] givenarray)
{
    int StrigOfNumber = 0;
    for (int i = 0; i < givenarray.Length; i++)
    {
        if (givenarray[i].Length <4 )
        {
             StrigOfNumber ++;
        }
    }
    return StrigOfNumber;
}
string [] SortedCreatedArray (string [] givenarray, int sizNewArray)
{
    string [] newStingArray = new string [sizNewArray];
    int j = 0;
    for (int i = 0; i < givenarray.Length; i++)
    {
        if (givenarray[i].Length <4)
        {
            newStingArray[j] = givenarray[i];
            j++;

        }
        

    }
    return newStingArray;
}

string[] givenarray = { "1234", ":))","Russia", "-34", "ferst", "Monday", "2 5","0" };
Printgivenarry(givenarray);

int sizNewArray = AmountOfElements(givenarray);
string [] newStingArray = SortedCreatedArray(givenarray,sizNewArray);
Write(" => ");

Printgivenarry(newStingArray);
WriteLine();
