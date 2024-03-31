using UnityEngine;
using UnityEngine.SceneManagement;

public class CheakFall : MonoBehaviour
{
    void Update()
    {
        // Player GameObject의 y 위치가 -10 이하인지 확인합니다.
        if (transform.position.y < -20f)
        {
            // 현재 씬의 이름을 가져옵니다.
            string currentSceneName = SceneManager.GetActiveScene().name;

            // 현재 씬을 다시 로드합니다.
            SceneManager.LoadScene(currentSceneName);
        }
    }
}