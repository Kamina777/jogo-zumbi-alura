using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleInimigo : MonoBehaviour
{
    public GameObject Jogador;
    public float velocidade = 5;
    private Rigidbody rigidbodyInimigo;
    private Animator animatorInimigo;

    void Start()
    {
        Jogador = GameObject.FindWithTag("Player");
        int geraTipoZumbi = Random.Range(1, 28);
        transform.GetChild(geraTipoZumbi).gameObject.SetActive(true);

        animatorInimigo = GetComponent<Animator>();
        rigidbodyInimigo = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float distancia = Vector3.Distance(transform.position, Jogador.transform.position);

        Vector3 direcao = Jogador.transform.position - transform.position;
        Quaternion novaRotacao = Quaternion.LookRotation(direcao);
        rigidbodyInimigo.MoveRotation(novaRotacao);

        if (distancia > 2.5f)
        {
            rigidbodyInimigo.MovePosition
                (rigidbodyInimigo.position
                + (direcao.normalized * velocidade * Time.deltaTime));
            animatorInimigo.SetBool("Atacando", false);
        }
        else
        {
            animatorInimigo.SetBool("Atacando", true);
        }
    }

    void AtacaJogador()
    {
        Time.timeScale = 0;
        Jogador.GetComponent<Movimentacao>().TextoGameOver.SetActive(true);
        Jogador.GetComponent<Movimentacao>().Vivo = false;
       
    }
}
