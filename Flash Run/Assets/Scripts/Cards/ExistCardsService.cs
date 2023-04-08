using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExistCardsService : IExistCardsService
{
    public RocketCard _existedRocketCard;

    public void IntryRocketCardToExist(RocketCard existedRocketCard)
    {
        _existedRocketCard = existedRocketCard;
    }
    public void DestroyRocket()
    {
        _existedRocketCard.CardEffect();
    }
    public bool CheckStatusCard()
    {
        if (_existedRocketCard == null)
            return false;
        else
            return true;
    }
}
public interface IExistCardsService 
{
    public void IntryRocketCardToExist(RocketCard existedRocketCard);
    public bool CheckStatusCard();
    public void DestroyRocket();
}

