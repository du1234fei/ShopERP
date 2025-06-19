namespace CoreCms.Net.UnitTest
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            for (int i = 0; i < 500; i++)
            {
                Console.WriteLine("--开始处理 任务-" + i);
                Console.WriteLine("--Start of the Program...线程 ID=" + Thread.CurrentThread.ManagedThreadId);

                //异步执行
                await DoSomething();

                Console.WriteLine("--end of the Program...线程ID=" + Thread.CurrentThread.ManagedThreadId);
            }

            Console.ReadLine();
        }

        static async Task DoSomething()
        {
            Console.WriteLine("--Async Operation before...线程ID=" + Thread.CurrentThread.ManagedThreadId);

            //模拟长时间运行的操作
            await Task.Delay(2000);

            Console.WriteLine("--Async Operation Completed...线程ID=" + Thread.CurrentThread.ManagedThreadId);
        }

    }
}
