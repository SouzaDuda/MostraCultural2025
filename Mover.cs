using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.Rendering;

public class Mover : MonoBehaviour
{
    Vector3 mousePosition;
    Vector3 movingObject;
    public GameObject tileSelected;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);

        Vector3 v3 = Input.mousePosition;
        v3.z = 6;
        v3 = Camera.main.ScreenToWorldPoint(v3);

        if (Input.GetMouseButton(0))
        {
            Debug.Log("a");
            if (Physics.Raycast(mouseRay, out RaycastHit moveTile) && moveTile.collider.gameObject.CompareTag("Tile"))
            {
                Debug.Log(moveTile.collider.gameObject.name);
                tileSelected = moveTile.collider.gameObject;

            }

            
            Debug.Log(tileSelected);
            tileSelected.transform.position = new Vector3(v3.x, v3.y, -4.5f);

        }
        else if (tileSelected != null)
        {

            tileSelected.transform.position = new Vector3(tileSelected.transform.position.x, tileSelected.transform.position.y, -4);
            tileSelected = null;
        }

    }
}
