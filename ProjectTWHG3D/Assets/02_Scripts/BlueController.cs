using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlueController : MonoBehaviour
{
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            string currentSceneName = SceneManager.GetActiveScene().name;

            // 현재 씬을 다시 로드합니다.
            SceneManager.LoadScene(currentSceneName);

        }
    }
}