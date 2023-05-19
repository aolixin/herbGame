using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomGUIToggleGroup : MonoBehaviour
{
    public CustomGUIToggle[] toggles;

    //��¼��һ��Ϊtrue�� toggle
    private CustomGUIToggle frontTurTog;

    void Start()
    {
        if (toggles.Length == 0)
            return;

        //ͨ������ ��Ϊ��� ��ѡ�� ��� �����¼�����
        //�ں������� ���� 
        //��һ��Ϊtrueʱ �����������false
        for (int i = 0; i < toggles.Length; i++)
        {
            CustomGUIToggle toggle = toggles[i];
            toggle.changeValue += (value) =>
            {
                //������� value  ��tureʱ ��Ҫ���������� 
                //���false
                if (value)
                {
                    //��ζ����������Ҫ���false
                    for (int j = 0; j < toggles.Length; j++)
                    {
                        //�����бհ�  toggle������һ�������������ı���
                        //�ı���������������
                        if (toggles[j] != toggle)
                        {
                            toggles[j].isSel = false;
                        }
                    }
                    //��¼��һ��Ϊtrue��toggle
                    frontTurTog = toggle;
                }
                //���ж� ��ǰ���false�����toggle�ǲ�����һ��Ϊtrue
                //����� �Ͳ�Ӧ���������false
                else if (toggle == frontTurTog)
                {
                    //ǿ�Ƹĳ� true
                    toggle.isSel = true;
                }
            };
        }
    }

}
