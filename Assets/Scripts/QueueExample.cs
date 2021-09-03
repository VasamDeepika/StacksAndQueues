using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QueueExample : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI queueDebug;
    // Start is called before the first frame update
    void Start()
    {
        //define stack
        Queue queue = new Queue();

        queue.Enqueue("x");
        queue.Enqueue("y");
        queue.Enqueue("z");
        queue.Enqueue("a");
        queue.Enqueue("b");

        ShowInfoInQueue(queue);

        queue.Dequeue();
        ShowInfoInQueue(queue);
    }

    void ShowInfoInQueue(Queue queue)
    {
        queueDebug.text += "..............\n";
        foreach (var queueitem in queue)
        {
            queueDebug.text += $"{queueitem}\n";
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
