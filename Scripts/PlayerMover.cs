using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMover : MonoBehaviour
{
    public Rota rota;
    public float speed = 5f;

    private int posAtual = 0;
    private bool estaAndando = false;

    void Start()
    {
        if (PlayerPrefs.HasKey("PosicaoSalva"))
        {
            posAtual = PlayerPrefs.GetInt("PosicaoSalva");
            transform.position = rota.pontosDaRota[posAtual].position;
        }
    }

    void Update()
    {
        // Tecla R para rolar o dado
        if (Input.GetKeyDown(KeyCode.R) && !estaAndando)
        {
            RolarDado();
        }

        // Tecla B para voltar à casa inicial
        if (Input.GetKeyDown(KeyCode.B) && !estaAndando)
        {
            VoltarParaInicio();
        }
    }

    public void RolarDado()
    {
        if (estaAndando) return;

        int valorDado = Random.Range(1, 5); // D4
        Debug.Log("Dado rolado: " + valorDado);
        StartCoroutine(Mover(valorDado));
    }

    IEnumerator Mover(int passos)
    {
        estaAndando = true;

        for (int i = 0; i < passos; i++)
        {
            int proximoIndex = posAtual + 1;

            if (proximoIndex >= rota.pontosDaRota.Count)
                break;

            posAtual = proximoIndex;

            Transform destino = rota.pontosDaRota[posAtual];
            while (Vector3.Distance(transform.position, destino.position) > 0.1f)
            {
                transform.position = Vector3.MoveTowards(transform.position, destino.position, speed * Time.deltaTime);
                yield return null;
            }

            if (destino.CompareTag("Fase"))
            {
                PlayerPrefs.SetInt("PosicaoSalva", posAtual);
                SceneManager.LoadScene("Cena");
                yield break;
            }
        }

        estaAndando = false;
    }

    void VoltarParaInicio()
    {
        posAtual = 0;
        transform.position = rota.pontosDaRota[0].position;
        PlayerPrefs.SetInt("PosicaoSalva", 0);
        Debug.Log("Jogador voltou à casa inicial.");
    }
}

