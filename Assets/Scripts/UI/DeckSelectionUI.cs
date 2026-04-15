using System.Collections.Generic;
using UnityEngine;

public class DeckSelectionUI : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private UnitConfigDatabase unitDatabase;
    [SerializeField] private DeckSelectionCardView cardPrefab;

    [Header("Containers")]
    [SerializeField] private Transform availableContainer;
    [SerializeField] private Transform selectedContainer;

    [Header("Deck Settings")]
    [SerializeField] private int maxDeckSize = 8;

    private readonly List<UnitData> selectedUnits = new();
    private readonly List<DeckSelectionCardView> availableCards = new();
    private readonly List<DeckSelectionCardView> selectedCards = new();

    private void Start()
    {
        BuildAvailableCards();
    }

    private void BuildAvailableCards()
    {
        foreach (var unit in unitDatabase.GetAll())
        {
            if (unit == null) continue;

            var card = Instantiate(cardPrefab, availableContainer);
            card.Initialize(unit, false, this);

            availableCards.Add(card);
        }
    }

    public void ToggleCard(UnitData unit, DeckSelectionCardView card)
    {
        if (selectedUnits.Contains(unit))
        {
            RemoveFromDeck(unit, card);
            return;
        }

        AddToDeck(unit, card);
    }

    private void AddToDeck(UnitData unit, DeckSelectionCardView card)
    {
        if (selectedUnits.Count >= maxDeckSize)
            return;

        selectedUnits.Add(unit);

        card.transform.SetParent(selectedContainer, false);
        card.SetSelected(true);

        selectedCards.Add(card);
        availableCards.Remove(card);
        PlayerSessionData.instance.Profile.SelectedDeck.Add(unit.UnitId);
    }

    private void RemoveFromDeck(UnitData unit, DeckSelectionCardView card)
    {
        selectedUnits.Remove(unit);
        PlayerSessionData.instance.Profile.SelectedDeck.Remove(unit.UnitId);

        card.transform.SetParent(availableContainer, false);
        card.SetSelected(false);

        availableCards.Add(card);
        selectedCards.Remove(card);
    }

    public IReadOnlyList<UnitData> GetSelectedDeck()
    {
        return selectedUnits;
    }
}