using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Rigidbody2D rGPlayer;
    public float speed = 23f;
    public bool isgrounded = false;
    public float jumpheight = 5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(speed, 0, 0);
        transform.position += movement * Time.deltaTime;
        if (Input.GetMouseButtonDown(0) && isgrounded == true)
        {
            rGPlayer.AddForce(new Vector2(0f, jumpheight), ForceMode2D.Impulse);
        }
        //*****************************************
    }
}
