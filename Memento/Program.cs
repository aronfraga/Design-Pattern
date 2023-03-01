using Patterns.Memento;
using Patterns.Memento2;

Console.WriteLine("## Memento First Example");

Usuario usuario = new Usuario("Max", 22);
Console.WriteLine(usuario.getNombre() + " - " + usuario.getEdad() );
Usuario memento = usuario.getMemento(); // copia

usuario.setNombre("Maximiliano");
usuario.setEdad(32);

Console.WriteLine(usuario.getNombre() + " - " + usuario.getEdad() );
Console.WriteLine("Rollback -- " + memento.getNombre() + " - " + memento.getEdad() );

usuario.recuperarMemento(memento);

Console.WriteLine(usuario.getNombre() + " - " + usuario.getEdad() );
Console.WriteLine("Rollback -- " + memento.getNombre() + " - " + memento.getEdad() );

Console.WriteLine("");
Console.WriteLine("## Memento Second Example");

TextEditor textEditor = new TextEditor(new TextWindow());
textEditor.write("El patron memento de diseño");
textEditor.write(" Como implementarlo en c#");
textEditor.hitSave(); // guarde el estado del objeto con mememnto

textEditor.write(" tengo que pasar por el super");
textEditor.hitUndo(); //restauro al punto guardado

Console.WriteLine(textEditor.print());