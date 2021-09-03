using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StackExample : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI stackDebug;
    // Start is called before the first frame update
    void Start()
    {
        //define stack
        Stack stack = new Stack();

        //prepare data
        int firstPlayerScore = 12;
        int secondPlayerScore = 10;
        int thirdPlayerScore = 100;

        //push a new player score into stack
        stack.Push(firstPlayerScore);
        stack.Push(secondPlayerScore);
        stack.Push(thirdPlayerScore);
        ShowInfoInStack(stack);//show information in stack

        //pop player score from stack
        stack.Pop();
        ShowInfoInStack(stack);
    }

    void ShowInfoInStack(Stack stack)
    {
        stackDebug.text += "..............\n";
        foreach (var stackitem in stack)
        {
            stackDebug.text += $"{stackitem}\n";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
