using UnityEngine;

public class EnemyRotate1 : MonoBehaviour
{
    // 회전 속도
    public float rotateSpeed = 50f;

    void Update()
    {
        // 회전할 각도를 설정합니다. 여기서는 Y축을 기준으로 회전하므로 Vector3.up을 사용합니다.
        float rotation = rotateSpeed * Time.deltaTime;

        // 게임 오브젝트를 회전합니다.
        transform.Rotate(Vector3.up, rotation);
    }
}

