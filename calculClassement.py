
import parser as pr


def calculerMoy(listEtudiants, formulaire):     # ajouter column de moyen dont list etudiant
    for etudiant in listEtudiants:
       etudiant["MC"]=parseFormulaire(formulaire, etudiant)
    
    return listEtudiants

def sortClassement(listEtudiants):
    return sorted(listEtudiants, key=lambda k: k["MC"], reverse=True) 


def parseFormulaire(formulaire , dict):
    for i in range(1,len(formulaire.keys())):
        formulaire["form"]=formulaire["form"].replace(("$"+str(i)+"$"),"dict[\"" + formulaire[str(i)]+"\"]")
    
    return eval(formulaire["form"])
 
