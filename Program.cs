using System.ComponentModel;
using System.Collections;
using System.Text;
namespace CSStudy;

class Program
{

    static void Main(string[] args)
    {
            repeatSample();
            // EnumSample();
       // StringSample();
        // CodingGuide();v
        // ListSample();
        // QueueSample();
        // HashTableSample();
        // DicSample();
        // ArraySample2();

    }


static void repeatSample()
    {
        for(int i=0; i < 100; i++)
        {
            if(i%2==0) continue;
            //Console.WriteLine(i);
        string[] array = ["AB","CD","EF"];// new string[]{"AB",'CD","EF"};
        foreach(string s in array)
            {
                Console.WriteLine("string: {0}",s);
                foreach(char c in s)
                {
                    Console.WriteLine("char: {0}", c);                      
                    
                }

               } 
               //foreach(var item in)
               var dic = new Dictionary<int, char>();
               dic.Add(3,'a'); dic.Add(5,'z');
               foreach(var item in dic)
            {
                Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }

            string[,,] arr= new string[,,]
            {
                {{"1","2"},{"11","22"},
                {"3,","4"},{"33","44"}}};

            
// for(int i1=0; i1 < arr.GetLength(0); i1++)
//             {
//                 for(int j=0; j < arr.GetLength(1); j++)
//                 {
//                     for(int k=0; k<arr.GetLength(2); k++)
//                     {
//                         Console.WriteLine(arr[i1,j,k]);
//                     }
//                 }
//             }
            

            foreach(var item in arr) Console.WriteLine(item);
            int i2=1;
            while (i2 <= 10)
            {
                i2++;
                if(i2<4) continue;
                Console.WriteLine(i2);
                if(i2==7) break;
            }
            i2=10;
            while (i2 < 10)
            {
                Console.WriteLine(i2); i2++;
            }

            do
            {
                if (i2 > 10)
                {
                    Console.WriteLine("맞는 값이 없음");
                }
                else
                {
                    Console.WriteLine(i2);
                }
                i2++;
            } while (i2 <= 10);
            var KeyList = new List<char>();
            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey();
                KeyList.Add(key.KeyChar);
            }while(key.Key != ConsoleKey.Q);
            Console.WriteLine();
            foreach(var item in KeyList)
            {
                Console.Write(item);
            }
            
    }
    
    
    
    }
    static void OperatorSample()
    {
        int a= (1+2-3)*(4/5)%6;
        a+=3;
        int b =0;
        


    }
    enum City
    {
        Seoul,
        Daejeon,
        Busan = 5,
        Jeju = 10
    }
    public enum Category{
        Cake,
        IceCream,
        Bread
    }
    enum EnglishDay
    {
        Sunday, Monday, Tuesday, wednesday, Thursday, Friday, Saturday
    }

    [Flags]
    enum Border
    {
        None = 0, Top =1, Right = 2, Bottom = 4, Left = 8
    }
    static void EnumSample()
    {
        City myCity; myCity = City.Seoul; 
        int cityValue = (int)myCity;
        Console.WriteLine(cityValue);
        if(myCity == City.Seoul) Console.WriteLine("Welcome To Seoul");

        EnglishDay englishDay = EnglishDay.Thursday;
        if(englishDay == EnglishDay.Saturday || englishDay == EnglishDay.Sunday)
        {
            Console.WriteLine("Play all day..");
        }
        Border b = Border.Top | Border.Bottom;

        if ((b & Border.Top) != 0)
        {
            if (b.HasFlag(Border.Bottom))
            {
                Console.WriteLine(b.ToString());
            }
        } 
    }
    static void StringSample()
    {
        string s1 = "C#";
        string s2 = "Programming";

        String s3 = s1 + " " + s2;
        //    Console.WriteLine("String: {0} {1}",s1,s2);

        Console.WriteLine($"String:{s1}{s2}");
        string s3sub = s3.Substring(1, 5);
        Console.WriteLine("Sub: {0}", s3sub);

        string s = "C# studies";
        for (int i = 0; i < s.Length; i++)
        {
            Console.WriteLine("{0} {1}", i, s[i]);
        }
        char[] charArr2 = ['A', 'B', 'C', 'D'];
        string s34 = new string(charArr2);
        Console.WriteLine(s34);

        Char c1 = 'A';
        Char c2 = (char)(c1 + 3);
        Console.WriteLine(c2);

        StringBuilder sb = new StringBuilder();
        for (int i = 1; i <= 26; i++)
        {
            sb.Append(i.ToString());
            sb.Append(System.Environment.NewLine);
        }
        String s20 = sb.ToString();
        Console.WriteLine(s20);
        bool isValid = false;
        int a = 0, b = 1;
        if (isValid) a = 2;
        if (!isValid) b = 2;
        Console.WriteLine("a: {0}, b: {1}",a,b);

    }
    // public string Name
    // {
    //     get { return this.name; }
    //     set { this.Name = value; }
    // }
    static void CodingGuide()
    {
        bool condition = false;
        if (condition)
        {
            ArraySample2();
        }
        else ArraySample2();

        //나쁜 표현
        if (condition)
        {

            ArraySample2();
        }
        else
        {
            // 자바식 표현
        }

        for (int i = 0; i < 100; i++)
            ArraySample2();


        //예외처리
        int category = 0;
        switch (category)
        {
            case 0:
                // ArraySample();
                break;

            case 1:
                {
                    ArraySample2();
                }
                break;
        }
    }

    static int CalculateSum(int[] scoresArray)
    {
        int sum = 0;
        for (int i = 0; i < scoresArray.Length; i++)
        {
            sum += scoresArray[i];
        }
        return sum;
    }
    static void ArraySample2()
    {
        string[] players = new string[10];
        // string[] Regions = {"서울","경기","부산"};
        string[] Regions = new string[3] { "서울", "경기", "부산" };
        // Console.WriteLine(players.Length+","+Regions.Length);
        Console.WriteLine("{0},{1}", players.Length, Regions.Length);

        // string[,] Dept = new string[,]{};
        string[,] dept = { { "김", "경리" }, { "이", "총무" } };
        // int[,] dsum = new int[,];
        int[,] dsum = new int[3, 2];
        dsum[0, 0] = 0; dsum[0, 1] = 1; dsum[1, 0] = 2; dsum[1, 1] = 3; dsum[2, 0] = 4; dsum[2, 1] = 5;
        // dsum[0,2] =2; 배열 크키 초과
        // int[,] dsum2 = new int[3,2]{{0,1},{2,3},{3,4}};
        int[,] dsum2 = { { 0, 1 }, { 2, 3 }, { 3, 4 } };

        // string[,,] cubes; //3차원 배열 선언
        //가변배열
        // int[][] a= new int[3][];
        int[][] a = new int[3][];
        a[0] = new int[2]; a[0][0] = 1; a[0][1] = 2;
        a[1] = new int[3] { 1, 2, 3 };
        a[2] = new int[] { 1, 2, 3, 4 };

        int total = 0;
        int[] scores = { 80, 78, 60, 90, 100 };
        total = CalculateSum(scores);
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
        emp.Add(1001, "Jane");
        emp.Add(1002, "Tom");
        emp.Add(1003, "Cindy");
        string name = emp[1002]; Console.WriteLine(name);
        Dictionary<string, int> scores = new Dictionary<string, int>();
        scores.Add("철수", 98);
        scores.Add("영희", 95);
        int score = scores["철수"];

        Hashtable scores_ = new Hashtable();
        scores_.Add("철수", 90); scores_.Add("영희", "95");
        Console.WriteLine(scores_["철수"]);
        // int score = (int)scores["철수"];

        string keystring = "영희";
        if (scores.ContainsKey(keystring)) Console.WriteLine(scores[keystring]);

        if (scores.ContainsKey("철수")) Console.WriteLine(score);
        SortedDictionary<int, string> tmap = new SortedDictionary<int, string>();
        tmap.Add(1001, "Tom");
        tmap.Add(1013, "John");
        tmap.Add(1010, "Irina");
        string name1010 = tmap[1010];
        foreach (KeyValuePair<int, string> kv in tmap)
        {
            Console.WriteLine("{0}:{1}", kv.Key, kv.Value);
        }
    }
    static void HashTableSample()
    {
        Hashtable ht = new Hashtable();
        ht.Add("som", "pje");
        ht.Add("irina", "Irina SP");
        ht.Add("Tom", "Tom Cr");
        if (ht.Contains("som")) Console.WriteLine(ht["som"]);
        else Console.WriteLine("No SOM Data");
    }
    static void StackSample()
    {
        Stack<int> s = new Stack<int>();
        s.Push(10); s.Push(8); s.Push(16);
        Console.WriteLine("Peek:" + s.Peek());
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

        for (int i = 0; i < myList.Count(); i++)
        {
            Console.WriteLine(myList[i]);
        }
    }
}