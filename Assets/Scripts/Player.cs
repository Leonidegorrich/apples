using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed;

    // ”правление тележкой влево-вправо + так чтобы она упиралась в невидимые стены
    // и не выезжала за край экрана
    // + красивый UI дл€ жизней
}
