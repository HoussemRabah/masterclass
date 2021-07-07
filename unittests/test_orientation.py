from orientation import affecter, getChoixOf
import unittest
import converter as h
import pandas as pd 


class Test_tableOrientation(unittest.TestCase):
    
    listFicheVoeux = []
    
    listFicheVoeux.append({
        "matricule":181831053792,
        "lesChoix":("il","mind","ssi","sii")
    })

    listFicheVoeux.append({
        "matricule":181831053795,
        "lesChoix":("mind","il","sii","ssi")
    })

    specialite = {
    "il": 0,   
    "rsd": 2,
    "sii": 2,
    "ssi": 1, 
    "mind": 2,
    "iv": 2,
    "bio-info": 1}

    def test_getChoixOf(self):
        self.assertEqual(getChoixOf(self.listFicheVoeux[0]["lesChoix"], self.specialite), "mind")


    def test_affecter(self):
        etd = affecter(self.listFicheVoeux[1], self.specialite)
        self.assertEqual(etd["choix"] , "mind")
 

if __name__ == '__main__':
    unittest.main()
