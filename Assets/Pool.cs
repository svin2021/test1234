using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour
{
    public Transform canvas;
    public static int BlocksCount = 81;
    public static int BombsCount = 10;
    public static int blocksinlayer = 9;
    public static int q;
    public static int q1 = 0;
    public static int bombsaround = 0;
    public GameObject block;
    public GameObject newBlock;
    private int x = -450;
    private int y = 297;
    static int ReCount(int input)
    {
        int output;

        int ql = q;

        ql += input / blocksinlayer * 2;

        output = input + ql;

        return output;
    }
    void Start()
    {
        q = blocksinlayer + 3;
        matrix();
    }
    public void matrix()
    {
        //float random = UnityEngine.Random.Range(-1, 4);

        List<int> result = new List<int>();

        List<int> bufer = new List<int>();

        //заполнение массива
        for (int i = 0; i < BlocksCount; i++)
        {
            result.Add(0);
        }

        for (int i = 0; i < BombsCount; i++)
        {
            bufer.Add(0);
        }

        //расчитываем индексы мин
        for (int i = 0; i < BombsCount; i++)
        {
            int NewRandom;
            NewRandom = UnityEngine.Random.Range(0, BlocksCount - 1);

            if (bufer.Contains(NewRandom))
            {
                i--;
            }
            else
            {
                bufer[i] = NewRandom;
            }
        }

        //расставляем мины
        foreach (int i in bufer)
        {
            result[i] = 9;
        }
        //массив с внешним слоем
        List<int> result2 = new List<int>();

        for (int i = 0; i < (BlocksCount / blocksinlayer + 2) * (blocksinlayer + 2); i++)
        {
            result2.Add(0);
        }

        //вносим старый массив в навый
        for (int i = 0; i < BlocksCount; i++)
        {
            result2[ReCount(i)] = result[i];
        }

        //расставляем подсказки для игрока
        for (int i = 0; i < BlocksCount; i++)
        {
            int inprogress = ReCount(i);

            if (result[i] != 9)
            {
                if (result2[inprogress - blocksinlayer - 3] == 9)
                {
                    bombsaround++;
                }
                if (result2[inprogress - blocksinlayer - 2] == 9)
                {
                    bombsaround++;
                }
                if (result2[inprogress - blocksinlayer - 1] == 9)
                {
                    bombsaround++;
                }
                if (result2[inprogress - 1] == 9)
                {
                    bombsaround++;
                }
                if (result2[inprogress + 1] == 9)
                {
                    bombsaround++;
                }
                if (result2[inprogress + blocksinlayer + 3] == 9)
                {
                    bombsaround++;
                }
                if (result2[inprogress + blocksinlayer + 2] == 9)
                {
                    bombsaround++;
                }
                if (result2[inprogress + blocksinlayer + 1] == 9)
                {
                    bombsaround++;
                }
                result2[inprogress] = bombsaround;
            }
            else
            {
                result2[inprogress] = 9;
            }
            bombsaround = 0;
        }

        for (int i = 1; i <= BlocksCount; i++)
        {
            newBlock = Instantiate(block, new Vector3(x, y, 0), Quaternion.identity);
            newBlock.GetComponent<button1>().a = result2[ReCount(i-1)];
            newBlock.transform.SetParent(canvas, false);

            x += 30;
            if (i % blocksinlayer == 0 && i != 0)
            {
                y -= 30;
                x = -450;
            }
        }
    }
}
