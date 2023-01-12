

Dictionary<string, string> cookies = new Dictionary<string, string>();

cookies["user"] = "alex";
cookies["email"] = "alex@gmail.com";
cookies["phone"] = "99999999";
cookies["phone"] = "00000000";

System.Console.WriteLine(cookies["user"]);

System.Console.WriteLine(cookies["phone"]);
cookies.Remove("phone");
if (cookies.ContainsKey("phone"))
{
    System.Console.WriteLine(cookies["phone"]);
}
else
{
    System.Console.WriteLine("Nao existe");
}

System.Console.WriteLine(cookies.Count);

cookies["phone"] = "00000000";

foreach (KeyValuePair<string, string> cookie in cookies)
{
    System.Console.WriteLine($"{cookie.Key}, {cookie.Value}");
}