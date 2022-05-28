using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseBtn : MonoBehaviour
{
    public GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu = GameObject.Find("Pause");
    }

    // Update is called once per frame
    void Update()
    {
    }
}
