using Patterns.TemplateMethod;

Console.WriteLine("## Template Method");
Network network1 = new Facebook("ana", "154321");
network1.post("este es mi primer post en facebook");

Console.WriteLine("");
Network network2 = new Twitter("ana", "154321");
network1.post("este es mi primer post en twitter");