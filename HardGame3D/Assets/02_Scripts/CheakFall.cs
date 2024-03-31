using UnityEngine;
using UnityEngine.SceneManagement;

public class CheakFall : MonoBehaviour
{
    void Update()
    {
        // Player GameObject�� y ��ġ�� -10 �������� Ȯ���մϴ�.
        if (transform.position.y < -20f)
        {
            // ���� ���� �̸��� �����ɴϴ�.
            string currentSceneName = SceneManager.GetActiveScene().name;

            // ���� ���� �ٽ� �ε��մϴ�.
            SceneManager.LoadScene(currentSceneName);
        }
    }
}