using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackExample : MonoBehaviour
{
    [SerializeField]
    GameObject cubePrefab;
    int i = 0;
    //private TextMeshProUGUI stackDebug;

    // Start is called before the first frame update
    void Start()
    {
        //define stack
        Stack stack = new Stack();

        //prepare data
        //int firstPlayerScore = 12;
        //int secondPlayerScore = 10;
        //int thirdPlayerScore = 100;

        //push a new player score into stack
        stack.Push(cubePrefab);
        stack.Push(cubePrefab);
        stack.Push(cubePrefab);
        ShowInfoInStack(stack);//show information in stack

        //pop player score from stack
        stack.Pop();
        Debug.Log("Cube removed");
        ShowInfoInStack(stack);
    }

    void ShowInfoInStack(Stack stack)
    {
        //stackDebug.text += "..............\n";
        foreach (var stackitem in stack)
        {
            //stackDebug.text += $"{stackitem}\n";
            i++;
            Instantiate(cubePrefab, transform.position+new Vector3(0,i,0), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
