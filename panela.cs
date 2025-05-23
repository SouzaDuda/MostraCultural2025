using UnityEngine;

public class panela : MonoBehaviour
{
  public GameObject pocao01;
    public GameObject pocao02;
    public GameObject pocao03;
    public GameObject pocao04;
    public GameObject pocao05;

    void Start()
    {
      //  pocao01.SetActive(true);
      //  pocao02.SetActive(true);
      //  pocao03.SetActive(true);
      //  pocao04.SetActive(true);
      //  pocao05.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
       if (other.gameObject.CompareTag("Player") && this.pocao01 | this.pocao02 | this.pocao03 | this.pocao04 | this.pocao05)
        {
            if (Input.GetKey(KeyCode.E))
            {

                pocao01.SetActive(false);
                pocao02.SetActive(false);
                pocao03.SetActive(false);
                pocao04.SetActive(false);
                pocao05.SetActive(false);


            }

        }
    }
}

