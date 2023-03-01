using System.Text;
namespace Patterns.TemplateMethod; 

abstract public class Network {
    public string userName;
    public string password;

    public Network() {
        
    }

    public bool post(string mensaje) { // plantilla template method
        if (logIn(this.userName, this.password)) {
            bool resultado = enviarData(Encoding.ASCII.GetBytes(mensaje));
            logOut();
            return resultado;
        }

        return false;
    }

    abstract public bool logIn(string userName, string password);
    abstract public bool enviarData(byte[] data);
    abstract public void logOut();
    
}