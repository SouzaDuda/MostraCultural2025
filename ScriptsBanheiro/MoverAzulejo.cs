using UnityEngine;
using System.Linq;

public class MoverAzulejo : MonoBehaviour
{
    Vector3 localMouse;
    public Transform azulejoSelecionado;
    [SerializeField] private Transform espa�oVazio;
    public GameObject azulejosColoridos;
    public bool[] ChecaPosicoes = new bool[4];

    void Update()
    {
        Ray raioMouse = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Input.GetMouseButton(0))
        {
            if (Physics.Raycast(raioMouse, out RaycastHit selecionaAzulejo) && selecionaAzulejo.collider.gameObject.CompareTag("Azulejo"))
            {
                
                if (Vector3.Distance(espa�oVazio.position, selecionaAzulejo.collider.transform.position) < 0.5)
                {
                    if (VerificarAzulejos())
                    {
                        azulejosColoridos.SetActive(false);
                    }

                    azulejoSelecionado = selecionaAzulejo.collider.gameObject.transform;
                    Vector3 ultimoVazio = espa�oVazio.position;
                    espa�oVazio.position = azulejoSelecionado.position;
                    azulejoSelecionado.position = ultimoVazio;
                }
            }
        }
    }

    bool VerificarAzulejos()
    {
        for (int i = 0; i < ChecaPosicoes.Length; ++i)
        {
            if (ChecaPosicoes[i] == false)
            { 
                return false;
            }
        }
        return true;
    }
}
