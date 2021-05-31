import converter as cv

specialite = {
    "il": 1,
    "rsd": 2,
    "sii": 2,
    "ssi": 1,
    "mind": 1,
    "iv": 2,
    "bio-info": 1
}



def isAvailble(choix, specialite):
    if(specialite[choix] > 0):
        return True
    else:
        return False


def getChoixOf(etudiant, specialite):
    for i in range(1, 5):
        if(isAvailble(etudiant["choix{}".format(i)], specialite)):
            return etudiant["choix{}".format(i)]
    return "empty"


def affecter(etudiant, specialite):
    choix = getChoixOf(etudiant, specialite)
    etudiantData = {
        "MAT": etudiant["MAT"],
        "NAME": etudiant["NAME"],
        "PNAME": etudiant["PNAME"],
        "choix": choix
    }
    return etudiantData

def affecterTous(listEtudiants, specialite):
    listEtudiantsFinal = []
    for etudiant in listEtudiants:
       listEtudiantsFinal.append(affecter(etudiant, specialite))
       choix = getChoixOf(etudiant, specialite)
       if(choix != "empty"):
         specialite[choix] = specialite[choix]-1
    return listEtudiantsFinal 


