using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractCard : MonoBehaviour
{
    protected IColldawnService _colldawnService;
    protected IExistCardsService _existCardsService;
    protected Vector3 _direction;
    public void GetValues(Vector3 direction, IColldawnService colldawnService, IExistCardsService existCardsService)
    {
        _direction = direction;
        _colldawnService = colldawnService;
        _existCardsService = existCardsService;
    }

    protected virtual void MoveCardStart()
    {
        //here settings of move
    }
    internal virtual void CardEffect()
    {
        //here concrete effect card (explosion, mini-game, etc.)
    }
    public virtual IEnumerator DestroyCardWithoutEffect()
    {
        yield return new WaitForSeconds(10f);
        Destroy(gameObject);
    }
    private IEnumerator Start()
    {
        yield return new WaitForEndOfFrame();
        StartCoroutine(DestroyCardWithoutEffect());
        MoveCardStart();
    }
}
