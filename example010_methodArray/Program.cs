int[] array = {1,2,3,4,0,5,6,7,8,9,0};
int n = array.Length;
int find = 0;
int index = 0;

while(index<n){
if(array[index]==find){
    Console.WriteLine(index);
    break;//после нахождения первого сходства следующие искать не будет
}
    index++;
}