using UnityEngine;

public class EnemyRotate3 : MonoBehaviour
{
    // 회전 속도
    public float rotateSpeed = 50f;

    // 현재 회전 각도
    private float currentRotation = 0f;

    void Update()
    {
        // 회전할 각도를 설정합니다. 여기서는 Y축을 기준으로 회전하므로 Vector3.up을 사용합니다.
        float rotation = rotateSpeed * Time.deltaTime;

        // 현재 회전 각도를 누적합니다.
        currentRotation += rotation;

        // 게임 오브젝트를 회전합니다.
        transform.Rotate(Vector3.up, rotation);

        // 현재 회전 각도가 360도를 넘어가면 방향을 변경합니다.
        if (currentRotation >= 360f)
        {
            // 현재 회전 각도를 0으로 초기화합니다.
            currentRotation = 0f;

            // 회전 방향을 반대로 변경합니다.
            rotateSpeed *= -1f;
        }

        if (currentRotation <= -360f)
        {
            // 현재 회전 각도를 0으로 초기화합니다.
            currentRotation = 0f;

            // 회전 방향을 반대로 변경합니다.
            rotateSpeed *= -1f;
        }


    }
}
