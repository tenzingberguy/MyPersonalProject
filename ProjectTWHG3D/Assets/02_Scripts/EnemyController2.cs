using UnityEngine;

public class EnemyController2 : MonoBehaviour
{
    public Transform[] waypoints; // ������ �������� ���� �迭
    public float moveSpeed = 5f; // ��ֹ��� �̵� �ӵ�

    private int currentWaypointIndex = 0; // ���� ��ǥ ������ �ε���

    void FixedUpdate()
    {
        Move(); // ��ֹ� �̵� �Լ� ȣ��
    }

    void Move()
    {
        // ���� ��ǥ �������� �Ÿ��� ���
        float distanceToWaypoint = Vector3.Distance(transform.position, waypoints[currentWaypointIndex].position);

        // ��ǥ ������ �����ߴ��� Ȯ��
        if (distanceToWaypoint < 0.1f)
        {
            // ���� ��ǥ �������� �̵�
            currentWaypointIndex = (currentWaypointIndex + 1) % waypoints.Length;
        }

        // ���� ��ǥ ���� �������� ��ֹ��� �̵�
        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].position, moveSpeed * Time.deltaTime);
    }
}
