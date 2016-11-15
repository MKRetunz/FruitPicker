using UnityEngine;
using System.Collections;

public class DragScript : MonoBehaviour {
    private Color mouseOverColor = Color.blue;
    private Color originalColor = Color.yellow;
    private bool dragging = false;
    private float distance;


    void OnMouseEnter()
    {
        GetComponent<Renderer>().material.color = mouseOverColor;
    }

    void OnMouseExit()
    {
        GetComponent<Renderer>().material.color = originalColor;
    }

    void OnMouseDown()
    {
        distance = Vector3.Distance(transform.position, Camera.main.transform.position);
        dragging = true;
    }

    void OnMouseUp()
    {
        Destroy(gameObject);
    }

    void Update()
    {
        if (dragging)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector3 rayPoint = ray.GetPoint(distance);
            rayPoint.y = 1;
            transform.position = rayPoint;
        }
    }
}
