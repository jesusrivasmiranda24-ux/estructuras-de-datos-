using System;

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


public class BSTDeletion
{
    public Node DeleteNode(Node root, int key)
    {
        if (root == null) return root;

        // Navegación hacia el nodo a eliminar
        if (key < root.Data)
            root.Left = DeleteNode(root.Left, key);
        else if (key > root.Data)
            root.Right = DeleteNode(root.Right, key);
        else
        {
            // Caso 1 y 2: Un solo hijo o sin hijos
            if (root.Left == null) return root.Right;
            else if (root.Right == null) return root.Left;

            // Caso 3: Dos hijos -> Obtener el Sucesor Inorden (Menor del subárbol derecho)
            root.Data = MinValue(root.Right);

            // Eliminar el sucesor inorden
            root.Right = DeleteNode(root.Right, root.Data);
        }

        return root;
    }

    private int MinValue(Node root)
    {
        int minv = root.Data;

        while (root.Left != null)
        {
            minv = root.Left.Data;
            root = root.Left;
        }

        return minv;
    }
    public class Program
{
    public static void Main()
    {
        // Crear el árbol
        Node root = new Node(45);
        root.Left = new Node(23);
        root.Right = new Node(67);
        root.Left.Left = new Node(12);
        root.Left.Right = new Node(34);
        root.Right.Left = new Node(56);
        root.Right.Right = new Node(89);

        // Eliminar un nodo
        BSTDeletion eliminacion = new BSTDeletion();
        root = eliminacion.DeleteNode(root, 23);

    Console.WriteLine("Nodo eliminado correctamente.");
    }
}
}
