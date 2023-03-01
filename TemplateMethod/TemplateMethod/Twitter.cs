namespace Patterns.TemplateMethod; 

public class Twitter : Network {

    public Twitter(string userName, string password) {
        base.userName = userName;
        base.password = password;
    }
    
    public override bool logIn(string userName, string password) {
        Console.WriteLine("1a Nombre: " + userName + " - Password: " + password + " Ok!");
        Console.WriteLine("1b El usuario ha sido logueado en Twitter!");
        return true;
    }

    public override bool enviarData(byte[] data) {
        Console.WriteLine("2 El Mensaje: " + new string(data.ToString()) + "fue posteado en twitter");
        return true;
    }

    public override void logOut() {
        Console.WriteLine("3 El usuario ha cerrado sesion en twitter");
    }
}