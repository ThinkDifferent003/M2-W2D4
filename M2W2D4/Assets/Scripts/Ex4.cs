using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex4 : MonoBehaviour
{
    [SerializeField] int startNumber = 5;
    [SerializeField] int amount = 3;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < amount; i++) ;
        Debug.Log(startNumber + amount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
