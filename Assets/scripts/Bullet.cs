using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 1; // ���ʳt��
    public GameObject ExplosionPrefab; // �z���ĪG���w�s����

    void Start()
    {
        Destroy(gameObject, 2); //�]�w2���l�u����Q�R��
    }

    void FixedUpdate()
    {
        gameObject.transform.position += new Vector3(0, moveSpeed, 0) * Time.deltaTime; //�l�u�|���_���W����
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "Wall") //�p�G�I�������Ҥ��OWall(���H�~����)
        {
            Instantiate(ExplosionPrefab, transform.position, transform.rotation); //�b�l�u�I������m�����z��
        }
        Destroy(gameObject); //�R���l�u����
    }
}