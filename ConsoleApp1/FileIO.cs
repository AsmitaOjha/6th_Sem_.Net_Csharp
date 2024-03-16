using System.IO;
public class FileIO{
public void LearnFileHandling(){
    var ReadFile = File.ReadAllText(@"E:\Programming\Dot_NET_practice_6th_sem\ConsoleApp1\Myintro.txt");
    Console.ForegroundColor=ConsoleColor.DarkBlue;
   
    Console.WriteLine(ReadFile);
}
}