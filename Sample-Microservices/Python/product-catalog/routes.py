import json
import repository
from repository import productcatalog

def add_routes(flaskApp):
    
    @flaskApp.route('/products', methods=['GET'])
    def home():
        return json.dumps(productcatalog.readProducts(), indent=4)