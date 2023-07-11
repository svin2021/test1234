using UnityEngine;

public class intermediant : MonoBehaviour
{
    public void onClick()
    {
        Pool.BlocksCount = 256;
        Pool.blocksinlayer = 16;
        Pool.BombsCount = 40;
    }
}
