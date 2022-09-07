from typing import Any
from dataclasses import dataclass
import json

@dataclass
class Price:
    sku: str
    retailPrice: float
    wholesalePrice: float
    
    def __init__(self, sku, retailPrice, wholesalePrice):
        self.sku = sku
        self.retailPrice = retailPrice
        self.wholesalePrice = wholesalePrice
        
    def toJSON(self):
        return json.dumps(self, default=lambda o: o.__dict__, 
            sort_keys=True, indent=4)

    @staticmethod
    def from_dict(obj: Any) -> 'Price':
        _sku = str(obj.get("sku"))
        _retailPrice = float(obj.get("retailPrice"))
        _wholesalePrice = float(obj.get("wholesalePrice"))
        return Price(_sku, _retailPrice, _wholesalePrice)


@dataclass
class Product:
    sku: str
    name: str
    description: str
    manufacturer: str
    price: Price
    
    def __init__(self, sku, name, description, manufacturer):
        self.sku = sku
        self.name = name
        self.description = description
        self.manufacturer = manufacturer

    @staticmethod
    def from_dict(obj: Any) -> 'Product':
        _sku = str(obj.get("sku"))
        _name = str(obj.get("name"))
        _description = str(obj.get("description"))
        _manufacturer = str(obj.get("manufacturer"))
        _price = Price.from_dict(obj.get("price"))
        return Product(_sku, _name, _description, _manufacturer, _price)
