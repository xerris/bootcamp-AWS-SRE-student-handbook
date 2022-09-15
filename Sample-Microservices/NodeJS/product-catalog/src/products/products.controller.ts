import { Controller, Get } from '@nestjs/common';
import { ProductsService } from './products.service';
import { ConfigService } from '@nestjs/config';
import { Product } from "../models/product.model";

@Controller('products')
export class ProductsController {
  constructor(private productsService: ProductsService,private config: ConfigService) {}

  @Get()
  getAllProducts(): Product[] {
    const pricingUrl = this.config.get<string>('pricing-url');
    console.log(pricingUrl);
    return this.productsService.GetAllProducts();
  }
}
