using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex5 : MonoBehaviour
{
    [SerializeField] private int numberToFind;
    [SerializeField] private int arraySize;
    // Start is called before the first frame update
    void Start()
    {
        int[] numeri = new int[5];
        for (int i = 0; i < numeri.Length; i++)
            {
            if (numeri[i] == numberToFind)
                Debug.Log("found");
            else
                Debug.Log("Not Found");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
