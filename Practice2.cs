// void TestString(string strName){
//     strName = "Inside";
// }

// string strName;

// strName = "Outside";
// Console.WriteLine(strName);
// TestString(strName);
// Console.WriteLine(strName);

// ///////////////////////////
// void TestString(string strName){    //Even if string is a reference type & we pass address of string, because its immutable 
//                                     //we cant change it inside the function. when we sat strName = "Test" its a reassignment -> new memory address
//     strName[0] = "Inside";
// }

// string strName;

// strName = "Outside";
// Console.WriteLine(strName);
// TestString(strName);
// Console.WriteLine(strName);



// void TestNumber(int intNum){
//     intNum = 10;
// }

// int intNum;

// intNum = 1;
// Console.WriteLine(intNum);
// TestNumber(intNum);
// Console.WriteLine(intNum);


// void IncrementAges(int[] ages)
// {
//     for (var i = 0; i < ages.Length; i++)
//     {
//         ages[i]++;
//     }
// }

// var ages = new[] { 25, 30, 50 };
// Console.WriteLine(string.Join(", ", ages));
// IncrementAges(ages);
// Console.WriteLine(string.Join(", ", ages));




// void ReassignAges(int[] agesRe)
// {
//     agesRe = new[] { 26, 31, 51 };
// }

// var agesRe = new[] { 25, 30, 50 };
// Console.WriteLine(string.Join(", ", agesRe));
// ReassignAges(agesRe);
// Console.WriteLine(string.Join(", ", agesRe));


