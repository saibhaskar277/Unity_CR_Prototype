using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UnitCardView : MonoBehaviour
{
    [Header("UI References")]
    [SerializeField] private Image unitIcon;
    [SerializeField] private TextMeshProUGUI unitNameText;
    [SerializeField] private TextMeshProUGUI elixirText;
    [SerializeField] private Button selectButton;
    [SerializeField] private Image selectionHighlight;

    private UnitData boundData;
    private UnitSpawnSystem spawnSystem;

    public void Initialize(UnitData data, UnitSpawnSystem system)
    {
        boundData = data;
        spawnSystem = system;

        SetupCard();
        RegisterButton();
        RefreshState();
    }

    private void SetupCard()
    {
        if (boundData == null) return;

        unitIcon.sprite = boundData.CardSprite;
        unitNameText.text = boundData.UnitId.ToString();
        elixirText.text = boundData.ElixirCost.ToString();
    }

    private void RegisterButton()
    {
        selectButton.onClick.RemoveAllListeners();
        selectButton.onClick.AddListener(OnSelectClicked);
    }

    public void RefreshState()
    {
        if (boundData == null || spawnSystem == null)
            return;

        bool canSpawn = spawnSystem.CanSpawn(boundData);
        bool isSelected =
            spawnSystem.IsPlacing &&
            spawnSystem.SelectedUnitData == boundData;

        selectButton.interactable = canSpawn;
        selectionHighlight.enabled = isSelected;
    }

    private void OnSelectClicked()
    {
        if (boundData == null || spawnSystem == null)
            return;

        if (!spawnSystem.CanSpawn(boundData))
            return;

        spawnSystem.StartPlacement(boundData);
        RefreshState();
    }
}