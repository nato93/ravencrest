using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/*Loads a new scene, while also clearing level-specific inventory!*/

public class SceneLoadTrigger : MonoBehaviour
{

    [SerializeField] string loadSceneName;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(loadSceneName);

            
        }
    }
}
