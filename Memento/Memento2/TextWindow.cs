using System.Text;

namespace Patterns.Memento2; 

// originador
public class TextWindow {

    private StringBuilder currentText;

    public TextWindow() {
        this.currentText = new StringBuilder();
    }

    public void addText(string text) {
        currentText.Append(text);
    }

    public string getCurrentText() {
        return currentText.ToString();
    }

    public TextWindowsState save() { // creando el memmento
        return new TextWindowsState(currentText.ToString()); // objeto memento este metodo le pasa al memento el texto para que lo guarde
    }

    public void restore(TextWindowsState save) {
        currentText = new StringBuilder(save.getText());
    }
}