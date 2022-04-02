using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceAnimationUI : MonoBehaviour
{
    public static DiceAnimationUI instance;

    private void Awake()
    {
        instance = this;
    }

    public Image diceAnimationImage;
    
    public float diceAnimationTime;

    private Sprite[] sprites;

    public delegate void AnimationFinishedEvent(int diceValue); // delegate ������ ���� ����

    private void Start()
    {
        sprites = Resources.LoadAll<Sprite>("DiceVectorDark"); // �̹��� ������
    }

    // thread ���� �ڿ� �ϳ���
    public IEnumerator E_DiceAnimation(int diceValue, DicePlayManager manager, AnimationFinishedEvent finishEvent)
    {
        float elapseTime = 0;
        while (elapseTime < diceAnimationTime)
        {
            elapseTime += diceAnimationTime / 10;
            int tmpldx = Random.Range(0,sprites.Length);
            diceAnimationImage.sprite = sprites[tmpldx];
            yield return new WaitForSeconds(diceAnimationTime/10);
        }
        diceAnimationImage.sprite = sprites[diceValue - 1];

        if(finishEvent != null)
            finishEvent(diceValue);
        manager.animationCoroutine = null;
    }

}
