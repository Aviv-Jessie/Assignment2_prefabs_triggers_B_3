using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfinitLimit: MonoBehaviour
{
    enum Limit {Left, Right, Top ,Bottom}
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
    [Tooltip("Wall in left,right,top or button")]
    [SerializeField] Limit limit;
    [Tooltip("The size of the boarders can be changed according to the board size")]
    [SerializeField] int LeftRight = 16;
    [Tooltip("The size of the boarders can be changed according to the board size")]
    [SerializeField] int TopBottom = 9;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTag )
        {
            switch (limit)
            {
                case Limit.Left:
                    other.transform.position += new Vector3(LeftRight, 0, 0);
                    break;
                case Limit.Right:
                    other.transform.position += new Vector3(-LeftRight, 0, 0);
                    break;
                case Limit.Top:
                    other.transform.position += new Vector3(0, -TopBottom, 0);
                    break;
                case Limit.Bottom:
                    other.transform.position += new Vector3(0, TopBottom, 0);
                    break;
            }
        }
    }
}
