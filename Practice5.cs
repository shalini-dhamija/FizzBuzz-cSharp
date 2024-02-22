void PrintCollection<T>(ICollection<T> enumerable)
{
    Console.WriteLine(string.Join(", ",enumerable));
}


var students = new List<(string name, Cohort cohort, int? score)>
{
    (name: "Alice", cohort: Cohort.AM, score: 92),
    (name: "Bob", cohort: Cohort.AM, score: null),
    (name: "Charlie", cohort: Cohort.AM, score: 70),
    (name: "David", cohort: Cohort.PM, score: 60),
    (name: "Eve", cohort: Cohort.PM, score: 99),
    (name: "Frank", cohort: Cohort.PM, score: 75),
};
// var cohortAverages = students
//     .Where(student => student.score != null)
//     .GroupBy(student => student.cohort)
//     .Select(group => (cohort: group.Key, averageScore: group.Count(student => student.score!= null)));

// foreach (var (cohort, average) in cohortAverages)
// {
//     Console.WriteLine($"Average for {cohort} cohort: {average}");
// }

var averageScore = students.Where(student => student.score != null)
                    .Average(student => student.score);
                    
                   
var ifAny = students.All(students => students.score!=null);
Console.WriteLine(averageScore);
PrintCollection(students);


enum Cohort
{
    AM,
    PM,
}
