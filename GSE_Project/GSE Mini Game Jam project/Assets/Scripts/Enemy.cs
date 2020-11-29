using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update

    Movement MovementComponent;
    public EnemyType EnemyType;
    public float MySpeed;
    public int NoPillNeeded = 1;
    [SerializeField]
    public float MoveSpeedMultiplier = 1f;
    public float MovementDelay;
    Image MyImage;
    RectTransform MyRectTransform;
    void Awake()
    {
        MyImage = GetComponent<Image>();
        MyRectTransform = GetComponent<RectTransform>();
        MovementComponent = GetComponent<Movement>();
    }

    public void Initialize(EnemyType type, float speed)
    {
        if (MyImage == null)
            return;       
        EnemyType = type;
        MySpeed = speed;
        //InvokeRepeating("MoveEnemy", MovementDelay / 2, MovementDelay);
        switch(type)
        {
            case EnemyType.Green:
                MyImage.color = Color.green;
                break;
            case EnemyType.Blue:
                MyImage.color = Color.blue;
                break;
            case EnemyType.Red:
                MyImage.color = Color.red;
                break;
        }
    }

    void MoveEnemy()
    {
       // MyRectTransform.anchoredPosition = new Vector2(MyRectTransform.anchoredPosition.x + MySpeed, 0);
    }

    // Update is called once per frame
    void Update()
    {
        this.MovementComponent.ApplyMovement(new Vector2(MySpeed * Time.deltaTime, 0));
    }
    public bool NotifyHitByBullet(MedicineBullet bullet)
    {
        if(bullet == null)
        {
            return false;
        }
        if((int)bullet.BulletType == (int)this.EnemyType)
        {
            Destroy(this.gameObject);
            return true;
        }
        else
        {
            this.MySpeed *= this.MoveSpeedMultiplier;
            return true;
        }
        
    }
}
