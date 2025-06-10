using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// Class in charge of transitions between scenes
/// </summary>
public class Scenemanager : MonoBehaviour
{
    /// <summary>
    /// Opens the Play Screen
    /// </summary>
    public void PlayGameCasualGame()
    {
        SceneManager.LoadScene("Scenes/CasualGameScene");
    }
    /// <summary>
    /// Opens the Top Ten Screen
    /// </summary>
    public void OpenTopTen()
    {
        SceneManager.LoadScene("Scenes/HighScoreScene");
    }
    /// <summary>
    /// Opens the Skins Screen
    /// </summary>
    public void OpenSkins()
    {
        SceneManager.LoadScene("Scenes/SkinsScene");
    }
    /// <summary>
    /// Opens the Credits Screen
    /// </summary>
    public void OpenCredits()
    {
        SceneManager.LoadScene("Scenes/CreditsScene");
    }
    /// <summary>
    /// Opens the Main Screen
    /// </summary>
    public void OpenMain()
    {
        SceneManager.LoadScene("Scenes/MainScreenScene");
    }
}
