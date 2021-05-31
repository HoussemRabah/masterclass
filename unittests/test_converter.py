import unittest
import converter as h
import pandas as pd 


class Test_tableConverter(unittest.TestCase):

    # The folder .\unittests contains xlsx,csv,json files that I created manually for testing

    tableTest = '.\\unittests\\tableTest.xlsx'                       # simple two-line Excel file
    tableTest_CSVresult = '.\\unittests\\tableTest_CSVresult.csv'    # correct CSV format  of the first xlsx file
    tableTest_JSONresult = '.\\unittests\\tableTest_JSONresult.json' # correct JSON format of the first xlsx file

    tableTest_CSV = '.\\unittests\\tableTest_CSVoutput.csv'          # extracted CSV  file with our code (output)
    tableTest_JSON = '.\\unittests\\tableTest_JSONoutput.json'       # extracted JSON file with our code (output)

    # then we compare the first 3 files  with the new two output files

    def setUp(self) :
        h.excelToCSV(self.tableTest,'p1',self.tableTest_CSV) 
        h.CSVToJSON(self.tableTest_CSV,self.tableTest_JSON)

    def test_excelToCSV(self):
        t1 = open(self.tableTest_CSV, 'r')
        t2 = open(self.tableTest_CSVresult, 'r')
        fileProduced = t1.readlines()
        fileSuposed = t2.readlines()
        t1.close()
        t2.close()
        self.assertEqual(fileProduced, fileSuposed)

    def test_CSVToDict(self):
        dict = h.CSVToDict(self.tableTest_CSV)
        self.assertEqual(dict[0]['NAME'], 'RABAH')
        self.assertEqual(dict[1]['NAME'], 'SAHLI')


    def test_CSVToJSON(self):
        t1 = open(self.tableTest_JSON, 'r')
        t2 = open(self.tableTest_JSONresult, 'r')
        fileProduced = t1.readlines()
        fileSuposed = t2.readlines()
        t1.close()
        t2.close()
        self.assertEqual(fileProduced, fileSuposed)



if __name__ == '__main__':
    unittest.main()