using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ControlaArma : MonoBehaviour
{
    public GameObject Bala;
    [SerializeField] GameObject canoDaArma;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(Bala, canoDaArma.transform.position, canoDaArma.transform.rotation);
        }
    }
}
