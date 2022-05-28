using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxEnter : MonoBehaviour
{
    public bool hover;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (GameObject.Find("Block").GetComponent<dragAndDrop>().selected == true && hover == true)
        {
            GameObject.Find("Block").transform.position = new Vector2((float)-0.45, (float)0.45);
        }

    }
    private void OnMouseOver()
    {
        hover = true;       
    }
    private void OnMouseExit()
    {
        hover = false;
    }
}
