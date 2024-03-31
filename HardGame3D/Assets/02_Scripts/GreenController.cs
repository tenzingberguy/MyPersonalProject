using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GreenController : MonoBehaviour
{
    private int yellowObjectCount;

    // Start is called before the first frame update
    void Start()
    {
        // Scene ���� ��� GameObject �迭�� �����ɴϴ�.
       

    }

    private void Awake()
    {
        Time.timeScale = 1f;
    }
    void Update()
    {
        

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            GameObject[] yellowObjects = GameObject.FindGameObjectsWithTag("Yellow");

           
            yellowObjectCount = yellowObjects.Length;

           
            Debug.Log("Number of objects with the Yellow tag: " + yellowObjectCount);

            if (yellowObjectCount == 0)
            {

               
                string currentSceneName = SceneManager.GetActiveScene().name;

              
                int currentSceneNumber = int.Parse(currentSceneName.Replace("MainTest", ""));

              
                string nextSceneName = "MainTest" + (currentSceneNumber + 1);

               
                SceneManager.LoadScene(nextSceneName);

            }
            
            




        }
    }
}