using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorZumbis : MonoBehaviour
{
    public GameObject Zumbi;
    public float contadorTempo = 0;
    public float TempoGerarZumbi = 1;

    void Start()
    {
        
    }

    void Update()
    {
        contadorTempo += Time.deltaTime;
        if(contadorTempo >= TempoGerarZumbi)
        {
            Instantiate(Zumbi, this.transform.position, this.transform.rotation);
            contadorTempo = 0;
        }
    }
}
