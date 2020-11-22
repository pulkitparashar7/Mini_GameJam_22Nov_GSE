using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update

    public EnemyType EnemyType;
    public float MySpeed;
    public int NoPillNeeded = 1;
    public float MovementDelay;
    Image MyImage;
    RectTransform MyRectTransform;
    void Awake()
    {
        MyImage = GetComponent<Image>();
        MyRectTransform = GetComponent<RectTransform>();
    }

    public void Initialize(EnemyType type, float speed)
    {
        EnemyType = type;
        MySpeed = speed;
        InvokeRepeating("MoveEnemy", MovementDelay / 2, MovementDelay);

        switch(type)
        {
            case EnemyType.Green:
                MyImage.color = Color.green;
                break;
            case EnemyType.Yellow:
                MyImage.color = Color.yellow;
                break;
            case EnemyType.Red:
                MyImage.color = Color.red;
                break;
        }
    }

    void MoveEnemy()
    {
        MyRectTransform.anchoredPosition = new Vector2(MyRectTransform.anchoredPosition.x + MySpeed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
