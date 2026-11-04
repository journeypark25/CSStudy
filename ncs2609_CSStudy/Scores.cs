using System.ComponentModel.DataAnnotations.Schema;

class Scores
{
    private int[] data = new int[5];

    public int data
    {
        get{ return data[0];}
        set{data = value;}
    }
    public int this[int index]
    {
        get{return data[index];}
        set{data[index] = value;}
    }
}