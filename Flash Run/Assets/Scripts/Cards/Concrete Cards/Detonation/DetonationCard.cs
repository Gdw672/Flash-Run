using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DetonationCard : AbstractCard
{
    [SerializeField] private SphereCollider _collider;
    [SerializeField] private GameObject cardObject;
    [SerializeField] private float _speedRotate;
    protected override void MoveCardStart()
    {
      _rigidbody.AddForce(_direction * 8, ForceMode.Impulse);
        StartCoroutine(_colldawnService.CooldawnForTime());
    }

    private void FixedUpdate()
    {
        cardObject.transform.Rotate(_speedRotate * Time.deltaTime, 0, 0);
    }
    
    private IEnumerator DestroyCard()
    {
        yield return new WaitForSeconds(0.2f);
        Destroy(gameObject);
    }

    internal override void CardEffect()
    {
        _rigidbody.constraints = RigidbodyConstraints.FreezeAll;
        _speedRotate = 0;
        _collider.gameObject.SetActive(true);
        _collider.transform.DOScale(5f, 0.2f);
        StartCoroutine(DestroyCard());
    }

    private void OnDestroy()
    {
        _colldawnService.CancelCooldawn();
    }
}
