import calculClassement as cc
import converter as cn
from input import loadConfig , loadFile
import json


def run() :
    print("Charger les confugirations à partir de config.json ...")
# load config 
    jsontxt= loadConfig("config.json")
    config = json.loads(jsontxt)

# load list etudiant
    listEtudiant = loadFile(config["listEtudiants"]["filename"], config["listEtudiants"]["sheetname"])

    print("Traitement des données ...")
# preparer classement
    listEtudiant = cc.calculerMoy(listEtudiant, config["formule"])
    listEtudiant = cc.sortClassement(listEtudiant)

    print("Sauvegarder ...")
# output classement
    cn.dictToExcel(listEtudiant, config["output"]["classement"])

    
    print("Terminé avec succès en :")
    print(config["output"]["classement"])
