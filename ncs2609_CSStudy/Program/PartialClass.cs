using System.Runtime.CompilerServices;

partial class Pclass
{
    public void Run()
    {
     
    }   public void Get(int a){}
    partial class Pclass
    {
        public void Put(){}
    }
    partial struct Pstruct
    {
        public int ID;
    }
    partial struct Pstruct
    {
        public string Name;
        public Pstruct(int id, string name)
        {
            this.ID = id;
            this.name = name;
        }
    }
    partial interface IDoable
    {
        string name {get; set;}
    }
   
}