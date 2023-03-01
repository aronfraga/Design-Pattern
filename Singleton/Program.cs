using Patterns;

Console.WriteLine("## Singleton");
Singleton s1 = Singleton.GetSetup("mirul", "mibasededatos");
Console.WriteLine("random s1: {0} - url: {1} - db: {2}", 
    s1.getRandom(),
    s1.GetUrl(),
    s1.getBaseDatos()
);

Singleton s2 = Singleton.GetSetup("mirul2", "mibasededatos2");
Console.WriteLine("random s2: {0} - url: {1} - db: {2}", 
    s2.getRandom(),
    s2.GetUrl(),
    s2.getBaseDatos()
);

Singleton s3 = Singleton.GetSetup("mirul3", "mibasededatos3");
Console.WriteLine("random s3: {0} - url: {1} - db: {2}", 
    s3.getRandom(),
    s3.GetUrl(),
    s3.getBaseDatos()
);