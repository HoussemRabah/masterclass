from orientation import affecter, affecterTous, getChoixOf
import unittest
import converter as h
import pandas as pd 


class Test_tableOrientation(unittest.TestCase):
    
    listEtudiants = []

    listEtudiants.append({
        "MAT":181831053792,
        "PNAME":"houssem",
        "NAME":"RABAH",
        "choix1":"il",
        "choix2":"sii",
        "choix3":"ssi",
        "choix4":"iv"
    })
    listEtudiants.append({
        "MAT":181831053795,
        "PNAME":"wassim",
        "NAME":"sahli",
        "choix1":"il",
        "choix2":"rsd",
        "choix3":"mind",
        "choix4":"iv"
    })
    specialite = {
    "il": 3,   
    "rsd": 2,
    "sii": 2,
    "ssi": 1,
    "mind": 1,
    "iv": 2,
    "bio-info": 1}

    def test_getChoixOf(self):
        self.assertEqual(getChoixOf(self.listEtudiants[0], self.specialite), "il")


    def test_affecter(self):
        etd = affecter(self.listEtudiants[0], self.specialite)
        self.assertEqual(etd["choix"] , "il")

    
    def test_affecterTous(self):
        listEtdFinal = affecterTous(self.listEtudiants, self.specialite)
        etd1 = listEtdFinal[0]
        etd2 = listEtdFinal[1]
        self.assertEqual(etd1["choix"] , "il")
        self.assertEqual(etd2["choix"] , "il")

if __name__ == '__main__':
    unittest.main()