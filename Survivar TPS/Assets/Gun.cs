using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ���� ���콺 ���� ��ư�� ������
// ����ī�޶� �ٶ󺻰��� �Ѿ��ڱ��� �����ʹ�.
public class Gun : MonoBehaviour
{
    public class Test
    {
        public int aaa;
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    public GameObject bImpactFactory;
    void Update()
    {
        // ���� ���콺 ���� ��ư�� ������
        if (Input.GetButtonDown("Fire1"))
        {
            // ����ī�޶� �ٶ󺻰��� �Ѿ��ڱ��� �����ʹ�.
            // �ü�, �ٶ󺸴�, �������� ����
            // ����ī�޶��� ��ġ���� ����ī�޶��� �չ������� �ü��� �����ʹ�.
            Ray ray = new Ray(Camera.main.transform.position, Camera.main.transform.forward);


            RaycastHit hitInfo;
            // �ٶ󺸴�.
            if (Physics.Raycast(ray, out hitInfo))
            {
                print(hitInfo.transform.name);
                // �Ѿ��ڱ��� �ε��� ���� �����ʹ�.
                GameObject bImpact = Instantiate(bImpactFactory);
                bImpact.transform.position = hitInfo.point;
                bImpact.transform.forward = hitInfo.normal;
            }
        }
    }
}
