using System.Diagnostics;
using System;

Process p = new Process()  
{
    StartInfo = new ProcessStartInfo("cmd.exe")
    {
       RedirectStandardInput = true,
       RedirectStandardOutput = true,
       UseShellExecute = false,
       CreateNoWindow = true
    }
};





int f = 512;
Console.WriteLine("flooding .....");
while (f > 1)
    {
        Random rand = new Random();
    int stringlen = rand.Next(4, 10);
    int randValue;
    string str = "";
    char letter;
    for (int i = 0; i < stringlen; i++) {
    randValue = rand.Next(0, 26);
    letter = Convert.ToChar(randValue + 65);
    str = str + letter;
}
    string command = "echo :)))) > ";
    string filename = str;
    string fullcommand = command + filename + ".txt";
    p.Start();
    using (StreamWriter sw = p.StandardInput)
    {
        sw.WriteLine(fullcommand);
        sw.WriteLine(fullcommand);
    }
    f -= 1;
}
