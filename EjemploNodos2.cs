using System;
using System.Collections.Generic;

// Clase que representa cada nodo del árbol
public class Node
{
    public int Data;
    public Node Left;
    public Node Right;

    public Node(int data)
    {
        Data = data;
        Left = null;
        Right = null;
    }
}

// Clase que implementa los recorridos del árbol
public class TreeTraversals
{
    // 1. Recorrido Preorden (Root, Left, Right)
    public void PreOrder(Node node)
    {
        if (node == null)
            return;

        Console.Write(node.Data + " ");

        PreOrder(node.Left);
        PreOrder(node.Right);
    }

    // 2. Recorrido Inorden (Left, Root, Right)
    public void InOrder(Node node)
    {
        if (node == null)
            return;

        InOrder(node.Left);

        Console.Write(node.Data + " ");

        InOrder(node.Right);
    }

    // 3. Recorrido Posorden (Left, Right, Root)
    public void PostOrder(Node node)
    {
        if (node == null)
            return;

        PostOrder(node.Left);
        PostOrder(node.Right);

        Console.Write(node.Data + " ");
    }

    // 4. Recorrido BFS por niveles (Queue FIFO)
    public void LevelOrder(Node root)
    {
        if (root == null)
            return;

        Queue<Node> queue = new Queue<Node>();

        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            Node current = queue.Dequeue();

            Console.Write(current.Data + " ");

            if (current.Left != null)
                queue.Enqueue(current.Left);

            if (current.Right != null)
                queue.Enqueue(current.Right);
        }
    }
}

// Clase principal para ejecutar el programa
public class Program
{
    public static void Main()
    {
        // Construcción del árbol binario de búsqueda
        Node root = new Node(8);

        root.Left = new Node(3);
        root.Right = new Node(10);

        root.Left.Left = new Node(1);
        root.Left.Right = new Node(6);

        root.Left.Right.Left = new Node(4);
        root.Left.Right.Right = new Node(7);

        root.Right.Right = new Node(14);
        root.Right.Right.Left = new Node(13);

        // Instancia de la clase TreeTraversals
        TreeTraversals traversals = new TreeTraversals();

        // Ejecución de los recorridos
        Console.WriteLine("Recorrido Preorden:");
        traversals.PreOrder(root);

        Console.WriteLine("\n\nRecorrido Inorden:");
        traversals.InOrder(root);

        Console.WriteLine("\n\nRecorrido Posorden:");
        traversals.PostOrder(root);

        Console.WriteLine("\n\nRecorrido Por Niveles:");
        traversals.LevelOrder(root);

        Console.WriteLine();
    }
}
