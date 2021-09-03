using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using TMPro;

public class QueueExample : MonoBehaviour
{
    //[SerializeField]
    //private TextMeshProUGUI queueDebug;
    public GameObject cubePrefab;
    int i = 0;
    // Start is called before the first frame update
    void Start()
    {
        //define stack
        Queue queue = new Queue();

        queue.Enqueue(cubePrefab);
        queue.Enqueue(cubePrefab);
        queue.Enqueue(cubePrefab);
        queue.Enqueue(cubePrefab);
        queue.Enqueue(cubePrefab);

        ShowInfoInQueue(queue);


        
    }

    void ShowInfoInQueue(Queue queue)
    {
        //queueDebug.text += "..............\n";
        foreach (var queueitem in queue)
        {
            //queueDebug.text += $"{queueitem}\n";
            
            i++;
            Instantiate(cubePrefab, transform.position + new Vector3(0, i, 0), Quaternion.identity);
            
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
