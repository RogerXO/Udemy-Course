using System;
using Udemy_Course;



Console.WriteLine("Without ref");
int a = 10;
UsingRefAndOut.TripleNoRef(a);
Console.WriteLine(a);

Console.WriteLine();

//The variable passed with "ref" needs to be inicialized;
Console.WriteLine("With ref");
int b = 10;
UsingRefAndOut.TripleWithRef(ref b);
Console.WriteLine(b);

Console.WriteLine();

//The variable passed with "out" doesnt need to be inicialized;
Console.WriteLine("With out");
int c = 10;
int result;
UsingRefAndOut.TripleWithOut(c, out result);
Console.WriteLine(result);