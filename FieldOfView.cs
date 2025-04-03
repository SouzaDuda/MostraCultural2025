using UnityEngine;
using UnityEngine.AI;

public class FieldOfView : MonoBehaviour
{
    [SerializeField] int rayNumber;
    public NavMeshAgent other;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating(nameof(Rays), 1, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Rays()
    {
        LayerMask Enemy = LayerMask.GetMask("Enemy");

        for(int i = -9; i < rayNumber; i++)
        {

            Vector3 rayAngle = transform.forward + new Vector3(i*0.2f, 0, 0);

            Debug.DrawRay(transform.position, transform.forward, Color.red);

            if (Physics.Raycast(transform.position, transform.forward, 15f, Enemy))
            {
                Debug.Log("a");

            }
            if (Physics.Raycast(transform.position, rayAngle, out RaycastHit hitInfo, 15f, Enemy))
            {
                Debug.Log(rayAngle);
                Debug.Log(hitInfo.point);
                other.isStopped = true;
            }
            else
            {
                other.destination = transform.position;
            }
                Debug.DrawRay(transform.position, rayAngle, Color.red);

        }
    }
}
