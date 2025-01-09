
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject EnemyAirplanePrefab; //�Ծ��w�m����
    public float span = 1.0f;
    public float delta = 0;

    void Update()
    {
        //�H�U�ڭ̰ѦҤ��e�����߫}�Ԫ̹C���A�Q�Q�ݦp�󮳽b�Y���ͪ��{���A�ק令���~�P�Ǫ������͵{��
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            float px = Random.Range(-3.0f, 3.0f); // �o���ڭ̲��ͪ��O-3��3�������B�I��
            Instantiate(EnemyAirplanePrefab, new Vector3(px, 7, 0), Quaternion.identity);
        }
    }
}
