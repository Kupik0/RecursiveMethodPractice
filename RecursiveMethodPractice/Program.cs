int[] numbers = new[]
{
    12,123,51,34,82,34,09,23
};
var index = FindIndex_Recursive(numbers, 34, 3);
var index2 = FindIndex_Iteration(numbers, 34, 3);
Console.WriteLine("Indexler: {0} {1}",index,index2);


int FindIndex_Iteration(int[] numbers, int val, int startIndex) //basit bir for döngüsü
{ 
    for(int i = startIndex; i< numbers.Length; i++)
{
        if (numbers[i] == val)
            return i;

}
    return -1;
}
int FindIndex_Recursive(int[] numbers, int val, int startIndex) //basit bir recursive döngüsü
{ //exit condition, çıkış koşulu
    if (startIndex >= numbers.Length)
        return -1;
    // actual process, asıl işlem 
    if (numbers[startIndex] == val)
        return startIndex;
    //re-calling, döngüyü sürdürme
    return FindIndex_Recursive(numbers, val, startIndex + 1);

}
//binary tree üzerinde çalışalım

var rootNode = new Node(8);
AddNode(rootNode, 3);
AddNode(rootNode, 10);
AddNode(rootNode, 1);
Traverse(rootNode);

void Traverse(Node rootNode)
{
    if (rootNode is null)
        return;
    Traverse(rootNode.LeftNode);
    Console.WriteLine(rootNode.Val);
    Traverse(rootNode.RightNode);
}
 void AddNode(Node rootNode, int val)
{
    if (val < rootNode.Val)
    {
        if (rootNode.LeftNode is null)
        {
            rootNode.LeftNode = new Node(val);
            return;
        }
        else
        {
            AddNode(rootNode.LeftNode, val);
        }
    }
    else
    {
        if (rootNode.RightNode is null)
        {
            rootNode.RightNode = new Node(val);
            return;
        }
        else
        {
            AddNode(rootNode.RightNode, val);
        }
    }

}
class Node
{
    public Node(int val)
    {
        Val = val;

    }

    public int Val { get; set; }
    public Node LeftNode { get; set; }
    public Node RightNode { get; set; }
}
