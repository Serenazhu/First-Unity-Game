using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    bool gameHasEnded = false;
    public float waitTime = 5f;
    public GameObject completeLevelUI;

    public void ComepleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("hi");
            Invoke("StartGame", waitTime);
        }

    }

    void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
