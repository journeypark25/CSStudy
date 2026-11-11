interface IAnimal //관례상 대문자I로 시작한다.
{
    void Speak();
}

class Dog: IAnimal
{
    public void Speak() //반드시 만들어야 하고, public이어야 한다.
    {
        Console.WriteLine("WalkWalk");
    }
}

class Cat: IAnimal
{
    public void Speak()
    {
        Console.WriteLine("야옹~");
    }
}


class InterSample
{
    void AnimalSpeak()
    {
          IAnimal[] animals = {new Dog(), new Cat()};
          foreach(IAnimal item in animals)
        {
            item.Speak();
        }
    }
  

}