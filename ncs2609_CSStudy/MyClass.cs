using System.Data;

public interface Icomparable
{
    int CompareTo(object obj);
}
public class MyClass5: IComparable
{
    int key;
    int value;
    public int CompareTo(object obj)
    {
        MyClass5 target = (MyClass5)obj;
        return this.key.CompareTo(target.key);
    }
    public void Run()
    {
        IDbConnection dbConn = GetDbConnection();
        dbConn.Open();
    }
    public IDbConnection GetDbConnection()
    {
        IDbConnection dbConn =null;
        string cn = "Connection";
        switch (cn)
        {
            case "SQLServer":
            // dbConn = new sqlConnection();
            break;
            case "Oracle":
            break;
        }
        return dbConn;
    }
}