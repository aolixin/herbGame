using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TextureGenerator
{
    
    public static Texture2D TextureFromColorMap(Color[]colorMap,int w,int h)
    {
        Texture2D texture = new Texture2D(w,h);
        texture.filterMode = FilterMode.Point;
        texture.wrapMode = TextureWrapMode.Clamp;
        texture.SetPixels(colorMap);
        texture.Apply();
        return texture;
    }

    public static Texture2D TextureFromHeightMap(float[,]heightMap)
    {
        //������ȡ����ָ��ά���е�Ԫ�ظ��� ����ֱ��ǳ��Ϳ�
        int width = heightMap.GetLength(0);
        int height = heightMap.GetLength(1);

        Texture2D texture = new Texture2D(width, height);

        //Color�����ǽ��յ���һ��[0,1]��ֵ����Ҫ��R��G��B��A�ĸ�ֵ���Գ���255
        //�����Ƕ�������ͼ��ȡֵ��� ��Ҫ�޸���ɫ��Ķ���
        Color[] colourMap = new Color[width * height];

        //��ÿ���㸳ֵɫ��
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                //Color.Lerp��ֵ����ȡ0��1֮���һ��ֵ
                colourMap[y * width + x] = Color.Lerp(Color.black, Color.white, heightMap[x, y]);
            }
        }
        return TextureFromColorMap(colourMap, width,height);
    }
}
