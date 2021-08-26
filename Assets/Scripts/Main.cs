using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main : MonoBehaviour
{
    public static Action<float> onTurn;
    public static Action<float> onSpin;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (onTurn != null)
            {
                onTurn(90);
            }
            Debug.Log("Game world rotated clockwise by 90 degrees.");
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            if (onTurn != null)
            {
                onTurn(-90);
            }
            Debug.Log("Game world rotated anticlcokwise by 90 degrees.");
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            if (onTurn != null)
            {
                onTurn(180);
            }
            Debug.Log("Game world has been flipped upside down.");
        }

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (onSpin != null)
            {
                onSpin(-90);
            }
        }
        else if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            if (onSpin != null)
            {
                onSpin(90);
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Scene currentScene = SceneManager.GetActiveScene();
            string sceneName = currentScene.name;
            SceneManager.LoadScene(sceneName);
            Debug.Log("You reset the level.");
        }
    }
}
