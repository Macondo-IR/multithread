// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var task1=Task.Factory.StartNew(Method1);
var task2=Task.Factory.StartNew(Method2);
Task.WaitAll(new Task[]{task1,task2});
Console.ReadLine();

static void  Method1()
{
Console.WriteLine("Method1");
}
static void  Method2()
{
Console.WriteLine("Method2");
}