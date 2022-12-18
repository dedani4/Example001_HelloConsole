
int Max(int arg1, int arg2, int arg3){
    int maxMeth = arg1;
    if (arg2>maxMeth) maxMeth = arg2;
    if (arg3>maxMeth) maxMeth = arg3;
    return maxMeth;
}

int a = 23, b = 23, c = 23, d = 63, e = 32, f = 48, g = 71, h = 13, i = 64;

/*
int max = a;
if(b>max) max = b; 
if(c>max) max = c;
if(d>max) max = d;
if(e>max) max = e;
if(f>max) max = f;
if(g>max) max = g;
if(h>max) max = h;
*/

/*
int max1 = Max(a,b,c);
int max2 = Max(d,e,f);
int max3 = Max(g,h,i);
int max = Max(max1,max2,max3);
*/

int max = Max(Max(a,b,c), Max(d,e,f), Max(g,h,i));

Console.Write(max);
