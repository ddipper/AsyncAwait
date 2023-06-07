

int n1 = await SquareAsync(5);
int n2 = await SquareAsync(6);

Console.WriteLine($"{n1} {n2}");

async Task<int> SquareAsync(int n)
{
    await Task.Delay(0);
    return n * n;
}











/*Func<string, Task> printer = async (message) =>
{
    await Task.Delay(2000);
    Console.WriteLine(message);
};

await printer("Hello world");
await printer("Hello dip");*/


/*var tomTask = PrintNameAsync("Tom");
var samTask = PrintNameAsync("Sam");
var bobTask = PrintNameAsync("Bob");

await tomTask;
await samTask;
await bobTask;


async Task PrintNameAsync(string name)
{
    Thread.Sleep(2000);
    Console.WriteLine(name);
}*/


/*await PrintAsync();
Console.WriteLine("Something in main");

async Task PrintAsync()
{
    await Task.Delay(2000);
    Console.WriteLine("hello dip");
}*/


/*class Program
{
    async static Task Main(string[] args)
    {
        await PrintAsync();
        Console.WriteLine("Something in main");
        
        void Print()
        {
            Thread.Sleep(3000);
            Console.WriteLine("Hello dip");
        }

        async Task PrintAsync()
        {
            Console.WriteLine("Start method");
            await Task.Run(() => Print());
            Console.WriteLine("End method");
        }
    }
}*/


/*await PrintAsync();
Console.WriteLine("Something in main");

void Print()
{
    Thread.Sleep(5000);
    Console.WriteLine("Hello dip");
}

async Task PrintAsync()
{
    Console.WriteLine("Start method PrintAsync");
    await Task.Run(() => Print());
    Console.WriteLine("End method PrintAsync");
}*/