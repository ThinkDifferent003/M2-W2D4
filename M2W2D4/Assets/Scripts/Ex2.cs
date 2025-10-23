using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] numeri = new int[4];
        numeri[0] = 10;
        numeri[1] = 20;
        numeri[2] = 30;
        numeri[3] = 40;
        int somma = 0;
        int moltiplicazione = 0;
        Debug.Log(somma + numeri[0] + numeri[1] + numeri[2] + numeri[3]);
        Debug.Log(moltiplicazione + numeri[0] * numeri[1] * numeri[2] * numeri[3]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
