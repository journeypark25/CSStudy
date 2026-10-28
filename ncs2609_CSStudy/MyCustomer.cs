namespace MyClass;

public class MyCustomer
{
    //private 생략하는 추세
    string name;
    int age;
    public bool isMen;

    public event EventHandler NameChanged;
    //생성자
    public MyCustomer()
    {
        name = "홍길동";
        age = -1;
        isMen = true;
    }

    public MyCustomer(string name, int age, bool isMen)
    {
        this.age = age;
        this.isMen = isMen;
        this.name = name;
    }
    //소멸자

    public string Name
    {
        get{return this.name;}
        set
        {
            if(name!= value)
            {
                name = value;
                if (NameChanged != null)
                {
                    NameChanged(this, EventArgs.Empty);
                }
            }

        }
    }
    public int Age
    {
        get
        {
            return age;
        }
        set{age = value;}
    }
    public string GetCustomerData()
    {
        string sex = isMen ? "남": "여";
        // string data = string.Format("이름: {0}, 나이: {1}, 성별: {2}",name, age, sex);
        string data = $"이름: {name}, 나이: {age}, {sex}";
        return data;
    }

    private int GetMaxAge()
    {
        return 100;
    }
}