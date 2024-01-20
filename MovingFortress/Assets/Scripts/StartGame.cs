using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public Button StartButton, m_YourSecondButton, m_YourThirdButton;

    // Start is called before the first frame update
    void Start()
    {
        StartButton.onClick.AddListener(StartClicked);
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
}
