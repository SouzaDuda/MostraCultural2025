using UnityEngine;

public class ChecarPosicao : MonoBehaviour
{

    [SerializeField] Vector3 posicaoCorreta;
    public bool estaPosicionado;
    public MoverAzulejo moverAzulejo;
    public int indexAzulejo;

    void Update()
    {
        if (Vector3.Distance(transform.position, posicaoCorreta) < 0.8)
        {

            moverAzulejo.ChecaPosicoes[indexAzulejo] = true;
        }
        else
        {
            moverAzulejo.ChecaPosicoes[indexAzulejo] = false;
        }
    }
}