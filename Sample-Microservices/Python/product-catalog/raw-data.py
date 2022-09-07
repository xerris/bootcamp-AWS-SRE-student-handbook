import logging

from repository import product, productcatalog

productcatalog.toJson()

logging.basicConfig(level=logging.DEBUG)
logging.info('reading products')

data = productcatalog.readProducts()

logging.info(data)