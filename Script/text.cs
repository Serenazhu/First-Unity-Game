using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class text : MonoBehaviour
{
    [SerializeField] private TMP_Text actualText;

    public Transform player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        actualText.text = player.position.z.ToString("0");
    }




}
