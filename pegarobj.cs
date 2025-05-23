using UnityEngine;

public class pegarobj : MonoBehaviour
{
    public GameObject pocao;
    



    void Start()
    {
        pocao.SetActive(false);
        

    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (Input.GetKey(KeyCode.E))
            {
                this.gameObject.SetActive(false);
                pocao.SetActive(true);
                

            }

        }
    }
}