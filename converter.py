import pandas as pd

# filename : address of the excal file
# sheetname : name of the first sheet in the excal 'classement'
# CSVname : output address of CSV file
# JSONname: output address of JSON file


def excelToCSV(filename, sheetname, CSVname):  # excel ==> csv
    data = pd.read_excel(filename, sheetname, index_col=0)
    data.to_csv(CSVname, encoding='utf-8')


def CSVToDict(filename):                    # csv ==> dictionaie
    return pd.read_csv(filename).to_dict(orient='records')


def CSVToJSON(filename, JSONname):           # dictionary ==> JSON
    data = pd.read_csv(filename)
    data.to_json(JSONname, orient='records')

