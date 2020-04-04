using System;
using System.IO;
using System.Text;

namespace ToUTF8
{
    /// <summary>
    /// 使用方式:
    ///     1. 通过命令行的方式打开文件所在目录
    ///     2. 通过命令: csc ToUTF8.cs 编译源文件，得到ToUTF8.exe
    ///     3. 将ToUTF8.exe放到需要批量执行的文件目录中，双击执行即可
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var dir = Directory.GetCurrentDirectory();
            foreach (var f in new DirectoryInfo(dir).GetFiles("*.cs", SearchOption.AllDirectories))
            {
                var s = File.ReadAllText(f.FullName, Encoding.Default);
                try
                {
                    File.WriteAllText(f.FullName, s, Encoding.UTF8);
                }
                catch (Exception)
                {
                    continue;
                }
            }
        }
    }
}