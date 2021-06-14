from os import remove
import converter as cn
import pandas as pa
import numpy as nu


# load config file
def loadConfig(filename):
    f = open(filename, "r")
    return f.read()

# input the excel file of "classement" as a list of dictionary 'classement must be sorted'
def loadClassement(filename, sheetname):
    cn.excelToCSV(filename, sheetname, "\\temp.csv")
    return cn.CSVToDict("\\temp.csv")


# input excel files of "les fiche de voeux" as a list of dictionary
# listFilename : list of filenames of "les fiches" (fiche de isil,fiche de acad , fiche de gtr)
def loadFicheVoeux(listFilename, listSheetname):
    dic=[]
    i=0
    for filename in listFilename:
        cn.excelToCSV(filename, listSheetname[i] , "\\temp.csv")
        dic=dic+(cn.CSVToDict("\\temp.csv"))
        i=i+1
    return dic #format : {"maticule": xxxx, "il":1, "vi":3, "mind":2}


# step 2 : 

#  {"maticule": xxxx, "il":1, "vi":3, "mind":2} ==> ("il", "mind", "vi") "with startIndex = 1"
def createListOfChoix(ficheVoeux, startIndex):
    choixOrdre = list(ficheVoeux.values())[startIndex:]        # example : (1,3,4,2)
    choixColumns = list(ficheVoeux.keys())[startIndex:]        # example : (il,vi,bio,si)
    # remplir les choix vides avec des values increment
    i=0
    for choi in choixOrdre:
        if(pa.isna(choi)):
            choixOrdre[i]= nu.nanmax(choixOrdre)+1
        i=i+1
    return list(zip(*sorted(zip(choixOrdre,choixColumns))))[1] # alors   : (il,si,vi,bio)
    


# Convert fiche voeux to the correct format (les choix sont un list , non columns)
def createListOfFicheVoeux(listFicheVoeux, startIndex):
    l=[]
    for fiche in listFicheVoeux:
        l.append(
            {
                "matricule":fiche['matricule'],
                "lesChoix": createListOfChoix(fiche, startIndex)
            } 
        )
    return l



# Arrange list of "fiche de voeux" according the "classement excel"
def sortListOfFicheVoeux(listFicheVoeux , listEtudiantsSorted) :
    e=[]  
    for etd in listEtudiantsSorted :
        e.append(etd['MAT'])
    
    # Deleting a student from classement if he does not have a fiche de voeux (Did not choose a master)
    for mat in e:
        if not (mat in [x['matricule'] for x in listFicheVoeux]):
            e= [i for i in e if i != mat]


    # Deleting a student fiche de voeux if he does not exist in classement (L3 n'est pas valider)
    for fiche in listFicheVoeux:
        if not (fiche["matricule"] in e):
            listFicheVoeux= [i for i in listFicheVoeux if i["matricule"] != fiche["matricule"]]


    try:
        listFicheVoeux.sort(key = lambda i: e.index(i['matricule']))
        return listFicheVoeux
    except ValueError as e:
        print(e)
        return []
    
