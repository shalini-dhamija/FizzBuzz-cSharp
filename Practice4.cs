// foreach(var num in Enumerable.Range(1,10))
// {
//     Console.WriteLine($"Square of {num} is {num*num}");
// }


// int CalculateProduct(params int[] numbers)
// {
//     var product = 1;
//     foreach (var number in numbers)
//     {
//         product *= number;
//     }
//     return product;
// }
// Console.WriteLine(CalculateProduct(2, 4));
// Console.WriteLine(CalculateProduct(2, 4, 6));
// Console.WriteLine(CalculateProduct(2, 4, 6, 8));

// int CalculateProduct1(int[] numbers)
// {
//     var product = 1;
//     foreach (var number in numbers)
//     {
//         product *= number;
//     }
//     return product;
// }
// Console.WriteLine(CalculateProduct1(new[]{2, 4}));  //if no param then create a new array everytime & pass
// Console.WriteLine(CalculateProduct1([2, 4, 6]));    //This is new way of declaring array in C#, recent to match javascript
// Console.WriteLine(CalculateProduct1([2, 4, 6, 8]));