using Codice.Client.Commands.Matcher;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;


[CreateAssetMenu(menuName = "ScriptableObjects/LubanUnityConfig")]
public class LubanUnityConfig : ScriptableObject
{
    

    [Header("���������ļ���·��")]
    public string LubanOutputDataPath;
    [Header("���ɴ����ļ���·��")]
    public string LubanOutputCodePath;

    [Header("���е�exe�ļ�·��")]
    public string LubanToolPath;
    [Header("���Excel�ļ��е�·��")]
    public string LubanExcelDataPath;
    [Header("���ö����ļ�·��")]
    public string LubanDefinesPath;
    [Header("Root�����ļ�·��")]
    public string LubanConfPath;
    [Header("���Excel�Ƿ�������exe")]
    public string LubanCheckPath;
    [Space]
    //���Բ������
    [Header("·�������ļ�·��")]
    public string LubanPathValidatorRoot;
    [Header("�������ļ�����·��")]
    public string LubanL10nTextProvider;

    public void Init(string rootPath)
    {
        rootPath = Path.GetFullPath(rootPath);
        var unityRootPath=Path.GetFullPath(Application.dataPath);
        LubanToolPath = Path.Combine(rootPath, "Tools", "Luban", "Luban.exe");
        LubanExcelDataPath = Path.Combine(rootPath, "Config", "Datas");
        LubanDefinesPath = Path.Combine(rootPath, "Config", "Defines");
        LubanConfPath = Path.Combine(rootPath, "Config", "luban.conf");
        //���֮��Ҳ������Ƕ
        LubanCheckPath = Path.Combine(rootPath, "Config", "gen.bat");

        LubanOutputDataPath = Path.Combine(unityRootPath, "OutPutData");
        LubanOutputCodePath = Path.Combine(unityRootPath, "OutPutCode");
    }
}
