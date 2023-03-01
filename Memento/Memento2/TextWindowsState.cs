namespace Patterns.Memento2; 

// memento
// si quisiera tener varios estado deberia crear una coleccion de estados
public class TextWindowsState {

    private string text;

    public TextWindowsState(string text) { // guarda estado
        this.text = text;
    }

    public string getText() {
        return this.text;
    }
    
}