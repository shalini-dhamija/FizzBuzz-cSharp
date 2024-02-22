// /*Write a program to check whether an oven is at the right temperature to cook a potato. 
// The following temperature ranges in degrees Celsius apply:
// Less than 180 is too cold
// Between 180 and 220 is just right
// More than 220 is too hot
// You should write different versions of the program to try each of the following:
// An if-else block
// Ternary conditional operators
// A switch statement
// A switch expression
// */

// decimal ovenTemp;

// Console.WriteLine("Enter the oven Temperature");
// ovenTemp = decimal.Parse(Console.ReadLine() ?? "");

// // Console.WriteLine(ovenTemp<180
// //                 ?"Less than 180 is too cold"
// //                 :ovenTemp>=180 && ovenTemp<=220
// //                     ?""
// //                     :"More than 220 is too hot");

// // switch (ovenTemp)
// // {
// //     case < 180:
// //         Console.WriteLine("Less than 180 is too cold");
// //         break;
// //     case >220:
// //         Console.WriteLine("More than 220 is too hot");
// //         break;
// //     default:  
// //         Console.WriteLine("Between 180 and 220 is just right");
// //         break; 
// // }

// // Console.WriteLine(ovenTemp switch{
// //     < 180 => "Less than 180 is too cold",
// //     >220 => "More than 220 is too hot",
// //     _ => "Between 180 and 220 is just right"
// // });

// // Console.WriteLine((ovenTemp>=180, ovenTemp<=220) switch{
// //     (false,true) => "Less than 180 is too cold",
// //     (true,false) => "More than 220 is too hot",
// //     (true,true) => "Between 180 and 220 is just right"
// // });



// switch (ovenTemp)
// {
//     case < 180:
//         Console.WriteLine("Less than 180 is too cold");
//         break;
//     case >=180 and <=220:   //C# Pattern Matching
//         Console.WriteLine("Between 180 and 220 is just right");
//         break; 
//     case >220:
//         Console.WriteLine("More than 220 is too hot");
//         break;    
// }