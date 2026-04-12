using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DeckSelectionCardView : MonoBehaviour
{
    [SerializeField] private Image icon;
    [SerializeField] private TextMeshProUGUI unitName;
    [SerializeField] private Button button;
    [SerializeField] private Image selectedHighlight;

    private UnitData unitData;
    private DeckSelectionUI deckUI;

    public void Initialize(UnitData data, bool selected, DeckSelectionUI ui)
    {
        unitData = data;
        deckUI = ui;

        icon.sprite = data.CardSprite;
        unitName.text = data.UnitId.ToString();

        button.onClick.RemoveAllListeners();
        button.onClick.AddListener(OnClick);
    }

    public void SetSelected(bool selected)
    {
        selectedHighlight.enabled = selected;
    }

    private void OnClick()
    {
        deckUI.ToggleCard(unitData, this);
    }
}