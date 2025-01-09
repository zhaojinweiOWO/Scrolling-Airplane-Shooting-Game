using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlane : MonoBehaviour
{
    public float MoveSpeed = 0.005f; //�ľ����t�׳]�w��

    // Start is called before the first frame update
    void Start()
    {
        // Destroy(gameObject, 2); // �]�i�H�γ]�w�ɶ����覡�ӱ���ľ��O�_�R��
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //transform.position += new Vector3(0, -1 * MoveSpeed, 0); 
        transform.Translate(Vector3.down * MoveSpeed * Time.deltaTime); //�ľ��|���_���U���ʡA�ϥ�Translate
    }

    void Update()
    {
        // ���_�����ľ���m�A�p�G�C��y�b-6�A�N�R���ۤv
        if (transform.position.y < -6)
            Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bullet") //�p�G�I�������ҬOBullet
        {
            Destroy(gameObject); //�R���ľ�����
        }
    }
}