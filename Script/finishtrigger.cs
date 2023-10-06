using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finishtrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public GameManager gamemanager;
    void OnTriggerEnter()
    {
        gamemanager.ComepleteLevel();
    }
}
