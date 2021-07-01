from numpy import append, mat
from orientation import affecter , getChoixOf, mergeTwoDict
from input import createListOfChoix, loadFile, loadConfig , loadFicheVoeux , createListOfFicheVoeux, sortListOfFicheVoeux
import json
import converter as cn

def run ():
    print("Charger les confugirations à partir de config.json ...")

# step 1 : load config file and excel files (classement must be sorted)
    jsontxt= loadConfig("config.json")
    config = json.loads(jsontxt)
    classement= loadFile(config["classement"]["filename"], config["classement"]["sheetname"])
    listFilesOfFDV = [i["filename"] for i in config["ficheVoeux"]]
    listSheetsOfFDV = [i["sheetname"] for i in config["ficheVoeux"]]
    listFicheVoeux= loadFicheVoeux(listFilesOfFDV, listSheetsOfFDV)
    

    print("Traitement des données ...")
# step 2 : Prepare dictionaries
    listFicheVoeux = createListOfFicheVoeux(listFicheVoeux, config["choixStartIndex"])
    listFicheVoeux = sortListOfFicheVoeux(listFicheVoeux, classement)
    specialite = config["specialites"]

# step 3 : Check that everything is good
    everythingGood = True
    totalPlace=0
    for s in specialite.keys():
      totalPlace=totalPlace+specialite[s]
    if(not len(listFicheVoeux)<=totalPlace):
        everythingGood=False
        print("Les places en master ne suffisent pas à tous les étudiants")


    # step 4 : fait oriontation
    if(everythingGood):
        classementFinal=[]
        for ficheVoeux in listFicheVoeux:
            classementFinal.append(affecter(ficheVoeux, specialite))
            choix = getChoixOf(ficheVoeux["lesChoix"], specialite)
            specialite[choix]=specialite[choix]-1
    
        print("Sauvegarder ...")
    # step 5 : output
        classementFinal=mergeTwoDict(classement,classementFinal, "MAT")
        cn.dictToExcel( classementFinal, config["output"]["orientation"])
        print("Terminé avec succès en :")
        print(config["output"]["orientation"])
