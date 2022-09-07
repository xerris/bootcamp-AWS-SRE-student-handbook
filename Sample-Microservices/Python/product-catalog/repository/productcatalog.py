import json
from random import seed
from types import SimpleNamespace
from .product import Product

def readProducts():
    data = seedData()
    with open('data/products.json') as f:
       data = f.read().strip().replace('\n','').replace('\r','').replace('\t','')
       x = json.loads(data, object_hook=lambda d: SimpleNamespace(**d))
       return x
    
def seedData():
    products = []
    products.append( Product('d18b1bdb-596a-4fd7-abe5-3bec4bcb6e4d', \
                             'Flat White Latte', 'Our most popular Latte', \
                             'Coffee-Bucks') )
    products.append(Product('c0c20648-ecd9-4896-999d-8c2d55010f77', \
                            'Pumpkin Spice Latte', 'Our favorite Latte for Halloween', \
                            'Coffee-Bucks') )
    products.append(Product('76ad06f0-8ced-401e-862d-da27b1b496bb', \
                            'Chocolate Fudge Brownee', 'Our favorite brownee', \
                            'Jim Hortons' ))
    return products

def toJson():
    data = seedData()
    toJson = json.dumps([ob.__dict__ for ob in data])
    with open('data.json', 'w', encoding='utf-8') as f:
        json.dump(toJson, f, ensure_ascii=False, indent=4)