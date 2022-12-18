int[] array = {5,7,4,9,89,45,2,76,14,4,43};

 int find = 4;
 int n = array.Length;

 int index = 0;

 while (index < n){
    if (array[index] == find) {
        Console.WriteLine (index);
        break;
    }
    index++;
 }
