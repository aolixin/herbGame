using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapDisplay : MonoBehaviour
{
    //ͨ������plane��Renderer�����Ƶ��ε���ʾ
    public Renderer textureRender;
    public MeshFilter meshFilter;
    public MeshRenderer meshRender;
    //��������ͼ
    public void DrawTexture(Texture2D texture)
    {
        //��Ӧ�ú��ͼ����Randererȥչ��Ч��
        textureRender.sharedMaterial.mainTexture = texture;
        textureRender.transform.localScale = new Vector3(texture.width, 1, texture.height);
    }

    

    internal void DrawMesh(MeshData meshData, Texture2D texture)
    {
        meshFilter.sharedMesh = meshData.CreateMesh();
        meshRender.sharedMaterial.mainTexture = texture;
    }
}

