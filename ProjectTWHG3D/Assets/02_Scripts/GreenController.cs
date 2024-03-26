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

    // Update is called once per frame
    void Update()
    {
        

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {

            GameObject[] yellowObjects = GameObject.FindGameObjectsWithTag("Yellow");

            // Yellow �±׸� ���� ���� ������Ʈ�� ���� �����ɴϴ�.
            yellowObjectCount = yellowObjects.Length;

            // Yellow �±׸� ���� ���� ������Ʈ�� ���� ����մϴ�.
            Debug.Log("Number of objects with the Yellow tag: " + yellowObjectCount);

            if (yellowObjectCount == 0)
            {

                // ���� ���� �̸��� �����ɴϴ�.
                string currentSceneName = SceneManager.GetActiveScene().name;

                // ���� ���� �̸��� ���ڷ� ��ȯ�մϴ�.
                int currentSceneNumber = int.Parse(currentSceneName.Replace("MainTest", ""));

                // ���� ���� �̸��� �����մϴ�.
                string nextSceneName = "MainTest" + (currentSceneNumber + 1);

                // ���� ������ �̵��մϴ�.
                SceneManager.LoadScene(nextSceneName);

            }
            
            




        }
    }
}