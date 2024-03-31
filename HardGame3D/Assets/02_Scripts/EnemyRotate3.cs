using UnityEngine;

public class EnemyRotate3 : MonoBehaviour
{
    // ȸ�� �ӵ�
    public float rotateSpeed = 50f;

    // ���� ȸ�� ����
    private float currentRotation = 0f;

    void Update()
    {
        // ȸ���� ������ �����մϴ�. ���⼭�� Y���� �������� ȸ���ϹǷ� Vector3.up�� ����մϴ�.
        float rotation = rotateSpeed * Time.deltaTime;

        // ���� ȸ�� ������ �����մϴ�.
        currentRotation += rotation;

        // ���� ������Ʈ�� ȸ���մϴ�.
        transform.Rotate(Vector3.up, rotation);

        // ���� ȸ�� ������ 360���� �Ѿ�� ������ �����մϴ�.
        if (currentRotation >= 360f)
        {
            // ���� ȸ�� ������ 0���� �ʱ�ȭ�մϴ�.
            currentRotation = 0f;

            // ȸ�� ������ �ݴ�� �����մϴ�.
            rotateSpeed *= -1f;
        }

        if (currentRotation <= -360f)
        {
            // ���� ȸ�� ������ 0���� �ʱ�ȭ�մϴ�.
            currentRotation = 0f;

            // ȸ�� ������ �ݴ�� �����մϴ�.
            rotateSpeed *= -1f;
        }


    }
}
