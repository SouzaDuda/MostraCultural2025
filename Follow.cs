using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;

public class Follow : MonoBehaviour
{
    public Transform target;
    public NavMeshAgent agent;
    RaycastHit view;
    LayerMask enemy;

    private void Start()
    {
        enemy = LayerMask.GetMask("Enemy");
    }

    void Update()
    {
        View();
        Debug.DrawRay(transform.position, target.position - transform.position);
    }


    void View()
    {
        
        Vector3 dir = (target.position - transform.position).normalized;
        float dot = Vector3.Dot(dir, transform.forward);
        Physics.Raycast(transform.position, target.position - transform.position, out view, enemy);
        if (dot > 0.55f && view.rigidbody)
        {
            Debug.Log("visible");
            agent.isStopped = true;
        }
        else
        {
            Debug.Log("NotVisible");
            agent.isStopped = false;
            agent.SetDestination(transform.position);
        }
        
    }
}
