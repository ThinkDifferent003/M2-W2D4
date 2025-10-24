using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExPlus : MonoBehaviour
{
    [SerializeField] private int tabellina;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <=10; i++)
        {
            Debug.Log(i * tabellina);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
