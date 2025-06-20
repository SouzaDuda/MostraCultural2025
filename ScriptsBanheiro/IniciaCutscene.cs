using UnityEngine;

public class StartCutscene : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Animator camAnim;
    public Animator azulejoAnim;
    public GameObject jogadorControle;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            camAnim.SetBool("iniciar", true);
            jogadorControle.SetActive(false);
            azulejoAnim.SetBool("cair", true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
        }
    }
}
