using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement; //for Play Button
using UnityEngine.UI;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    //This is the handler of the main menu scene

    public TMP_Text PlayerNameInput;

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void SetPlayerName()
    {
        PlayerDataHandle.Instance.PlayerName = PlayerNameInput.text;
    }


    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

}