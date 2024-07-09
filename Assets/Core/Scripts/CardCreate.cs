using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardCreate : MonoBehaviour
{
    public List<GameObject> cardsPrefabs = new List<GameObject>();
    public List<Transform> refCardPosition=new List<Transform>();
    public int cardCount;

    private void Start()
    {
        cardCount=refCardPosition.Count;
        Create();
    }

    void Create()
    {
        for (int i = 0; i < cardCount; i++)
        {
            int cardX = Random.Range(0, cardsPrefabs.Count);
            GameObject card = Instantiate(cardsPrefabs[cardX], refCardPosition[i]);
            card.transform.position = refCardPosition[i].position;
        }
    }
}
