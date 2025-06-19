using System.Collections.Generic;
using UnityEngine;

public class Rota : MonoBehaviour
{
    public List<Transform> pontosDaRota = new List<Transform>();

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;

        for (int i = 0; i < pontosDaRota.Count - 1; i++)
        {
            if (pontosDaRota[i] != null && pontosDaRota[i + 1] != null)
            {
                Gizmos.DrawLine(pontosDaRota[i].position, pontosDaRota[i + 1].position);
            }
        }
    }
}
