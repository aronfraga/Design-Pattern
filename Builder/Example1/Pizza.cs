namespace Builder; 

public class Pizza {

    private string masa = "";
    private string salsa = "";
    private string relleno = "";

    public string getMasa() {
        return masa;
    }
    
    public void SetMasa(string masa) {
        this.masa = masa;
    }
    
    public string getSalsa() {
        return salsa;
    }
    
    public void SetSalsa(string salsa) {
        this.salsa = salsa;
    }

    public string getRelleno() {
        return relleno;
    }
    
    public void SetRelleno(string relleno) {
        this.relleno = relleno;
    }

}