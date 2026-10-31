using System;

class Program
{
    static void Main()
    {
        BinarySearchTree arbol = new BinarySearchTree();

        int[] valores = { 45, 23, 67, 12, 34, 56, 89 };

        foreach (int valor in valores)
            arbol.Insert(valor);

        TreeTraversals recorrido = new TreeTraversals();

        Console.WriteLine("Preorden:");
        recorrido.PreOrder(arbol.Root);

        Console.WriteLine("\nInorden:");
        recorrido.InOrder(arbol.Root);

        Console.WriteLine("\nPosorden:");
        recorrido.PostOrder(arbol.Root);
    }
}
