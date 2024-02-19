
using System.Collections.Generic;

int number = 1;
List<string> lstPrint = new List<string>(); 
string strPrint = string.Empty;

while (number <=100){
    lstPrint.Clear();
    strPrint = "";
    if(number%3==0)
        lstPrint.Add("Fizz");
    if(number%13==0)
        lstPrint.Add("Fezz");
    if(number%5==0)
        lstPrint.Add("Buzz");
    if(number%7==0)
        lstPrint.Add("Bang");    
    if (number%11==0){
        lstPrint.Clear();
        lstPrint.Add("Bong");
    }
    if(number%13==0 && number%11==0){
        lstPrint.Clear();
        lstPrint.Add("FezzBong");           
    }

    if (lstPrint.Count == 0)
        Console.WriteLine(number);
    else if (number%17==0){
        for(var i=lstPrint.Count-1;i>=0;i--)
            strPrint += lstPrint[i];
        Console.WriteLine(strPrint);            
    }
    else{
        for(var i=0;i<lstPrint.Count;i++)
            strPrint += lstPrint[i];
        Console.WriteLine(strPrint);            
    } 
        
    number++;
}