using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Chat : MonoBehaviour
{
    //TMP_Text m_text;
    public static UI_Chat I;
    [Range(0.0001f, 0.01f)] public float duration = 0.01f;
    public TextMeshProUGUI textMeshPro;
    public Image characterImg;
    public Button btnNext;
    private bool isFinished = true;
    public LineBookLib lineBookLib;

    public int index;
    public string curtLine;
    public List<string> lineBook;

    public void Init()
    {
        I = this;
        lineBookLib.Init();
        Hide();
    }

    private void Awake()
    {
        //TryGetComponent<TMP_Text>(out m_text);
    }
    private void Start()
    {
        btnNext.onClick.AddListener(() =>
        {
            PlayOneLineInTyping();
        });
    }

    public void StartPresentlines(string bookName)
    {
        Show();
        index = 0;
        lineBook = lineBookLib.GetLineBook(bookName);

        PlayOneLineInTyping();
    }

    private void PlayOneLineInTyping()
    {
        if (!isFinished) return;

        //[1].Pick up one line from the dialogue script.
        curtLine = lineBook[index];

        //Parse Line:
        string[] strArray = curtLine.Split('|');
        if (strArray[0] == "*e")
        {
            Hide();
            return;
        }
        //Set Character Image.
        if (strArray[0]=="t")
        {
            characterImg.sprite= UIMgr.I.ui_CharacterImgLib.GetCharacterImg(strArray[1]);

        }



        //[2].Play it.
        StartCoroutine(TypeWrite(strArray[2]));

        index++;
    }

    private IEnumerator TypeWrite(string str)
    {
        isFinished = false;

        bool isCharComplete = false;
        textMeshPro.text = str;

        textMeshPro.ForceMeshUpdate();
        //m_text.ForceMeshUpdate();

        TMP_TextInfo text_info = textMeshPro.textInfo;
        int total = text_info.characterCount;
        int current = 0;
        while (!isCharComplete)
        {
            if (current > total)
            {
                current = total;
                yield return new WaitForSecondsRealtime(0.1f);
                isCharComplete = true;
            }
            textMeshPro.maxVisibleCharacters = current;
            current += 1;
            yield return new WaitForSecondsRealtime(duration);
        }
        isFinished = true;
        yield return null;
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }
    public void Hide()
    {
        gameObject.SetActive(false);
    }

    private void SetCharacterImg() 
    {

    }
    // Update is called once per frame
    void Update()
    {

    }
}
