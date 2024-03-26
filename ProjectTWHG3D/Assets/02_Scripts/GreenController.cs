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
        // Scene 내의 모든 GameObject 배열을 가져옵니다.
       

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

            // Yellow 태그를 가진 게임 오브젝트의 수를 가져옵니다.
            yellowObjectCount = yellowObjects.Length;

            // Yellow 태그를 가진 게임 오브젝트의 수를 출력합니다.
            Debug.Log("Number of objects with the Yellow tag: " + yellowObjectCount);

            if (yellowObjectCount == 0)
            {

                // 현재 씬의 이름을 가져옵니다.
                string currentSceneName = SceneManager.GetActiveScene().name;

                // 현재 씬의 이름을 숫자로 변환합니다.
                int currentSceneNumber = int.Parse(currentSceneName.Replace("MainTest", ""));

                // 다음 씬의 이름을 생성합니다.
                string nextSceneName = "MainTest" + (currentSceneNumber + 1);

                // 다음 씬으로 이동합니다.
                SceneManager.LoadScene(nextSceneName);

            }
            
            




        }
    }
}