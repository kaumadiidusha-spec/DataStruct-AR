using UnityEngine;

public class StackController : MonoBehaviour
{
    public int blockCount = 0;

    void Start()
    {
        Debug.Log("Welcome to DataStruct AR!");
        Debug.Log("Current stack size: " + blockCount);
    }

    public void Push()
    {
        blockCount = blockCount + 1;

        Debug.Log("Block added. Stack size: " + blockCount);
    }

    public void Pop()
    {
        if (blockCount > 0)
        {
            blockCount = blockCount - 1;
            Debug.Log("Block removed. Stack size: " + blockCount);
        }
        else
        {
            Debug.Log("The stack is empty!");
        }
    }
}
