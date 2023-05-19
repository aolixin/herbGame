using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum E_Style_OnOff
{
    on,
    off
}

public abstract class CustomGUIControl : MonoBehaviour
{
    //λ����Ϣ
    public CustomGUIPos guiPos;
    //������Ϣ
    public GUIContent content;
    //�Զ�����ʽ
    public GUIStyle style;
    //�Զ�����ʽ�Ƿ�����
    public E_Style_OnOff styleOnOROff = E_Style_OnOff.off;

    public void DrawGUI()
    {
        switch (styleOnOROff)
        {
            case E_Style_OnOff.on:
                StyleOnDraw();
                break;
            case E_Style_OnOff.off:
                StyleOffDraw();
                break;
            default:
                break;
        }
    }
    /// <summary>
    /// �Զ��忪��ʱ���Ʒ���
    /// </summary>
    public abstract void StyleOnDraw();
    /// <summary>
    /// �Զ���ر�ʱ���Ʒ���
    /// </summary>
    public abstract void StyleOffDraw();
}
