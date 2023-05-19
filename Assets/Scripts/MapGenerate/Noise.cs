using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Noise
{
    //����һ���������ɵ�ͼ �������������õ��εĳ����С������
    public static float[,] GenerateNoiseMap(int mapWidth, int mapHeight, float scale)
    {
        //����һ������ά�ȵĸ��������͵����� ���ڴ洢����������
        float[,] noiseMap = new float[mapWidth, mapHeight];
        //��ֹ��ͼ�Ĵ�С���ָ���
        if (scale <= 0)
        {
            scale = 0.0001f;
        }

        //�Դ���ĺ����ĳ�����������лҶ�ֵ��ֵ ģ������
        for (int y = 0; y < mapHeight; y++)
        {
            for (int x = 0; x < mapWidth; x++)
            {
                //����scale ��Ӱ��scale��ͬʱ�ܹ�Ӱ�쵽��ͼ���ŵĴ�С
                float sampleX = x / scale;
                float sampleY = y / scale;

                //����ֵ Mathf.PerlinNoise���Լ����Ϊ�������������ĻҶ�ֵ
                float perlinValue = Mathf.PerlinNoise(sampleX, sampleY);
                //���Ҷ�ֵ���ظ������
                noiseMap[x, y] = perlinValue;
            }
        }
        return noiseMap;
    }
}

