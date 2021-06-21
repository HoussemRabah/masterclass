

def calculerMoy(listEtudiants, formulaire):     # ajouter column de moyen dont list etudiant
    for etudiant in listEtudiants:
       etudiant["MC"]=parseFormule(formulaire, etudiant)
    
    return listEtudiants

def sortClassement(listEtudiants):
    return sorted(listEtudiants, key=lambda k: k["MC"], reverse=True) 


def parseFormule(formule , dict):
    for i in range(1,len(formule.keys())):
        formule["form"]=formule["form"].replace(("$"+str(i)+"$"),"dict[\"" + formule[str(i)]+"\"]")
    
    return eval(formule["form"])
