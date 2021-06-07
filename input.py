import converter as cn




# input the excel file of "classement" as a list of dictionary 'classement must be sorted'
def getClassement(filename, sheetname):
    cn.excelToCSV(filename, sheetname, "\\temp.csv")
    return cn.CSVToDict("\\temp.csv")

# input excel files of "les fiche de voeux" as a list of dictionary
# listFilename : list of filenames of "les fiches" (fiche de isil,fiche de acad , fiche de gtr)
def getFicheVoeux(listFilename, listSheetname):
    dic=[]
    i=0
    for filename in listFilename:
        cn.excelToCSV(filename, listSheetname[i] , "\\temp.csv")
        dic.append(cn.CSVToDict("\\temp.csv"))
        i=i+1
    return dic #format : {"maticule": xxxx, "il":1, "vi":3, "mind":2}



#  {"maticule": xxxx, "il":1, "vi":3, "mind":2} ==> ("il", "mind", "vi") "with startIndex = 1"
def createListOfChoix(ficheVoeux, startIndex):
    choixOrdre = list(ficheVoeux.values())[startIndex:]        # example : (1,3,4,2)
    choixColumns = list(ficheVoeux.keys())[startIndex:]        # example : (il,vi,bio,si)
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
    listFicheVoeux.sort(key = lambda i: e.index(i['matricule']))
    return listFicheVoeux