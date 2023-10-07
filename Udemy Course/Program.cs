Dictionary<string, string> cookies = new();

cookies["user"] = "maria";
cookies["email"] = "maria@gmail.com";
cookies.Add("phone", "999999999");

Console.WriteLine(cookies["phone"]);

cookies.Remove("phone");

if (cookies.ContainsKey("phone"))
{
    Console.WriteLine("Phone: " + cookies["email"]);
}
else
{
    Console.WriteLine("There is no 'phone' key");
}

Console.WriteLine("Size: " + cookies.Count);

Console.WriteLine("All cookies:");
foreach (KeyValuePair<string, string> item in cookies)
{
    Console.WriteLine($"{item.Key}: {item.Value}");
}
