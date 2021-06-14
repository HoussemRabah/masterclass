import pandas as pn
 

specialite = {
    "il": 1,
    "rsd": 2, 
    "sii": 2,
    "ssi": 1,
    "mind": 1,
    "iv": 2, 
    "bio-info": 1
}




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

