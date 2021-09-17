using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToNextStage : MonoBehaviour
{
    private int currentStage;

    private void Awake()
    {
        currentStage = SceneManager.GetActiveScene().buildIndex;
    }

    public void NextStage()
    {
        SceneManager.LoadScene(currentStage + 1);
    }
}
