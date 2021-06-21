import calculClassement as cc
import converter as cn
from input import loadConfig , loadFile
import json



# load config 
jsontxt= loadConfig("config.json")
config = json.loads(jsontxt)

# load list etudiant
listEtudiant = loadFile(config["listEtudiants"]["filename"], config["listEtudiants"]["sheetname"])

# preparer classement
listEtudiant = cc.calculerMoy(listEtudiant, config["formule"])
listEtudiant = cc.sortClassement(listEtudiant)

# output classement
cn.dictToExcel(listEtudiant, config["output"]["classement"])
