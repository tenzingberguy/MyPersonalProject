using UnityEngine;
using System.Collections;

public class EnemyRotate2 : MonoBehaviour
{
    public float rotateSpeed = 50f;
    private bool isRotating = false;

    void Start()
    {
        StartCoroutine(RotateAndPauseCoroutine());
    }

    IEnumerator RotateAndPauseCoroutine()
    {
        while (true)
        {
            if (!isRotating)
            {
                // -90도 회전 (반대 방향으로 회전)
                yield return StartCoroutine(RotateObject(Vector3.up, -90f, rotateSpeed));

                // 1초 대기
                yield return new WaitForSeconds(1f);

                // -90도 회전 (반대 방향으로 회전)
                yield return StartCoroutine(RotateObject(Vector3.up, -90f, rotateSpeed));

                // 1초 대기
                yield return new WaitForSeconds(1f);
            }
            yield return null;
        }
    }

    IEnumerator RotateObject(Vector3 axis, float angle, float speed)
    {
        isRotating = true;
        float rotated = 0f;

        while (rotated > angle)
        {
            float rotation = Mathf.Max(angle - rotated, -speed * Time.deltaTime); // 음수로 설정하여 반대 방향으로 회전
            transform.Rotate(axis, rotation);
            rotated += rotation;
            yield return null;
        }

        isRotating = false;
    }
}
