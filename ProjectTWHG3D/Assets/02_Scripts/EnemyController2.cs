using UnityEngine;

public class EnemyController2 : MonoBehaviour
{
    public Transform[] waypoints; // 움직일 지점들을 담을 배열
    public float moveSpeed = 5f; // 장애물의 이동 속도

    private int currentWaypointIndex = 0; // 현재 목표 지점의 인덱스

    void FixedUpdate()
    {
        Move(); // 장애물 이동 함수 호출
    }

    void Move()
    {
        // 현재 목표 지점과의 거리를 계산
        float distanceToWaypoint = Vector3.Distance(transform.position, waypoints[currentWaypointIndex].position);

        // 목표 지점에 도착했는지 확인
        if (distanceToWaypoint < 0.1f)
        {
            // 다음 목표 지점으로 이동
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
        }

        // 다음 목표 지점 방향으로 장애물을 이동
        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].position, moveSpeed * Time.deltaTime);
    }
}
