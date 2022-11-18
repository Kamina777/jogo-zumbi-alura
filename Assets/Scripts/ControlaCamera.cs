using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ControlaCamera : MonoBehaviour
{
    public GameObject Jogador;
    private Vector3 distanciaCompensar;
    public int distanciaYCamera = 15;
    public int distanciaZCamera = -10;
    public int distanciaXCamera = 0;


    void Start()
    {
        //Jogador = GameObject.FindGameObjectWithTag("Player");

        Vector3 distanciaInicial = new Vector3(distanciaXCamera, distanciaYCamera, distanciaZCamera);
        transform.position = Jogador.transform.position + distanciaInicial;
        distanciaCompensar = transform.position - Jogador.transform.position;
    }

    void Update()
    {
        transform.position = Jogador.transform.position + distanciaCompensar;
    }
}
