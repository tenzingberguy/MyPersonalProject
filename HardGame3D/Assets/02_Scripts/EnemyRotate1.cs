using UnityEngine;

public class EnemyRotate1 : MonoBehaviour
{
    // ȸ�� �ӵ�
    public float rotateSpeed = 50f;

    void Update()
    {
        // ȸ���� ������ �����մϴ�. ���⼭�� Y���� �������� ȸ���ϹǷ� Vector3.up�� ����մϴ�.
        float rotation = rotateSpeed * Time.deltaTime;

        // ���� ������Ʈ�� ȸ���մϴ�.
        transform.Rotate(Vector3.up, rotation);
    }
}

