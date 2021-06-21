import calculClassement as cl
import unittest


class Test_tableCalculClassement(unittest.TestCase):
    
    listEtudiant=[
        {
            "MAT":1,
            "MSE":10.0,
            "a":0,
            "r":2,
            "d":2,
            "s":2,
            "n":2
        },
        {
            "MAT":2,
            "MSE":16.0,
            "a":2,
            "r":2,
            "d":2,
            "s":2,
            "n":2}
    ]
  
    listEtudiantToSort=[
        {
            "MC":12.0,
            "MAT":1
        },
        {
            "MC":15.0,
            "MAT":2
        },
    ]
  
    formulaire={
        "form":"$1$*(1-$2$*($3$+$4$/2+$5$/4))",
        "1":"MSE",
        "2":"a",
        "3":"r",
        "4":"d",
        "5":"s"
    }

    dict={
        "MSE":10,
        "a":0,
        "r":0,
        "d":0,
        "s":0
    }
    def test_calculerMoy(self):
        newlist=cl.calculerMoy(self.listEtudiant, self.formulaire)
        self.assertEqual(newlist[0]["MC"] , 10.0)


    def test_sortClassement(self):
        newlist=cl.sortClassement(self.listEtudiantToSort)
        self.assertEqual(newlist[0]["MAT"] , 2)

    def test_parseFormulaire(self):
        self.assertEqual(cl.parseFormulaire(self.formulaire, self.dict ), 10)

if __name__ == '__main__':
    unittest.main()
