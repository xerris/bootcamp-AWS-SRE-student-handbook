import logging
import sys

def initialize_logging():
    
    logging.basicConfig(level=logging.INFO,
        format="%(asctime)s [%(levelname)s] %(message)s",
        handlers=[
            logging.FileHandler(".logs/debug.log"),
            logging.StreamHandler(sys.stdout)
        ]
    )