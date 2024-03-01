// See https://aka.ms/new-console-template for more information
//using TopLevel Statements
using System.Diagnostics;
// namespace ClearCookiesApp;
// Console.WriteLine("Hello, World!");
try
{
    string edgePath = @"C:\Program Files (x86)\Microsoft\Edge\Application\msedge.exe";
    Console.WriteLine("Attempting to clear Edge cookies.. ");
    Thread.Sleep(1500);
    Process.Start(edgePath);
    Console.WriteLine("Edge cookies cleared successfully..! ");
    Thread.Sleep(2000);

}
catch (Exception e)
{
    Console.WriteLine($"Error clearing Edge cookies: {e.Message}");
    Console.ReadLine();
}