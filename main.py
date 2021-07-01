import process_classement as pc
import process_oriontation as po
import sys
import os

#this file should build with PyInstaller with name "process.exe" and placed in same folder with MasterClassUI

def main(arg):
    try:
        if(len(arg)!=1):
            arg=arg[1]
        else : 
            arg="2"
        if(arg=="0"):
            pc.run()
            return None
        if(arg=="1"):
            po.run()
            return None
        print("Veuillez ouvrir MasterClassUI.exe et fermer cette fenêtre")
    except :
        print("error")

    

if __name__ == "__main__":
    main(sys.argv)
    os.system("pause")
    
