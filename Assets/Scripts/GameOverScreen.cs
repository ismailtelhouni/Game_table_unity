using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour
{
    public Button firstRestart;
    public Button secondeRestart;
    public void Setup(){
        gameObject.SetActive(true);
        firstRestart.gameObject.SetActive(false);
        secondeRestart.gameObject.SetActive(true);
    }
    public void restartButton(){
        SceneManager.LoadScene("MiniJeu");
    }
}
