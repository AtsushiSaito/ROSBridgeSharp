using System;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;

namespace RBS.Messages
{
    [System.Serializable]
    public class Message
    {
    }

    [System.Serializable]
    public abstract class ExtendMessage : Message
    {
        public abstract string Type();
        public string ConvertString()
        {
            string result = "";
            string[] lines = JsonUtility.ToJson(this, true).Split(new char[] { '\n' });
            for (int i = 0; i < lines.Length; i++)
            {
                //　"記号や配列の終端である場合
                if (lines[i].Contains("\"") || lines[i].Contains("]"))
                {
                    // 配列の開始記号が含まれている場合は改行
                    if (!lines[i].Contains("[")) { lines[i] += "\n"; }
                    // 配列の終端記号が含まれている場合は改行
                    if (lines[i].Contains("]")) { lines[i] = lines[i].Replace(" ", ""); }
                    // コロンがあった場合、カンマを削除
                    if (lines[i].Contains(":")) { lines[i] = lines[i].Replace(",", ""); }
                    // 配列の終端記号の後ろについてるカンマを削除
                    lines[i] = lines[i].Replace("],", "]");
                }
                else
                {
                    // 空白を削除
                    lines[i] = lines[i].Replace(" ", "");
                    // 配列の区切り文字の後ろにカンマ
                    lines[i] = lines[i].Replace(",", ", ");
                }
                // 配列内がオブジェクトの場合の例外処理
                if (i > 1 && (lines[i].Contains("{") && lines[i - 1].Contains(": ["))) { lines[i] = "\n"; }
                // 中括弧系の削除
                lines[i] = lines[i].Replace("{", "");
                lines[i] = lines[i].Replace("}, ", "");
                lines[i] = lines[i].Replace("}", "");
                // インデント幅の調整
                lines[i] = lines[i].Replace("    \"", "");
                // "の削除
                lines[i] = lines[i].Replace("\"", "");

                if (lines[i].Contains(":"))
                {
                    string ss = lines[i].Substring(0, lines[i].IndexOf(":"));
                    lines[i] = lines[i].Replace(ss, "<color=#F2F5A9>" + ss + "</color>");
                }
                // テキストに追加
                result += lines[i] + "";
            }
            return result;
        }
    }
    [System.Serializable]
    public class OperationMessage : Message
    {
        public string op;
        public string id;
    }
}
