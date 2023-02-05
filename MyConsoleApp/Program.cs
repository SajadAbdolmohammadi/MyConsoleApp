// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
MyClass obj = new MyClass("sajad", "mohamadi");
obj.Dispaly();
public class MyClass
{
    private string name;
    private string description;
    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
    public string Description
    {
        get
        {
            return description;
        }
        set
        {
            description = value;
        }
    }
    public MyClass(string name,string description)
    {
        this.name = name;
        this.description = description;
    }
    public void Dispaly()
    {
        Console.WriteLine("name is:{0} and description is:{1}", name, description);

    }
}
