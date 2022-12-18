Console.Clear();

void FillArray(int[] arrayToFill){
    int length = arrayToFill.Length;
    int index = 0;
    while (index<length){
        arrayToFill[index] = new Random().Next(1,10);
        index++;
    }
}

void PrintArray(int[] arrayToPrint){
    int length = arrayToPrint.Length;
    int index = 0;
    while (index<length){
        Console.WriteLine(arrayToPrint[index]);
        index++;
    }

}

int IndexOf(int[] arrayToSearch, int find){
    int length = arrayToSearch.Length;
    int index = 0;
    int concurrence = -1;
    while(index<length){
        if (arrayToSearch[index]==find){
            concurrence = index;
            break;
        }
        index++;
    }
    return concurrence;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int result = IndexOf(array, 4);
Console.WriteLine(result);



