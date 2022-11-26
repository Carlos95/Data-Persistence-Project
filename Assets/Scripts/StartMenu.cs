using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    [SerializeField] private TMPro.TMP_InputField nameInputField;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewPlayerNameInput()
    {
        MenuManager.Instance.playerName = nameInputField.text;
        SceneManager.LoadScene(1);

    }
}
