using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class RocketCard : AbstractCard
{
    [SerializeField] private Collider _collider;
    [SerializeField] private Vector3 _explosionSize;
    protected override void MoveCardStart()
    {
        _rigidbody.AddForce(_direction * 45, ForceMode.Impulse);
        _colldawnService.CooldawnTillDestroy();
    }
    internal override void CardEffect()
    {
        _collider.gameObject.SetActive(true);

        _collider.transform.DOScale(_explosionSize, 0.3f);

        StartCoroutine(DestroyCard());
    }

    private IEnumerator SetCardExist()
    {
        yield return new WaitForEndOfFrame();
        _existCardsService.IntryRocketCardToExist(GetComponent<RocketCard>());
    }
    private IEnumerator DestroyCard() 
    {
        yield return new WaitForSeconds(0.4f);
        Destroy(gameObject);
        _colldawnService.CancelCooldawn();
    }
    private void OnEnable()
    {
        StartCoroutine(SetCardExist());
    }
    private void OnDestroy()
    {
        _existCardsService.IntryRocketCardToExist(null);
    }
}

