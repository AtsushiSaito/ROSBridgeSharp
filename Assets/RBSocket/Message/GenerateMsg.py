import subprocess
import sys
args = sys.argv

cmd = "rosmsg show " + args[1]

namespace = args[1].rsplit("/",1)[0]
msg_name = args[1].rsplit("/",1)[1]

if msg_name == "Time" or msg_name == "Duration":
    print("not support.")
    exit()

process = subprocess.Popen(cmd, stdout=subprocess.PIPE,shell=True).communicate()[0]

files = process.split("\n")
process = ""
in_type_namespace = []

for i in range(len(files) - 2):
    if files[i].count(" ") < 2:
        if files[i].count("/") == 0:
            process += files[i] + "\n"
            in_type_namespace.append("")
        else:
            process += files[i].rsplit("/")[1] + "\n"
            in_type_namespace.append(files[i].rsplit("/")[0])

splited_data = process.split()

c_sharp_type = ["bool", "string", "Time", "int",  "uint",  "int",   "uint",   "int",   "uint",   "int",   "uint",   "float",   "double",  "Duration", "byte", "char"]
ros_type =     ["bool", "string", "time", "int8", "uint8", "int16", "uint16", "int32", "uint32", "int64", "uint64", "float32", "float64", "duration", "byte", "char"]
initial_data = ["false", "\"\"", "new Time()", "0", "0", "0", "0", "0", "0", "0", "0", "0.0f", "0.0f", "new Duration()", "0", "\'\0\'"]

in_type_list = []
in_type_isArray = []
in_name_list = []
in_name_IsInited = []
in_name_InitedValue = []
in_type_custom = []

in_name_IsArrayInited = []
in_name_ArrayInitedValue = []

for i in range(len(splited_data)):
    data = splited_data[i]
    if(0 == i % 2):
        isArray = data.find('[')
        isHit = False
        isArrayInited = False
        if(isArray == -1):
            in_type_isArray.append(False)
            for y in range(len(ros_type)):
                if ros_type[y] == str(data):
                    in_type_list.append(c_sharp_type[y])
                    isHit = True
                    in_type_custom.append(False)
            if not isHit:
                in_type_list.append(str(data))
                in_type_custom.append(True)
            in_name_IsArrayInited.append(False)
            in_name_ArrayInitedValue.append("")
        else:
            in_value_buf = ""
            if data[isArray + 1] == "]":
                in_name_IsArrayInited.append(False)
                in_name_ArrayInitedValue.append("")
            else:
                end_index = data.find(']')
                in_name_IsArrayInited.append(True)
                isArrayInited = True
                in_value_buf = data[isArray+1:end_index]
                in_name_ArrayInitedValue.append(in_value_buf)
            in_type_isArray.append(True)

            for y in range(len(ros_type)):
                if isArrayInited:
                    end_index = data.find(']')
                    if (ros_type[y]+"[" + in_value_buf +"]") == (str(data)):
                        in_type_list.append(c_sharp_type[y])
                        isHit = True
                        in_type_custom.append(False)
                else:
                    if (ros_type[y]+"[]") == (str(data)):
                        in_type_list.append(c_sharp_type[y])
                        isHit = True
                        in_type_custom.append(False)
            if not isHit:
                in_type_list.append(str(data)[:-2])
                in_type_custom.append(True)
    else:
        InitedIndex = data.find('=')
        if InitedIndex == -1:
            in_name_list.append(data)
            in_name_IsInited.append(False)
            in_name_InitedValue.append("")
        else:
            cut_index = len(data) - InitedIndex
            in_name_list.append(data[:-cut_index])
            in_name_IsInited.append(True)
            in_name_InitedValue.append(data[InitedIndex + 1:])

output_class = "using System;\n\nnamespace RBS.Messages."+ namespace + "\n{\n"
output_class += "    [System.Serializable]\n"
output_class += "    public class " + msg_name + " : ExtendMessage\n    {\n"

for i in range(len(in_type_list)):
    if in_type_custom[i]:
        if in_type_isArray[i]:
            output_class += "        public " + "RBS.Messages." + in_type_namespace[i] + "." + in_type_list[i] + "[] " + in_name_list[i] + ";\n"
        else:
            output_class += "        public " + "RBS.Messages." + in_type_namespace[i] + "." + in_type_list[i] + " " + in_name_list[i] + ";\n"
    else:
        if in_type_isArray[i]:
            output_class += "        public "+ in_type_list[i] + "[] " + in_name_list[i] + ";\n"
        else:
            output_class += "        public "+ in_type_list[i] + " " + in_name_list[i] + ";\n"
output_class += "        public override string Type() { return \"" + args[1] + "\"; }\n"

output_class += "        public " + msg_name + "()\n        {\n"
for i in range(len(in_type_list)):
    isHit = False
    for y in range(len(c_sharp_type)):
        if c_sharp_type[y] == in_type_list[i] and not isHit:
            isHit = True
            if in_type_isArray[i]:
                if not in_name_IsInited[i]:
                    if in_name_IsArrayInited[i]:
                        output_class += "            " + in_name_list[i] + " = new " + in_type_list[i] + "[" + in_name_ArrayInitedValue[i] + "];\n"
                    else:
                        output_class += "            " + in_name_list[i] + " = new " + in_type_list[i] + "[0];\n"
                else:
                    output_class += "            " + in_name_list[i] + " = " + in_name_InitedValue[i] + ";\n"
            else:
                if not in_name_IsInited[i]:
                    output_class += "            " + in_name_list[i] + " = " + initial_data[y] + ";\n"
                else:
                    output_class += "            " + in_name_list[i] + " = " + in_name_InitedValue[i] + ";\n"
    if not isHit:
        if in_type_isArray[i]:
            if not in_name_IsInited[i]:
                if in_name_IsArrayInited[i]:
                    output_class += "            " + in_name_list[i] + " = new " + "RBS.Messages." + in_type_namespace[i] + "." + in_type_list[i] + "[" + in_name_ArrayInitedValue[i] + "];\n"
                else:
                    output_class += "            " + in_name_list[i] + " = new " + "RBS.Messages." + in_type_namespace[i] + "." + in_type_list[i] + "[0];\n"
            else:
                output_class += "            " + in_name_list[i] + " = " + in_name_InitedValue[i]  + ";\n"
        else:
            if not in_name_IsInited[i]:
                output_class += "            " + in_name_list[i] + " = " + "new " + "RBS.Messages." + in_type_namespace[i] + "." + in_type_list[i] + "();\n"
            else:
                output_class += "            " + in_name_list[i] + " = " + in_name_InitedValue[i] + ";\n"

output_class += "        }\n    }\n}"

f = open(msg_name +".cs", "w")
f.write(output_class)
f.close()

print(output_class)