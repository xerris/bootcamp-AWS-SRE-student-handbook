import { Injectable } from '@nestjs/common';
import { Product } from "../models/product.model";

@Injectable()
export class ProductsRepository {
  latte = new Product(
    'c0c20648-ecd9-4896-999d-8c2d55010f77',
    'Flat White Latte',
    'Our most popular Latte',
    'Coffee-Bucks',
  );
  spice = new Product(
    'c0c20648-ecd9-4896-999d-8c2d55010f77',
    'Pumpkin Spice Latte',
    'Our favorite Latte for Halloween',
    'Coffee-Bucks',
  );

  brownee = new Product(
    '76ad06f0-8ced-401e-862d-da27b1b496bb',
    'Chocolae Fudge Brownee',
    'Try our most popular Brownee',
    'Jim-Hortons',
  );

  GetAllProducts() {
    return [this.latte, this.spice, this.brownee];
  }
}
