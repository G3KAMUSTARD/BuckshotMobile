using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TableSearch : MonoBehaviour
{
    public TMP_InputField searchField; // Поле ввода
    public Transform content;      // Контейнер таблицы

    // Метод для поиска
    public void SearchTable()
    {
        string searchText = searchField.text.ToLower();

        foreach (Transform row in content)
        {
            bool match = false;

            foreach (Text cell in row.GetComponentsInChildren<Text>())
            {
                if (cell.text.ToLower().Contains(searchText))
                {
                    match = true;
                    break;
                }
            }

            row.gameObject.SetActive(match);
        }
    }

    private void Start()
    {
        // Подключаем метод к изменению текста в поле
        searchField.onValueChanged.AddListener(delegate { SearchTable(); });
    }
}
