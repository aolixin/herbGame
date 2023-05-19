using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

//�����Ƕ���õĿؼ�չʾ����
[CustomEditor(typeof(MapGenerator))]
public class MapGeneratorEditor : Editor
{
    public bool mapGenChange = true;
    

    public override void OnInspectorGUI()
    {
        MapGenerator mapGen = (MapGenerator)target;

        //�޸Ĳ����������о��ܿ����޸ĺ��Ч��
        if (DrawDefaultInspector())
        {
            if (mapGenChange)
            {
                mapGen.DrawMapInEditor();
            }
        }

        //����������ܸ���
        if (GUILayout.Button("Generate"))
        {
            mapGen.DrawMapInEditor();
        }
    }
}
