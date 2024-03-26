using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float moveSpeed = 2f; // �� �̵� �ӵ�
    public float moveDistance = 10f; // �յڷ� �̵��� �Ÿ�

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
        // �̵� ���� ����
        Vector3 targetPosition = moveForward ? forwardPosition : backwardPosition;

        // ��ǥ ��ġ�� �̵�
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);

        // ��ǥ ��ġ�� �����ϸ� ���� ��ȯ
        if (transform.position == targetPosition)
        {
            moveForward = !moveForward;
        }
    }
}
