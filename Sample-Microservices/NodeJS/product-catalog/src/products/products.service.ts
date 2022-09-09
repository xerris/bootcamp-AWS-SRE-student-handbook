import { Injectable } from '@nestjs/common';
import { ProductsRepository } from './products.repository';

@Injectable()
export class ProductsService {
  constructor(private productsRepository: ProductsRepository) {}
  GetAllProducts() {
    return this.productsRepository.GetAllProducts();
  }
}
