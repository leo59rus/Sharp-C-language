int a = 12898;
int b = 123;
int c = 14;
int a1 = 2;
int b1 = 18987898;
int c1 = 142;
int a2 = 14;
int b2 = 150089;
int c2 = 100;

//int max = a;
//if(b > max) max = b;
//if(c > max) max = c;
//if(a1 > max) max = a1;
//if(b1 > max) max = b1;
//if(c1 > max) max = c1;
//if(a2 > max) max = a2;
//if(b2 > max) max = b2;
//if(c2 > max) max = c2;
//Console.WriteLine(max);

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;

}

//int max1 = Max(a,b,c);
//int max2 = Max(a1,b1,c1);
//int max3 = Max(a2,b2,c2);
//int max = Max(max1, max2, max3);

int max = Max(
    Max(a,b,c),
    Max(a1,b1,c1),
    Max(a2,b2,c2)
);

Console.WriteLine(max);


