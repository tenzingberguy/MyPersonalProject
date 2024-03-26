using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float moveSpeed = 2f; // 적 이동 속도
    public float moveDistance = 10f; // 앞뒤로 이동할 거리

    private Vector3 initialPosition;
    private Vector3 forwardPosition;
    private Vector3 backwardPosition;
    private bool moveForward = true;

    void Start()
    {
        initialPosition = transform.position;
        forwardPosition = initialPosition + transform.forward * moveDistance;
        backwardPosition = initialPosition;
    }

    void Update()
    {
        // 이동 방향 설정
        Vector3 targetPosition = moveForward ? forwardPosition : backwardPosition;

        // 목표 위치로 이동
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

        // 목표 위치에 도달하면 방향 전환
        if (transform.position == targetPosition)
        {
            moveForward = !moveForward;
        }
    }
}
