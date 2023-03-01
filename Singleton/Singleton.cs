namespace Patterns;

public class Singleton {

    private string _url;
    private string _database;
    private double _random;

    private static Singleton setup; //  

    public static Singleton GetSetup(string url, string database) {
        if (setup == null) {
            setup = new Singleton(url, database);
        }
        return setup;
    }

    public Singleton (string url, string database) {
        Random random = new Random();
        _url = url;
        _database = database;
        _random = random.NextDouble();
    }

    public string GetUrl() {
        return _url;
    }
    
    public void setUrl(String url) {
       _url = url;
    }

    public String getBaseDatos() {
        return _database;
    }

    public void setBaseDatos(String database) {
        _database = database;
    }

    public double getRandom() {
        return _random;
    }

    public void setRandom(double random) {
        _random = random;
    }
    
}