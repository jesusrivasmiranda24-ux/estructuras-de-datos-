using System;

class Program
{
    static void Main()
    {
        BinarySearchTree arbol = new BinarySearchTree();

        int[] valores = { 45, 23, 67, 12, 34, 56, 89 };

        foreach (int valor in valores)
            arbol.Insert(valor);

        Console.WriteLine("Nodos hoja:");
        MostrarHojas(arbol.Root);
    }

    static void MostrarHojas(Node nodo)
    {
        if (nodo == null) return;

        if (nodo.Left == null && nodo.Right == null)
            Console.Write(nodo.Data + " ");

        MostrarHojas(nodo.Left);
        MostrarHojas(nodo.Right);
    }
}
