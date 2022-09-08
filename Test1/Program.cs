int Number = new Random().Next(0,99999);
Console.WriteLine(Number);
string fivNum = Convert.ToString(Number);
if (fivNum.Length==5)
{
    if(fivNum[0]==fivNum[4] || fivNum[1]==fivNum[3])
    {
       Console.WriteLine("Полиндром");
    } 
    else
    {
       Console.WriteLine("Не полиндром"); 
    }
}
else
{
  Console.WriteLine("Число не является пятизначным");   
}
    
    

