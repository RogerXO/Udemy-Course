
using System.Drawing;

namespace Udemy_Course
{ 
Console.WriteLine("#66 - reference type and value type ");
Points p; //Error - needs to inicilize the struct before use it.
    p.X = 10;
p.Y = 20;
Console.WriteLine(p);
p= new Points();
    Console.WriteLine(p);
}