using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex5 : MonoBehaviour
{
    [SerializeField] private int numberToFind;
    [SerializeField] private int arraySize;
    [SerializeField] private int numberOffset;
    // Start is called before the first frame update
    void Start()
    {
        int[] numeri = new int[arraySize];


        for (int i = 0; i < numeri.Length; i++)
        {
            numeri[i] = Random.Range(numberToFind - numberOffset,numberToFind + numberOffset);

            if (numeri[i] == numberToFind)
            {
                Debug.Log("Found");
            }
            else
            { Debug.Log("Not Found"); }
           
        }
        Debug.Log("Iterations Finished");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
