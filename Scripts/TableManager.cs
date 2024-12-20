using UnityEngine;
using UnityEngine.UI;

public class TableManager : MonoBehaviour
{
    public GameObject rowPrefab; // ������ ������
    public Transform content;   // ��������� (Content) �������

    // ����� ��� ���������� ������
    public void AddRow(string[] rowData)
    {
        GameObject newRow = Instantiate(rowPrefab, content);
        Text[] cells = newRow.GetComponentsInChildren<Text>();

        for (int i = 0; i < rowData.Length; i++)
        {
            cells[i].text = rowData[i];
        }
    }

    // ������ ���������� �������
    private void Start()
    {
        AddRow(new[] { "P2MS001", "��-74", "��������" });
        AddRow(new[] { "P2MS002", "M4A1", "�� ��������" });
        AddRow(new[] { "P2MS003", "��-12", "��������" });
        AddRow(new[] { "P2MS004", "HK416", "�� ��������" });
        AddRow(new[] { "P2MS005", "��-47", "��������" });
        AddRow(new[] { "P2MS006", "M16A4", "��������" });
        AddRow(new[] { "P2MS007", "���", "�� ��������" });
        AddRow(new[] { "P2MS008", "RPK-74", "��������" });
        AddRow(new[] { "P2MS009", "PKM", "�� ��������" });
        AddRow(new[] { "P2MS010", "G36", "��������" });
        AddRow(new[] { "P2MS011", "FN SCAR", "��������" });
        AddRow(new[] { "P2MS012", "��-103", "�� ��������" });
        AddRow(new[] { "P2MS013", "���", "��������" });
        AddRow(new[] { "P2MS014", "MP5", "�� ��������" });
        AddRow(new[] { "P2MS015", "��-74�", "��������" });
    }
}
