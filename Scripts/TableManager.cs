using UnityEngine;
using UnityEngine.UI;

public class TableManager : MonoBehaviour
{
    public GameObject rowPrefab; // Префаб строки
    public Transform content;   // Контейнер (Content) таблицы

    // Метод для добавления строки
    public void AddRow(string[] rowData)
    {
        GameObject newRow = Instantiate(rowPrefab, content);
        Text[] cells = newRow.GetComponentsInChildren<Text>();

        for (int i = 0; i < rowData.Length; i++)
        {
            cells[i].text = rowData[i];
        }
    }

    // Пример заполнения таблицы
    private void Start()
    {
        AddRow(new[] { "P2MS001", "АК-74", "Исправен" });
        AddRow(new[] { "P2MS002", "M4A1", "Не исправен" });
        AddRow(new[] { "P2MS003", "АК-12", "Исправен" });
        AddRow(new[] { "P2MS004", "HK416", "Не исправен" });
        AddRow(new[] { "P2MS005", "АК-47", "Исправен" });
        AddRow(new[] { "P2MS006", "M16A4", "Исправен" });
        AddRow(new[] { "P2MS007", "СВД", "Не исправен" });
        AddRow(new[] { "P2MS008", "RPK-74", "Исправен" });
        AddRow(new[] { "P2MS009", "PKM", "Не исправен" });
        AddRow(new[] { "P2MS010", "G36", "Исправен" });
        AddRow(new[] { "P2MS011", "FN SCAR", "Исправен" });
        AddRow(new[] { "P2MS012", "АК-103", "Не исправен" });
        AddRow(new[] { "P2MS013", "ВСС", "Исправен" });
        AddRow(new[] { "P2MS014", "MP5", "Не исправен" });
        AddRow(new[] { "P2MS015", "АК-74М", "Исправен" });
    }
}
