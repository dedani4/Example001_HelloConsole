
int Max(int arg1, int arg2, int arg3){
    int maxMeth = arg1;
    if (arg2>maxMeth) maxMeth = arg2;
    if (arg3>maxMeth) maxMeth = arg3;
    return maxMeth;
}

int[] array ={144,355,5,7,9,54,56,74,45};

int max = Max(Max(array[0],array[1],array[2]), Max(array[3],array[4],array[5]), Max(array[6],array[7],array[8]));

Console.Write(max);
