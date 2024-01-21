using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public Button StartButton, QuitButton, m_YourThirdButton;

    // Start is called before the first frame update
    void Start()
    {
        StartButton.onClick.AddListener(StartClicked);
        QuitButton.onClick.AddListener(QuitClicked);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartClicked()
    {
        // Debug.Log("You have clicked the button!");

        SceneManager.LoadScene("TestScene");
    }

    void QuitClicked()
    {
        // The game cannot be exited whilst being viewed in the editor so you just have to trust me that this works

        // Debug.Log("Game Exited");

        Application.Quit();
    }
}
