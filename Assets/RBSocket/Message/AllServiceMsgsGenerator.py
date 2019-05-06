import subprocess
import sys

DIR = subprocess.Popen("pwd", stdout=subprocess.PIPE,
                       shell=True).communicate()[0]
cmd = "rossrv list"
fullname = subprocess.Popen(
    cmd, stdout=subprocess.PIPE, shell=True).communicate()[0]
namespace_list = []

for data in fullname.split("\n"):
    if not data.rsplit("/", 1)[0] in namespace_list:
        namespace_list.append(data.rsplit("/", 1)[0])

for name in namespace_list:
    cmd = "mkdir -p DefaultService/" + name
    subprocess.Popen(cmd, stdout=subprocess.PIPE, shell=True).communicate()

for data in fullname.split("\n"):
    if data != "":
        print("Generate: " + data)
        cmd = "cd DefaultService/" + \
            data.rsplit("/", 1)[0] + \
            " && python ../../GenerateServiceMsg.py " + data
        subprocess.Popen(cmd, stdout=subprocess.PIPE, shell=True).communicate()
