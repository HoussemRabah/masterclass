from numpy import append, mat
from orientation import affecter , getChoixOf
from input import createListOfChoix, loadClassement, loadConfig , loadFicheVoeux , createListOfFicheVoeux, sortListOfFicheVoeux
import json
import converter as cn


# step 1 : load config file and excel files (classement must be sorted)
jsontxt= loadConfig("config.json")
config = json.loads(jsontxt)
classement= loadClassement(config["classement"]["filename"], config["classement"]["sheetname"])
listFilesOfFDV = [i["filename"] for i in config["ficheVoeux"]]
listSheetsOfFDV = [i["sheetname"] for i in config["ficheVoeux"]]
listFicheVoeux= loadFicheVoeux(listFilesOfFDV, listSheetsOfFDV)
    


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
    
    # step 5 : output
    print(str(classementFinal).replace("},","}\n"))
    
