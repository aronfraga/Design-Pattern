namespace Patterns.Memento2; 

// caretaker gestion la entrada de datos hacia el mememnto
public class TextEditor {

    private TextWindow textWindow; // va a tener el editor de texto
    private TextWindowsState savedTextWindow; //posibilidad de guardar el estado

    public TextEditor(TextWindow textWindow) {
        this.textWindow = textWindow;
    }

    public void write(string text) {
        textWindow.addText(text);
    }

    public string print() {
        return textWindow.getCurrentText();
    }

    public void hitSave() {
        savedTextWindow = textWindow.save(); // saco la instantanea, foto del estado
    }

    public void hitUndo() {
        textWindow.restore(savedTextWindow); // volver para atras
    }
}