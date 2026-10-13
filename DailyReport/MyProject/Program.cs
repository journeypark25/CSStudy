using System.ComponentModel;
using System.Collections;
namespace CSStudy;

class Program{

static void Main(string[] args)
{
    // StackSample();
    // ListSample();
    // QueueSample();
// HashTableSample();
// DicSample();
ArraySample2();
}


static int CalculateSum(int[] scoresArray)
    {
        int sum = 0;
        for(int i=0; i<scoresArray.Length; i++)
        {
            sum+= scoresArray[i];
        }
        return sum;
    }
static void ArraySample2()
    {
        string[] players = new string[10];
        // string[] Regions = {"서울","경기","부산"};
        string[] Regions = new string[3]{"서울","경기","부산"};
        // Console.WriteLine(players.Length+","+Regions.Length);
        Console.WriteLine("{0},{1}", players.Length, Regions.Length);

        // string[,] Dept = new string[,]{};
        string[,] dept = {{"김","경리"},{"이","총무"}};
        // int[,] dsum = new int[,];
        int[,] dsum = new int[3,2];
        dsum[0,0] =0; dsum[0,1]=1; dsum[1,0]=2; dsum[1,1]=3; dsum[2,0] =4; dsum[2,1]=5;
        // dsum[0,2] =2; 배열 크키 초과
        // int[,] dsum2 = new int[3,2]{{0,1},{2,3},{3,4}};
        int[,] dsum2 = {{0,1},{2,3},{3,4}};

        string[,,] cubes; //3차원 배열 선언
        //가변배열
        // int[][] a= new int[3][];
        int[][] a = new int[3][];
        a[0] = new int[2]; a[0][0] =1; a[0][1] =2;
        a[1] = new int[3]{1,2,3};
        a[2] = new int[]{1,2,3,4};

        int total = 0;
        int[] scores = {80,78,60,90,100};
        total =  CalculateSum(scores);
        // for(int i=0; i<scores.length; i++)
        // {
        //     total += scores[i];
        // }
        // Console.WriteLine("합계: "+ total);
        // foreach(int item in scores)
        // {
        //     total+=item;
        // }

        Console.WriteLine("합계: {0}", total);
         
        
    }
static void DicSample()
    {
        Dictionary<int, string> emp = new Dictionary<int, string>();
       emp.Add(1001,"Jane");
        emp.Add(1002,"Tom");
        emp.Add(1003,"Cindy");
        string name = emp[1002];   Console.WriteLine(name);
        Dictionary<string, int> scores = new Dictionary<string, int>();
        scores.Add("철수",98);
        scores.Add("영희",95);
        int score = scores["철수"];

       Hashtable scores_ = new Hashtable();
        scores_.Add("철수",90); scores_.Add("영희", "95");
        Console.WriteLine(scores_["철수"]);
        // int score = (int)scores["철수"];

    string keystring = "영희";
    if(scores.ContainsKey(keystring)) Console.WriteLine(scores[keystring]);
    
    if(scores.ContainsKey("철수")) Console.WriteLine(score);
        SortedDictionary<int, string> tmap = new SortedDictionary<int, string>();
        tmap.Add(1001, "Tom");
        tmap.Add(1013, "John");
        tmap.Add(1010, "Irina");
        string name1010 = tmap[1010];
        foreach(KeyValuePair<int, string> kv in tmap)
        {
            Console.WriteLine("{0}:{1}", kv.Key, kv.Value);
        }
    }
static void HashTableSample()
    {
        Hashtable ht = new Hashtable();
        ht.Add("som","pje");
        ht.Add("irina","Irina SP");
        ht.Add("Tom","Tom Cr");
        if(ht.Contains("som")) Console.WriteLine(ht["som"]);
        else Console.WriteLine("No SOM Data");
    }
static void StackSample()
    {
        Stack<int>s = new Stack<int>();
        s.Push(10); s.Push(8); s.Push(16);
        Console.WriteLine("Peek:"+s.Peek());
        Console.WriteLine(s.Pop()); Console.WriteLine(s.Pop());


    }
static void QueueSample()
    {
        Queue<int> q = new Queue<int>();
        q.Enqueue(120); q.Enqueue(130); q.Enqueue(150);
        Console.Write("Queue Peek: ");
         Console.WriteLine(q.Peek());
        Console.WriteLine(q.Dequeue());
        Console.WriteLine(q.Dequeue());
       
    }
static void ListSample()
    {
         List<int> myList = new List<int>();
        myList.Add(88); myList.Add(90);
        myList.Add(75); myList.Sort();
        // Console.WriteLine(myList[0]); Console.WriteLine(myList[1]); Console.WriteLine(myList[2]);

        for(int i = 0;i< myList.Count() ;i++)
        {
            Console.WriteLine(myList[i]);
        }
    }
}