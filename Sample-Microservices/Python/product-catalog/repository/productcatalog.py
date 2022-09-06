import json

def readProducts():
    with open('data/products.json') as f:
        data = f.read().strip().replace('\r','').replace('\t','')
        return json.loads(data)