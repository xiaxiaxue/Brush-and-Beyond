using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public GameObject CrossFade;
    public float transitionTime = 1f;

    void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.tag == "Player")
        {
        Debug.Log("TriggerEnter");
        LoadNextLevel();
        }

    }


    private void LoadNextLevel()
    {
          // transition.Play;
            StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));


    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);
    }
}
