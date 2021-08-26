using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VicBoundary : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Scene currentScene = SceneManager.GetActiveScene();
            string sceneName = currentScene.name;
            Debug.Log("You won, well done! You complete level: " + sceneName + ". Ready for the next level?");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    private void OnEnable()
    {
        Main.onTurn += Pivot;
    }

    public void Pivot(float angle)
    {
        transform.RotateAround(new Vector3(0, 4.5f, 5.0f), Vector3.back, angle);
    }

    private void OnDisable()
    {
        Main.onTurn -= Pivot;
    }
}

//bool isSpeeding = false;

//if (other.attachedRigidbody.velocity.y <= 0)
//{
//    isSpeeding = true;
//}
//else if (other.tag == "Player" && isSpeeding == true)
//{
//    Debug.Log("Oh no, you have fallen off the game world! You need to start over!");
//    Scene currentScene = SceneManager.GetActiveScene();
//    string sceneName = currentScene.name;
//    SceneManager.LoadScene(sceneName);
//}