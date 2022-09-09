import { Controller, Get } from '@nestjs/common';
import { ProductsService } from './products.service';
import { Product } from './models';

@Controller('products')
export class ProductsController {
  constructor(private productsService: ProductsService) {}

  @Get()
  getAllProducts(): Product[] {
    return this.productsService.GetAllProducts();
  }
}
