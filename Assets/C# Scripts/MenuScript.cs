using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject CharacterCreator;
    public GameObject Settings;

    public void SetActMenu()
    {
        CharacterCreator.SetActive(false);
        Settings.SetActive(false);
        MainMenu.SetActive(true);
        // end
    }

    public void SetActCharacterCreator()
    {
        CharacterCreator.SetActive(true);
        Settings.SetActive(false);
        MainMenu.SetActive(false);
        // end
    }

    public void SetActSettings()
    {
        CharacterCreator.SetActive(false);
        Settings.SetActive(true);
        MainMenu.SetActive(false);
        // end
    }

    public void SceneLoader(int SceneIndex)
    {
        SceneManager.LoadScene(SceneIndex);
    }

}
