using UnityEngine;
using UnityEngine.SceneManagement;

public class InputManager : MonoBehaviour
{
    public SeekBehavior seekBehavior;
    public GameObject fleeingBehavior;
    public GameObject arrivalBehavior;
    public GameObject obstacleAvoidanceBehavior;
    //public GameObject resetBehavior;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            CheckAndDestroyGameObjects();
            seekBehavior.StartSeeking();
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            CheckAndDestroyGameObjects();
            fleeingBehavior.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            CheckAndDestroyGameObjects();
            arrivalBehavior.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            CheckAndDestroyGameObjects();
            obstacleAvoidanceBehavior.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            //resetBehavior.SetActive(true);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void CheckAndDestroyGameObjects()
    {
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Target");
        GameObject[] agents = GameObject.FindGameObjectsWithTag("Agent");

        foreach (GameObject target in gameObjects)
        {
            Destroy(target);
        }

        foreach (GameObject agent in agents)
        {
            Destroy(agent);
        }
    }
    }
