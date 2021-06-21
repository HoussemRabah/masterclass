import pandas as pn



# Vérifier si on peut donner le choix à l'étudiant
def isAvailble(choix, specialite):
    if(specialite[choix] > 0):
        return True
    else:
        return False

# Obtention du choix final de l'étudiant
def getChoixOf(lesChoix, specialite):
    for choix in lesChoix:
        if(isAvailble(choix, specialite)):
            return choix
    return "empty"


# Renvoie un dictionnaire contenant matricule de l'étudiant et la spécialisation à laquelle il a été envoyé
def affecter(ficheVoeux, specialite):
    choix = getChoixOf(ficheVoeux["lesChoix"], specialite)
    etudiantData = {
        "MAT": ficheVoeux["matricule"],
        "choix": choix
    }
    return etudiantData

def mergeTwoDict(dict1, dict2, sameKey):
    dict1.extend(list(map(lambda x,y: y if x.get(sameKey) != y.get(sameKey) else x.update(y), dict1, dict2)))
    dict1 = list(filter(None, dict1))
    return dict1
