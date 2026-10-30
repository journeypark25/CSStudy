 
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
 }
 
 
