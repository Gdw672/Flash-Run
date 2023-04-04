using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractCard : MonoBehaviour
{
    protected IColldawnService _colldawnService;
    protected Vector3 _direction;
    public void SetDirection(Vector3 direction, IColldawnService colldawnService)
    {
        _direction = direction;
        _colldawnService = colldawnService;
    }

    public virtual void CardEffect()
    {
        //here effect of card
    }
    private IEnumerator Start()
    {
        yield return new WaitForEndOfFrame();
        CardEffect();
    }
}
