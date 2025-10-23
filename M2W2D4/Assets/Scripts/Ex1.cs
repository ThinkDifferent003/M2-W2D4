using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex1 : MonoBehaviour
{
    ////Start is called before the first frame update
    [SerializeField] int index = 5;
    [SerializeField] int numero = 0;
    void Start()
    {
       
        while (index > 0)
        {
            index--;
            numero++;
            Debug.Log("numero" + numero);
            
        }
        Debug.Log("index a 0");
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
