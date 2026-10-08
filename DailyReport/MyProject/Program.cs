using System.ComponentModel;

namespace CSStudy;

class Program{

static void Main(string[] args)
{
    // ListSample();
    QueueSample();
}


static void QueueSample()
    {
        Queue<int> q = new Queue<int>();
        q.Enqueue(120); q.Enqueue(130); q.Enqueue(150);
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