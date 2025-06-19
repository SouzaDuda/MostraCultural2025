using UnityEngine;
using System.Linq

public class MoverAzulejo : MonoBehaviour
{
    Vector3 localMouse;

    public Transform azulejoSelecionado;
    [SerializeField] private Transform espa�oVazio;
    public int AzulejosPosicionados = 0;

    public bool[] ChecaPosicoes = new bool[4];

    void Update()
    {



        Ray raioMouse = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        localMouse = Input.mousePosition;
        localMouse.z = 4.6f;
        localMouse = Camera.main.ScreenToWorldPoint(localMouse);

        if (Input.GetMouseButton(0))
        {


            if (Physics.Raycast(raioMouse, out RaycastHit selecionaAzulejo) && selecionaAzulejo.collider.gameObject.CompareTag("Azulejo"))
            {
                Debug.Log(selecionaAzulejo);


                    if (Vector3.Distance(espa�oVazio.position, selecionaAzulejo.collider.transform.position) < 0.5)
                    {
                        
                        azulejoSelecionado = selecionaAzulejo.collider.gameObject.transform;
                        Vector3 ultimoVazio = espa�oVazio.position;
                        espa�oVazio.position = azulejoSelecionado.position;
                        azulejoSelecionado.position = ultimoVazio;

                    if (VerificarAzulejos)
                    {
                        Debug.Log("final");
                    }

                }
            }

        }

    }

    bool VerificarAzulejos()
    {
        for (int i = 0; i < ChecaPosicoes.Length; ++i)
        {
            if (MissionList[i].ChecaPosicoes == false)
            {
                return false;
            }

        }
        return true;
    }


}
