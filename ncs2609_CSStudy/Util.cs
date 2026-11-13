 
 namespace MyUtil;

 public class Util{
 public static void PrintArray(int[] answer){
        Console.Write("[");
       for(int i=0; i<answer.Length; i++)
        {
            Console.Write(answer[i]);
            if (i < answer.Length - 1)
            {
                Console.Write(",");
            }
            else Console.Write("]");
        }
 }

  public static void Swap(ref int x, ref int y)
    {
        Console.WriteLine($"x = {x}, y={y}");
        int temp = x;
        x= y;
        y = temp;
    }
    public delegate int CompareDelegate(int i1, int i2);
     public static void Sort(int[] arr, CompareDelegate comp)
    {
        if(arr.Length<2) return;
        Console.WriteLine("함수 Prototype:"+ comp.Method);
        int ret;
        for(int i=0; i<arr.Length-1; i++)
        {
            for(int j=i+1;j<arr.Length; j++)
            {
                ret = comp(arr[i], arr[j]);
                if(ret == -1)
                {
                   Swap(ref arr[i], arr[j]);
                }
            }
        }
        PrintArray(arr);
    }
 }
 
 
