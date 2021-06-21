import input as ip
import unittest


class Test_tableInput(unittest.TestCase):
    
    listFicheVoeux = []
    listFicheVoeux_correctFormat = []
    listEtudiants = []

    listFicheVoeux.append({
        "matricule":181831053792,
        "il":1,
        "ssi":3,
        "sii":4,
        "mind":2
    })

    listFicheVoeux.append({
        "matricule":181831053795,
        "il":2,
        "ssi":4,
        "sii":3,
        "mind":1
    })

    listEtudiants.append(
    {
        "MAT":181831053795
    }
    )
    listEtudiants.append(
    {
        "MAT":181831053792
    }
    )

    listFicheVoeux_correctFormat.append({
        "matricule":181831053792,
        "lesChoix":("il","mind","ssi","sii")
    })

    listFicheVoeux_correctFormat.append({
        "matricule":181831053795,
        "lesChoix":("mind","il","sii","ssi")
    })
    specialite = {
    "il": 3,   
    "rsd": 2,
    "sii": 2,
    "ssi": 1,
    "mind": 1,
    "iv": 2,
    "bio-info": 1}

  

    def test_createListOfChoix(self):
        self.assertEqual(ip.createListOfChoix(self.listFicheVoeux[0],1) , ('il','mind','ssi','sii'))

    def test_createListOfFicheVoeux(self):
        l=ip.createListOfFicheVoeux(self.listFicheVoeux,1)
        self.assertEqual(l , self.listFicheVoeux_correctFormat)

    def test_sortListOfFicheVoeux(self):
        l=ip.sortListOfFicheVoeux(self.listFicheVoeux_correctFormat, self.listEtudiants)
        self.assertEqual(l[0]["matricule"] , 181831053795)
        self.assertEqual(l[1]["matricule"] , 181831053792)
 
if __name__ == '__main__':
    unittest.main()
