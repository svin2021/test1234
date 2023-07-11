using UnityEngine;

public class beginnerButton : MonoBehaviour
{
    public void onClick()
    {
        Pool.BlocksCount = 81;
        Pool.blocksinlayer = 9;
        Pool.BombsCount = 10;
    }
}
