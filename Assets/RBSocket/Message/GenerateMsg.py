#!/usr/bin/env python
# -*- coding: utf-8 -*-

import subprocess
import sys
args = sys.argv


class CHClassGenerate():
    def __init__(self):
        self.CSharpTypeName = ["bool", "string", "Time", "int", "byte", "int",
                               "uint", "int", "uint", "int", "uint", "float",
                               "double", "Duration", "byte", "char"]

        self.ROSTypeName = ["bool", "string", "time", "int8", "uint8", "int16",
                            "uint16", "int32", "uint32", "int64", "uint64", "float32",
                            "float64", "duration", "byte", "char"]

        self.CSharpInitialValues = ["false", "\"\"", "new Time()", "0", "0", "0", "0",
                                    "0", "0", "0", "0", "0.0f", "0.0f", "new Duration()", "0", "\'\0\'"]

        self.set_msg_name(args[1])
        self.CheckMessgage()
        self.CommandMsgShowRun()
        self.CommandRowData_to_NoNestMsgData()
        self.ParseTypeNameSpace()
        self.SplitTypeAndName()
        self.GenerateMsgText()
        self.Save()

    # メッセージの名前とネームスペースを分離
    def set_msg_name(self, msg_arg):
        self.msg = msg_arg
        self.msg_namespace = msg_arg.rsplit("/", 1)[0]
        self.msg_name = msg_arg.rsplit("/", 1)[1]

    # TimeとDurationは除外する。
    def CheckMessgage(self):
        if self.msg_name == "Time" or self.msg_name == "Duration":
            exit()

    def CommandMsgShowRun(self):
        # rosmsg showコマンドを実行してメッセージ情報を受取る
        self.CommandRowData = subprocess.Popen(
            "rosmsg show " + self.msg, stdout=subprocess.PIPE, shell=True).communicate()[0]

    def CommandRowData_to_NoNestMsgData(self):
        self.NoNestMsgData = ""
        data = self.CommandRowData.split("\n")  # 改行で分割
        for i in range(len(data)):
            # データが空の場合はコンティニュー
            if data[i] == "":
                continue
            # スペースが2個以上含まれる場合はネストと判断してスキップ
            if data[i].count(" ") < 2:
                self.NoNestMsgData += data[i]
                if not i == len(data) - 3:
                    self.NoNestMsgData += "\n"

    def ParseTypeNameSpace(self):
        self.ParseMsgData = ""
        self.TypeNameSpaces = []
        data = self.NoNestMsgData.split("\n")  # 改行で分割
        for i in range(len(data)):
            if data[i].count("/") == 0:
                self.TypeNameSpaces.append("")
                self.ParseMsgData += data[i] + "\n"
            else:
                self.TypeNameSpaces.append(data[i].rsplit("/")[0])
                self.ParseMsgData += data[i].rsplit("/")[1] + "\n"

    def SplitTypeAndName(self):
        # 型リスト
        self.TypeList = []
        # 変数名リスト
        self.NameList = []
        # ネームスペースがあるかどうか
        self.IsCustonNameSpace = []
        # 初期値があるかどうか
        self.IsInited = []
        # 初期値の値
        self.InitedValues = []
        # 配列であるかどうか
        self.IsArray = []

        # 配列に初期値があるかどうか
        self.IsArrayInited = []
        # 配列であった場合に、初期値があるかないか
        self.ArrayInitialValues = []

        datas = self.ParseMsgData.split()

        # 分割した個数分だけ回す
        for i in range(len(datas)):
            # 偶数の場合は型
            if(0 == i % 2):
                isArray = datas[i].find('[')
                hasOrinalType = False
                # 配列でない場合
                if(isArray == -1):
                    # ------------------------------------
                    # 配列ではないので
                    self.IsArray.append(False)
                    # 配列でなく、初期値もないので
                    self.ArrayInitialValues.append("")
                    # ------------------------------------
                    for j in range(len(self.ROSTypeName)):
                        if self.ROSTypeName[j] == str(datas[i]):
                            self.TypeList.append(self.CSharpTypeName[j])
                            # オリジナルタイプである
                            hasOrinalType = True
                            # ------------------------------------
                            # カスタムネームスペースではない
                            self.IsCustonNameSpace.append(False)
                            # ------------------------------------
                    # オリジナルタイプではない場合
                    if not hasOrinalType:
                        # ------------------------------------
                        self.TypeList.append(str(datas[i]))
                        self.IsCustonNameSpace.append(True)
                        # ------------------------------------
                    self.IsArrayInited.append(False)
                # 配列の場合
                else:
                    # 配列なので
                    self.IsArray.append(True)
                    # 配列に初期値
                    hasArrayValue = False
                    # 配列の初期値
                    ArrayValue = ""
                    # 括弧が次にある場合
                    if datas[i][isArray + 1] == "]":
                        self.IsArrayInited.append(False)
                        self.ArrayInitialValues.append("")
                    # 初期値ある場合
                    else:
                        self.IsArrayInited.append(True)
                        # 括弧の終わりのインデックス番号を調べる
                        end_index = datas[i].find(']')
                        hasArrayValue = True
                        ArrayValue = datas[i][isArray + 1: end_index]
                        self.ArrayInitialValues.append(ArrayValue)

                    for j in range(len(self.ROSTypeName)):
                        if hasArrayValue:
                            end_index = datas[i].find(']')
                            if (self.ROSTypeName[j] + "[" + ArrayValue + "]") == (str(datas[i])):
                                self.TypeList.append(self.CSharpTypeName[j])
                                hasOrinalType = True
                                self.IsCustonNameSpace.append(False)
                        else:
                            if (self.ROSTypeName[j] + "[]") == (str(datas[i])):
                                self.TypeList.append(self.CSharpTypeName[j])
                                hasOrinalType = True
                                self.IsCustonNameSpace.append(False)
                    if not hasOrinalType:
                        self.TypeList.append(str(datas[i])[:-2])
                        self.IsCustonNameSpace.append(True)
            else:
                equal_index = datas[i].find('=')
                if equal_index == -1:
                    self.NameList.append(datas[i])
                    self.IsInited.append(False)
                    self.InitedValues.append("")
                else:
                    cut_index = len(datas[i]) - equal_index
                    self.NameList.append(datas[i][:-cut_index])
                    self.IsInited.append(True)
                    self.InitedValues.append(datas[i][equal_index + 1:])

    def GS(self, n):
        space = ""
        for _ in range(n):
            space += " "
        return space

    def GenerateMsgText(self):
        text = ""
        text += "using System;\n\n"
        text += "namespace RBS.Messages." + self.msg_namespace + "\n{\n"
        text += self.GS(4) + "[System.Serializable]\n"
        text += self.GS(4) + "public class " + self.msg_name
        text += " : ExtendMessage\n"
        text += self.GS(4) + "{\n"

        # クラス定義のところまで
        for i in range(len(self.TypeList)):
            if(self.TypeList[i] == "byte" and self.IsArray[i]):
                self.TypeList[i] = "string"
                self.IsArray[i] = False
            # ネームスペースが存在する場合
            if self.IsCustonNameSpace[i]:
                text += self.GS(8) + "public " + "RBS.Messages."
                text += self.TypeNameSpaces[i] + "." + self.TypeList[i]
            else:
                text += self.GS(8) + "public " + self.TypeList[i]
            if self.IsArray[i]:
                text += "[] "
            else:
                text += " "
            text += self.NameList[i] + ";\n"

        text += self.GS(8) + "public override string Type() { return \""
        text += self.msg + "\"; }\n"
        text += self.GS(8) + "public " + self.msg_name + "()\n"
        text += self.GS(8) + "{\n"

        # 初期化の箇所
        for i in range(len(self.TypeList)):
            isOrignal = False
            text += self.GS(12) + self.NameList[i] + " = "
            for j in range(len(self.CSharpTypeName)):
                if self.CSharpTypeName[j] == self.TypeList[i] and not isOrignal:
                    isOrignal = True
                    if self.IsArray[i]:
                        if not self.IsInited[i]:
                            text += "new " + self.TypeList[i] + "["
                            if self.IsArrayInited[i]:
                                text += self.ArrayInitialValues[i] + "];\n"
                            else:
                                text += "0];\n"
                        else:
                            text += self.InitedValues[i] + ";\n"
                    else:
                        if not self.IsInited[i]:
                            text += self.CSharpInitialValues[j] + ";\n"
                        else:
                            text += self.InitedValues[i] + ";\n"
            if not isOrignal:
                if self.IsArray[i]:
                    if self.IsArrayInited[i]:
                        text += "new " + "RBS.Messages."
                        text += self.TypeNameSpaces[i] + "."
                        text += self.TypeList[i] + "["
                        text += self.ArrayInitialValues[i] + "];\n"
                    else:
                        text += "new " + "RBS.Messages."
                        text += self.TypeNameSpaces[i] + "."
                        text += self.TypeList[i] + "[0];\n"
                else:
                    text += "new " + "RBS.Messages."
                    text += self.TypeNameSpaces[i] + "."
                    text += self.TypeList[i] + "();\n"
        text += "        }\n    }\n}"
        self.maked_text = text

    def Save(self):
        file = open(self.msg_name + ".cs", "w")
        file.write(self.maked_text)
        file.close()
        print(self.maked_text)


if __name__ == '__main__':
    CHClassGenerate()
