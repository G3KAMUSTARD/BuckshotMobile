using TMPro;
using UnityEngine;

public class PasswordInput : MonoBehaviour
{
    public TMP_InputField passwordField;

    void Start()
    {
        // Установить тип контента на "Password"
        passwordField.contentType = TMP_InputField.ContentType.Password;
        // Установить символ пароля, например, круг (●)
        passwordField.asteriskChar = '●';
        // Применить изменения
        passwordField.ForceLabelUpdate();
    }
}