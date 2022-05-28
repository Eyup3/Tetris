using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    float distance = 10f;
    private void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector3 objPosiFloor = new Vector3(Mathf.Floor(objPosition.x), objPosition.y, Mathf.Floor(objPosition.z));
        transform.position = objPosiFloor;
    }
    
}
