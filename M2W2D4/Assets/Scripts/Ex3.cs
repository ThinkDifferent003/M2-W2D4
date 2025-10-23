using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Ex3 : MonoBehaviour
{
    [SerializeField] int variabile = 30;
    int i;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i <= variabile; i++)
        {
            if (i % 3 == 0 && i % 5 ==0)
            {
                Debug.Log("FizzBuzz");
            }
            else if (i % 5 == 0)
            {
                Debug.Log("Buzz");
            }
            else if (i % 3 == 0)
            {
                Debug.Log("Fizz");
            }
            else
            {
                Debug.Log(i);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
