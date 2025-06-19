using UnityEngine;

public class ChecarPosicao : MonoBehaviour
{

    [SerializeField] Vector3 posicaoCorreta;

    public bool estaPosicionado;
    public MoverAzulejo moverAzulejo;
 
    public int indexAzulejo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, new Vector3(2.12799501f, 2.20000005f, 4.66650152f)) < 0.5)
        {

            moverAzulejo.ChecaPosicoes[indexAzulejo] = true;
        }
        else
        {
            moverAzulejo.ChecaPosicoes[indexAzulejo] = false;
        }
    }
}
